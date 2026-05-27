using System;
using System.Linq.Expressions; // Бесполезны

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kar = {1, 54, 12, 6};

            foreach (int item in kar)
            {
                System.Console.WriteLine(item);
            }
        }  
    }    
}
