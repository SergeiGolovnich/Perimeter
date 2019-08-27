using System;

namespace Периметр
{
    [Serializable]
    public class TestParams
    {
        [NonSerialized]
        private Patient patient;
        [NonSerialized]
        private DateTime dateOfTest;
        [NonSerialized]
        private TestMethods.TestMethod testMethod;
        [NonSerialized]
        private Eyes.Eye currentEye;
        [NonSerialized]
        private TestResults results;
        private string testName;

        /// <summary>
        /// Резуьтаты тестирования
        /// </summary>
        public TestResults Results { get => results; set => results = value; }
        /// <summary>
        /// Информация о пациенте
        /// </summary>
        public Patient Patient { get => patient; set => patient = value; }
        /// <summary>
        /// Исследуемый глаз
        /// </summary>
        public Eyes.Eye CurrentEye { get => currentEye; set => currentEye = value; }
        /// <summary>
        /// Метод тестирования
        /// </summary>
        public TestMethods.TestMethod TestMethod { get => testMethod; set => testMethod = value; }
        /// <summary>
        /// Название теста
        /// </summary>
        public string TestName { get => testName; set => testName = value; }
        /// <summary>
        /// Время проведения теста
        /// </summary>
        public DateTime DateOfTest { get => dateOfTest; set => dateOfTest = value; }

        /// <summary>
        /// Массив индексов светодиодов
        /// </summary>
        public int[] IndexesOfLights;

        public override string ToString()
        {
            return string.Format("Тест: {0}; Метод: {1}; Пациент: {2} {3}; Глаз: {4}", TestName, TestMethods.GetString(TestMethod), Patient.Surname, Patient.Name, Eyes.GetString(CurrentEye));
        }
    }
    public class Patient
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// ФИО одной строкой
        /// </summary>
        public string FIO
        {
            get
            {
                return String.Format("{0} {1} {2}", Surname, Name, Patronymic);
            }
        }
    }
    public static class TestMethods
    {
        public enum TestMethod
        {
            threshold, screening
        }
        public static string GetString(TestMethod tm)
        {
            string ret = "";
            switch (tm)
            {
                case TestMethod.screening:
                    ret = "Скрининг-тест";
                    break;
                case TestMethod.threshold:
                    ret = "Пороговый уровень";
                    break;
            }
            return ret;
        }
    }
    public static class Eyes
    {
        public enum Eye { left, right }
        public static string GetString(Eye e)
        {
            string ret = "";
            switch (e)
            {
                case Eye.left:
                    ret = "Левый";
                    break;
                case Eye.right:
                    ret = "Правый";
                    break;
            }
            return ret;
        }
    }
    public class TestResults
    {
        /// <summary>
        /// Время прохождения теста
        /// </summary>
        public string TestTime { get; set; }
        /// <summary>
        /// Интервал воздействия
        /// </summary>
        public int Interval { get; set; }
        /// <summary>
        /// Время воздействия
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// Полученные уровни интенсивности точек
        /// </summary>
        public ResultOfLight[] IntensityResults { get; set; }
    }
    public struct ResultOfLight
    {
        /// <summary>
        /// Наименьший уровень яркости, который заметил пациент
        /// </summary>
        public int IntensityLevel { get; set; }
        /// <summary>
        /// Сколько раз пациент увидел светодиод с одинаковой интенсивностью
        /// </summary>
        public int RespondedPerIntensity { get; set; }
        /// <summary>
        /// Количество активаций с одинаковой интенсивностью
        /// </summary>
        public int ActivatedPerIntensity { get; set; }
        /// <summary>
        /// True показывает, что точка проверена
        /// </summary>
        public bool Verified { get; set; }
    }
}
