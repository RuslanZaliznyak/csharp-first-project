using System;
using System.Globalization;

namespace zero_project
{
    public class MainFile
    {
        struct City
        {
            private string number;
            private string name;

            public City(string Number, string Name)
            {
                number = Number;
                name = Name;
            }

            public string Get_Number() { return number; }
            public string Get_Name() { return name; }

            public void Set_Number(string Number) { number = Number; }
            public void Set_Name(string Name) { name = Name; }
        }

        public static void Main()
        {
            City[] cityList = new City[10];

            for (int i = 0; i<2; i++)
            {
                Console.WriteLine("Please write city name");
                string cityName = Console.ReadLine();

                cityList[i] = new City(Convert.ToString(i), cityName);
            }

            foreach (City city in cityList)
            {
                Console.WriteLine(city.Get_Name());
            }
        }

    }
}