using Emlakci.Lib;
using System.Reflection.Emit;

namespace Gazi.Emlakci
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //var evim6 = new Ev { alan = 130, katno = 2, odasayisi = 3, semt = "yenimahalle" }; //tek satırda değer atama örneği
            
            //Ev evim = new Ev();
            //evim.alan = 100;
            //evim.semt = "Sincan";
            //evim.katno = 2;
            //evim.odasayisi = 3;

            //Console.WriteLine(evim.EvBilgileri());

            //Ev evim2 = new Ev();
            //evim2.alan = 120;
            //evim2.semt = "Gazi";
            //evim2.katno = 4;
            //evim2.odasayisi = 4;

            //Console.WriteLine(evim2.EvBilgileri());

            //var evim3 = new Ev(2,4,130);
            //Console.WriteLine(evim3.EvBilgileri());

            //var evim4=new Ev(2,1,125,"Etimesgut");
            //Console.WriteLine(evim4.EvBilgileri());

            //Console.WriteLine("bellekteki ev sayısı:"+Ev.sayac);

            /*
            Ev kul_ev1 = new Ev();

            Console.Write("evinizin oda sayısını girin:");
            kul_ev1.Odasayisi=(Convert.ToInt32(Console.ReadLine()));

            Console.Write("evinizin kat numarasını girin:");
            kul_ev1.Katno=(Convert.ToInt32(Console.ReadLine()));

            Console.Write("evinizin semtini yazın:");
            kul_ev1.Semt=(Console.ReadLine());

            try
            {
                Console.Write("evinizin alanını girin:");
                kul_ev1.Alan = (Convert.ToInt32(Console.ReadLine()));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine(kul_ev1.Buyukluk);
            */

            /*
            Ev evim=new Ev();

            evim.Alan = 130;
            evim.Katno = 2;
            evim.Semt = "kazan";
            evim.Odasayisi = 4;

            Console.WriteLine(evim.EvBilgileri());
            */
            
            

            

            Console.ReadLine();
        }

       
    }

    

    class Bilgisayar 
    {
        public string model;
        public  string gpu;
        public string cpu;
        public int ram;
        public int depolama;
        public int ekranhz;
        public int fiyat;
       
    }
}

/*
Ev evim = new Ev(); //Ev classından nesne türetildi.
evim => Referans(Referanslar nesnelerin bellekteki adresini tutarlar.Belleğin STACK bölgesinde tutulurlar)
Ev => Class(Classlar aynı zamanda bir veri tipidir)
new: Bellekte nesne oluşturmaya yarayan anahtar sözcük
nesne: new anahtar sözcüğü ile HEAP bölgesinde oluşturulurlar

Erişim Belirleyiciler(Access Modifiers)
private: Sadece class içinden erişilebilir üyelerdir
public: Class içinde tanımlanan üyeye her yerden erişim imkanı sağlar

*/



