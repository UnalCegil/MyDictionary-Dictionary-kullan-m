using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> sehirPlaka = new Dictionary<int,string>();

            sehirPlaka.Add(16, "Bursa");
            sehirPlaka.Add(75, "Ardahan");
            sehirPlaka.Add(67, "Zonguldak");
            sehirPlaka.Add(34, "İstanbul");
            foreach (var item in sehirPlaka)
            {
                Console.WriteLine(item+"Başarıyla eklendi");
            }
        }
    }
}
