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

            String output = $"{paprika.Name} the {paprika.GetType().Name.ToLower()} can {paprika.GetSound().ToLower()}";
            String output2 = $"{cleopatra.Name} the {cleopatra.GetType().Name.ToLower()} can {cleopatra.GetSound().ToLower()}";
            String output3 = $"{hercules.Name} the {hercules.GetType().Name.ToLower()} can {hercules.GetSound().ToLower()}";


            Console.WriteLine(output + "\n" + output2 + "\n" + output3);
            Console.ReadKey();
        }

        
    }
}
