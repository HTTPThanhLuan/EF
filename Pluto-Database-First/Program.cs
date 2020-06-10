using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto_Database_First
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new plutoContext();
            var courses = context.GetCourses();
            foreach (var item in courses)
            {
                Console.WriteLine(item.Title);
            }

            Console.ReadKey();
        }
    }
}
