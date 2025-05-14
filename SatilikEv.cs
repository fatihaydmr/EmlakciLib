using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakci.Lib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {
        }



        public SatilikEv(double satisfiyat, int odasayisi, int katno, double alan, string semt = "Kızılay") : base(odasayisi, katno, alan, semt)
        {
            Satisfiyat = satisfiyat;
        }
        // içeriye tek tek base.odasayisi vs yazmamıza gerek kalmadı

        public double Satisfiyat { get; set; }


    }
}
