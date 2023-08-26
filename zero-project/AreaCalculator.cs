using System;
using System.Globalization;

namespace zero_project
{
    public class AreaCalculator
    {
        public static void AreaCalculatorFunc()
        {
            Console.WriteLine("What units do you want to calculate in?\n" +
                "1) Meters\n" +
                "2) Centimeters");

            int unitsType = Convert.ToInt32(Console.ReadLine());

            string unit = ""; 

            Console.WriteLine("Is the room simple or complex form?\n" +
                "1) Simple \n" +
                "2) Complex ");

            int roomType = Convert.ToInt32(Console.ReadLine());

            switch (roomType)
            {
                case 1:
                    if (unitsType == 1) unit = "meters";
                    else if (unitsType == 2) unit = "centimeters";

                    Console.WriteLine($"Enter the length of the room in {unit}");
                    float lengthRoom = float.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture.NumberFormat);

                    Console.WriteLine($"Enter the width of the room in {unit}");
                    float widthRoom = float.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture.NumberFormat);

                    break;

            }
        }
    }
}
