using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon
{
    class Program
    {
        public static int sayac = 0;
        public static double[] ogrencino = new Double[10];
        public static string[] ogrenciadsoyad = new string[10];
        public static Double[] vizenot = new double[10];
        public static Double[] finalnot = new double[10];
        public static double[] ortalama = new double[10];
        static void Main(string[] args)
        {
            menuislemleri();

        }
        static void menuislemleri()
        {
            Console.Clear();
            Console.Write("***1)KAYIT EKLEME***\n***2)KAYIT DÜZELTME***\n***3)KAYIT SİLME***\n***4)KAYIT ARAMA***\n***5)KAYIT LİSTELEME***\n***6)ÇIKIŞ***");
            Console.WriteLine("\n SEÇİMİNİZİ YAPINIZ: (1-6) :");
            char anamenusecim = Convert.ToChar(Console.ReadLine());
            if(anamenusecim !='1' && anamenusecim != '2' && anamenusecim != '3' && anamenusecim != '4' && anamenusecim != '5' && anamenusecim != '6')
            {
                Console.WriteLine("!!! HATALI İŞLEM GİRDİNİZ !!!");
                Console.ReadKey();
                menuislemleri();
            }
            switch(anamenusecim)
            {
                case '1':
                    kayitekle();
                    break;
                case '2':
                    kayitduzeltme();
                    break;
                case '3':
                    kayitsilme();
                    break;
                case '4':
                    kayitarama();
                    break;
                case '5':
                    kayitlisteleme();
                    break;
                case '6':
                    Environment.Exit(0);
                    break;
            }
        }
        static void kayitekle()
        {
            Console.Clear();
            Console.WriteLine("*** YENİ ÖĞRENCİ KAYIT İŞLEMLERİ ***");
            Console.Write("ÖĞRENCİ NO :");
            ogrencino[sayac] =Convert.ToDouble(Console.ReadLine());
             
            if (ogrencino[sayac] > 0 && ogrencino[sayac] < 1000 )
            {
            }
            else
            {
                Console.WriteLine("LÜTFEN BELİRTİLEN DEĞERLER ARASI BİR ÖĞRENCİ NUMARASI GİRİNİZ");
                Console.WriteLine("(0-1000)");
                Console.ReadKey();
                kayitekle();

            }
            Console.Write("ÖĞRENCİ ADI SOYADI :");
            ogrenciadsoyad[sayac] = Console.ReadLine();
            /*
            if ()
            {
            !!!EKRANA SADECE YAZI YAZDIRMA ŞEKLİNDE İLERLEME DİĞER TÜRLÜ OLDUĞUNDA "YANLIŞ KAREKTER KULLANDINIZ" HATASI VERME VAHDET HOCAYA SOR!!!
            }
            */
            Console.Write("ÖĞRENCİ VİZE NOTU :");
            if (vizenot[sayac] < 0 && 100 < vizenot[sayac])
            {
                Console.WriteLine("!!! HATALI PUANLAMA GİRDİNİZ !!!");
                Console.ReadKey();
                kayitekle();
            }
            vizenot[sayac] =Convert.ToDouble(Console.ReadLine());
            Console.Write("ÖĞRENCİ FİNAL NOTU :");
            if (finalnot[sayac] < 0 && 100 < finalnot[sayac])
            {
                Console.WriteLine("!!! HATALI PUANLAMA GİRDİNİZ !!!");
                Console.ReadKey();
                kayitekle();
            }
            finalnot[sayac] = Convert.ToDouble(Console.ReadLine());
            ortalama[sayac] = (finalnot[sayac] * 0.6) + (vizenot[sayac] * 0.4);
            Console.WriteLine("ÖĞRENCİ ORTALAMASI :{0}",ortalama[sayac]);
            sayac++;
            Console.WriteLine("TEKRAR ÖĞRENCİ KAYIT ETMEK İÇİN Y TUŞUNU GİRİNİZ :");
            Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN Y DIŞINDA BİR TUŞA BASINIZ");
            char yenikayit = Convert.ToChar(Console.ReadLine());
            if (yenikayit == 'y' || yenikayit == 'Y')
            
                kayitekle();
            else
                menuislemleri();
        }
        static void kayitduzeltme()
        {
            Console.Clear();
            Console.WriteLine("***KAYIT DÜZELTME İŞLEMLERİ***");
            Console.Write("KAYITINI DÜZELTMEK İSTEDİĞİNİZ ÖĞRENCİ NUMARASSINI GİRİNİZ:");
            String ogrno = Console.ReadLine();
            int index = Array.IndexOf(ogrencino, ogrno);
            if (index>=0)
            {
                Console.WriteLine("ÖĞRENCİ BİLGİLERİ");
                Console.WriteLine("ÖĞRENCİ NO :{0} ADI SOYADI :{1} VİZE NOTU :{2} FİNAL NOTU :{3} ORTALAMA :{4}", ogrencino[index], ogrenciadsoyad[index], vizenot[index], finalnot[index], ortalama[index]);
                Console.Write("ÖĞRENCİ AD SOYADI:");    Console.ReadLine();
                Console.Write("VİZE NOT :");    Convert.ToDouble(Console.ReadLine());
                Console.Write("FİNAL NOT :");   Convert.ToDouble(Console.ReadLine());
                ortalama[index] = (vizenot[index] * 0.4) + (finalnot[index]*0.6);
                Console.WriteLine("ORTALAMA :{0}" , ortalama[index]);
                Console.WriteLine("***TEKRAR KAYIT DÜZELTMEK İSTİYORSANIZ 'Y' TUŞUNA BASINIZ***");
                Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN Y DIŞINDA BİR TUŞA BASINIZ");
                char yeniduzeltme = Convert.ToChar(Console.ReadLine());
                if (yeniduzeltme == 'y' || yeniduzeltme == 'Y')
                {
                    kayitduzeltme();
                }
                else
                {
                    menuislemleri();
                }
            }
            else
            {
                Console.WriteLine("SİSTEMDE KAYITLI ÖĞRENCİ BULUNMAMAKTADIR");
                Console.WriteLine("SİSTEME ÖĞRENCİ KAYIT ETMEK İÇİN Y TUŞUNA BASINIZ");
                char kayitekranigecis = Convert.ToChar(Console.ReadLine());
                if (kayitekranigecis=='y' || kayitekranigecis=='Y')
                {
                    kayitekle();
                }
                else
                {
                    menuislemleri();
                }
            }
        }
        static void kayitsilme()
        {
            Console.Clear();
            Console.WriteLine("*** KAYIT SİLME İŞLEMLERİ ***");
            Console.Write("KAYDINI SİLMEK İSTEDİĞİNİZ ÖĞRENCİNİN NUMARASINI GİRİNİZ :");
            Double ogrno = Convert.ToDouble(Console.ReadLine());
            int index = Array.IndexOf(ogrencino, ogrno);
            if (index>=0)
            {
                Console.WriteLine("ÖĞRENCİ BİLGİLERİ");
                Console.WriteLine("ÖĞRENCİ NO :{0} ADI SOYADI :{1} VİZE NOTU :{2} FİNAL NOTU :{3} ORTALAMA :{4}", ogrencino[index], ogrenciadsoyad[index], vizenot[index], finalnot[index], ortalama[index]);
                Array.Clear(ogrencino,index,1);
                Array.Clear(ogrenciadsoyad ,index,1);
                Array.Clear(vizenot ,index,1);
                Array.Clear(finalnot,index,1);
                Array.Clear(ortalama ,index,1);
                Console.WriteLine("SİLMEK İSTEDİĞİNİZ BAŞKA KAYIT VARSA Y TUŞUNA BASINIZ");
                Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN Y DIŞINDA BİR TUŞA BASINIZ");
                char tekrarsilme = Convert.ToChar(Console.ReadLine());
                if (tekrarsilme =='y' || tekrarsilme == 'Y' )
                {
                    kayitsilme();
                }
                else
                {
                    menuislemleri();
                }
            }




        }
        static void kayitarama()
        {
            Console.Clear();
            Console.WriteLine("***KAYIT ARAMA İŞLEMLERİ***");
            Console.WriteLine("GÖRÜNTÜLEMEK İSTEDİĞİNİZ ÖĞRENCİNİN NUMARASINI GİRİNİZ");
            String ogrno = Convert.ToString(Console.ReadLine());
            int index = Array.IndexOf(ogrencino, ogrno);
            if (index>=0)
            {
                Console.WriteLine("***ÖĞRENCİ BİLGİLERİ***");
                Console.WriteLine("NUMARASI :{0} ADI-SOYADI :{1} VİZE NOTU :{2} FİNAL NOTU :{3} ORTALAMASI :{4} ",ogrencino[index],ogrenciadsoyad[index],vizenot[index],finalnot[index],ortalama[index]);
                Console.WriteLine("GÖRÜNTÜLEMEK İSTEDİĞİNİZ BAŞKA ÖĞRECİ VARSA Y TUŞUNA BASINIZ");
                Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN Y DIŞINDA BİR TUŞA BASINIZ");
                char tekrararama = Convert.ToChar(Console.ReadLine());
                if (tekrararama == 'y' || tekrararama == 'Y')
                {
                    kayitarama();
                }
                else
                {
                    menuislemleri();
                }
            }
            else
            {
                Console.WriteLine("!!!HATALI NUMARA TUŞLADINIZ!!!");
                Console.WriteLine("GERİ DÖNMEK İÇİN Y TUŞUNA BASINIZ");
                Console.WriteLine("ANA MENÜYE DÖNMEK İÇİN Y DIŞINDA BİR TUŞA BASINIZ");
                char yanlısarama = Convert.ToChar(Console.ReadLine());
                if (yanlısarama == 'y' || yanlısarama == 'Y')
                {
                    kayitarama();
                }
                else
                {
                    menuislemleri();
                }

            }
        }
        static void kayitlisteleme()
        {
            Console.Clear();
            bool kayitkontol = false;
            for (int i = 0; i < ogrencino.Length; i++)
            {
                if (ogrencino[i] != null)
                {
                    kayitkontol = true;
                    Console.WriteLine("ÖĞRENCİ NO :{0} İSİM SOYİSİM :{1} VİZE NOTU :{2} FİNAL NOTU :{3} ORTALAMASI :{4}", ogrencino[i], ogrenciadsoyad[i], vizenot[i], finalnot[i], ortalama[i]);

                }
            }
            if (kayitkontol==false)
            {
                Console.WriteLine("OTOMASYONDA KAYITLI ÖĞRENCİ BULUNMAMAKTADIR");

            }
            Console.Write("ANA MENÜYE DÖNMEK İÇİN TUŞLAYINIZ : ");
            Console.ReadKey();
            menuislemleri();
        }

    }

}
