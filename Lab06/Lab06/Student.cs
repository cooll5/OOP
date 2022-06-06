using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Lab06
{
    public class Student
    {
        private Man man;
        int kurs;
        static int counter;
        public class Man
        {
            private string name;
            private int age;

            private double weight;
            private static int counter = 0;
            public Man()
            {
                name = "";
                age = 0;

                weight = 0;
                counter++;
            }
            public Man(String name, int age, double weight)
            {
                this.name = name;
                this.age = age;
                this.weight = weight;
                counter++;
            }
            public Man(Man m)
            {
                this.name = m.name;
                this.age = m.age;
                this.weight = m.weight;
                counter++;
            }
            public int GetAge() { return this.age; }
            public string GetName() { return this.name; }
            public double GetWeight() { return this.weight; }
            public static int GetCounter() { return counter; }
            public void SetAge(int age) { this.age = age; }
            public void SetName(String name) { this.name = name; }
            public void SetWeight(double weight) { this.weight = weight; }
            public bool Init(string name, int age, double weight)
            {
                if (age > 0 && age < 100 && weight > 0)
                {
                    SetName(name);
                    SetAge(age);
                    SetWeight(weight);
                    return true;
                }
                return false;
            }
            public void Display()

            { Console.WriteLine("Name: {0}, age: {1}, weight: {1}", name, age, weight); }

            public void Read()
            {
                String n;
                int a;
                double b;
                do
                {
                    Console.WriteLine(" Name: ");
                    n = Console.ReadLine();
                    Console.WriteLine(" Age: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Weight: ");
                    b = Convert.ToInt32(Console.ReadLine());
                } while (!Init(n, a, b));
            }
            public static Man operator ++(Man m) { return new Man(m.name, m.age++, m.weight++); }
            public static Man operator --(Man m) { return new Man(m.name, m.age--, m.weight--); }
            public override string ToString()
            {
                return "Man: [name: " + this.name + ", "
              + "age: " + this.age + "weight: " + this.weight + "]";
            }
        }
        public Student()
        {
            this.man = new Man();
            this.kurs = 0;
            counter++;
        }
        public Student(Man man, int kurs)
        {
            this.man = man;
            this.kurs = kurs;
            counter++;
        }
        public Student(Student student)
        {
            this.man = student.man;
            this.kurs = student.kurs;
            counter++;
        }
        public Student(String name, int age, double weight, int kurs)
        {
            this.kurs = kurs;
            this.man = new Man(name, age, weight);
            counter++;
        }
        public Man GetMan() { return this.man; }
        public int GetKurs() { return this.kurs; }
        public static int GetCounter() { return counter; }
        public void SetMan(Man man) { this.man = man; }
        public void SetSpec(int kurs) { this.kurs = kurs; }
        public void Display()
        {
            Console.WriteLine("Kurs: {0}", this.kurs);
            this.man.Display();
        }
        public void Read()
        {
            string name;
            int age, kur;
            double weight;
            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Weight: ");
                weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kurs: ");
                kur = Convert.ToInt32(Console.ReadLine());
            } while (!this.man.Init(name, age, weight));
            this.kurs = kur;
        }
        public static Student operator ++(Student student)
        {
            return new Student(student.man++, student.kurs);
        }
        public static Student operator --(Student student)
        {
            return new Student(student.man--, student.kurs);
        }
        public override string ToString()
        {
            return "Student: [" + this.man.ToString() + ", "
   + "kurs: " + this.kurs + "]";
        }
    }
}
