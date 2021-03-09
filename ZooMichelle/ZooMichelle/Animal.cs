using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWk3MH
{
     class Animal
    {
        private String name;

        public Animal(string name)
        {
            this.name = name;
        }

      

        public virtual void GetSound()
        {
            Console.WriteLine("Sound");
        }
    
    }
}