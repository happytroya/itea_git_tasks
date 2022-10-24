using System.Collections.Generic;

namespace Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Person> personList = new List<Person>();
            personList.Add(new Person("John", 21));
            personList.Add(new Person("Vika", 21));
            personList.Add(new Person("John", 21));
            personList.Add(new Person("Mikola", 81));

            for (int i = 0; i < personList.Count; i++)
            {
                for (int j = i+1; j < personList.Count; j++)
                {

                    if (personList[i] < personList[j])
                    {
                        Console.WriteLine($"{personList[i].GetInfo()} age is less than {personList[j].GetInfo()} age");
                    }
                    if (personList[i] > personList[j])
                    {
                        Console.WriteLine($"{personList[i].GetInfo()} age is greater than {personList[j].GetInfo()}");
                    }
                    if (personList[i] == personList[j])
                    {
                        Console.WriteLine($"{personList[i].GetInfo()}  name and age or just age equals {personList[j].GetInfo()}");
                    }
                }
            }
        }

        
    }
}