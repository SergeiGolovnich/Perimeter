using System.Collections.Generic;

namespace SerialPortWorker
{
    public static class LibraryOfLights
    {
        //задание массива возможных для использования светодиодов
        public static readonly List<RadialLight> RadialLights = new List<RadialLight>
        {
            //Центральная точка
           new RadialLight(23,10,0),
            //1-ый радиус
           new RadialLight(1,1,2),
           new RadialLight(1,2,2),
           new RadialLight(1,3,2),
           new RadialLight(1,4,2),
           new RadialLight(1,5,2),
           new RadialLight(1,6,2),
           new RadialLight(1,7,2),
           new RadialLight(1,8,2),
           new RadialLight(1,9,2),
           new RadialLight(1,10,2),
           new RadialLight(1,11,2),
           new RadialLight(1,12,2),
           //2-ой радиус
           new RadialLight(2,1,4),
           new RadialLight(2,2,4),
           new RadialLight(2,3,4),
           new RadialLight(2,4,4),
           new RadialLight(2,5,4),
           new RadialLight(2,6,4),
           new RadialLight(2,7,4),
           new RadialLight(2,8,4),
           new RadialLight(2,9,4),
           new RadialLight(2,10,4),
           new RadialLight(2,11,4),
           new RadialLight(2,12,4),
           //3
           new RadialLight(3,1,6),
           new RadialLight(3,2,6),
           new RadialLight(3,3,6),
           new RadialLight(3,4,6),
           new RadialLight(3,5,6),
           new RadialLight(3,6,6),
           new RadialLight(3,7,6),
           new RadialLight(3,8,6),
           new RadialLight(3,9,6),
           new RadialLight(3,10,6),
           new RadialLight(3,11,6),
           new RadialLight(3,12,6),
           //4
           new RadialLight(4,1,8,-15),
           new RadialLight(4,2,8,-15),
           new RadialLight(4,3,8,-15),
           new RadialLight(4,4,8,-15),
           new RadialLight(4,5,8,-15),
           new RadialLight(4,6,8,-15),
           new RadialLight(4,7,8,-15),
           new RadialLight(4,8,8,-15),
           new RadialLight(4,9,8,-15),
           new RadialLight(4,10,8,-15),
           new RadialLight(4,11,8,-15),
           new RadialLight(4,12,8,-15),
           //5
           new RadialLight(5,1,10),
           new RadialLight(5,2,10),
           new RadialLight(5,3,10),
           new RadialLight(5,4,10),
           new RadialLight(5,5,10),
           new RadialLight(5,6,10),
           new RadialLight(5,7,10),
           new RadialLight(5,8,10),
           new RadialLight(5,9,10),
           new RadialLight(5,10,10),
           new RadialLight(5,11,10),
           new RadialLight(5,12,10),
           //6
           new RadialLight(6,1,5,-15),
           new RadialLight(6,2,5,-15),
           new RadialLight(6,3,5,-15),
           new RadialLight(6,4,5,-15),
           new RadialLight(6,5,5,-15),
           new RadialLight(6,6,5,-15),
           new RadialLight(6,7,5,-15),
           new RadialLight(6,8,5,-15),
           new RadialLight(6,9,5,-15),
           new RadialLight(6,10,5,-15),
           new RadialLight(6,11,5,-15),
           new RadialLight(6,12,5,-15),
           //7
           new RadialLight(7,1,13),
           new RadialLight(7,2,13),
           new RadialLight(7,3,13),
           new RadialLight(7,4,13),
           new RadialLight(7,5,13),
           new RadialLight(7,6,13),
           new RadialLight(7,7,13),
           new RadialLight(7,8,13),
           new RadialLight(7,9,13),
           new RadialLight(7,10,13),
           new RadialLight(7,11,13),
           new RadialLight(7,12,13),
           //8
           new RadialLight(8,1,20,-15),
           new RadialLight(8,2,20,-15),
           new RadialLight(8,3,20,-15),
           new RadialLight(8,4,20,-15),
           new RadialLight(8,5,20,-15),
           new RadialLight(8,6,20,-15),
           new RadialLight(8,7,20,-15),
           new RadialLight(8,8,20,-15),
           new RadialLight(8,9,20,-15),
           new RadialLight(8,10,20,-15),
           new RadialLight(8,11,20,-15),
           new RadialLight(8,12,20,-15),
           //9
           new RadialLight(9,1,23),
           new RadialLight(9,2,23),
           new RadialLight(9,3,23),
           new RadialLight(9,4,23),
           new RadialLight(9,5,23),
           new RadialLight(9,6,23),
           new RadialLight(9,7,23),
           new RadialLight(9,8,23),
           new RadialLight(9,9,23),
           new RadialLight(9,10,23),
           new RadialLight(9,11,23),
           new RadialLight(9,12,23),
           //10
           new RadialLight(10,1,27,-15),
           new RadialLight(10,2,27,-15),
           new RadialLight(10,3,27,-15),
           new RadialLight(10,4,27,-15),
           new RadialLight(10,5,27,-15),
           new RadialLight(10,6,27,-15),
           new RadialLight(10,7,27,-15),
           new RadialLight(10,8,27,-15),
           new RadialLight(10,9,27,-15),
           new RadialLight(10,10,27,-15),
           new RadialLight(10,11,27,-15),
           new RadialLight(10,12,27,-15),
           //11
           new RadialLight(11,1,30),
           new RadialLight(11,2,30),
           new RadialLight(11,3,30),
           new RadialLight(11,4,30),
           new RadialLight(11,5,30),
           new RadialLight(11,6,30),
           new RadialLight(11,7,30),
           new RadialLight(11,8,30),
           new RadialLight(11,9,30),
           new RadialLight(11,10,30),
           new RadialLight(11,11,30),
           new RadialLight(11,12,30),
           //12
           new RadialLight(12,1,35,-15),
           new RadialLight(12,2,35,-15),
           new RadialLight(12,3,35,-15),
           new RadialLight(12,4,35,-15),
           new RadialLight(12,5,35,-15),
           new RadialLight(12,6,35,-15),
           new RadialLight(12,7,35,-15),
           new RadialLight(12,8,35,-15),
           new RadialLight(12,9,35,-15),
           new RadialLight(12,10,35,-15),
           new RadialLight(12,11,35,-15),
           new RadialLight(12,12,35,-15),
           //13
           new RadialLight(13,1,40),
           new RadialLight(13,2,40),
           new RadialLight(13,3,40),
           new RadialLight(13,4,40),
           new RadialLight(13,5,40),
           new RadialLight(13,6,40),
           new RadialLight(13,7,40),
           new RadialLight(13,8,40),
           new RadialLight(13,9,40),
           new RadialLight(13,10,40),
           new RadialLight(13,11,40),
           new RadialLight(13,12,40),
           //14
           new RadialLight(14,1,45,-15),
           new RadialLight(14,2,45,-15),
           new RadialLight(14,3,45,-15),
           new RadialLight(14,4,45,-15),
           new RadialLight(14,5,45,-15),
           new RadialLight(14,6,45,-15),
           new RadialLight(14,7,45,-15),
           new RadialLight(14,8,45,-15),
           new RadialLight(14,9,45,-15),
           new RadialLight(14,10,45,-15),
           new RadialLight(14,11,45,-15),
           new RadialLight(14,12,45,-15),
           //15
           new RadialLight(15,1,50),
           new RadialLight(15,2,50),
           new RadialLight(15,3,50),
           new RadialLight(15,4,50),
           new RadialLight(15,5,50),
           new RadialLight(15,6,50),
           new RadialLight(15,7,50),
           new RadialLight(15,8,50),
           new RadialLight(15,9,50),
           new RadialLight(15,10,50),
           new RadialLight(15,11,50),
           new RadialLight(15,12,50),
           //16
           new RadialLight(16,1,55,-15),
           new RadialLight(16,2,55,-15),
           new RadialLight(16,3,55,-15),
           new RadialLight(16,4,55,-15),
           new RadialLight(16,5,55,-15),
           new RadialLight(16,6,55,-15),
           new RadialLight(16,7,55,-15),
           new RadialLight(16,8,55,-15),
           new RadialLight(16,9,55,-15),
           new RadialLight(16,10,55,-15),
           new RadialLight(16,11,55,-15),
           new RadialLight(16,12,55,-15),
           //17
           new RadialLight(17,1,60),
           new RadialLight(17,2,60),
           new RadialLight(17,3,60),
           new RadialLight(17,4,60),
           new RadialLight(17,5,60),
           new RadialLight(17,6,60),
           new RadialLight(17,7,60),
           new RadialLight(17,8,60),
           new RadialLight(17,9,60),
           new RadialLight(17,10,60),
           new RadialLight(17,11,60),
           new RadialLight(17,12,60),
           //18
           new RadialLight(18,1,65,-15),
           new RadialLight(18,2,65,-15),
           new RadialLight(18,3,65,-15),
           new RadialLight(18,4,65,-15),
           new RadialLight(18,5,65,-15),
           new RadialLight(18,6,65,-15),
           new RadialLight(18,7,65,-15),
           new RadialLight(18,8,65,-15),
           new RadialLight(18,9,65,-15),
           new RadialLight(18,10,65,-15),
           new RadialLight(18,11,65,-15),
           new RadialLight(18,12,65,-15),
           //19
           new RadialLight(19,1,70),
           new RadialLight(19,2,70),
           new RadialLight(19,3,70),
           new RadialLight(19,4,70),
           new RadialLight(19,5,70),
           new RadialLight(19,6,70),
           new RadialLight(19,7,70),
           new RadialLight(19,8,70),
           new RadialLight(19,9,70),
           new RadialLight(19,10,70),
           new RadialLight(19,11,70),
           new RadialLight(19,12,70),
           //20
           new RadialLight(20,1,75,-15),
           new RadialLight(20,2,75,-15),
           new RadialLight(20,3,75,-15),
           new RadialLight(20,4,75,-15),
           new RadialLight(20,5,75,-15),
           new RadialLight(20,6,75,-15),
           new RadialLight(20,7,75,-15),
           new RadialLight(20,8,75,-15),
           new RadialLight(20,9,75,-15),
           new RadialLight(20,10,75,-15),
           new RadialLight(20,11,75,-15),
           new RadialLight(20,12,75,-15),
           //21
           new RadialLight(21,1,80),
           new RadialLight(21,2,80),
           new RadialLight(21,3,80),
           new RadialLight(21,4,80),
           new RadialLight(21,5,80),
           new RadialLight(21,6,80),
           new RadialLight(21,7,80),
           new RadialLight(21,8,80),
           new RadialLight(21,9,80),
           new RadialLight(21,10,80),
           new RadialLight(21,11,80),
           new RadialLight(21,12,80),
           //22
           new RadialLight(22,1,85,-15),
           new RadialLight(22,2,85,-15),
           new RadialLight(22,3,85,-15),
           new RadialLight(22,4,85,-15),
           new RadialLight(22,5,85,-15),
           new RadialLight(22,6,85,-15),
           new RadialLight(22,7,85,-15),
           new RadialLight(22,8,85,-15),
           new RadialLight(22,9,85,-15),
           new RadialLight(22,10,85,-15),
           new RadialLight(22,11,85,-15),
           new RadialLight(22,12,85,-15),
           //23
           new RadialLight(23,1,90),
           new RadialLight(23,2,90),
           new RadialLight(23,3,90),
           new RadialLight(23,4,90),
           new RadialLight(23,5,90),
           new RadialLight(23,6,90),
           new RadialLight(23,7,90),
           new RadialLight(23,8,90),
           new RadialLight(23,9,90),
           new RadialLight(23,11,90),
           new RadialLight(23,12,90)
        };
        /// <summary>
        /// Получить индексы светодиодов, находящихся в заданном угловом диапазоне 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static int[] GetIndexesByAngleRange(int from, int to)
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < RadialLights.Count; i++)
            {
                if (RadialLights[i].Distance >= from && RadialLights[i].Distance <= to) ret.Add(i);
            }
            return ret.ToArray();
        }
        //задание уровней яркости
        public static readonly byte[] IntensityLevels = new byte[] {0,36,40,44,48,52,56,60,64,68,72,76,80,
            84,88,92,96,100,104,108,112,116,120,124,128,132,136,140,144,148,152,156,160,164,168,172,176,180,184,188,192 };
    }
    public class RadialLight
    {
        /// <summary>
        /// Номер радиуса, на котором расположет светодиод
        /// </summary>
        public int Radius { get; private set; }
        /// <summary>
        /// Номер светодиода на заданном радиусе
        /// </summary>
        public int Number { get; private set; }
        /// <summary>
        /// Угол отклонения светодиода от начала координат
        /// </summary>
        public int Distance { get; private set; }
        /// <summary>
        /// Угол отклонения светодиода на заданном радиусе относительно положительного направления оси X
        /// </summary>
        public int AngleShift { get; private set; }
        /// <summary>
        /// Параметры радиального светодиода
        /// </summary>
        /// <param name="radius">Номер радиуса, на котором расположен светодиод</param>
        /// <param name="number">Номер светодиода на заданном радиусе</param>
        /// <param name="angle">Угол относительно положительного направления оси Х</param>
        /// <param name="distance">Расстояние от начала координат</param>
        public RadialLight(int radius, int number, int distance, int angleShift = 0)
        {
            Radius = radius;
            Number = number;
            Distance = distance;
            AngleShift = angleShift;
        }
    }
}
