using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Pattern_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objct = new Program();
            Console.WriteLine("enter any size between 1 and 10 that will help size the shapes\n");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr another value preferable number similar to your initial value");
            int b = int.Parse(Console.ReadLine());

            HalfDiamondStarPattern(a);
            MirroredHalfDiamondStarPattern(a);

           

            InvertedPyramidStarPattern(a, b);
            HollowInvertedPyramidStarPattern(a);

            printHallowSquare(a);

            HollowRightTriangleStarPattern(a);
         
            printRhombus(a);
            printHallowRhombus(a);
            printMirroredRhombus(a);
            printMirroredHallowRhombus(a);

            printInvertedRightAngledTriangle(a);
            printMirrorInvertedRightTriangle(a);

            objct.HollowPyramidStarPattern(a);
            objct.printHallowInvertedMirroredRightAngleTriangle(a);

            printInvertedRightAngledTriangle(a);
            objct.printHallowRightAngleTriangle(a);


            objct.printMirroredRightAngleTriangle(a);
            objct.printHallowMirroredRightAngleTriangle(a);

            


            Console.ReadLine();
        }
        private static void HalfDiamondStarPattern(int a)
        {
            Console.WriteLine("printing Half Diamond Star Pattern");

           
            int columns = 1;
            for (int i = 1; i < a * 2; i++)
            {

                for (int j = 1; j <= columns; j++)
                {

                    Console.Write("*");
                }
                if (i < a)
                {
                    columns++;
                }
                else
                {
                    columns--;
                }
                Console.WriteLine();
            }
        }


        /*==================================================================================================================
         
                                          Hollow Inverted Pyramid Star Pattern

        ===================================================================================================================*/


        private static void HollowInvertedPyramidStarPattern( int a)
        {
            Console.WriteLine(" we are in aprogram that prints Hollow Inverted Pyramid Star Pattern\n");

          
            int i, j;

            for (i = a; i >= 1; i--)
            {
                for (j = i; j < a; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (2 * i - 1); j++)
                {
                    if (i == a || j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }

        /*=================================================================================================================
          
                                        Mirrored Half Diamond Star Pattern

       =====================================================================================================================*/
        private static void MirroredHalfDiamondStarPattern(int a)
        {
            Console.WriteLine("Mirrored half diamond star pattern \n");

            int spaces = a - 1;
            int stars = 1;
            for (int i = 1; i < a * 2; i++)
            {
                Console.Write(" ");
                for (int j = 1; j <= spaces; j++)
                    Console.Write(" ");
                for (int j = 1; j <= stars; j++)
                    Console.Write("*");


                //Console.WriteLine(" ");

                if (i < a)
                {
                    stars++;
                    spaces--;
                }
                else
                {
                    stars--;
                    spaces++;
                }
                Console.WriteLine();
            }
        }

        /*================================================================================================================
        
                                       Hollow Pyramid Star Pattern

         ================================================================================================================= */

        public void HollowPyramidStarPattern(int a)


        {

            Console.WriteLine("printing hallow Pyramid star pattern :");
            int i, space,  star = 0;
           

            for (i = 1; i < a; i++)
            {
                for (space = 1; space <= a - i; space++)
                {
                    Console.Write(" ");

                }
                while (star != (2 * i - 1))
                {
                    if (star == 0 || star == 2 * i - 2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    star++;
                }
                star = 0;
                Console.WriteLine();
            }
            for (i = 0; i < 2 * a - 1; i++)
            {
                Console.Write("*");

            }
        }
        /*===================================================================================================================

                                                Hollow Right Triangle Star Pattern

         ==================================================================================================================*/

        public static void HollowRightTriangleStarPattern(int a)
        {

            Console.WriteLine("we are in the function that prints Hollow Right Triangle Star Pattern \n");

            int i, space, star = 0;
           

            for (i = 1; i < a; i++)
            {
                for (space = 1; space <= a - i; space++)
                {
                    Console.Write("");

                }
                while (star != (2 * i - 1))
                {
                    if (star == 0 || star == 2 * i - 2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    star++;
                }
                star = 0;
                Console.WriteLine();
            }
            for (i = 0; i < 2 * a - 2; i++)
            {
                Console.Write("*");

            }
        }
        /*=================================================================================================================
        
                                              Inverted Pyramid Star Pattern

        ==================================================================================================================*/
        public static void InvertedPyramidStarPattern(int a,int b)
        {
            Console.WriteLine("we are in the function that prints  Inverted Pyramid Star Pattern \n");

            int i, j, k;

            
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < i; j++)
                {

                    Console.Write(" ");

                }
                for (k = 0; k < b; k++)
                {
                    Console.Write(" * ");
                }
                b--;
                Console.WriteLine();
            }
        }

        /*=================================================================================================================

                                             printing Hallowed Square

       ==================================================================================================================*/

        public static void printHallowSquare(int number)
        {
            Console.WriteLine("\nHALLOW SQUARE PATTERN");


       

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == number - 1)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= number-2)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == number - 1)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= number-2)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

            /*=================================================================================================================

                                                printing Rhombus 

          ==================================================================================================================*/

            public static void printRhombus(int n)
            {
                Console.WriteLine("THE STAR PATTERN OF RHOMBUS");
                for (int i = 1; i <= n; i++)
                {

                    for (int j = i; j < n; j++)
                    {
                        Console.Write(' ');
                    }


                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write('*');
                    }


                    Console.WriteLine();
                }
            }

            /*=================================================================================================================

                                               Printing Hallow Rhombus

         ==================================================================================================================*/

            public static void printHallowRhombus(int n)
            {
                Console.WriteLine("PRINTING HALLOW RHOMBUS");
                for (int i = 1; i <= n; i++)
                {
                    // Print space
                    for (int j = i; j < n; j++)
                    {
                        Console.Write(' ');
                    }

                    for (int j = 1; j <= n; j++)
                    {
                        // Print '*' for boundaries
                        if (i == 1 || i == n || j == 1 || j == n)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }

                    // Move to the next row
                    Console.WriteLine();
                }



            }

            /*=================================================================================================================

                                              Printing Hallow Rhombus

        ==================================================================================================================*/

            public static void printMirroredRhombus(int size)
            {
                Console.WriteLine("PRINTING MIRRORED RHOMBUS STAR PATTERN");
                for (int row = 0; row < size; row++)
                {
                    //first print the space
                    for (int space = size - row; space < size; space++)
                    {
                        Console.Write(" ");
                    }
                    //print the character
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write("*");
                    }
                    //add a newline
                    Console.WriteLine();
                    Console.Write("\n");
                }

            }


            /*=================================================================================================================

                                              Printing MIRRORED HALLOW RHOMBUS

        ==================================================================================================================*/


            public static void printMirroredHallowRhombus(int n)
            {
                Console.WriteLine("PRINTING MIRRORED HALLOW RHOMBUS");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    if (i == 1 || i == n)
                        for (int j = 1; j <= n; j++)
                        {
                            Console.Write("*");
                        }
                    else
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (j == 1 || j == n)
                                Console.Write("*");

                            else
                                Console.Write(" ");
                        }
                    }
                    Console.WriteLine();

                }

          

        

    }


            /*=================================================================================================================

                                             Printing Right Angle

       ==================================================================================================================*/

            public void printRightAngle(int row)
            {
                Console.WriteLine("RIGHT ANGLE  TRIANGLE PATTERN");

                for (int i = 1; i < row; i++)
                {
                    for (int j = i; j < row; j++)
                    {
                        Console.WriteLine("");
                    }
                    for (int k = 1; k < (i * 2); k++)
                        Console.WriteLine("*");
                    Console.WriteLine("\n");
                }
            }

            /*=================================================================================================================

                                            Printing \inverted Right Angled Triangle

      ==================================================================================================================*/


            public static void printInvertedRightAngledTriangle(int n)
            {
                Console.WriteLine("PRINTING INVERTED RIGHT ANGLE TRIANGLE");
                for (int i = n; i >= 1; i--)
                {
                    // Print '*' i times
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write('*');
                    }

                    // Move to the next line
                    Console.WriteLine();
                }
            }

            /*=================================================================================================================

                                        PRINTING MIRROR INVERTED RIGHT TRIANGLE

    ==================================================================================================================*/


            public static void printMirrorInvertedRightTriangle(int n)
            {
                Console.WriteLine("PRINTING MIRROR INVERTED RIGHT TRIANGLE\n");
                for (int i = 1; i <= n; i++)
                {
                    // Loop for printing space
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(' ');
                    }

                    // Loop for printing '*'
                    for (int k = i; k <= n; k++)
                    {
                        Console.Write('*');
                    }

                    // Move to the next line
                    Console.WriteLine();
                }
            Console.WriteLine();
            }


            /*=================================================================================================================

                                        PRINTING HALLOW INVERTED MIRRORED RIGHT TRIANGLE

    ==================================================================================================================*/

            public void printHallowInvertedMirroredRightAngleTriangle(int n)
            {
                Console.WriteLine("\nPRINTING HALLOW INVERTED MIRRORED RIGHT TRIANGLE");
                for (int i = 1; i <= n; i++)
                {
                    // Loop for printing space
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(' ');
                    }

                    // Loop for printing '*'
                    for (int k = i; k <= n; k++)
                    {
                        // Print '*' for boundaries
                        if (i == 1 || k == i || k == n)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }

                    // Move to the next line
                    Console.WriteLine();
                }
            }
            /*=================================================================================================================

                                   PRINTING HALLOW RIGHT ANGLE TRIANGLE

    ==================================================================================================================*/

            public void printHallowRightAngleTriangle(int height)
            {
                Console.WriteLine("PRINTING HALLOW RIGHT ANGLE TRIANGLE");

                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i == 1 || i == 2 || i == height || j == 1 | j == i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            /*=================================================================================================================

                                     PRINTING MIRRORED RIGHT ANGLE TRIANGLE

           ==================================================================================================================*/


            public void printMirroredRightAngleTriangle(int n)
            {
                Console.WriteLine("PRINTING MIRRORED RIGHT ANGLE TRIANGLE");


                for (int row = 1; row <= n; ++row)
                {
                    for (int col = 1; col <= row; ++col)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }

            /*=================================================================================================================

                                  PRINTING HALLOW MIRRORED RIGHT ANGLE TRINAGLE

           ==================================================================================================================*/

            public void printHallowMirroredRightAngleTriangle(int n)
            {
                Console.WriteLine("PRINTING HALLOW MIRRORED RIGHT ANGLE TRINAGLE");
                for (int i = 1; i <= n; i++)
                {
                    // Loop for printing space
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(' ');
                    }

                    // Loop for printing '*'
                    for (int k = 1; k <= i; k++)
                    {
                        // Print '*' for boundaries
                        if (i == n || k == 1 || k == i)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    // Move to the next row
                    Console.WriteLine();
                }
            }

            /* *=================================================================================================================

                                   PRINTING HALLOW INVERTED RIGHT ANGLE TRIANGLE

            ==================================================================================================================*/


            public void printHallowInvertedRightAngleTriangle(int n)
            {
                Console.WriteLine("PRINTING HALLOW INVERTED RIGHT ANGLE TRIANGLE");
                for (int i = n; i >= 1; i--)
                {
                    // Print '*' i times
                    for (int j = 1; j <= i; j++)
                    {
                        {
                            // Print '*' for boundaries
                            if (i == n || j == 1 || j == i)
                            {
                                Console.Write('*');
                            }
                            else
                            {
                                Console.Write(' ');
                            }
                        }
                    }
                    // Move to the next line
                    Console.WriteLine();
                }

            }




        }
    }

