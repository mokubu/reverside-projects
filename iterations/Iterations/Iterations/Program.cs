using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objct = new Program();

            int[] num = { 1, 1, 1, 3, 3, 4, 5, 6, 7, 0 };

          


            string str = "No man is an island";

            string numb = "476";

            objct.HigestNumberOfOccurance(num);
            swap(num);
            objct.WordCount(str);
            SpaceCount(str);
            objct.ReplaceWithDash(str);
            objct.ReverseString(str);
            SecondLargest();

            MaxRepeating(num);
            CheckValue(num);
            objct. Sorted(num);
            objct.Sorted(num);
            FindEvenNumbers();
            FindOddNumbers();
            LargestNumber(3, 4, 5);

            objct.IntergerReversal();
            objct.FiboCalcultor();
            objct.SumDigits();
            Checkvowls();

            Ocurance();
            objct.FindMaxDifference(num);

            {
                Console.ReadLine();

            }
        }
        /*======================================================================================================//

                                                      FUNCTION THA FIND THE LARGEST NMBERS 

       =========================================================================================================*/

        public static int LargestNumber(int a, int b, int c)
        {
            int highest = 0;

            if (a > highest)
                highest = a;
            if (b > highest)
                highest = b;
            if (c > highest)
                highest = c;
            Console.WriteLine(" the highest value is {0}", highest);

            return highest;
        }


        //=====================================================================================================//


        //>>>>>>>>>>>>>>>>>>>>>>>>>>>> Find second largest number from an array of numbers<<<<<<<<<<<<<<<<<<<<<<//


        public static void SecondLargest()
        {
            int n, i, j = 0, lrg, lrg2nd;
            int[] arr1 = new int[50];

            Console.Write("\n\nFind the second largest element in an array :\n\n");


            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            // Stored values into the array
            Console.Write("\nInput {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element # {0} : ", i + 1);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            // find location of the largest element in the array 
            lrg = 0;

            for (i = 0; i < n; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }
            // ignore the largest element and find the 2nd largest element in the array 
            lrg2nd = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  // ignoring the largest element 
                    i--;
                }
                else
                {
                    if (lrg2nd < arr1[i])
                    {
                        lrg2nd = arr1[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
        }


        /*================================================================================================================

       >>>>>>>>>>>>>>>>>>>>>>>>>> number that repeats the most for a sorted array.

        ==========================================================================================================*/



        public static void maxRepeating(int[] num)
        {
            //int[] num = { 1, 1, 1, 3, 3, 4, 5, 6, 7, 0 };
            int[] count = new int[10];

            //Loop through 0-9 and count the occurances
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < num.Length; y++)
                {
                    if (num[y] == x)
                        count[x]++;
                }
            }

            //For displaying output only            
            for (int x = 0; x < 10; x++)
                Console.WriteLine("Number " + x + " appears " + count[x] + " times");
        }


        /*=============================================================================================================

                  //>>>>>>>>>>>>>>calculates the number of characters in the string<<<<<<<<<<<<<<<<//

        =============================================================================================================*/



        public static int numberOfString(string str)
        {
            // string str;
            int count = 1, len = 0;
            //Console.WriteLine("enter a string ");
            //str = Console.ReadLine();

            while (len < str.Length - 1)
            {
                if (str[len] == ' ' || str[len] == '\n' || str[len] == '\t') ;
                {
                    count++;
                }
                len++;
            }
            Console.WriteLine("the number of string " + count);

            return count++;


        }



        /*=============================================================================================================

                                 Sort an array of numbers in ascending order

       ========================================================================================================*/
        public void Sorted(int[] arrayz)
        {
            Console.WriteLine("function that sorts the array");

            {

                // int size = int.Parse(Console.ReadLine());

                //  int[] arrayz = new int[size];

                int temp = 0;
                /* for (int i = 0; i < arrayz.Length; i++)
                 {
                     Console.WriteLine("enter pleas eneter value number# {0}",i+1);
                     arrayz[i] = int.Parse(Console.ReadLine());

                 }*/

                for (int i = 0; i < arrayz.Length; i++)
                {
                    for (int j = 0; j < arrayz.Length - 1; j++)
                    {

                        if (arrayz[i] < arrayz[j])
                        {
                            temp = arrayz[i];
                            arrayz[i] = arrayz[j];
                            arrayz[j] = temp;

                        }
                    }

                }
                Console.WriteLine("\n the sorted array in ascending order");
                for (int i = 0; i < arrayz.Length; i++)
                {
                    Console.Write(" " + arrayz[i]);
                }
            }
        }
        /*======================================================================================================//

                            Find all even numbers from an array of numbers

       =======================================================================================================*/

        public static void FindEvenNumbers()
        {
            Console.WriteLine("please enter the size of the array");

            {

                int size;
                size = int.Parse(Console.ReadLine());

                int[] arrayz = new int[size];

                //
                //int temp = 0;
                for (int i = 0; i < arrayz.Length; i++)
                {
                    Console.WriteLine("enter pleas eneter value number# {0}", i + 1);
                    arrayz[i] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("even numbers in the array ");
                for (int i = 0; i < size; i++)
                {
                    if (arrayz[i] % 2 == 0)
                    {

                        Console.Write(arrayz[i] + " ");
                    }

                }
                Console.WriteLine();




            }
        }

        //======================================================================================================//

        //                                               Space counter 

        //=========================================================================================================
        public static int SpaceCount(string str)
        {

            Console.Write("\n\nFunction that count number of spaces in a string :\n");





            int spcctr = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    spcctr++;
            }


            Console.WriteLine("\"" + str + "\"" + " contains {0} spaces", spcctr);
            return spcctr;

        }
        //=======================================================================================================//

        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> INTEGER REVERSAL <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<//



        public int IntergerReversal()
        {
            Console.WriteLine("function perform interger reversal\n=============================\n");

            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);

            return reverse;
        }

        /*======================================================================================================//

                                                      FIBONACI FUNCTION

        =========================================================================================================*/


        public void FiboCalcultor()
        {
            Console.WriteLine("FUNCTION CALCULATING THE FIBONACI NUMBERS\n>>>>>>>>>>>>>>>>>>>>>  ");

            int i, count, n1 = 0, n2 = 1, n3 = 0;

            Console.Write("Enter the Limit : ");
            count = int.Parse(Console.ReadLine());
            Console.Write(n1 + " ");
            Console.Write(n2 + " ");
            for (i = 0; i <= count; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();

        }

        public int SumDigits()
        {
            Console.Write("Input  a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
            return sum;
        }

        /*======================================================================================================//

                                                   CHECKS FOR THE VOWLS AND CONSONENT 

      =========================================================================================================*/

        private static void Checkvowls()
        {

            Console.Write("we are in a function that checks if an alphabet is vowel or consonant \n>>>>>>>>>>>>>>>>\n\n");
            char character;
            Console.Write("\nEnter an alphabet: ");
            character = Char.Parse(Console.ReadLine());

            if ((character >= 'A' && character <= 'Z') || character >= 'a' && character <= 'z')
            {
                if (character == 'a' || character == 'A' || character == 'e' || character == 'E' || character == 'i'
                    || character == 'I' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
                {
                    Console.WriteLine(character + " is a vowel");
                }
                else
                {
                    Console.WriteLine(character + " is a consonant");
                }
            }
            else
            {
                Console.WriteLine(character + " is not an alphabet");
            }
        }


        /*======================================================================================================//

                                                   Find Odd Numbers 

      =========================================================================================================*/


        public static void FindOddNumbers()
        {
            Console.WriteLine("please enter the size of the array");

            {

                int size;
                size = int.Parse(Console.ReadLine());

                int[] arrayz = new int[size];


                for (int i = 0; i < arrayz.Length; i++)
                {
                    Console.WriteLine("enter pleas eneter value number# {0}", i + 1);
                    arrayz[i] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("odd numbers in the array array of numbers ");
                for (int i = 0; i < size; i++)
                {
                    if (arrayz[i] % 2 != 0)
                    {

                        Console.Write(arrayz[i] + " ");
                    }

                }
                Console.WriteLine();




            }
        }


        /*======================================================================================================//

                                                   Reverse a string

      =========================================================================================================*/


        public  void ReverseString(string StR)
        {
           // String StR = "i love the lord";
            string reversestring = "";
            int Length;

            Length = StR.Length - 1;
            while (Length >= 0)
            {
                reversestring = reversestring + StR[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", reversestring);

        }


        private static void Ocurance()
        {
            int i = 0;
            int count = 0;
            int item = 0;

            int[] arr1 = new int[5];

            //Read numbers into array
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter item : ");
            item = int.Parse(Console.ReadLine());

            for (i = 0; i < 5; i++)
            {
                if (item == arr1[i])
                {
                    count++;
                }
            }

            Console.WriteLine("Total occurrence of item " + item + " is : " + count);

            Console.WriteLine();
        }

        public void ReplaceWithDash(string str)
        {
            Console.WriteLine("\nfunction that replaces a spaces with dashes\n");
            string str1 = str.Replace(' ', '_');
            Console.WriteLine(str1);
        }

        public int FindMaxDifference(int[] arr)
        {
            int diff = 0;
            int maxDiff = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                diff = arr[i + 1] - arr[i];
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }

            return maxDiff;
        }

        /*======================================================================================================//

                                                string conversion

     =========================================================================================================*/

        public int StringConversion(string numb)
        {

            int parsednum = int.Parse(numb);
            int number = parsednum;

            return number;
        }
        /*======================================================================================================//

                                                 counts the number of words in  string

     =========================================================================================================*/


        public int WordCount(string str)
        {

            Console.WriteLine("function that counts the number of words in a sentence \n");
            int count = 1;
            int i = 0, L = 1;

            while (i <= str.Length - 1)
            {
                if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
                {
                    count++;
                }
                i++;
            }
            Console.WriteLine("the numer of words in the sentence are "+count);
            return count;


        }


        /*======================================================================================================//

                                                check value in array

    =========================================================================================================*/
        public static int CheckValue(int[] arr)
        {

            Console.WriteLine("Please enter any number to check if the number already exist");
            int userInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (userInput == arr[i])
                {
                    Console.Write("FOUND NUMBER {0} : ", userInput);
                    
                    break;
                }
                else if (userInput != arr[i])
                {
                     Console.WriteLine("number not in array");
                    break;
                }

            }
             

                return userInput;
        }



        public static void MaxRepeating(int[] arr)
        {

            int[] count = new int[10];

            //Loop through 0-9 and count the occurances
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < arr.Length; y++)
                {
                    if (arr[y] == x)
                        count[x]++;
                }
            }

            //For displaying output only            
            for (int x = 0; x < 10; x++)
                Console.WriteLine("Number " + x + " appears " + count[x] + " times");
        }
        /*======================================================================================================//

                                        Higest Number Of Occurance

    =========================================================================================================*/

        public int HigestNumberOfOccurance(int[] array)
        {

            int count = 1, tempCount;
            int frequentNumber = array[0];
            int tempNumber = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                tempNumber = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (tempNumber == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.", frequentNumber, count);
            Console.ReadKey();
            return count;
        }

        /*======================================================================================================//

                                        swap first and last in array

    =========================================================================================================*/

        private static void swap(int[] array)
        {
            //int[] arr = { 20, 5, 6, 32, 15, 32, 95, 84, 36, 2, 52 };
            int length = array.Length - 1;
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Before swapping :first is " + array[0] + " and last is " + array[length]);
            Console.WriteLine("\n");
            if (array[0] != array[length])
            {

                temp = array[0];
                array[0] = array[length];
                array[length] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("After swapping :first is " + array[0] + " and last is " + array[length]);
        }
    }
}
 

    






 

    




