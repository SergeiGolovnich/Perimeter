using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SerialPortWorker;
using System.Diagnostics;

namespace Периметр
{
    public partial class FormTest : Form
    {
        /// <summary>
        /// Объект, который управляет окном вывода видео
        /// </summary>
        private Process videoPr;
        /// <summary>
        /// Объект для связи с аппаратной частью
        /// </summary>
        private SerialPortWorker.SerialPortWorker spw;
        /// <summary>
        /// Параметры теста
        /// </summary>
        private TestParams testParams;
        /// <summary>
        /// Массив светодиоднов в виде элементов Label
        /// </summary>
        private Label[] labels;
        private Random rand = new Random();
        /// <summary>
        /// Объект для рисования осей
        /// </summary>
        private Bitmap bmBackGround;
        /// <summary>
        /// индекс светодиода, зажженного в данный момент
        /// </summary>
        private int currentLight = -1;
        /// <summary>
        /// Количество проверенных точек
        /// </summary>
        private int checkedLights = 0;
        /// <summary>
        /// Количество секунд прошедшее с начала теста
        /// </summary>
        private int testtime = 0;

        public FormTest(TestParams tp)
        {
            InitializeComponent();
            this.testParams = tp;
            printTestName(testParams);
            PrintProgress();
            //создание объекта для сохранения результата
            testParams.Results = new TestResults()
            {
                IntensityResults = new ResultOfLight[testParams.IndexesOfLights.Length]
            };

#if DEBUG
            TopMost = false;
#else
            try
            {
                spw = new SerialPortWorker.SerialPortWorker();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
#endif
        }

        /// <summary>
        /// Вывод светодиодов на экран 
        /// </summary>
        /// <param name="listOfRadLights"></param>
        /// <param name="center"></param>
        /// <param name="radius"></param>
        private void fillLightsArray(List<RadialLight> listOfRadLights, Point center, int radius)
        {
            //определение самой отдаленной точки от центра координат
            int MaxAngle = 0;
            for (int i = 0; i < testParams.IndexesOfLights.Length; i++)
            {
                if (MaxAngle < listOfRadLights[testParams.IndexesOfLights[i]].Distance)
                {
                    MaxAngle = listOfRadLights[testParams.IndexesOfLights[i]].Distance;
                }
            }
            //определение максимального угла, написанного на осях
            int MaxAxisAngle = MaxAngle;
            if (MaxAngle % 10 != 0)
            {
                float val = MaxAngle / 10f + 1f;
                MaxAxisAngle = (int)val * 10;
            }
            if (MaxAxisAngle == 0) MaxAxisAngle = 5;
            //коэффициент растяжения точек по кругу
            float koef = radius / MaxAxisAngle;
            //рисование максимального угла
            Graphics.FromImage(bmBackGround).DrawString(MaxAxisAngle.ToString(), new Font("Times New Roman", 8), Brushes.Black, new Point(center.X + (int)(koef * MaxAxisAngle), center.Y + 9));

            labels = new Label[testParams.IndexesOfLights.Length];
            //размещение светодиодов
            Font font = new Font(FontFamily.GenericSansSerif, 6);
            Size size = new Size(1, 1);
            Padding pad = new Padding(0);
            for (int i = 0; i < testParams.IndexesOfLights.Length; i++)
            {
                Label lb = new Label();
                lb.Text = "1";
                lb.Parent = pLights;
                lb.Size = size;
                lb.ForeColor = Color.Black;
                lb.BackColor = Color.WhiteSmoke;
                lb.TextAlign = ContentAlignment.TopLeft;
                lb.Font = font;
                lb.Margin = pad;
                lb.AutoSize = true;
                //определение положения светодиода на экране
                lb.Location = getLocationOfLabel(listOfRadLights[testParams.IndexesOfLights[i]], center, koef);

                labels[i] = lb;
            }

        }

        /// <summary>
        /// определение положения светодиода на экране
        /// </summary>
        /// <param name="radialLight"></param>
        /// <param name="center"></param>
        /// <param name="koef"></param>
        /// <returns></returns>
        private Point getLocationOfLabel(RadialLight radialLight, Point center, float koef)
        {
            //угл относительно оси Х
            double angle = (radialLight.AngleShift - (radialLight.Number - 1) * 30) * Math.PI / 180.0;
            //длина до точки
            float dist = koef * radialLight.Distance;
            return new Point((int)(center.X + dist * Math.Cos(angle) - 6), (int)(center.Y - dist * Math.Sin(angle) - 8));
        }

        private void printTestName(TestParams testParams)
        {
            this.Text = testParams.ToString();
        }
        /// <summary>
        /// Рисование осей
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        private Bitmap DrawBackgroundToBitMap(PictureBox panel)
        {
            Bitmap bm = new Bitmap(panel.Width, panel.Height);
            Graphics gr = Graphics.FromImage(bm);
            Pen pen = new Pen(Color.Black, 1);
            Point center = new Point(panel.Size.Width / 2, panel.Size.Height / 2);
            int diametr = panel.Size.Width <= panel.Size.Height ? panel.Size.Width : panel.Size.Height;
            //окружность
            gr.FillEllipse(Brushes.WhiteSmoke, new Rectangle(center.X - diametr / 2, center.Y - diametr / 2, diametr, diametr));
            //рисование осей
            gr.DrawLine(pen, center.X - diametr / 2, center.Y, center.X + diametr / 2, center.Y);
            gr.DrawLine(pen, center.X, center.Y - diametr / 2, center.X, center.Y + diametr / 2);
            return bm;
        }

        /// <summary>
        /// Нарисовать область светодиодов
        /// </summary>
        /// <param name="panel"></param>
        private void drawLightsMap(PictureBox panel)
        {
            bmBackGround = DrawBackgroundToBitMap(panel);
            pLights.Image = bmBackGround;
            Point center = new Point(panel.Size.Width / 2, panel.Size.Height / 2);
            int diametr = panel.Size.Width <= panel.Size.Height ? panel.Size.Width : panel.Size.Height;
            //расположение светодиодов на экране
            if (labels == null)
            {
                fillLightsArray(LibraryOfLights.RadialLights, center, diametr / 2);
            }
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
        /// Действия при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Выйти из теста?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    //выключение видео
                    videoPr.Kill();
                }
                catch { }
            }
        }

