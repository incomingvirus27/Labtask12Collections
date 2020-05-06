using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    class Result
    {
        public int Year { get; set; }
        private int marks;
        public string Subject { get; set; }


        public Result(int yrs, int mrk, string sub)
        {
            Year = yrs;
            Marks = mrk;
            Subject = sub;
        }


        public int Marks
        {
            get { return marks; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    marks = value;
                }
                else
                {
                    //  throw ArgumentOutOfRangeException;
                }
            }
        }

    }
}
