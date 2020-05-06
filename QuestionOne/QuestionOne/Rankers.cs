using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    class Rankers
    {
        public string Name { get; set; }
        public Result TopRankers { get; set; }
        SortedList<object, object> sortedResults = new SortedList<object, object>();

        public Rankers(string name, Result topRanked)
        {
            Name = name;
            TopRankers = topRanked;
        }

        public void GetTopRanked()
        {
            if (TopRankers.Marks >= 70)
            {
                sortedResults.Add(ToString(), TopRankers.Marks);
            }
        }

        public object GetResults()
        {
            foreach (var item in sortedResults)
            {
                return $"{item}";
            }

            return "";
        }

        public override string ToString()
        {
            return $" {Name} {TopRankers.Subject}";
        }
    }
}