        /// <summary>
        /// Действия при изменении времени воздействия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hsbDuration_ValueChanged(object sender, EventArgs e)
        {
            if (hsbDuration.Value % 100 != 0)
            {
                float val = hsbDuration.Value / 100f + 0.5f;
                hsbDuration.Value = (int)val * 100;
            }
            timerDuration.Interval = hsbDuration.Value;
            lbDurationTime.Text = hsbDuration.Value.ToString() + " ms";
        }

        /// <summary>
        /// Действия при изменении интервала воздействия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hsbInterval_ValueChanged(object sender, EventArgs e)
        {
            if (hsbInterval.Value % 100 != 0)
            {
                float val = hsbInterval.Value / 100f + 0.5f;
                hsbInterval.Value = (int)val * 100;
            }
            timerInterval.Interval = hsbInterval.Value;
            lbIntervalTime.Text = hsbInterval.Value.ToString() + " ms";
        }

        /// <summary>
        /// Действия при загризке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTest_Shown(object sender, EventArgs e)
        {
            drawLightsMap(pLights);
            //запуск видео
            videoPr = new Process();
            videoPr.StartInfo.FileName = @".\Video\TkWatcher.exe";
            //videoPr.StartInfo.Arguments = "";
            videoPr.Start();
        }

        private void FormTest_SizeChanged(object sender, EventArgs e)
        {
            //if (WindowState != FormWindowState.Maximized)
            //{
            WindowState = FormWindowState.Maximized;
            //    drawLightsMap(pLights);
            //}
        }

        /// <summary>
        /// Кнопка начала теста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            testParams.Results = new TestResults()
            {
                IntensityResults = new ResultOfLight[testParams.IndexesOfLights.Length]
            };
            testtime = 0;
            for (int i = 0; i < testParams.IndexesOfLights.Length; i++)
            {
                labels[i].Text = "1";
            }
            currentLight = 0;

            timerTime.Enabled = true;
            btnStart.Visible = false;
            btnPause.Visible = true;
            btnStop.Visible = true;

