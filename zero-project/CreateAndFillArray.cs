using System;
namespace zero_project
{
    public class CreateAndFillArray
    {
        public static void Program()
        {
            int count;

            Console.WriteLine("Enter array size: ");
            count = Convert.ToInt32(Console.ReadLine());

            string[] newArray = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please enter element of array");
                string arrayElement = Console.ReadLine();
                newArray[i] = arrayElement;
            }

            foreach (string element in newArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}