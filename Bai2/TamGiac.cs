using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class TamGiac
    {
        private double canhA, canhB, canhC;

        public double CanhA
        {
            get { return canhA; }
            set
            {
                if (canhA > 0)
                    canhA = value;
                else canhA = 0;
            }
        }

        public double CanhB
        {
            get { return canhB; }
            set
            {
                if (canhB > 0)
                    canhB = value;
                else canhB = 0;
            }
        }

        public double CanhC
        {
            get { return canhC; }
            set
            {
                if (canhC > 0)
                    canhC = value;
                else canhC = 0;
            }
        }
        public TamGiac()
        {
            CanhA = 3;
            CanhB = 4;
            CanhC = 5;
        }
        public TamGiac(double CA, double CB, double CC)
        {
            if(CA + CB > CC || CA + CC > CB || CB + CC > CA)
            this.CanhA = CA;
            this.CanhB = CB;
            this.CanhC = CC;
        }
        public double tinhCV()
        {
           double P =((CanhA + CanhB + CanhC) / 2);
           return P;
        }
        public double tinhDT()
        {
            return Math.Sqrt(tinhCV()* (tinhCV() - CanhA) * (tinhCV() - CanhB) * (tinhCV() - CanhC));
        }

    }
}
