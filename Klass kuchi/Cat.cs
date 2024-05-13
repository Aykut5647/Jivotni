using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_kuchi
{
    internal class Cat
    {
        static int catCount;

        private string name;
        private int age;
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
            catCount += 2;
        }
        public void Meow()
        {
            Console.WriteLine("meow-meow");
        }

        internal void PrintInfo()
        {
            Console.Write("Cat's name: " + this.name + "; age:" + this.age + "; Obajda se sas: ");
            this.Meow();
        }
    }
}
