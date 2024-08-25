using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Project
{
    internal class Car
    {
        // Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı

        private DateTime produceDate; // produceDate field
        private string? serialNumber; // serialNumber field (optional)
        private string? brand; // brand field (optional)
        private string? model; // model field (optional)
        private string? color; // color field (optional)
        private int doorCount; // doorCount field 
        public string Brand // Brand property
        {
            get
            {
                return brand!;
            }
            set
            {
                brand = value;
            }
        }

        public string SerialNumber // Brand property
        {
            get
            {
                return serialNumber!;
            }
            set
            {
                serialNumber = value;
            }
        }
        public string Model // Brand property
        {
            get
            {
                return model!;
            }

            set
            {
                model = value;
            }

        }
        public string Color // Brand property
        {
            get
            {
                return color!;
            }
            set
            {
                color = value;
            }
        }

        public int DoorCount // Brand property
        {
            get
            {
                return doorCount;
            }
            set
            {
                doorCount = value;
            }
        }

        public DateTime ProduceDate // Brand property
        {
            get
            {
                return produceDate;
            }
            

        }

        public Car() // Default Constructor
        {
            produceDate = DateTime.Now; // Nesne üretildiği zaman Üretim tarihi belirlenir.

        }

        public void InfoCar(DateTime date,string serial, string bra, string mod, string col, int door) // Nesneyi konsol ekranına yazdırmak için metot
        {
            Console.WriteLine($"\nAracın bilgileri : \nÜretim Tarihi : {date}\nSeri Numarası : {serial}\nMarkası : {bra}\nModeli : {mod}\nRengi : {col}\nKapı Sayısı : {door}");
        }
    }
}
