using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWk3MH
{
    class Lion : Animal
    {
        public Lion(string name) : base(name)
        {
        }

        public override void GetSound()
        {
            Console.WriteLine("Roar");
        }
    }
}
