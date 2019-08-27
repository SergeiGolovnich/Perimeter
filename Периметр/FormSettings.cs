using System;
using System.Windows.Forms;
using System.IO;

namespace Периметр
{
    public partial class FormSettings : Form
    {
        /// <summary>
        /// Файл, где хранятся настройки
        /// </summary>
        private static FileInfo fi = new FileInfo(@".\Settings.dat");
        /// <summary>
        /// Настройки, загруженные из файла
        /// </summary>
        private static string[] stringsSettings = new string[3];
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Shown(object sender, EventArgs e)
        {
            LoadSettings();
            PrintSettings();
        }
        /// <summary>
        /// Сохранение настроек
        /// </summary>
        private static void SaveSettings()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(fi.FullName, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                foreach (var data in stringsSettings)
                {
                    sw.WriteLine(data);
                }
            }
        }
        /// <summary>
        /// Загрузка настроек
        /// </summary>
        private static void LoadSettings()
        {
            if (fi.Exists)
            {
                stringsSettings = File.ReadAllLines(@".\Settings.dat");
            }
            else
            {
                stringsSettings[2] = "123";//пароль по-умолчанию
                SaveSettings();
            }
        }
        /// <summary>
        /// Проверка правильности пароля
        /// </summary>
        /// <param name="str"></param>
        public static bool GetPassConfirmed(string str)
        {
            LoadSettings();
            if (str == stringsSettings[2])
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Вывод настроек на экран
        /// </summary>
        private void PrintSettings()
        {
            tbName.Text = stringsSettings[0];
            tbFIO.Text = stringsSettings[1];
            tbPass.Text = stringsSettings[2];
        }
        /// <summary>
        /// Обработка нажания кнопки "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработка нажания кнопки "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string fio = tbFIO.Text.Trim();
            string pass = tbPass.Text.Trim();
            //проверка на пустой ввод
            if (name == "" || fio == "" || pass == "")
            {
                MessageBox.Show("Неправильно заполнены поля для ввода.");
                return;
            }
            //проверка изменения важных данных
            if (stringsSettings[0] != name || stringsSettings[2] != pass)
            {
                //ввод пароля
                FormPassEnter fpe = new FormPassEnter();
                fpe.ShowDialog();
                //если пароль правильный
                if (fpe.PasswordConfirmed)
                {
                    fpe.Close();
                    stringsSettings[0] = name;
                    stringsSettings[1] = fio;
                    stringsSettings[2] = pass;
                }
                else//если неправильный пароль
                {
                    MessageBox.Show("Данные не могут быть сохранены без ввода пароля администратора.");
                    fpe.Close();
                    return;
                }
            }
            else
            {
                stringsSettings[1] = fio;
            }
            SaveSettings();
            Close();
        }
        /// <summary>
        /// Получить название организации и ФИО врача
        /// </summary>
        /// <returns></returns>
        public static string[] GetInfo()
        {
            string[] ret = new string[2];
            LoadSettings();
            ret[0] = stringsSettings[0];
            ret[1] = stringsSettings[1];
            return ret;
        }
    }
}
