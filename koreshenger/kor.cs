using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreshenger
{
    class Kör
    {
        private double sugar,
                       Terulet,
            Kerulet;

        public Kör() { }
        
        public Kör(double r)
        {
            sugar = r;
        }

        

        public void SetSugar(double r)
        {
            this.sugar = r;
        }

        public void SetTerulet()
        {
            this.Terulet =  Math.Round(Math.Pow(this.sugar,) * Math.PI, 2;
        }
        public void SetKerulet()
        {
            this.Kerulet = Math.Round(2* this.sugar * Math.PI,2);
        }

        public double GetKerulet()
        {
            return this.Kerulet;
        }


        public double GetSugar()
        {
            return this.sugar;
        }
        public double GetTerulet()
        {
            return this.Terulet;
        }
    }

}
