using System;

namespace CourseApp
{
    class Ship
    {
        int len;
        int displacement;
        string name;
        bool isGoing;

        public Ship() { name = "Неизвестно"; }

        public Person(string n) { name = n; }

        public Person(string n, int a, int b) { name = n; len = a; displacement = b; }

        public void SetDisplacement() {
            Console.WriteLine("Введите водоизмещение коробля ");
            displacement = Console.Read();
        }

        public void SetLen() {
            Console.WriteLine("Введите Длину коробля ");
            len = Console.Read();
        }
        
        public void GoTo() {
             Console.WriteLine("Press 1 if your Ship want put out to sea or 2 if not");
             int a = Console.Read();
             if (a == 1) isGoing = true;
             else isGoing = false;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Длина: {len} Водоизмещение: {displacement}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name for your Ship")
            string n;
            n = Console.ReadLine();
            Ship first = new Ship(string n);
            first.GoTo();
            first.SetDisplacement();
            first.SetLen();
            first.GetInfo();
        }
    }
}