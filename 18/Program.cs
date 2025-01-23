using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //создание экземпляра класса Address
            Address address = new Address{ Index = "100000",Country = "ПМР",City = "Тирасполь",Street = "Магистральная",House = "12",Apartment = "413"};

            //вывод значений полей на экран
            Console.WriteLine($"Почтовый адрес:\n" +
                $"Индекс: {address.Index}\n" +
                $"Страна: {address.Country}\n" +
                $"Город: {address.City}\n" +
                $"Улица: {address.Street}\n" +
                $"Дом: {address.House}\n" +
                $"Квартира: {address.Apartment}");
        }
    }
}
