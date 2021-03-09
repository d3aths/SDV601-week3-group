using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWk3MH
{
    class Mouse : Animal
    {
        public Mouse(string name) : base(name)
        {
        }

        public override void GetSound()
        {
            Console.Write("Squeak");
        }
    }
}
