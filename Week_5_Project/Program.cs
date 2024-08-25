using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using Week_5_Project;
namespace Weak_5_Project
{
    class Program
    {
        /*
            1- Konsol ekranından kullanıcıya araba üretmek isteyip istemediğini soralım. Üretmek istiyorsa e, istemiyorsa h harfi ile yanıt versin. 
            Büyük - Küçük harf duyarlılığını ortadan kaldıralım. Geçersiz bir cevap verirse, bu cevabın geçersiz olduğunu söyleyerek aynı soruyu tekrar yöneltelim.
            2- Kullanıcının cevabı hayır programı sonlandıralım, evet ise bir araba nesnesi üretip özelliklerini konsol ekranından kullanıcıya girdirelim.
            3- Üretim Tarihi değeri araba üretilirken otomatik olarak o an olarak atanacak.
            4- Kapı Sayısı için sayısal olmayan bir değer atanılmaya çalışılırsa programın exception fırlatmasını engelleyelim, uyarı mesajı verelim ve 
            kullanıcıyı yeniden o satıra yönlendirelim. (goto komutunu araştırınız.)
            5- Oluşturulan araba nesnesini arabalar isimli bir listeye atayınız.
            6- Kullanıcıya başka araba oluşturmak isteyip istemediğini sorunuz, evet ise program akışında 2. aşamaya geri dönünüz ve yeni bir araba üretip 
            listeye ekleyiniz. Cevap hayır ise arabalar listesinin bütün elemanlarının Seri numaralarını ve markalarını yazdırınız
         */

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            List<Car> cars = new List<Car>(); // Araba nesnelerinin yer aldığı liste
            Console.WriteLine("Araba üretmek istiyormusunuz? Üretmek istiyorsanız 'e' istemiyorsanız 'h' basın");
            
            bool isValid = true;
            
            while (isValid) // Program aksi belirtilmediği sürece başa dönecek
            {
                string input = Console.ReadLine().ToLower(); // Büyük küçük harf uyumsuzluğu giderildi
                
                if (input == "e") // Yeni nesne için bilgiler alınır. 
                {
                    Console.WriteLine("Araç bilgilerini giriniz.");
                    newCar:
                    Car car = new Car(); // Car sınıfından bir nesne üretilir            

                    Console.Write("Seri Numarasını giriniz : ");
                    car.SerialNumber = Console.ReadLine() ?? ""; // SerialNumber Property için değer alır

                    Console.Write("Marka giriniz : ");
                    car.Brand = Console.ReadLine() ?? ""; // Brand Property için değer alır

                    Console.Write("Model giriniz : ");
                    car.Model = Console.ReadLine() ?? ""; // Model Property için değer alır

                    Console.Write("Renk giriniz : ");
                    car.Color = Console.ReadLine() ?? ""; // Color Property için değer alır

                    Console.Write("Kapı Sayısını giriniz : ");
                    Car:
                    try // try - catch ile kapı sayısı için int alana kadar goto ile başa döner.
                    {
                        car.DoorCount = Convert.ToInt32(Console.ReadLine());

                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine("Lütfen sayısal değer girin");
                        goto Car;
                    }


                    cars.Add(car);

                    Console.WriteLine("Başka araç üretmek istiyormusunuz ? Evet için 'e' Araç Listesini görmek ve programdan çıkmak için 'h' basın");
                    
                    // Kullıcı yeni nesne üretip üretmeyeceğine karar vermesi beklenir. 

                    input:
                    input = Console.ReadLine() ?? "";

                    
                    if (input.ToLower() == "e") // Yeni nesne için goto ile başa döner.
                    {
                        
                        Console.WriteLine("Yeni araç bilgilerini giriniz.");
                        goto newCar;
                    }
                    else if (input == "h") // Hayır yanıtını verirse oluşturulan car nesneleri teker teker ekrana yazdırılır.
                    {
                        foreach (var item in cars)
                        {
                            //Console.WriteLine($"\nAracın bilgileri : \nÜretim Tarihi : {item.ProduceDate}\nSeri Numarası : {item.SerialNumber}\nMarkası : {item.Brand}\nModeli : {item.Model}\nRengi : {item.Color}\nKapı Sayısı : {item.DoorCount}");
                            car.InfoCar(item.ProduceDate,item.SerialNumber,item.Brand,item.Model,item.Color,item.DoorCount);
                            
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş yaptınız tekrar deneyin...");
                        Console.WriteLine("Evet için 'e' Araç Listesini görmek ve programdan çıkmak için 'h' basın");
                        goto input; // input alınacağı yere geri döner
                    }

                     
                }
                else if (input.ToLower() == "h") // Hayır cevabı sonrası program sonlandırma 
                {
                    Console.WriteLine("Daha sonra üretirsiniz artık...");
                    isValid = false;
                }
                else // Kullanıcı yanlış giriş yaparsa hata mesajı verilir.
                {
                    Console.WriteLine("Geçersiz giriş yaptınız tekrar deneyin...");
                    Console.WriteLine("Üretmek istiyorsanız 'e' istemiyorsanız 'h' basın");
                }
                

            }

            
        }
        
    }
}
