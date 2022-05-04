using System;

namespace lab3
{
    class Program
    {
        public struct Student
        {
            public string prizv;
            public int kurs;
            public string spec;
            public int fiz;
            public int mat;
            public int prog;
        };

        static void Main(string[] args)
        {
            string str = "Ukraine, (Drohobych), Lviv, University";
            char[] modifiedstr = str.ToCharArray();
            int k = 0;
            Console.WriteLine();
            Console.WriteLine($"Modified String = {String.Join("", modifiedstr)}");
            modifiedstr = str.ToCharArray();

            #region Task 2
            Console.WriteLine();
            Console.WriteLine("Task 2:");

            int k1 = 0;
            int k2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' && k != 2)
                {
                    k1++;
                }

                else if (k == 2)
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[i] == ')' && k != 2)
                        {
                            k2++;
                        }
                    }
            }
            if (k1 != 1 && k2 != 1)
                Console.WriteLine("ERROR \n STRING CONTAINES MORE THAN 1 BRACKETS");
            else
            {
                int pos = str.IndexOf("(");
                int pos2 = str.IndexOf(")");
                modifiedstr = str.Remove(pos, pos2 - pos + 1).ToCharArray();
                Console.WriteLine($"Modified String = {String.Join("", modifiedstr)}");
                modifiedstr = str.ToCharArray();
            }

            #endregion

            #region Task 3
            string[] lastnames = { "Kobyrynka", "Kotyk", "Klimasevskiy", "Yachechak", "Savshak", "Bilionok", "Senyshyn" };
            string[] specialnist = { "Комп науки", "матем. i ек.", "iнформатика", "фiзика i iнф.", "трудове" };

            Console.WriteLine();
            Console.WriteLine("Task 3:");

            Console.Write("Кiлькiсть студентiв = ");
            int N = Convert.ToInt32(Console.ReadLine());
            Student[] p = new Student[N]; // створення посилання на об`єкт типу Student
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                p[i].prizv = lastnames[rand.Next(7)];
                p[i].kurs = rand.Next(1, 5);
                p[i].spec = specialnist[rand.Next(5)];
                p[i].fiz = rand.Next(2, 6);
                p[i].mat = rand.Next(2, 6);
                p[i].prog = rand.Next(2, 6);
            }
            Console.WriteLine("===============================================================================\n" +
                              "| № |  Прiзвище  | Курс | Cпецiальнiсть | Фiзика | Математика | Програмування |\n" +
                              "-------------------------------------------------------------------------------");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"|{i,3}|{p[i].prizv,12}|{p[i].kurs,6}|{p[i].spec,15}|{p[i].fiz,8}|{p[i].mat,12}|{p[i].prog,15}|");
            }
            Console.WriteLine("===============================================================================");

            Console.WriteLine("Студенти що мають 5 з фiзики\n" +
                          "| № |  Прiзвище  |");
            for (int i = 0; i < N; i++)
            {
                if (p[i].fiz == 5)
                {
                    Console.WriteLine($"|{i,3}|{p[i].prizv,12}|");
                }
            }

            #endregion
        }
    }
}
