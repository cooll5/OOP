using Lab06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
	public static void Main(String[] args)
	{
		Student s1 = new Student("Yura", 29, 39, 1);
		Student s2 = new Student("Oleg", 28, 44, 2);
		Student s3 = new Student("Nazar", 27, 40, 2);
		Console.WriteLine("Student: {0}", Student.GetCounter());
		Console.WriteLine("Student::Man: {0}", Student.Man.GetCounter());
		Console.WriteLine("s1: {0}", s1.ToString());
		Console.WriteLine("s2: {0}", s2.ToString());
		Console.WriteLine("s3: {0}", s3.ToString());
		Console.WriteLine("-----------------------------------------------------------------");
		Console.WriteLine("Minus one for age and weight:");
		s1--;
		Console.WriteLine("s1--: {0}", s1.ToString());
		Console.WriteLine("\nPlus one to age and weight:");
		s2++;
		Console.WriteLine("s2++: {0}", s2.ToString());
		Console.WriteLine("-----------------------------------------------------------------");
		Console.WriteLine("Student local (+with changes): {0}", Student.GetCounter());
		Console.WriteLine("Student::Man local(+with changes): {0}", Student.Man.GetCounter());

	}
}
