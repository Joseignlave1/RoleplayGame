using NUnit.Framework;
using RolePLay;

namespace Test.Library
{
    public class ExampleTest
    {
        [Setup]
        public void Setup()
        {

        }
        [Test]
        public void AtacarTest()
        {
            Enano enano = new Enano("Enano", 100);
            Item item1 = new Item("Arma", "Martillo", 21, 0);
            Mago mago = new Mago("Mago", 100);
            mago.RecibirAtaque(enano);
            int actual = mago.Salud;
            int expected = 100 - 21;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}