using Microsoft.VisualStudio.TestTools.UnitTesting;
using Travel;

namespace TravelUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDataGeting()
        {
            // Створення об'єкту типу Operaions
            Operaions operaions = new Operaions();

            // Виклик методу Get для існуючих елементів у БД старших аргументу за індексом
            int res = operaions.Get(1).Count;

            // Коррекція змінної res в залежності до того, скільки записів повернув метод Get
            res = res > 0 ? 1 : 0;

            // Перевірка відповідності. У випадку невдалої - виводиться текст помилки
            Assert.AreEqual(1, res, 0.001, "Invalid data geting");
        }
    }
}
