using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SerialPortWorker;

namespace Периметр
{
    public partial class FormSelectLights : Form
    {
        public FormSelectLights()
        {
            InitializeComponent();
#if DEBUG
            TopMost = false;
#endif
        }

        /// <summary>
        /// Кнопка "Задать светодиоды"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Удаление уже имеющихся чекбоксов
            if(FormTestCreation.checkBoxes != null)
            {
                foreach (CheckBox cb in FormTestCreation.checkBoxes) cb.Dispose();
            }

            if (nFrom.Value == nTo.Value) { MessageBox.Show("Укажите правильный диапазон."); return; }

            if(nFrom.Value > nTo.Value)
            {
                decimal temp = nTo.Value;
                nTo.Value = nFrom.Value;
                nFrom.Value = temp;
            }
            int[] lights = LibraryOfLights.GetIndexesByAngleRange((int)nFrom.Value, (int)nTo.Value);
            if ((cb1.Checked && cb2.Checked && cb3.Checked && cb4.Checked)||(!cb1.Checked && !cb2.Checked && !cb3.Checked && !cb4.Checked))
            {
                FormTestCreation.IndexesOfLights = lights;
                Close();
                return;
            }
            //фитрация точек по четвертям
            List<int> listReturn = new List<int>();
            for (int i = 0; i < lights.Length; i++)
            {
                int[] chetverti = ChetvertOfLight(LibraryOfLights.RadialLights[lights[i]]);
                for(int j = 0; j < chetverti.Length; j++)
                {
                    if (chetverti[j] == 1 && cb1.Checked) { listReturn.Add(lights[i]); break; }
                    if (chetverti[j] == 2 && cb2.Checked) { listReturn.Add(lights[i]); break; }
                    if (chetverti[j] == 3 && cb3.Checked) { listReturn.Add(lights[i]); break; }
                    if (chetverti[j] == 4 && cb4.Checked) { listReturn.Add(lights[i]); break; }
                }
            }
            FormTestCreation.IndexesOfLights = listReturn.ToArray();
            Close();
        }
        /// <summary>
        /// К каким четвертям относится точка
        /// </summary>
        /// <param name="rl"></param>
        /// <returns></returns>
        private int[] ChetvertOfLight(RadialLight rl)
        {
            //угл относительно оси Х
            double angle = Math.Abs((rl.AngleShift - (rl.Number - 1) * 30));

            switch (angle)
            {
                case 0.0:
                case 360.0:
                    return new int[] { 1, 4 };
                case 90.0:
                    return new int[] { 3, 4 };
                case 180.0:
                    return new int[] { 2, 3 };
                case 270.0:
                    return new int[] { 1, 2 };
            }
            int[] ret = new int[1];
            if (angle > 0.0 && angle < 90.0) ret[0] = 4;
            else if (angle > 90.0 && angle < 180.0) ret[0] = 3;
            else if (angle > 180.0 && angle < 270.0) ret[0] = 2;
            else ret[0] = 1;
            return ret;
        }
    }
}
