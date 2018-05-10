using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        List<float> grades;
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics computeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();
            stats.HighestGrade = 0;
            float sum = 0;
            foreach(float grade in grades)
            {
               
                    stats.HighestGrade = Math.Max(grade,stats.HighestGrade);
                    stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                    sum = sum + grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
       
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}
