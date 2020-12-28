using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet2._26
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius = 4.5F;
            double circumfence;
            circumfence = 2 * 3.14 * radius;
            object boxed = (object)circumfence;
            Console.WriteLine("Circumfence of the circle ={0}", circumfence);
            Console.ReadKey();
        }
    }
}
