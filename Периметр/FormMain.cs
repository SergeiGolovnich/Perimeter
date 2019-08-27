using System;
using System.Windows.Forms;

namespace Периметр
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            TestManager.FindFilesOfTests();
#if DEBUG
            TopMost = false;
#endif
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Запуск выбранного теста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                FormSelectMethod fsm = new FormSelectMethod(getPatientInfo(), (sender as Button).Text);
                fsm.ShowDialog();
            }
            catch (ArgumentException ae) { MessageBox.Show(ae.Message); }
        }
        /// <summary>
        /// Считать данные пациента
        /// </summary>
        /// <returns></returns>
        private Patient getPatientInfo()
        {
            Patient patient = new Patient();
            patient.Name = tbName.Text.Trim();
            patient.Surname = tbFam.Text.Trim();
            patient.Patronymic = tbOt.Text.Trim();
            patient.DateOfBirth = mcBirth.SelectionStart;
            if (rbMale.Checked)
            {
                patient.Sex = "Мужской";
            }
            else
            {
                patient.Sex = "Женский";
            }
            if (patient.Name == "" || patient.Surname == "" || patient.Patronymic == "" || patient.DateOfBirth >= DateTime.Today)
            {
                throw new ArgumentException("Неправильно заполнены данные пациента.");
            }
            return patient;
        }
        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        private void FormMain_Shown(object sender, EventArgs e)
        {
            TestManager.CreateButtons(this, panelOfTests);
        }
        /// <summary>
        /// Перезагрузить кнопки тестов
        /// </summary>
        public void ResetTestsButtons()
        {
            TestManager.Reset();
            TestManager.CreateButtons(this, panelOfTests);
        }
        /// <summary>
        /// Запуск формы изменения списка тестов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditTests_Click(object sender, EventArgs e)
        {
            //проверка пароля
            FormPassEnter fpe = new FormPassEnter();
            fpe.ShowDialog();
            if (fpe.PasswordConfirmed)
            {
                fpe.Close();
                FormEditTests fet = new FormEditTests();
                fet.ShowDialog();
                ResetTestsButtons();
            }
            else
            {
                fpe.Close();
                MessageBox.Show("Для изменения списка тестов требуется пароль администратора.");
                return;
            }
        }

        /// <summary>
        /// Запуск формы настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            fs.ShowDialog();
        }

        /// <summary>
        /// Запуск формы справка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            FormHelpInfo fhi = new FormHelpInfo();
            fhi.ShowDialog();
        }
    }
}
