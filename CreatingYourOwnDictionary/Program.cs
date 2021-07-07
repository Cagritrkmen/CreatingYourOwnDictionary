using System;

namespace CreatingYourOwnDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------MY DICTIONARY--------------------------------------------------");

            MyDictionary<int, string> myCustomerList = new MyDictionary<int, string>();

            myCustomerList.Add(1, "Çağrı Türkmen");
            myCustomerList.Add(2, "Derya Sarı");
            myCustomerList.Add(3, "Hüseyin Kağan Arduç");

            Console.WriteLine(myCustomerList.Count);

            myCustomerList.ShowKeysValues();
        }
    }
}
