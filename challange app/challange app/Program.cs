using challange_app;


var Employee = new Employee("Mateusz", "Świderski");
Employee.AddGrade("2000");
Employee.AddGrade(200);
Employee.AddGrade(2);
Employee.AddGrade(6);
var statistics = Employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

var statistics1 = Employee.GetStatisticsWithWhile();
var statistics2= Employee.GetStatisticsWithDoWhile();
var statistics3 = Employee.GetStatisticsWithFor();
var statistics3 = Employee.GetStatisticsWithForeach();
