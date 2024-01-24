using System.Collections.Specialized;

namespace challange_app
{
   public interface IEmployee
    {
         string Name { get; }
         string Surname { get; }
         string Sex { get;  }
        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
       void AddGrade(string grade);
        Statistics GetStatistics();

    }
}
