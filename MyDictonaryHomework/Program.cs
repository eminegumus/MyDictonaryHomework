using System;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary=new MyDictionary<int, string>();
            myDictionary.Add(1,"Emine");
            myDictionary.Add(2,"Birce");
            myDictionary.Add(3,"İsmail");
        }
    }
}
