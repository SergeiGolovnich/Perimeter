using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Периметр
{
    public static class TestManager
    {
        /// <summary>
        /// Папка, в которой хранятся тесты
        /// </summary>
        private static DirectoryInfo testsFolder = Directory.CreateDirectory(@".\Tests");
        /// <summary>
        /// Список файлов, хранящих параметры тестов
        /// </summary>
        public static FileInfo[] files;
        /// <summary>
        /// Массив кнопок на панели
        /// </summary>
        private static Button[] buttons;
        /// <summary>
        /// Поиск файлов, содержащих параметры тестов
        /// </summary>
        public static void FindFilesOfTests()
        {
            files = testsFolder.GetFiles("*.testparams", SearchOption.TopDirectoryOnly);
        }
        /// <summary>
        /// Сохранение параметров теста в файл
        /// </summary>
        /// <param name="tp"></param>
        public static void SaveTest(TestParams tp)
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream sw = new FileStream(testsFolder.FullName + '\\' + DeleteUnsupportedCharacters(tp.TestName) + ".testparams", FileMode.OpenOrCreate))
                {
                    bf.Serialize(sw, tp);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Невозможно сохранить тест в файл.\n" + ex.Message);
            }
        }
        /// <summary>
        /// Удаление неподдерживаемых символов в названиях файлов
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string DeleteUnsupportedCharacters(string str)
        {
            char[] mustBeDeleted = new char[] { '/', '\\', ':', '*', '?', '\"', '<', '>', '|' };
            for (int i = 0; i < mustBeDeleted.Length; i++)
            {
                int index;
                while ((index = str.IndexOf(mustBeDeleted[i])) >= 0)
                {
                    str.Remove(index, 1);
                }
            }
            return str;
        }
        /// <summary>
        /// Поместить кнопки для запука тестов на пенель
        /// </summary>
        /// <param name="form"></param>
        /// <param name="p"></param>
        public static void CreateButtons(FormMain form, Panel p)
        {
            buttons = new Button[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                if (i == 0)
                    buttons[i] = CreateButton(files[i], p);
                else buttons[i] = CreateButton(files[i], p, buttons[i - 1]);
                //указываем обработчик нажатия на кнопку
                buttons[i].Click += form.buttonTest_Click;
            }
        }
        /// <summary>
        /// Создание и расположение кнопки на панели
        /// </summary>
        /// <param name="fi"></param>
        /// <param name="p"></param>
        /// <param name="previous"></param>
        /// <returns></returns>
        private static Button CreateButton(FileInfo fi, Panel p, Button previous = null)
        {
            Button btn = new Button();
            btn.AutoSize = true;
            btn.Text = fi.Name.Remove(fi.Name.Length - 11, 11);
            btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Parent = p;
            btn.Padding = new Padding(5);
            btn.Margin = new Padding(15);
            if (previous != null)
            {
                if ((p.Width - (previous.Location.X + previous.Width + 2 * previous.Margin.All)) < (btn.Width + 2 * btn.Margin.All))
                {
                    btn.Location = new System.Drawing.Point(btn.Margin.All, previous.Location.Y + previous.Height + btn.Margin.All);
                }
                else
                {
                    btn.Location = new System.Drawing.Point(previous.Location.X + previous.Width + previous.Margin.All, previous.Location.Y);
                }
            }
            else
            {
                btn.Location = new System.Drawing.Point(btn.Margin.All, btn.Margin.All);
            }
            return btn;
        }
        /// <summary>
        /// Получить параметры теста по его названию
        /// </summary>
        /// <param name="testName"></param>
        /// <returns></returns>
        public static TestParams GetTestParams(string testName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            TestParams tp = null;
            try
            {
                using (FileStream sw = new FileStream(testsFolder.FullName + '\\' + testName + ".testparams", FileMode.Open))
                {
                    tp = (TestParams)bf.Deserialize(sw);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Невозможно открыть файл теста.\n" + ex.Message);
            }
            return tp;
        }
        /// <summary>
        /// Перезагрузить тесты
        /// </summary>
        public static void Reset()
        {
            if (buttons == null) return;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Dispose();
            }
            buttons = null;
            FindFilesOfTests();
        }
        /// <summary>
        /// Удаление файла теста
        /// </summary>
        /// <param name="testName"></param>
        public static void DeleteTest(string testName)
        {
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name == testName + ".testparams")
                {
                    try
                    {
                        files[i].Delete();
                        return;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Нельзя удалить файл.\n" + ex.Message);
                    }
                }
            }
        }
    }
}
