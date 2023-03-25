

namespace challange_app.Test
{
    public class TypeTests
    {
        [Test]
        public void NameWitchWeHaveArentTheSame()
        {
            //arrange
            string Student1 = "Kuba";
            string Student2 = "Mateusz";
            //act

            //assert
            Assert.AreNotEqual(Student1, Student2);
        }
        [Test]
        public void TestNumberWitchWeHaveReturnTheSameResult()
        {
            //arrange
            float number = 0324243234;
           float number2 = 0324243234;
            //act

            //assert
            Assert.AreEqual(number, number2);
        }
        [Test]
        public void TestNumberWitchWeHaveReturnDifrentResult()
        {
            //arrange
            int number = 0;
            int number2 = 2;
            //act

            //assert
            Assert.AreNotEqual(number, number2);
        }
            [Test]
        public void GetEmployeeShouldRetunDifrentObjects()
        {
            //arrange
            var Employee1 = GetEmployee("Mateusz", "Kowalski", "22");
            var Employee2 = GetEmployee("piotr", "Kowalski", "22");
            //act

            //assert
            Assert.AreNotEqual(Employee1, Employee2);
        }
        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee(name, surname, age);
        }
    }
}
