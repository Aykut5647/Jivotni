using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_kuchi
{
    internal class Bird
    {
        static int birdCount;

        private string name;
        private int age;
        public Bird(string name, int age)
        {
            this.name = name;
            this.age = age;
            birdCount += 1;
        }
        public void Chick()
        {
            Console.WriteLine("chick-chick");
        }

        internal void PrintInfo()
        {
            Console.Write("Bird's name: " + this.name + "; age:" + this.age + "; Obajda se sas: ");
            this.Chick();
        }
    }
}
