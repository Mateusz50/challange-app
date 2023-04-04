using System.Reflection.Metadata.Ecma335;

namespace challange_app.Test
{
    public class Tests
    {

        [Test]
        public void whenEmployerGetGrades_thenShowCorectMaxStatisticsValue()
        {
            //arrange
            var Employee = new Employee("tomek", "misiak");
            Employee.AddGrade(2);
            Employee.AddGrade(5);
            Employee.AddGrade(5);
            //act
            var statistics = Employee.GetStatistics();

            //assert

            Assert.AreEqual(5, statistics.Max);
        }
        [Test]
        public void whenEmployerGetGrades_thenShowCorectMinStatisticsValue()
        {
            //arrange
            var Employee = new Employee("tomek", "misiak");
            Employee.AddGrade(2);
            Employee.AddGrade(5);
            Employee.AddGrade(5);
            //act
            var statistics = Employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void whenEmployerGetGrades_thenShowCorectAverageStatisticsValue()
        {
            //arrange
            var Employee = new Employee("tomek", "misiak");
            Employee.AddGrade(2);
            Employee.AddGrade(5);
            Employee.AddGrade(5);
            //act
            var statistics = Employee.GetStatistics();

            //assert

            Assert.AreEqual(4, statistics.Average);
        }
    }
}