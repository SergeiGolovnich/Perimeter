using System;
using System.Windows.Forms;

namespace Периметр
{
    public partial class FormSelectMethod : Form
    {
        /// <summary>
        /// Информация о пациенте
        /// </summary>
        private Patient patient;
        private FormTest ft;
        /// <summary>
        /// Название теста
        /// </summary>
        private string testName;

        public FormSelectMethod(Patient patient, string testName)
        {
            InitializeComponent();
            this.patient = patient;
            this.testName = testName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка "ОК"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Hide();//сворачиваем форму выбора метода
            TestParams ts;
            try
            {
                ts = TestManager.GetTestParams(testName);
                ts.Patient = this.patient;
                //выбор глаза
                if (rbLeft.Checked) ts.CurrentEye = Eyes.Eye.left;
                else ts.CurrentEye = Eyes.Eye.right;
                //выбор метода
                if (rbThreshold.Checked) ts.TestMethod = TestMethods.TestMethod.threshold;
                else ts.TestMethod = TestMethods.TestMethod.screening;
                //задание текущей даты
                ts.DateOfTest = DateTime.Now;
                ft = new FormTest(ts);
                ft.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Close(); }
        }
    }
}
