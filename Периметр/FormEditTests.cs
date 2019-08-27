using System;
using System.Windows.Forms;

namespace Периметр
{
    public partial class FormEditTests : Form
    {
        public FormEditTests()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Вывести список тестов
        /// </summary>
        private void FillListOfTests()
        {
            lbTests.Items.Clear();
            for (int i = 0; i < TestManager.files.Length; i++)
            {
                lbTests.Items.Add(TestManager.files[i].Name.Remove(TestManager.files[i].Name.Length - 11, 11));
            }
        }
        private void FormEditTests_Shown(object sender, EventArgs e)
        {
            FillListOfTests();
        }
        /// <summary>
        /// Обработка нажатия на кнопку "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Hide();
            FormTestCreation ftc = new FormTestCreation();
            ftc.ShowDialog();

            Show();
            TestManager.Reset();
            FillListOfTests();
        }
        /// <summary>
        /// Обработка нажатия на кнопку "Удалить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbTests.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран тест.");
                return;
            }
            try
            {
                TestManager.DeleteTest(lbTests.Items[lbTests.SelectedIndex].ToString());
                TestManager.Reset();
                FillListOfTests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Обработка нажатия на кнопку "Изменить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbTests.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран тест.");
                return;
            }
            Hide();
            try
            {
                FormTestCreation ftc = new FormTestCreation(TestManager.GetTestParams(lbTests.Items[lbTests.SelectedIndex].ToString()));
                ftc.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Show();
        }
    }
}
