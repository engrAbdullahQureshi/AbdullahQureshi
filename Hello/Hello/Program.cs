using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        //methods or functions
        static float average(int a,int b,int c)
        {
            float sum = (a + b + c) / 3;
            return sum;
        }
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World");
             // if want to print on same line use "write" key word
             Console.Write("my name is ");
             Console.WriteLine("ABDULLAH");

             int abd = 100;
             Console.WriteLine("value in abd is " + 100);

             string name = Console.ReadLine();
             Console.WriteLine("my name is :"+name);*/

            /*int a= 10;
            float b = 10.10F; // here for float , we have to put F with num
            double c = 200D;
            char d = 'A';
            bool istrue = true;
            string e = "my name is Abdullah";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(istrue);
            Console.WriteLine(e);*/

            //typecasting 
            //1: implicit casting
            //char to int to long to float to double

            // but we cant go from double to flot or int '

            /*int w = 10;
            double x= w;

            char y = 'x';
            float z = 'x';
            Console.WriteLine(w);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/

            /*Console.WriteLine("my name is :");
            string name = Console.ReadLine();
            Console.WriteLine("hello:" + name);*/

            //below code will NOT work because we are trying to 
            //add string to number!

            /*Console.WriteLine("how many candies do you want ?");
            string candies = Console.ReadLine();
            Console.WriteLine("you will get 5 more candies:" + candies +" "+ 5);

            //to solve above issue ----use Convert.ToInt32 with brackets

            Console.WriteLine("how many candies do you want NOW:");
            string cand = Console.ReadLine();
            Console.WriteLine("you will get extra 5 candies: " + (Convert.ToInt32(cand)+5));*/

            //arithmatic operators:

            /*int a = 12;
            int b = 10;
            Console.WriteLine("the value of a + b " + (a + b));
            Console.WriteLine("the value of a - b " + (a - b));
            Console.WriteLine("the value of a * b " + (a * b));
            Console.WriteLine("the value of a / b " + (a / b));*/

            //ASSIGNMENT OPERATORS:

            /*int x = 10;
              int y = x;
              Console.WriteLine(y);
              y += 10;  //y=20
              Console.WriteLine(y);
              y -= 5; //y=20-5=15
              Console.WriteLine(y);
              y *= 5; //15*5 =75
              Console.WriteLine(y);
              y /= 2;   //75/2
              Console.WriteLine(y);*/

            /*
            //logical operators 
            //and operator &&
            Console.WriteLine(true && true);
            Console.WriteLine(false&&true);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            //or operator ||
            Console.WriteLine(true || true);
            Console.WriteLine(false || true);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            //not ! operator
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            */

            /*
            //comparison operators
            Console.WriteLine(320 > 500);
            Console.WriteLine(320 < 500);
            Console.WriteLine(320 <= 500);
            Console.WriteLine(500 == 500); */

            /*  string hello = "hi my name is abdullah";
              Console.WriteLine(hello.Length);
              Console.WriteLine(hello.ToUpper());
              Console.WriteLine(hello.ToLower());
              Console.WriteLine(hello + "i am 23 yeard old");
              Console.WriteLine(string.Concat(hello,"i am 23 years old"));*/
            /*
                        //string interpolation
                        Console.WriteLine("whl
                        string name=Console.ReadLine();
                        Console.WriteLine("how many candies you want?");
                        string cand = Console.ReadLine();

                        Console.WriteLine($"your name is {name} and you will get {cand} candies!"); */

            //string index

            /*string name="my name is abdulah";
            Console.WriteLine(name[0]); //m
            Console.WriteLine(name[3]); // n
            Console.WriteLine(name.IndexOf("name")); //3
            Console.WriteLine(name.Substring(5)); */

            //escape sequence characters!
            /*   Console.WriteLine("my name is \" abdullah");
               Console.WriteLine("my name is \t abdullah");
               Console.WriteLine("my name is \n abdullah");   */

            //if - else

            /*Console.WriteLine("what's your age?");
            string yourage = Console.ReadLine();
            int age = Convert.ToInt32(yourage);

            if (age < 18)
            {
                Console.WriteLine("you cant drive the car");
            }
            else if (age >18 && age < 20)
            {
                Console.WriteLine("make your learner and drive normal");
            }
            else
            {
                Console.WriteLine("you can drive the car");
            }

            */

            /* int age = 17;
             switch (age)
             {
                 case 18:
                     Console.WriteLine("teenager");
                     break;
                 case 20:
                     Console.WriteLine("no teenager");
                     break;
                 default:
                     Console.WriteLine("enjoy life");
                     break;
             }
             */
            //while loop
            /*  int i = 0;
              while (i < 10)
              {
                  Console.WriteLine("value of i :" + " " + i);
                  i++;
              }
              */
            //do-while loop

            /*int a = 10;
            do
            {
                Console.WriteLine(a + 2);
                a++;
            } while (a < 24);*/
            /* for (int j = 0; j <= 10; j++)
             {
                 Console.WriteLine(j + 1);
             } 
             */

            //  Console.WriteLine(average(10, 10, 10));

            player ronaldo = new player();
            Console.WriteLine(ronaldo.gethealth());
            ronaldo.sethealth(299);
            Console.WriteLine(ronaldo.gethealth());





























            Console.ReadLine();
        }
    }
}
