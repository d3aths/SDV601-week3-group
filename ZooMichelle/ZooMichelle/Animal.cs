using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWk3MH
{
    abstract class Animal
    {
        private String name;

        public Animal()
        {
            
        }

        public virtual string Name 
        { 
            get => name; 
            set => name = value; 
        }

        public virtual string GetSound()
        {
            return "Sound";
        }
    
    }
}