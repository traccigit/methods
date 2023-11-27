using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PenMaker : Maker
    {
        public override Product FactotyMethod()
        {
            return new ClassPens();
        }
    }
}
