using System;
using System.Collections;


namespace QuestionTwo
{
    class DictionaryGeneric : DictionaryBase
    {
        public void Add(string name, string department)
        {
            Dictionary.Add(name, department);
        }   
        
        public void GetDetails()
        {
            IDictionaryEnumerator objEnumerate = Dictionary.GetEnumerator();
            while (objEnumerate.MoveNext())
            {
                Console.WriteLine(objEnumerate.Key + "\t\t" + objEnumerate.Value);
            }
        }

    }
}
