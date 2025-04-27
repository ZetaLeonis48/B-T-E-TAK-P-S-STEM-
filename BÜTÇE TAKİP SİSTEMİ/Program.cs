namespace BÜTÇE_TAKİP_SİSTEMİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aySonuBakiyesi = 0;
        
        ayBilgisi:
            Console.WriteLine("Hangi ay için işlem yapmak istiyorsunuz rakam ile belirtiniz");
            int ayNumarası = Convert.ToInt32(Console.ReadLine());
            if (ayNumarası<1 || ayNumarası > 12)
            {
                Console.WriteLine("Yanlış bir değer girdiniz");
                goto ayBilgisi;
            }
           
            
            string ay = "";
            
            
            if (ayNumarası == 1)
            {
                ay = "Ocak";
            }
            else if (ayNumarası == 2)
            {
                ay = "Şubat";
            }
            else if (ayNumarası == 3)
            {
                ay = "Mart";
            }
            else if (ayNumarası == 4)
            {
                ay = "Nisan";
            }
            else if (ayNumarası == 5)
            {
                ay = "Mayıs";
            }
            else if (ayNumarası == 6)
            {
                ay = "Haziran";
            }
            else if ( ayNumarası == 7)
            {
                ay = "Temmuz";
            }
            else if (ayNumarası == 8)
            {
                ay = "Ağustos";
            }
            else if (ayNumarası == 9)
            {
                ay = "Eylül";
            }
            else if (ayNumarası == 10)
            {
                ay = "Ekim";
            }
            else if (ayNumarası == 11)
            {
                ay = "Kasım";
            }
            else if (ayNumarası == 12)
            {
                ay = "Aralık";
            }

            Console.Clear();

        secimEkrani:
            Console.WriteLine($"{ay} ayı işlemleri.");
            Console.WriteLine("Gelir girmek için 1'i gider girmek için 2'yi bakiyeyi görmek için ise lütfen 3 ü tuşlayın");
            int secim = Convert.ToInt32(Console.ReadLine());
           
        
            if (secim == 1)
            {
                Console.WriteLine($"{ay} ayı gelir işlemleri");
                Console.WriteLine("Lütfen gelirinizi giriniz");
                int gelir = Convert.ToInt32(Console.ReadLine());
                aySonuBakiyesi += gelir;
                Console.Clear();
                goto secimEkrani;
                

            }
            else if (secim == 2)
            {
                Console.WriteLine($"{ay} ayı gider işlemleri");
                Console.WriteLine("Lütfen giderinizi giriniz");
                int gider = Convert.ToInt32(Console.ReadLine());
                aySonuBakiyesi -= gider;
                Console.Clear();
                goto secimEkrani;
                
            }
            else if (secim == 3)
            {
                Console.WriteLine($"{ay} ayı bakiyesi {aySonuBakiyesi} TL'dir. ");
                
                if (aySonuBakiyesi < 0)
                {
                    Console.WriteLine("Bu ay ödemeniz gereken borçlar var");
                    
                    goto secimEkrani;
                    
                }
                
                goto secimEkrani;
                

                
            }
            else if (secim > 3 || secim < 1)
            {
                Console.WriteLine("Geçersiz bir işlem numarası girdiniz lütfen tekrar deneyiniz");
                
                goto secimEkrani;
            }














        }





    }
}
