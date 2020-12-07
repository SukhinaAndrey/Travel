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
            // ��������� ��'���� ���� Operaions
            Operaions operaions = new Operaions();

            // ������ ������ Get ��� �������� �������� � �� ������� ��������� �� ��������
            int res = operaions.Get(1).Count;

            // ��������� ����� res � ��������� �� ����, ������ ������ �������� ����� Get
            res = res > 0 ? 1 : 0;

            // �������� ����������. � ������� ������� - ���������� ����� �������
            Assert.AreEqual(1, res, 0.001, "Invalid data geting");
        }
    }
}
