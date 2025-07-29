using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano","roma","budapeşte","ankara","istanbul","varşova"};

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}




            //int[] numbers = { 45, 34, 23, 56, 789, 90, 234, 567, 3, 45678 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}





            //int[] numbers = { 45, 34, 23, 56, 789, 90, 234, 567, 3, 45678 }; 

            //foreach(int number in numbers)
            //{
            //    if(number % 2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}





            //int[] numbers = { 45, 34, 23, 56, 789, 90, 234, 567, 3, 45678 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);





            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,6,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}






            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("---------------------------");
            Console.WriteLine("Sınıfınızda kaç öğrenci var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            //Öğrenci isimlerini not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i=0; i< studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz:");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 notuu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz.
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }            

            //Sınav ortalamaları
            for(int i=0; i<studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumu
                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("---------------------------");
            }

            #endregion

            Console.Read();
        }
    }
}
