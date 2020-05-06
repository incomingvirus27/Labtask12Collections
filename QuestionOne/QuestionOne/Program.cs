using System;
using System.Collections;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {           
            string[,] exhibition = new string[15, 5]{
            {"Photography", "Jack Morris", "Science", "floor one", "Primary" },
            { "Photography", "Mary Jane", "Art", "floor one", "Labs" },
            { "Scholarship", "James Bond", "Education", "floor three", "Higher" },
            { "Museum", "Sky Walker", "Art", "floor one", "Primary" },
            { "Sports", "Bryan Chloe", "Education", "floor two", "Higher" },
            { "Medical facilities", "Joy Billy", "Science", "floor two", "Labs" },
            { "Organic food", "Gregory Timber", "Science", "floor one", "Labs" },
            { "Movies", "Osword Macualay", "Art", "floor two", "Higher" },
            { "Graphic Design", "Swagger Miley", "Science", "floor three", "Higher"},
            { "Product Sales", "Mercy Boris", "Marketing", "floor two", "Labs" },
            { "Medicine", "Cynthia Brown", "Science", "floor one", "Labs" },
            { "Movies", "Ramson Noah", "Art", "floor three", "Primary" },
            { "Photography", "Josephine Rice", "Art", "floor three", "Primary" },
            { "Scholarship", "Stanford Martins", "Education", "floor three", "Higher" },
            { "Sports", "Jones Bone", "Physical education", "floor two", "Primary" }
            };          

            ArrayList list = new ArrayList();
            for (int i = 0; i < 15; i++)
            {
                list.Add((exhibition[i, 0], exhibition[i, 1], exhibition[i, 2], exhibition[i, 3], exhibition[i, 4]));
            }

            list.RemoveAt(8);
            foreach (var item in list)
            {               
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("==============================Part B of Questuion One=============================================");

            Hashtable hashtable = new Hashtable();
            Result result1 = new Result(2019, 89, "MATHS");
            Result result2 = new Result(2018, 99, "English");
            Result result3 = new Result(2019, 69, "Fine Art");
            Result result4 = new Result(2018, 69, "MATHS");
            Result result5 = new Result(2019, 29, "MATHS");

            Rankers rankers1 = new Rankers("Joy", result1);
            Rankers rankers2 = new Rankers("Ngozi", result2);
            Rankers rankers3 = new Rankers("Luke", result3);
            Rankers rankers4 = new Rankers("Thomas", result4);
            Rankers rankers5 = new Rankers("Adepoju", result5);

            rankers1.GetTopRanked();
            rankers2.GetTopRanked();
            rankers3.GetTopRanked();
            rankers4.GetTopRanked();
            rankers5.GetTopRanked();

            hashtable.Add(rankers1.Name, rankers1.GetResults());
            hashtable.Add(rankers2.Name, rankers2.GetResults());
            hashtable.Add(rankers3.Name, rankers3.GetResults());
            hashtable.Add(rankers4.Name, rankers4.GetResults());
            hashtable.Add(rankers5.Name, rankers5.GetResults());


            foreach (Object key in hashtable.Values)
            {
                Console.WriteLine($"{key}");
            }

            Console.WriteLine("After selecting the highest");

        }
    }
}
