using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void TestPersonNameCorrecto() // Cambiá el nombre para indicar qué estás probando
        {
            string expected = "Mateo";
            Person person = new Person("Ricardo", "50757706");
            person.Name = "Mateo";
            Assert.AreEqual(expected, person.Name);
        }
        [Test]
        public void TestPersonIDCorrecto() // Cambiá el nombre para indicar qué estás probando
        {
            string expected = "50757706";
            Person person = new Person("Mateo", "1.234.567-8");
            person.ID = "50757706";
            Assert.AreEqual(expected, person.ID);
        }
        [Test]
        public void TestPersonNameIncorrecto() // Cambiá el nombre para indicar qué estás probando
        {
            string expected = "Mateo";
            Person person = new Person("Mateo", "50757706");
            person.Name = "";
            Assert.AreEqual(expected, person.Name);
        }
        [Test]
        public void TestPersonIDIncorrecto() // Cambiá el nombre para indicar qué estás probando
        {
            string expected = "50757706";
            Person person = new Person("Mateo", "50757706");
            person.ID = "50757886";
            Assert.AreEqual(expected, person.ID);
        }
    }
}