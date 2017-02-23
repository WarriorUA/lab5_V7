using System;
using System.Collections.Generic;

namespace Lab2_V7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int countV = 0;
            int countO = 0;
            int countP1 = 0;
            bool continueProgram = false;
            do
            {
                continueProgram = false;
                string timeName;
                int timeV;
                int timeO;
                Console.WriteLine("Vvedite ima studenta:");
                timeName = Console.ReadLine();
                Console.WriteLine("Vvedite kolichestvo propuschenuh chasov:");
                timeV = int.Parse(Console.ReadLine());
                Console.WriteLine("Vvedite kolichestvo opravdanuh chasov:");
                timeO = int.Parse(Console.ReadLine());
                students.Add(new Student(timeName, timeV, timeO));
                Console.WriteLine("Vi hotite prodolzhit?(Y/N)");
                string otvet = Console.ReadLine();
                if (otvet == "Y") continueProgram = true;
            }
            while (continueProgram);
            foreach (var t in students)
            {
                Console.WriteLine("Name: {0}\n VsogoPropysk: {1}\n Opravdano: {2}\n V Chash: {3}\n V procentah: {4}\n", t.name, t.v, t.o, t.p1, t.p2);
                countV += t.v;
                countO += t.o;
                countP1 += t.p1;
            }
            Console.WriteLine("Vsego propycheno bez opravdanii: {0}\n Vsego opravdano: {1}\n Vsego propyscheno: {2}\n",countV,countO,countP1);
            Console.ReadKey();
        }
    }
}
