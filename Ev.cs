using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Emlakci.Lib
{
    public class Ev
    {
        private static int sayac = 0; // static değişkenimiz Ev classına ait. Nesnelere değil. Ev. ... yazarak çağırabiliriz.

        public static int Sayac { get => sayac;}

        public Ev()
        {
            this.Semt = "Kızılay";
            sayac++;
        }
        public Ev(int odasayisi,int katno, string semt, double alan) //Constructor
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            sayac++;
        }

        public Ev(int odasayisi, int katno, double alan) //semt girmezse kızılay atanacak
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Kızılay";
            this.Alan = alan;
            sayac++;
        }

        public Ev(int odasayisi, int katno, double alan, string semt="Kızılay") //opsiyonel parametre kullanımı(değer girmezse otomatik kızılay atanır)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            sayac++;
        }

        private int odasayisi; //field(tr: alan)
        private int katno;
        private string semt;
        private double alan;
        //private string buyukluk;

        public string Buyukluk { get; private set; }
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); } //Property
        public int Katno { get => katno; set => katno = value; }
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        //public double Alan { get => alan; set => alan = Math.Abs(value); }



        


        public double Alan
        {
            get {  return alan; }
            set 
            {
                if (value<50)
                {
                    throw new Exception("MİNİMUM ALAN DEĞERİ 50 OLAMALIDIR");
                }
                alan = value;

                if (value>=50 && value<75)
                {
                    this.Buyukluk = "küçük ev";
                }
                else if (value>=75 && value<120)
                {
                    this.Buyukluk = "orta büyüklükte ev";
                }
                else if (value >= 120)
                {
                    this.Buyukluk = "büyük ev";
                }
                else
                {
                    this.Buyukluk = "ev büyüklüğü hesaplanamadı";
                }

            }
        }

        



        // full property özrenği
        //private int myVar;

        //public int MyProperty
        //{
        //    get 
        //    {
        //        //burada başka işlemler yapılabilir
        //        return myVar;
        //    }
        //    set 
        //    {
        //        myVar = value;
        //        //burada başka işlemler yapılabilir
        //    }
        //}



        public string EvBilgileri()
        {
            return $"Alan:{this.Alan}\nSemt:{this.Semt}\nKat no:{this.Katno}\nOda sayısı:{this.Odasayisi}\nEv büyüklüğü:{this.Buyukluk}"; // this.alan yerine sadece alan da yazılabilir.

        }

        
        
    }
}

/*
 
Constructor(tr: yapıcı/kurucu metod)
Görevi:Bir classtan nesne türetilirken çalışır ve class içindeki fieldlara varsayılan değer atamalarını yapar.Her classta mutlaka vardır.
Varsayılan olarak parametre almazlar. Bu constructorlara "default constructor" denir. İsimleri class adı ile aynıdır, farklı isimle
tanımlanamazlar. Geri dönüş tipleri yoktur. Classlardan nesne türetildiğinde çalışan ilk metoddur. 

->ctor code snippeti ile default constructor oluşturulabilir.

static: Bir class içinde static olarak tanımlanan üyelere class ismi ile erişilir(bu örnekte class ismi Ev) ve bu üyeler 
program çalıştığı sürece bellekte tutulurlar. Nesnelerden bağımsız, class'a ait yapılar 

Encapsulation(kapsülleme) İlkesi: Class içerisinde yapılan işlerin class dışından gizlenmesidir. Örneğin odasayisi fieldına değer atama
işlemi yapmak için öncelikle field private yapıldı, sonrasında bu field'a erişebilen public SetOdasayisi metodu yazıldı. Bu metod içinde 
gelen değerin mutlak değeri alınarak odasayisi fieldına atıldı ve bu işlemden bu metodu kullananların bilgisi olmadı.

Auto-Property: Get ve Set bloklarında işlme yapılmayacağı zaman kullanılır   Örnek -> public int MyProperty { get; set; }

*** return'ün altına kod yazılmaz

*/
