using Proba3.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba3.classes
{
    internal class Waluta2 :Interfaces2
    {
        private string waluta_2 = "";

        public string Waluta_2
        {
            get { return waluta_2; }
            set { waluta_2 = value; }
        }
        public Waluta2()
        {

        }
        public Waluta2(string _waluta2)
        {
            Waluta_2 = _waluta2;
        }
        ~Waluta2(){}

        public virtual string info()
        {
            return Waluta_2;
        }
    }
}
