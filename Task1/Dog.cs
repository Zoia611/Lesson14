using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Dog(string name)
            : base(name)
        {
            Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
