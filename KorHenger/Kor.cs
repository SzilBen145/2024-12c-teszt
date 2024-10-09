using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHenger
{
    class Kor
    {
        private double sugar, kerület, terület;

        public Kor()
        {

        }

        public Kor(double r)
        {
            setDatas(r);
        }

        private double kalkKerület(double r)
        {
            return 2 * r * Math.PI;
        }

        private double kalkTerület(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
        
        public double GetSugár()
        {
            return this.sugar;
        }

        public double GetKerület()
        {
            return this.kerület;
        }

        public double GetTerület()
        {
            return this.terület;
        }

        public void SetSugar(double r)
        {
            setDatas(r);
        }

        private void setDatas(double r)
        {
            this.sugar = r;

            this.kerület = kalkKerület(r);

            this.terület = kalkTerület(r);
        }



    }
}
