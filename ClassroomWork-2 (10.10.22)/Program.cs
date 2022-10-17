using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//30) Код должен содержать 3 класса: 1 родительский и два наследника.
//В одном классе-наследнике должен использоваться конструктор базового класса,
//во втором классе-наследнике должен использоваться переопределённый конструктор.

namespace ClassroomWork_2__10._10._22_
{
    public class Human
    {
        public string _name;
        public int _age = 0;
        public Human() 
        {
            _name = "Человек";    
        }
        public Human(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public void Print()
        {
            Console.WriteLine($"Человек:\nИмя - {_name}\nВозраст - {_age}");
        }
    }

    public class Athlete : Human
    {
        public Athlete(): base() {}
        public Athlete(string name, int age): base(name, age) {}

        public void Print()
        {
            Console.WriteLine($"Атлет:\nИмя - {_name}\nВозраст - {_age}\n");
        }
    }

    public class Employee: Human
    {
        int _ID = 0;
        int _salary = 0;

        public Employee()
        {
            _name = "Рабочий";
            _ID = 001;
        }
        public Employee(string name, int age, int iD, int salary)
        {
            _name = name;
            _age = age;
            _ID = iD;
            _salary = salary;
        }
        public void Print()
        {
            Console.WriteLine($"Рабочий:\nИмя - {_name}\nВозраст - {_age}" +
                $"\nНомер сотрудника - {_ID}\nЗарплата - {_salary}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и возраст атлета через Enter: ");
            string name1 = Console.ReadLine();
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя, возраст, ID номер(3-значное число) и зарплату рабочего через пробел: ");
            string name2 = Console.ReadLine();
            int age2 = int.Parse(Console.ReadLine());
            int ID = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            Athlete  athlete = new Athlete (name1, age1);
            Employee employee = new Employee (name2, age2, ID, salary);
            Console.WriteLine("\n");

            athlete.Print();
            employee.Print();

            Console.ReadKey();
        }
    }
}
