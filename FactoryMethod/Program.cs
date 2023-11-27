using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //массив производителей
            Maker[] makers = {new  PenMaker(), new PencilMaker()};

            //
            foreach (var maker in makers)
            {
                Product product = maker.FactotyMethod();
                Console.WriteLine("Создан {0}", product.GetType());
            }

            Console.ReadLine();
        }
    }
}
