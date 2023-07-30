using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfaces_EX2
{
    internal class Gato:IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("miauuu miau miauu");
        }
    }
}
