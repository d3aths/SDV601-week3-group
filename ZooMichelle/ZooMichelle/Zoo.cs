using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWk3MH
{
    class Zoo
    {

        
       
        static void Main(string[] args)
        {
            Tiger paprika = new Tiger("Paprika");
            Lion cleopatra = new Lion("Cleopatra");
            Mouse hercules = new Mouse("Hercules");

            paprika.GetSound();
            cleopatra.GetSound();
            hercules.GetSound();

            Console.ReadLine();
        }
        
    }
}
