using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            if (averageGrade > 80.0)
            {
                return 'A';
            }

            if (averageGrade > 60.0)
            {
                return 'B';
            }

            if (averageGrade > 40.0)
            {
                return 'C';
            }

            if (averageGrade > 20.0)
            {
                return 'D';
            }

            return 'F';
        }
    }
}
