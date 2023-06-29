using Proba3.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba3.classes
{
    internal class Waluta1 : Change,Interfaces2
    {
        private string waluta_1 = "";

        public string Waluta_1
        {
            get { return waluta_1; }
            set { waluta_1 = value; }
        }
        public Waluta1()
        {
        }
        public Waluta1(string _waluta1)
        {
           Waluta_1 = _waluta1;
        }
        ~Waluta1() { }

        public virtual string info()
        {
            return Waluta_1;  
        }
    }
}
