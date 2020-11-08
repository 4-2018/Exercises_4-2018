using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_4_2018
{
    class ExerciseResult
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }
        public int Points { get; set; }

        
        public ExerciseResult(int Id, string StudentName, string StudentIndex, int Points)
        {
            this.Id = Id;
            this.StudentName = StudentName;
            this.StudentIndex = StudentIndex;
            this.Points = Points;
        }

        public override string ToString()
        {
            return "ID:" + this.Id + "\n\t" +
                   "Ime:" + this.StudentName + "\n\t" +
                   "Indeks:" + this.StudentIndex + "\n\t" +
                   "Poeni:" + this.Points + "\n\t";
        }

    }
}
