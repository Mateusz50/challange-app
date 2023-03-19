namespace challange_app.Test
{
    public class Tests
    {
     
        [Test]
        public void whenEmployerGetTwoScore_thenShowCorectResult()
        {
            //arrange
            var employee = new Employee("tomek", "misiak", "12");
            employee.AddScore(2);
            employee.AddScore(5);
            employee.AddScore(-5);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(2, result);

        }
    }
}