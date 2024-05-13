using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_kuchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog=new Dog("Sharo",1);
            dog.PrintInfo();
            Cat cat = new Cat("Maradini",2);
            cat.PrintInfo();
            Bird bird = new Bird("Pirat",1);
            bird.PrintInfo();
        }
    }
}
