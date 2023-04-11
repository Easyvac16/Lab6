using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }

        public Animal(string name, int age, string habitat)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
        public virtual void print_info()
        {
            Console.WriteLine("Ім'я тварини: " + Name);
            Console.WriteLine("Вік тварини: " + Age);
            Console.WriteLine("Середа життя тварини: " + Habitat);
        }
    }

    public class Tiger : Animal
    {
        public bool IsEndangered { get; set; }

        public Tiger(string name, int age, string habitat, bool isEndangered) : base(name, age, habitat)
        {
            IsEndangered = isEndangered;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The tiger roars.");
        }
        public override void print_info()
        {
            Console.WriteLine("Iм'я тварини: " + Name);
            Console.WriteLine("Вiк тварини: " + Age);
            Console.WriteLine("Середа проживання тварини: " + Habitat);
            Console.WriteLine();
        }
    }

    public class Crocodile : Animal
    {
        public double NumberOfTeeth { get; set; }

        public Crocodile(string name, int age, string habitat, double numberOfTeeth) : base(name, age, habitat)
        {
            NumberOfTeeth = numberOfTeeth;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The crocodile hisses.");
        }
        public override void print_info()
        {
            Console.WriteLine("Iм'я тварини: " + Name);
            Console.WriteLine("Вiк тварини: " + Age);
            Console.WriteLine("Середа проживання тварини: " + Habitat);
            Console.WriteLine();
        }
    }

    public class Kangaroo : Animal
    {
        public int HasPouch { get; set; }

        public Kangaroo(string name, int age, string habitat, int hasPouch) : base(name, age, habitat)
        {
            HasPouch = hasPouch;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The kangaroo grunts.");
        }
        public override void print_info()
        {
            Console.WriteLine("Iм'я тварини: " + Name);
            Console.WriteLine("ВIк тварини: " + Age);
            Console.WriteLine("Середа проживання тварини: " + Habitat);
            Console.WriteLine();
        }
    }

    internal class cs1
    {
        public static void task_1()
        {
                Tiger tiger = new Tiger("Шерхан", 120 , "Тайга", true);

                // Використання методу для виведення даних про тигра
                tiger.print_info();
                tiger.MakeSound();
                Console.WriteLine();

                // Створення об'єкту класу Крокодил з ім'ям "Гена"
                Crocodile crocodile = new Crocodile("Гена", 250 , "Води" , 4.5 );

                // Використання методу для виведення даних про крокодила
                crocodile.print_info();
                crocodile.MakeSound();
                Console.WriteLine();

                // Створення об'єкту класу Кенгуру з ім'ям "Кен"
                Kangaroo kangaroo = new Kangaroo("Кен",60 , "Африка", 3);

                // Використання методу для виведення даних про кенгуру
                kangaroo.print_info();
                kangaroo.MakeSound();
                Console.WriteLine();
        }
        


    }
}
