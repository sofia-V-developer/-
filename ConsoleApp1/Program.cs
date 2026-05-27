using System;
using System.Linq.Expressions; // Бесполезны

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 54, 12};

            foreach (int item in arr)
            {
                System.Console.WriteLine(item);
            }
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("NEW");
            }
            

        }  
    }    
}
