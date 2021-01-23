using System;
using System.Collections.Generic;
namespace DictionaryCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "123");
            myDictionary.Add(2, "234");
            myDictionary.Add(3, "567");
            Console.WriteLine(myDictionary.Get(1));
            Console.ReadLine();
            

        }
    }
}