            timerDuration_Tick(null, null);
        }

        /// <summary>
        /// Действия при тике таймера времени воздействия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDuration_Tick(object sender, EventArgs e)
        {
            if (!timerDuration.Enabled)//если никакая точка не горит
            {
                //отправляем коды запуска
#if DEBUG
#else
                spw.SetLight(LibraryOfLights.RadialLights[testParams.IndexesOfLights[currentLight]]);
                spw.SetLightIntensity(int.Parse(labels[currentLight].Text));
#endif
                //зажигаем светодиод в программе
                labels[currentLight].BackColor = Color.Red;
                timerDuration.Enabled = true;
            }
            else//если точка горит
            {
                //выключение светодиода
#if DEBUG
#else
                spw.SetLightIntensity(0);
#endif
                labels[currentLight].BackColor = Color.WhiteSmoke;
                timerInterval.Enabled = true;
                timerDuration.Enabled = false;
            }
        }

        /// <summary>
        /// Действия при тике таймера интервала воздействия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerInterval_Tick(object sender, EventArgs e)
        {
            //проверка реакции пациента
            int lvl = int.Parse(labels[currentLight].Text);//считывание уровня яркости
            //нажал ли кнопку пациент
            if (
#if DEBUG
                false
#else
                spw.PatientsResponse()
#endif
                )
            {
                //выбор метода тестирования
                if (testParams.TestMethod == TestMethods.TestMethod.screening)//если скрининг-тест
                {
                    testParams.Results.IntensityResults[currentLight].IntensityLevel = lvl;
                    testParams.Results.IntensityResults[currentLight].Verified = true;
                    checkedLights++;
                    PrintProgress();
                }
                else//если пороговый
                {
                    testParams.Results.IntensityResults[currentLight].RespondedPerIntensity++;
                    testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity++;
                    if (testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity == 5)//если пациент увидел точку все пять раз
                    {
                        //если пациент видел точку в более 50% случаев
                        if (((double)testParams.Results.IntensityResults[currentLight].RespondedPerIntensity / (double)testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity) > 0.5)
                        {
                            testParams.Results.IntensityResults[currentLight].IntensityLevel = lvl;
                            testParams.Results.IntensityResults[currentLight].Verified = true;
                            checkedLights++;
                            PrintProgress();
                        }
                    }
                }
            }
            else//если кнопка не была нажата
            {
                if (testParams.TestMethod == TestMethods.TestMethod.screening)//если скрининг-тест
                {
                    //если яркость была максимальная
                    if (lvl == LibraryOfLights.IntensityLevels.Length - 1)
                    {
                        testParams.Results.IntensityResults[currentLight].Verified = true;
                        checkedLights++;
                        PrintProgress();
                    }
                    else
                    {
                        if ((lvl + 4) > (LibraryOfLights.IntensityLevels.Length - 1))
                        {
                            lvl = LibraryOfLights.IntensityLevels.Length - 1;
                        }
                        else
                        {
                            lvl = lvl + 4;
                        }
                        labels[currentLight].Text = lvl.ToString();
                    }
                }
                else//если пороговый
                {
                    testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity++;
                    //если яркость была максимальная и точка показаны 5 раз
                    if ((lvl == LibraryOfLights.IntensityLevels.Length - 1) && (testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity == 5))
                    {
                        //если пациент видел точку в более 50% случаев
                        if (((double)testParams.Results.IntensityResults[currentLight].RespondedPerIntensity / (double)testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity) > 0.5)
                        {
                            testParams.Results.IntensityResults[currentLight].IntensityLevel = lvl;
                        }
                        testParams.Results.IntensityResults[currentLight].Verified = true;
                        checkedLights++;
                        PrintProgress();
                    }
                    else
                    {
                        if (testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity == 5)//увеличиваем яркость
                        {
                            //если пациент видел точку в более 50% случаев
                            if (((double)testParams.Results.IntensityResults[currentLight].RespondedPerIntensity / (double)testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity) > 0.5)
                            {
                                testParams.Results.IntensityResults[currentLight].IntensityLevel = lvl;
                                testParams.Results.IntensityResults[currentLight].Verified = true;
                                checkedLights++;
                                PrintProgress();
                            }
                            else
                            {
                                testParams.Results.IntensityResults[currentLight].ActivatedPerIntensity = 0;
                                testParams.Results.IntensityResults[currentLight].RespondedPerIntensity = 0;
                                if ((lvl + 2) > (LibraryOfLights.IntensityLevels.Length - 1))
                                {
                                    lvl = LibraryOfLights.IntensityLevels.Length - 1;
                                }
                                else
                                {
                                    lvl = lvl + 2;
                                }
                                labels[currentLight].Text = lvl.ToString();
                            }
                        }
                    }
                }
            }
            //проверка на окончание теста
            if (CheckForEndOfTest())
            {
                timerDuration.Enabled = false;
                timerInterval.Enabled = false;
                timerTime.Enabled = false;
                checkedLights = 0;
                btnStart.Visible = true;
                btnStop.Visible = false;
                btnPause.Visible = false;

                testParams.Results.Duration = hsbDuration.Value;
                testParams.Results.Interval = hsbInterval.Value;
                testParams.Results.TestTime = lbCurrentTime.Text;
                MessageBox.Show("Тест окончен.");
                //вывод результатов теста
                FormResult fr = new FormResult(testParams);
                fr.ShowDialog();
                Close();
            }
            else
            {
                timerInterval.Enabled = false;
                //выбираем еще не проверенную точку
                do
                {
                    currentLight = rand.Next(labels.Length);
                } while (testParams.Results.IntensityResults[currentLight].Verified);
                //запуск следующего светодиода
                timerDuration_Tick(null, null);
            }
        }
        /// <summary>
        /// Проверка на окончание теста
        /// </summary>
        private bool CheckForEndOfTest()
        {
            return checkedLights == testParams.IndexesOfLights.Length;
        }
        /// <summary>
        /// Кнопка паузы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            timerTime.Enabled = false;
            btnPause.Visible = false;
            btnStart.Visible = true;

            timerInterval.Enabled = false;
            timerDuration.Enabled = false;
            if (currentLight > 0)
            {
                labels[currentLight].BackColor = Color.WhiteSmoke;
                currentLight = -1;
            }
            //очищение буфера ввода
