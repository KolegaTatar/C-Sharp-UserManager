using Proba3.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba3.classes
{
    internal abstract class Change:Interfaces1
    {
        private float kwota = 0.0f;

        public float Kwota
        {
            set { kwota = value; }
            get { return kwota; }
        }
        public List<float> kursy = new List<float>()
        {
            0.92F,  //DolarEuro
            4.20F,  //DolarPLN
            4.54F,  //EuroPLN
            1.08F,  //EuroDolar
            0.22F,  //PLNDolar
            0.24F   //PLNEuro
        };
        public enum Waluta
        {
            Euro,
            Dolar,
            PLN
        }
        Waluta waluta = new Waluta(); 

        ~Change() { }
        public float info_c()
        {
            return Kwota;
        }
    }
}
