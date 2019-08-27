using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;
using SerialPortWorker;

namespace Периметр
{
    public partial class FormResult : Form
    {
        /// <summary>
        /// Объект, на котором рисуется результат
        /// </summary>
        private Bitmap bmResult;
        /// <summary>
        /// Параметры теста
        /// </summary>
        private TestParams tp;
        public FormResult(TestParams testParams)
        {
            InitializeComponent();
            tp = testParams;
#if DEBUG
            TopMost = false;
#endif
        }
        /// <summary>
        /// Действия при появлении формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormResult_Shown(object sender, EventArgs e)
        {
            bmResult = DrawResult(tp);
            pbResult.Width = bmResult.Width;
            pbResult.Height = bmResult.Height;
            pbResult.Location = new Point(pResultWraper.Width / 2 - pbResult.Width / 2, 0);
            pbResult.Image = bmResult;
        }
        /// <summary>
        /// Формирование отчета
        /// </summary>
        /// <param name="tp"></param>
        /// <returns></returns>
        private Bitmap DrawResult(TestParams tp)
        {
            Bitmap bm = new Bitmap(840, 1188);
            Graphics gr = Graphics.FromImage(bm);
            //создание шрифтов
            Font font = new Font("Times New Roman", 14);
            Font fontSmall = new Font("Times New Roman", 7);
            Font fontBold = new Font("Times New Roman", 14, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);
            //заливка фона белым цветом
            gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, 840, 1188));
            //Название учреждения
            gr.DrawString(FormSettings.GetInfo()[0], fontBold, brush, new PointF(150, 15));
            //Пациент
            gr.DrawString(String.Format("Пациент: " + tp.Patient.FIO), font, brush, new PointF(30, 50));
            gr.DrawString(String.Format("Пол: " + tp.Patient.Sex), font, brush, new PointF(30, 75));
            gr.DrawString(String.Format("Дата рождения: " + tp.Patient.DateOfBirth.ToShortDateString()), font, brush, new PointF(30, 100));
            //возраст
            int age = DateTime.Now.Subtract(tp.Patient.DateOfBirth).Days / 365;
            gr.DrawString(String.Format("Возраст: " + age), font, brush, new PointF(30, 125));
            //дата теста
            gr.DrawString(String.Format("Дата проведения теста: " + tp.DateOfTest.ToShortDateString()), font, brush, new PointF(30, 150));
            gr.DrawString(String.Format("Время проведения теста: " + tp.DateOfTest.ToShortTimeString()), font, brush, new PointF(30, 175));
            //глаз
            gr.DrawString(String.Format("Глаз: " + Eyes.GetString(tp.CurrentEye)), font, brush, new PointF(480, 50));
            //Время теста
            gr.DrawString(String.Format("Длительность теста: " + tp.Results.TestTime), font, brush, new PointF(480, 75));
            //импульсы
            gr.DrawString(String.Format("Длительность импульса: " + tp.Results.Duration + " мс"), font, brush, new PointF(480, 100));
            gr.DrawString(String.Format("Интервал импульса: " + tp.Results.Interval + " мс"), font, brush, new PointF(480, 125));
            //точки
            gr.DrawString(String.Format("Количество точек: " + tp.Results.IntensityResults.Length), font, brush, new PointF(480, 150));
            //стратегия
            gr.DrawString(String.Format("Стратегия: " + TestMethods.GetString(tp.TestMethod)), font, brush, new PointF(480, 175));
            //название теста
            gr.DrawString(String.Format("Тест: " + tp.TestName), fontBold, brush, new PointF(150, 210));
            #region График светочувствительности
            Pen pen = new Pen(Color.Black, 1);
            Point center = new Point(420, 670);
            int diametr = 800;

            //рисование осей
            gr.DrawLine(pen, center.X - diametr / 2, center.Y, center.X + diametr / 2, center.Y);
            gr.DrawLine(pen, center.X, center.Y - diametr / 2, center.X, center.Y + diametr / 2);
            //определение самой отдаленной точки от центра координат
            int MaxAngle = 0;
            for (int i = 0; i < tp.IndexesOfLights.Length; i++)
            {
                if (MaxAngle < LibraryOfLights.RadialLights[tp.IndexesOfLights[i]].Distance)
                {
                    MaxAngle = LibraryOfLights.RadialLights[tp.IndexesOfLights[i]].Distance;
                }
            }
            //определение максимального угла, написанного на осях
            int MaxAxisAngle = MaxAngle;
            if (MaxAngle % 10 != 0)
            {
                float val = MaxAngle / 10f + 1f;
                MaxAxisAngle = (int)val * 10;
            }
            if (MaxAxisAngle == 0) MaxAxisAngle = 10;
            int numberOfCircles = MaxAxisAngle / 10;
            //коэффициент растяжения точек
            float koef = (diametr / 2) / MaxAxisAngle;
            //рисование окружностей 
            Pen pen2 = new Pen(new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent90, Color.WhiteSmoke), 0.5f);
            for (int i = 1; i <= numberOfCircles; i++)
            {
                int rad = (int)(koef * 10f * i);
                gr.DrawEllipse(pen2, new Rectangle(center.X - rad, center.Y - rad, rad * 2, rad * 2));
                gr.DrawString((i * 10).ToString(), fontSmall,
                    new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent20, Color.WhiteSmoke),
                    new PointF(center.X + koef * i * 10, center.Y));
            }
            //рисование интенсивностей
            for (int i = 0; i < tp.IndexesOfLights.Length; i++)
            {
                //определение положения
                Point loc = getLocationOfLabel(LibraryOfLights.RadialLights[tp.IndexesOfLights[i]], center, koef);
                //рисование
                gr.DrawString(tp.Results.IntensityResults[i].IntensityLevel.ToString(), fontSmall, brush, loc);
            }
            //график светочувствительности
            gr.DrawString("График светочувствительности, Дб", font, brush, new PointF(250, 1080));
            #endregion
            //врач
            gr.DrawString(String.Format("Врач: " + FormSettings.GetInfo()[1]), font, brush, new PointF(30, 1130));
            return bm;
        }
        private Point getLocationOfLabel(RadialLight radialLight, Point center, float koef)
        {
            //угл относительно оси Х
            double angle = (radialLight.AngleShift - (radialLight.Number - 1) * 30) * Math.PI / 180.0;
            //длина до точки
            float dist = koef * radialLight.Distance;
            return new Point((int)(center.X + dist * Math.Cos(angle) - 6), (int)(center.Y - dist * Math.Sin(angle) - 8));
        }
        /// <summary>
        /// Печать результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            PrintDialog pDialog = new PrintDialog();
            pDialog.Document = pd;
            pDialog.ShowDialog();
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmResult, new Point(0, 0));
            e.HasMorePages = false;
        }
        /// <summary>
        /// Сохранение результата в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.FileName = tp.Patient.FIO + ", " + tp.TestName + ", " + TestMethods.GetString(tp.TestMethod) + ", " + tp.DateOfTest.ToShortDateString();
            sfd.Filter = "jpeg|*.jpg";
            sfd.Title = "Сохранение результата в файл";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                try
                {
                    bmResult.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void FormResult_SizeChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
