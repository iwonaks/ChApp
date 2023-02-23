using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }

        void AddGrade(int grade);
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(char grade);

        Statistics GetStatistics();

        delegate void FeedbakToAddGrade(Object sender, EventArgs args);

        event FeedbakToAddGrade GradeAddedToStatistics;

        event FeedbakToAddGrade GradeSaveToFile;
    }
}
