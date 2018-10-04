using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objt = new Program();

            // objt.EvenOrOdd();
            // objt.check();
            // objt.LeapYear();
            //objt.largest();
            //objt.Numberzz();
            // FizzBuzz();
           // BiggestValue();

            Console.ReadLine();
        }

        public void EvenOrOdd()
        {
            int a;
            Console.WriteLine("sir please enter the number");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)

            {
                Console.WriteLine("the number is even ")
            ;
            }


            else if (a % 2 != 0)
            {

                Console.WriteLine("the numebre is odd ");
            }

        }

        public void check()
        {
            Console.WriteLine("please enter  any alphabet  : ");
            char a = char.Parse(Console.ReadLine());


            if (a < 0)
            {
                Console.WriteLine("the value is negative");
            }

            if (a == 0)
            {

                Console.WriteLine("the value is the one we looking for and it is zero {0}  ", a);

            }
            else if (a > 0)
            {
                Console.WriteLine("the value is not what we looking for ");
            }


        }

        public void LeapYear()
        {
            int year;
            Console.WriteLine("enter the year: ");
            year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)))
                Console.WriteLine("leao year " + year);
            else
                Console.WriteLine("not leap year " + year);

            Console.ReadLine();
        }

        public int largest()
        {
            int a, b, c;
            int bigger = 0;

            Console.WriteLine("enter  number #1 : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter  number #2 : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter  number #3 : ");
            c = int.Parse(Console.ReadLine());


            if (a > bigger)
            {
                bigger = a;
            }

            if (b > bigger)
            {
                bigger = b;
            }

            if (c > bigger)
            {

                bigger = c;
            }
            Console.WriteLine("the highst number  " + bigger);

            return bigger;


        }


        public int Numberzz()
        {


            int a, b, c;


            Console.WriteLine("enter  number #1 : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter  number #2 : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter  number #3 : ");
            c = int.Parse(Console.ReadLine());



            // a is the largest
            if (a >= b && a >= c)
            {
                if (b >= c)
                {

                    Console.WriteLine("{0} is the 2nd largest number\n", b);
                }
                else
                {
                    Console.WriteLine("\n\n{0} is the 2nd largest number\n", c);
                }
            }
            else if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine("{0} is the 2nd largest number\n", a);
                }
                else
                {
                    Console.WriteLine("\n\n{0} is the 2nd largest number\n", c);
                }
            }

            // c is the largest number of the three
            else if (a >= b)
            {
                Console.WriteLine("\n\n{0} is the 2nd largest number\n", a);
            }
            else
            {
                Console.WriteLine("\n\n{0} is the 2nd largest number\n", b);
            }

            return 0;
        }

        private static int FizzBuzz()

        {
            Console.WriteLine("enter  number #1 : ");
           int  a = int.Parse(Console.ReadLine());

            if (a % 3 == 0 && a % 5 != 0)
            {

                Console.WriteLine("fizz");
            }

            if (a % 3 != 0 && a % 5 == 0)
            {
                Console.WriteLine("buzz");
            }

            if (a % 3 == 0 && a % 5 == 0)
            {

                Console.WriteLine("fizz buzz");
            }

            if (a % 3 != 0 && a % 5 != 0)
            {
                Console.WriteLine(" a ke dlale machila");

            }

            return 1;
        }
        public static int BiggestValue() {

            Console.WriteLine("we are in the function that calculates the largest between 7 values \n");
            Console.WriteLine("-----------------------------------------------------------------------\n");
            
        int[] array = new int[7];

            Console.WriteLine("enter 7 values to compare");

            for (int i=0;i<7;i++)
            {
                Console.WriteLine("enter the array elements #{0} ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
    
            int largest = array[6];
            for(int i=0;i<7;i++)
            {

                if (array[i] > largest)
                {
                    largest = array[i];

                }
            }
            
            Console.WriteLine("the largest no is {0}", largest);
            Console.Read();
            return largest;}

            
        }
    }


  
        

    

