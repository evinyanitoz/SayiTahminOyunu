namespace SayiTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SAYI TAHMİN OYUNU
            //KULLANIICDAN RASTGEŞE 0-100 ARASINDA BİR SAYIYI HAFIZADA TUTACAK ,KULLANICIDAN SAYIYI
            //TAHMİN ETMESİ İSTENECEK

            //KULLANICIN GİRDİĞİ SAYI TUTULAN SAYIDAN BÜYÜKSE AŞAĞI DİYECEK ,KÜÇÜKSE YUKARI DİYECEK
            //SAYI TAHMİN EDİLİNCEDE KÇ KEREDE DOĞRU TAHMİN ETMİŞ ONU YAZACAK


            Random rd=new Random();
          
            int uretilensayi=Convert.ToInt32(rd.Next(0,100));
            int sayac = 0;



            do
            { 

                Console.WriteLine("Sayıyı tahmin ediniz");
            int tutulansayi= Convert.ToInt32(Console.ReadLine());
                if (tutulansayi == uretilensayi)
                {

                    Console.WriteLine($"{sayac} denemede bildiniz");
                    break;
                
                }
                if (tutulansayi < uretilensayi)
                {

                    Console.WriteLine("YUKARI");
                   

                }

                else if (tutulansayi > uretilensayi)


                {
                    Console.WriteLine("AŞAĞI");
                }

                sayac++;
                
            } while (true);
         

            //kullanıcının girdiği sayıları diziye at ve diziyi büyükten küçüğe doğru sıralamak.



        }
    }
}
