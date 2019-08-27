using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SerialPortWorker;

namespace Периметр
{
    public partial class FormTestCreation : Form
    {
        public FormSelectLights fsl;
        /// <summary>
        /// Массив индексов светодиодов
        /// </summary>
        public static int[] IndexesOfLights;
        /// <summary>
        /// Массив светодиодов в виде элементов CheckBox
        /// </summary>
        public static CheckBox[] checkBoxes;
        /// <summary>
        /// Объект, на котором рисуются оси
        /// </summary>
        private Bitmap bmBackGround;
        public FormTestCreation()
        {
            InitializeComponent();
#if DEBUG
            TopMost = false;
#endif
        }
        public FormTestCreation(TestParams tp)
        {
            InitializeComponent();
            IndexesOfLights = tp.IndexesOfLights;
            tbTestName.Text = tp.TestName;
            tbTestName.Enabled = false;
            btnSave.Enabled = true;
#if DEBUG
            TopMost = false;
#endif
        }
        /// <summary>
        /// Нарисовать область светодиодов
        /// </summary>
        /// <param name="panel"></param>
        private void drawLightsMap(PictureBox panel)
        {
            bmBackGround = new Bitmap(panel.Width, panel.Height);
            Graphics gr = Graphics.FromImage(bmBackGround);
            Pen pen = new Pen(Color.Black, 1);
            Point center = new Point(panel.Size.Width / 2, panel.Size.Height / 2);
            int radiusX = panel.Size.Width / 2;
            int radiusY = panel.Size.Height / 2;
            //элипс
            gr.FillEllipse(Brushes.WhiteSmoke, new Rectangle(center.X - radiusX, center.Y - radiusY, radiusX * 2, radiusY * 2));
            //рисование осей
            gr.DrawLine(pen, center.X - radiusX, center.Y, center.X + radiusX, center.Y);
            gr.DrawLine(pen, center.X, center.Y - radiusY, center.X, center.Y + radiusY);
            //расположение светодиодов
            if (checkBoxes == null || (checkBoxes.Length != IndexesOfLights.Length))
            {
                fillLightsArray(LibraryOfLights.RadialLights, center, radiusX, radiusY);
            }

            pLights.Image = bmBackGround;
        }
        /// <summary>
        /// Вывести сетодиоды
        /// </summary>
        /// <param name="listOfRadLights"></param>
        /// <param name="center"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        private void fillLightsArray(List<RadialLight> listOfRadLights, Point center, int radiusX, int radiusY)
        {
            //определение самой отдаленной точки от центра координат
            int MaxAngle = 0;
            for (int i = 0; i < IndexesOfLights.Length; i++)
            {
                if (MaxAngle < listOfRadLights[IndexesOfLights[i]].Distance)
                {
                    MaxAngle = listOfRadLights[IndexesOfLights[i]].Distance;
                }
            }
            //определение максимального угла, написанного на осях
            int MaxAxisAngle = MaxAngle;
            if (MaxAngle % 10 != 0)
            {
                float val = MaxAngle / 10f + 1f;
                MaxAxisAngle = (int)val * 10;
            }
            int numberOfCircles = MaxAxisAngle / 10;
            //коэффициент растяжения точек по кругу
            float koefX = radiusX / MaxAxisAngle;
            float koefY = radiusY / MaxAxisAngle;
            //рисование элипсов 
            Font fontSmall = new Font("Times New Roman", 7);
            Pen pen2 = new Pen(Brushes.White, 2f);
            for (int i = 1; i <= numberOfCircles; i++)
            {
                Graphics.FromImage(bmBackGround).DrawEllipse(pen2, new Rectangle(center.X - (int)(koefX * 10f * i), center.Y - (int)(koefY * 10f * i), (int)(koefX * 10f * i) * 2, (int)(koefY * 10f * i) * 2));
                Graphics.FromImage(bmBackGround).DrawString((i * 10).ToString(), fontSmall,
                    Brushes.Black,
                    new PointF(center.X + (int)(koefX * 10f * i) - 5, center.Y + 5));
            }

            checkBoxes = new CheckBox[IndexesOfLights.Length];

            Font font = new Font(FontFamily.GenericSansSerif, 8);
            Size size = new Size(10, 10);
            Padding pad = new Padding(0);
            for (int i = 0; i < IndexesOfLights.Length; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = "";
                cb.Parent = pLights;
                cb.Size = size;
                cb.Checked = true;
                cb.FlatStyle = FlatStyle.Popup;
                cb.Margin = pad;
                //определение положения
                cb.Location = getLocationOfCheckBox(listOfRadLights[IndexesOfLights[i]], center, koefX, koefY);

                checkBoxes[i] = cb;
            }

        }

        /// <summary>
        /// определение положения светодиода на экране
        /// </summary>
        /// <param name="radialLight"></param>
        /// <param name="center"></param>
        /// <param name="koefX"></param>
        /// <param name="koefY"></param>
        /// <returns></returns>
        private Point getLocationOfCheckBox(RadialLight radialLight, Point center, float koefX, float koefY)
        {
            //угл относительно оси Х
            double angle = (radialLight.AngleShift - (radialLight.Number - 1) * 30) * Math.PI / 180.0; ;
            //длина до точки
            float distX = koefX * radialLight.Distance;
            float distY = koefY * radialLight.Distance;
            return new Point((int)(center.X + distX * Math.Cos(angle) - 4), (int)(center.Y - distY * Math.Sin(angle) - 4));
        }
        private void FormTestCreation_Shown(object sender, EventArgs e)
        {
            if (IndexesOfLights != null)
                drawLightsMap(pLights);
        }

        /// <summary>
        /// Кнопка выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка выбора светодиодов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            fsl = new FormSelectLights();
            fsl.ShowDialog();
            if (IndexesOfLights != null)
            {
                btnSave.Enabled = true;
                drawLightsMap(pLights);
            }
            else { btnSave.Enabled = false; }
        }

        /// <summary>
        /// Кнопка "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            TestParams tp = new TestParams();
            tp.IndexesOfLights = getIndexesOfChekedLights();
            tp.TestName = tbTestName.Text.Trim();
            if (tp.IndexesOfLights.Length == 0)
            {
                MessageBox.Show("Не выбраны светодиоды.", "Ошибка!");
                return;
            }
            if (tp.TestName == "")
            {
                MessageBox.Show("Не указано название теста.", "Ошибка!");
                return;
            }
            try
            {
                TestManager.SaveTest(tp);
                TestManager.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }
        /// <summary>
        /// Составить массив выбранных светодиодов
        /// </summary>
        /// <returns></returns>
        private int[] getIndexesOfChekedLights()
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked) ret.Add(IndexesOfLights[i]);
            }
            return ret.ToArray();
        }

        /// <summary>
        /// Действия при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTestCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            //обнуление статических переменных
            checkBoxes = null;
            IndexesOfLights = null;
        }
    }
}
