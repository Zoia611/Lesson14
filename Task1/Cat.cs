using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Cat : Animal
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
        public Cat(string name)
            : base(name)
        {
            Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }

    }

}
