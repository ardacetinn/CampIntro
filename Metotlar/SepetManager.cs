using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Congratulations! Add to Basket : " + product.Name);
        }

    }
}
