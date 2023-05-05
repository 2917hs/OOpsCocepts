using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntrviewQA
{
    public class BaseClass
    {
        private void PrivateMethod()
        { }

        public void PublicMethod()
        { }

        //cannot mark virtual so cannot inherit ctor of base class
        public BaseClass()
        {

        }

        public virtual void ChildClass1Method()
        {
            System.Console.WriteLine("from BaseClass");
        }
    }
}