using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POchTA
{
    class OBtovar : pak
    {
        public double cf, co, cvaga,Ctype,costT;

        public string name1 { get; set; }
        public string name2 { get; set; }
        public double vag { get; set; }
        public double ob { get; set; }
        public double h { get; set; }
        public double l { get; set; }
        public double w { get; set; }
        public double rang { get; set; }
        public int i { get; set; }
        public int a { get; set; }
        public bool b { get ; set; }

        public OBtovar(string n_, string b_, double vag_, double rang_, double h_, double w_, double l_, int i_, int a_, bool b__)
        {
            name1 = n_;
            name2 = b_;
            vag = vag_;
            h = h_;
            w = w_;
            l = l_;
            rang = rang_;
            i = i_;
            a = a_;
            b = b__;
        }

        double v() {
            return (h * w * l);
        }
        public double Cost(double c, double cvag, double f, double pc)
        {
            return co + cvaga + cf + co;
        }

        public double costOB(double obb)
        {
            
            if (v()<40) { co = 10; } else { co = co * 1.5; }
           return co;
        }

        public double costTyPac(int aa)
        {
            if (a == 1) { Ctype = 0; } else { Ctype = v() * 1.3; }
            return Ctype;
        }

        public double costTyT(bool bb)
        {
            if (b) { costT = 0; } else {costT=v()*1.2; }
            return costT;
        }

        public double costVag(double va)
        {
            if (vag <= 5) { cvaga = 0; }
            else 
            {
                cvaga = vag * 1.2;
            }
                return cvaga;
        }
        public double Cost()
        {
            return CostFuil(rang, i) + costVag(vag) + costTyT(b) + costTyPac(a) + costOB(v());
        }
        public double CostFuil(double ran, int ii)
        {
            if (i == 1) { cf = ((rang / 100) * 11) * 24; } else { cf = ((rang / 100) * 7) * 30; }
            return cf ;

        }
    }
}
