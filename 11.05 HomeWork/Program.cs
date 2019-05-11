using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._05_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //Homework 1
            Console.WriteLine("Home Work 1.Davam etmekcun her hanisi duymeye basin");
            Console.ReadKey();



            Console.WriteLine("Bu programin Komeyile bir reqem daxil edib ve 0 dan hemin reqeme qeder olan ededlerin cemini tapa bilersiz");
            Console.WriteLine("Istediyiniz reqemi daxil edin");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine("Daxil etdiyiniz reqeme qeder edelerin cemi " + sum);




            //Homework 2
            Console.WriteLine("Home Work 2.Davam etmekcun her hanisi duymeye basin");
            Console.ReadKey();

            Console.WriteLine("Bu programin Komeyile bir reqem daxil edib ve 0 dan hemin reqeme qeder olan ededlerin cemini tapa bilersiz");
            Console.WriteLine("Istediyiniz reqemi daxil edin");
            int number2 = int.Parse(Console.ReadLine());
            int sum2 = 0;

            //Way1

            //for (int i = 0; i <= number2; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("Daxil etdiyiniz reqeme qeder edelerin cemi " + sum);

           // Way 2
            for (int i = 0; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                    sum2 += i;
                }

            }
            Console.WriteLine("Daxil etdiyiniz reqeme qeder edelerin cemi " + sum2);


            //Homework 3
            Console.WriteLine("Home Work 3.Davam etmekcun her hanisi duymeye basin");
            Console.ReadKey();

            Console.WriteLine("Bu programin Komeyile bir eded daxil edib ve hemin ededde olan reqemlerin cemini tapa bilersiz");
            Console.WriteLine("Istediyiniz ededi daxil edin");
            string number3 = Console.ReadLine();
            int numberLength = number3.Length;
            var sum3 = 0;
            for (int i = 0; i < numberLength; i++)
            {
                //int x = Convert.ToInt32(new string(number3[i],1));
                int x = int.Parse(number3[i].ToString());
                sum3 += x;

            }
            Console.WriteLine("Daxil etdiyiniz ededde olan reqemlerin cemi " + sum3);

            //Homework 4
            Console.WriteLine("Home Work 4.Davam etmekcun her hanisi duymeye basin");
            Console.ReadKey();

            Console.WriteLine("Zehmet olmasa email-i daxil edin");
            
            
            while (true)
            {
                string email = Console.ReadLine();
                string req = "@";
                
               if (email.IndexOf(req) >0)
                {
                    Console.WriteLine("Muveffeqiyyetle qeyd oldunuz.Sizin E-Mail- " + email);
                    return;

                }
                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun E-mail daxil edin");

                }

            }
           





        }
    }
}
