using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWk3MH
{
    class Tiger : Animal
    {
       
        public Tiger(string name) : base(name)
        {
        }

        public override void GetSound()
        {
            Console.WriteLine("Snarl");
            
        }
    }
}
