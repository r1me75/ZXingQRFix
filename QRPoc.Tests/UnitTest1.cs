using QRPoc.Models;

namespace QRPoc.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Menu menu = new Menu("Emir", "Ozdemir");

            Assert.That(menu, Is.Not.Null);
            Assert.That(menu.Name, Is.EqualTo("Emir"));
            Assert.That(menu.Description, Is.EqualTo("Ozdemir"));
        }
    }
}