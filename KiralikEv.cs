using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakci.Lib
{
    public class KiralikEv : Ev
    {

        public KiralikEv() 
        {
        }

        public KiralikEv(int odasayisi, int katno, double alan, double kira, double depozito, string semt = "Kızılay") //opsiyonel parametre kullanımı(değer girmezse otomatik kızılay atanır)
        {
            base.Odasayisi = odasayisi;
            base.Katno = katno;
            base.Alan = alan;
            base.Semt = semt;
            this.Kira = kira;
            this.Depozito = depozito;
            
        }

        public double Kira { get; set; }

        public double Depozito { get; set; }

    }
}

/*
internal: Yalnızca aynı namespace içindeki classlar tarafından erişilebilir.(access modifiers)
her class ın yalnızca bir tane base classı olabilir

*/