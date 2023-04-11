using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Human(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual void print_info()
        {
            Console.WriteLine("Iм'я : " + Name);
            Console.WriteLine("Вiк : " + Age);
            Console.WriteLine("Стать: " + Gender);
        }
    }

    // Клас Builder
    class Builder : Human
    {
        public string Specialization { get; set; }

        public Builder(string name, int age, string gender,string specialization) : base (name,age,gender)
        {
            Specialization = specialization;
        }
        public override void print_info()
        {
            Console.WriteLine("Iм'я : " + Name);
            Console.WriteLine("Вiк : " + Age);
            Console.WriteLine("Стать: " + Gender);
            Console.WriteLine();

        }
        public void BuildHouse()
        {
            Console.WriteLine($"{Name} зi спецiалiзацiєю {Specialization} будує будинок.");
        }
    }

    // Клас Sailor
    class Sailor : Human
    {
        public string ShipName { get; set; }
        public Sailor(string name, int age, string gender, string shipname) : base(name, age, gender)
        {
            ShipName = shipname;
        }

        public void Sail()
        {
            Console.WriteLine($"{Name} на кораблi з назвою {ShipName} пливе по водах.");
        }
        public override void print_info()
        {
            Console.WriteLine("Iм'я : " + Name);
            Console.WriteLine("Вiк : " + Age);
            Console.WriteLine("Стать: " + Gender);
            Console.WriteLine();

        }
    }

    // Клас Pilot
    class Pilot : Human
    {
        public string AircraftType { get; set; }

        public Pilot(string name, int age, string gender, string aircrafttype) : base(name, age, gender)
        {
            AircraftType = aircrafttype;
        }
        public override void print_info()
        {
            Console.WriteLine("Iм'я : " + Name);
            Console.WriteLine("Вiк : " + Age);
            Console.WriteLine("Стать: " + Gender);
            Console.WriteLine();

        }
        public void Fly()
        {
            Console.WriteLine($"{Name} на лiтаку типу {AircraftType} лiтає по небу.");
        }
    }
    internal class cs2
    {
        public static void task_2()
        {
            Builder builder = new Builder("Iван", 35,"Чоловiк","Муляр");
            builder.print_info();
            builder.BuildHouse();
            Console.WriteLine();

            Sailor sailor = new Sailor("Марiя",28,"Жiнка","Титанiк");
            sailor.print_info();
            sailor.Sail();
            Console.WriteLine();

            Pilot pilot = new Pilot("Олексiй", 45,"Чоловiк","Boeing 747");
            pilot.print_info();
            pilot.Fly();
            Console.WriteLine();
        }
    }
}
