using System;
using System.Linq.Expressions; // Бесполезны

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 54, 12, 6};

            foreach (int item in arr)
            {
                System.Console.WriteLine(item);
            }
        }  
    }    
}
