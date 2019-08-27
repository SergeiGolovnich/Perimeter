using System;
using System.Linq;
using System.IO.Ports;

namespace SerialPortWorker
{
    public class SerialPortWorker : IDisposable
    {
        public SerialPort serialPort;
        /// <summary>
        /// Флаг активности сервопривода
        /// </summary>
        private bool servoMoving = false;
        /// <summary>
        /// Задание параметров COM порта
        /// </summary>
        public SerialPortWorker()
        {
            serialPort = new SerialPort("COM1", 19200, Parity.None, 8, StopBits.One);
            serialPort.WriteBufferSize = 4096;
            serialPort.ReadTimeout = 0;
            try { serialPort.Open(); }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //Зажигание фоновой подсветки
            Send(new byte[] { 252, 6, 250, 15, 2, 129, 146, 252, 6, 250, 14, 2, 255, 15, 252, 6, 250, 12, 2, 255, 13, 252, 6, 250, 14, 2, 191, 207, 252, 6, 250, 14, 2, 255, 15, 252, 6, 246, 2, 86, 1, 85, 252, 6, 246, 3, 128, 1, 128, 252, 6, 246, 4, 32, 1, 33 });
            Send(new byte[] { 252, 6, 250, 12, 2, 255, 13, 252, 6, 250, 14, 2, 191, 207, 252, 6, 250, 14, 2, 255, 15 });
        }
        /// <summary>
        /// Послать набор комманд через COM порт
        /// </summary>
        /// <param name="arr">Массив команд</param>
        public void Send(byte[] arr)
        {
            if (arr.Length % 7 != 0) throw new ArgumentException("Неправильное количество байт.");//В каждой команде 7 байт

            int cmdCount = arr.Length / 7;
            for (int i = 0; i < cmdCount; i++)
            {
                serialPort.Write(calcChecksum(new byte[] { arr[7 * i], arr[7 * i + 1], arr[7 * i + 2], arr[7 * i + 3], arr[7 * i + 4], arr[7 * i + 5], arr[7 * i + 6], }), 0, 7);
            }
        }
        public void Send(string str)
        {
            var temp = str.Split(' ');
            if (temp.Length % 7 != 0) throw new ArgumentException("Неправильное количество байт.");
            int codes = temp.Length / 7;
            for (int i = 0; i < codes; i++)
            {
                serialPort.Write(calcChecksum(new byte[] { Convert.ToByte(temp[7 * i]), Convert.ToByte(temp[7 * i + 1]), Convert.ToByte(temp[7 * i + 2]), Convert.ToByte(temp[7 * i + 3]), Convert.ToByte(temp[7 * i + 4]), Convert.ToByte(temp[7 * i + 5]), Convert.ToByte(temp[7 * i + 6]), }), 0, 7);
            }
        }
        public override string ToString()
        {
            return String.Format("SerialPort's name: {0}\nBaundRate: {1}\nDataBits: {2}\nisOpen: {3}",
                serialPort.PortName, serialPort.BaudRate, serialPort.DataBits, serialPort.IsOpen);
        }
        /// <summary>
        /// Управление движением сервопривода
        /// </summary>
        /// <param name="cmd"></param>
        public void DoServoCmd(ServoCmd cmd)
        {
            if (!serialPort.IsOpen) return;
            switch (cmd)
            {
                case ServoCmd.Stop:
                    servoMoving = false;
                    Send(ServoCommands.Stop);
                    break;
                case ServoCmd.Up:
                    servoMoving = true;
                    new Action(() => { while (servoMoving) { Send(ServoCommands.Up); } }).BeginInvoke(null, null);
                    break;
                case ServoCmd.Down:
                    servoMoving = true;
                    new Action(() => { while (servoMoving) { Send(ServoCommands.Down); } }).BeginInvoke(null, null);
                    break;
                case ServoCmd.Left:
                    servoMoving = true;
                    new Action(() => { while (servoMoving) { Send(ServoCommands.Left); } }).BeginInvoke(null, null);
                    break;
                case ServoCmd.Right:
                    servoMoving = true;
                    new Action(() => { while (servoMoving) { Send(ServoCommands.Right); } }).BeginInvoke(null, null);
                    break;
            }
        }
        /// <summary>
        /// Расчёт контрольной суммы
        /// </summary>
        /// <param name="arr">Команда</param>
        /// <returns></returns>
        private byte[] calcChecksum(byte[] arr)
        {
            byte sum = 4;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                sum += arr[i];
            }
            arr[arr.Length - 1] = sum;
            return arr;
        }
        /// <summary>
        /// Возможные команды сервопривода
        /// </summary>
        public enum ServoCmd
        {
            Stop, Up, Down, Left, Right
        }
        /// <summary>
        /// Коды управления сервоприводом
        /// </summary>
        private static class ServoCommands
        {
            public static readonly byte[] Stop = new byte[] { 252, 06, 246, 13, 02, 00, 11 };
            public static readonly byte[] Up = new byte[] { 252, 06, 247, 221, 00, 03, 221 };
            public static readonly byte[] Down = new byte[] { 252, 06, 247, 221, 00, 04, 222 };
            public static readonly byte[] Left = new byte[] { 252, 06, 247, 09, 00, 02, 08 };
            public static readonly byte[] Right = new byte[] { 252, 06, 247, 09, 00, 01, 07 };
        }
        /// <summary>
        /// Задание светодиода
        /// </summary>
        /// <param name="rl">Светодиод</param>
        public void SetLight(RadialLight rl)
        {
            Send(new byte[] { 252, 6, 244, 1, (byte)(rl.Radius + 128), (byte)(rl.Number - 1), 0 });//Координаты
        }
        /// <summary>
        /// Задание интенсивности светодиода
        /// </summary>
        /// <param name="indexOfLvl">Уровень интенсивности</param>
        public void SetLightIntensity(int indexOfLvl)
        {
            Send(new byte[] { 252, 6, 244, 2, LibraryOfLights.IntensityLevels[indexOfLvl], LibraryOfLights.IntensityLevels[indexOfLvl], 0 });//Интенсивность
        }
        /// <summary>
        /// Определение нажатия на кнопку
        /// </summary>
        /// <returns></returns>
        public bool PatientsResponse()
        {
            byte[] response;
            //есть ли данные для чтения
            if (serialPort.BytesToRead > 0)
            {
                response = new byte[serialPort.BytesToRead];
                serialPort.Read(response, 0, serialPort.BytesToRead);
            }
            else
            {
                return false;
            }
            //если есть, то проверяем наличие команды нажатия кнопки
            if (response.Contains<byte>(13))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #region IDisposable Members

        void IDisposable.Dispose()
        {
            //Выключение фоновой подсветки
            Send(new byte[] { 252, 6, 250, 12, 2, 127, 141, 252, 6, 250, 14, 2, 191, 207, 252, 6, 250, 14, 2, 255, 15, 252, 6, 246, 13, 3, 0, 12 });
            serialPort.Close();
        }

        #endregion
    }
}
