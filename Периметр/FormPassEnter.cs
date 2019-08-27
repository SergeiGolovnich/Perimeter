using System;
using System.Windows.Forms;

namespace Периметр
{
    public partial class FormPassEnter : Form
    {
        /// <summary>
        /// Флажок правильности пароля
        /// </summary>
        public bool PasswordConfirmed = false;
        public FormPassEnter()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Кнопка "ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string enteredPass = tbPass.Text.Trim();
            //проверка на пустой ввод
            if (enteredPass == "")
            {
                MessageBox.Show("Пароль не может быть пустым.");
                return;
            }
            //Проверка правильности пароля
            if (FormSettings.GetPassConfirmed(enteredPass))
            {
                PasswordConfirmed = true;
                Hide();
            }
            else
            {
                PasswordConfirmed = false;
                MessageBox.Show("Неправильный пароль.");
                tbPass.Clear();
            }
        }
    }
}
