using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;
using JetBrains.ReSharper.ExternalSources.Resources;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        

        public RankedGradeBook(string name) :base(name)
        {
            Name = name;
            Type = GradeBookType.Ranked;
        }
    }
}
