using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MustafaAliKaganKucukOdev1
{
    class Program
    {

        
        static void Main(string[] args)
        {
           //Öncellikle bir TC numarası girdiyoruz.
            Console.WriteLine("T.C. giriniz");
            string TC = Console.ReadLine();
            //Kayıtlı olarak verdiğimiz bir giriş bulunmakta.
            string[,] arr = new string[5, 3];
            string user = " ";
            arr[0, 0] = "123456";
            arr[0, 1] = "kagan ";
            arr[0, 2] = "kucuk";
            //Bu kısımda telefonların tutulduğu bir dizi bulunuyor.
            string[] Phones = new string[5];
            Phones[0] = "Reeder P13 Blue Max 2021 128 GB 4 GB Ram";
            Phones[1] = "Samsung Galaxy M12 128 GB ";
            Phones[2] = "Oppo Reno 5 Lite 128 GB ";
            Phones[3] = "iPhone 12 64GB ";
            Phones[4] = "iPhone X 64 GB ";
            //Telefonların ücretlerini tuttuğumuz kısım.
            int Cost0 = 2440;
            int Cost1 = 3449;
            int Cost2 = 5129;
            int Cost3 = 17699;
            int Cost4= 20580;
            ArrayList hamper = new ArrayList();
            bool OrderContinue = true;
            // eğer kayıtlı girişi yapıcaksak bu kısımdan tc değerlerinin eşit olmasını bekliyoruz.
            for (int i = 0; i < 5; i++)
            {
                string a = arr[i, 0];
                if (a == TC)
                {
                    Console.WriteLine("İsim :" + arr[i, 1]);
                    user = arr[i, 1];
                    break;
                }
                else
                {
                    //yeni kayıt kısmımız.
                    Console.WriteLine("Yeni Kayıt oluşturmak için bir TC numarası vermelisiniz.");
                    string NewTC = Console.ReadLine();
                    Console.WriteLine("adınızı giriniz");
                    string NewName = Console.ReadLine();
                    Console.WriteLine("soyadınızı giriniz");
                    string NewSurName = Console.ReadLine();
                    arr[i, 0] = NewTC;
                    arr[i, 1] = NewName;
                    arr[i, 2] = NewSurName;
                    user = arr[i, 1];
                    break;
                }

            }
            Console.WriteLine("------" + user + "  " + "hoşgeldin" + "-------");

            for (int i = 0; i < Phones.Length; i++)
            {
                Console.WriteLine(i + "-" + Phones[i]);

            }

            while (OrderContinue)
            {
                Console.WriteLine("almak istediğiniz ürünün numarasını giriniz");
                int product = Convert.ToInt32(Console.ReadLine());
                if (product < Phones.Length)
                {
                    Console.WriteLine(" Seçtiğiniz Ürün Numarası "+product);

                }
                else
                {
                    Console.WriteLine("Yanlış ürün numarası girdiniz!");
                    break;
                }
              
                Console.WriteLine("kaç adet almak istiyorsunuz?");
                int Numbers = Convert.ToInt32(Console.ReadLine());
                int sum;
                if (product==0)
                {
                     sum = Numbers * Cost0;
                    Console.WriteLine(Numbers+ " adetin toplam tutarı : " + sum);
                }
                else if (product == 1)
                {
                    sum = Numbers * Cost1;
                    Console.WriteLine(Numbers + " adetin toplam tutarı: " + sum);
                }
                else if (product == 2)
                {
                     sum = Numbers * Cost2;
                    Console.WriteLine(Numbers + " adetin toplam tutarı : " + sum);
                }
                else if (product == 3)
                {
                     sum = Numbers * Cost3;
                    Console.WriteLine(Numbers + " adetin toplam tutarı : " + sum);
                }
                else if (product == 4)
                {
                     sum = Numbers * Cost4;
                    Console.WriteLine(Numbers + " adetin toplam tutarı : " + sum);
                }

               
                if (product <= Phones.Length)
                {
                    hamper.Add(Phones[product]);
                }
               
                Console.WriteLine(Numbers + " adet " + hamper[0]);
                Console.WriteLine("alışverişe devam etmek isterseniz herhangi bir tuşa basınız, çıkmak isterseniz'h'tuşuna basınız.");
                //Alışverişi sonlandırmak istersek bu kısımdan h harfine basarak sonlandırıyoruz.
                string Contiune = Console.ReadLine();
                if (Contiune.Equals("h"))
                {
                    OrderContinue = false;
                    Console.WriteLine("-------" + user + "'nın Sepeti----");
                    for (int i = 0; i < hamper.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " - "+Numbers+" adet "+ hamper[i]);
                    }
                }
               
            }
            
            Console.ReadKey();

        }
    }
}
