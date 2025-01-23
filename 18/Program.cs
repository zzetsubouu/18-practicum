using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace _18
{
    /// <summary>
    /// Задание 1. Создать класс Person с полями: имя, фамилия, возраст и методом вывода всех данных на консоль.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Person matvey = new Person("Матвей", "Пьяник", 17);
            Console.WriteLine(matvey.ToString());
        }
    }

    /// <summary>
    /// класс person
    /// </summary>
    class Person
    {
        string Name;
        string LastName;
        int Age;

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
        /// <summary>
        /// переопределние метода ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Имя и фамилия: {Name} {LastName}, возраст: {Age}";
        }
    }
}
