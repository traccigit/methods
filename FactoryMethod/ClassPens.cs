using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ClassPens : Product
    {
        public override string GetType() { return "Ручки"; }
    }
}