#if DEBUG
#else
            spw.serialPort.ReadExisting();
#endif
        }

        /// <summary>
        /// Кнопка "Стоп"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            timerTime.Enabled = false;
            testtime = 0;
            checkedLights = 0;
            lbCurrentTime.Text = "";
            btnStop.Visible = false;
            btnPause.Visible = false;
            btnStart.Visible = true;
            timerInterval.Enabled = false;
            timerDuration.Enabled = false;
            if (currentLight > 0)
            {
                labels[currentLight].BackColor = Color.WhiteSmoke;
                currentLight = -1;
            }
            PrintProgress();
            //подчистить собранные данные
#if DEBUG
#else
            spw.serialPort.ReadExisting();
#endif
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = "1";
            }
        }
        /// <summary>
        /// Напечатать прогресс выполнения теста
        /// </summary>
        private void PrintProgress()
        {
            lbProgress.Text = String.Format("{0}/{1}", checkedLights, testParams.IndexesOfLights.Length);
        }
        /// <summary>
        /// Обработка тика таймера считающего время
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            testtime++;
            int minutes = testtime / 60;
            int secs = testtime - minutes * 60;
            lbCurrentTime.Text = String.Format("{0} : {1}", minutes, secs);
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            //двигать сервопривод вверх
#if DEBUG
#else
            spw.DoServoCmd(SerialPortWorker.SerialPortWorker.ServoCmd.Up);
#endif
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            //двигать сервопривод вниз
#if DEBUG
#else
            spw.DoServoCmd(SerialPortWorker.SerialPortWorker.ServoCmd.Down);
#endif
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            //двигать сервопривод влево
#if DEBUG
#else
            spw.DoServoCmd(SerialPortWorker.SerialPortWorker.ServoCmd.Left);
#endif
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            //двигать сервопривод вправо
#if DEBUG
#else
            spw.DoServoCmd(SerialPortWorker.SerialPortWorker.ServoCmd.Right);
#endif
        }

        private void btn_StopServo(object sender, MouseEventArgs e)
        {
            //остановить сервопривод
#if DEBUG
#else
            spw.DoServoCmd(SerialPortWorker.SerialPortWorker.ServoCmd.Stop);
#endif
        }
    }
}
