﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> cities = new List<string>
            {
                "Ankara",
                "İzmir",
                "Adana",
                "Eskişehir",
                "İstanbul",
                "Ankara",
                "Eskişehir",
                "Ankara",
                "Ankara"
            };

            var citiesList = cities.Distinct();

            foreach(var city in citiesList)
            {
                Console.WriteLine(city);
            }

        }
    }
}
