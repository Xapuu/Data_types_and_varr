using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceMethodsAndRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wellcome to my basic math quiz.\nGood Luck!");
            double score=0;
            for (int i = 0; i < 4; i++)
            {
                Random numberGenerator = new Random();
                double assigment = numberGenerator.Next(1, 7);
                double firstInput = numberGenerator.Next(1, 11);
                double secondInput = numberGenerator.Next(1, 11);
                double thirdInput = numberGenerator.Next(1, 11);
                

                if (assigment == 1)
                {
                    Console.WriteLine($"What is the area of triangle with side:{firstInput} and height:{secondInput}");
                    double answer = double.Parse(Console.ReadLine());
                    if (answer==triangleSurcoonference(firstInput,secondInput))
                    {
                        Console.WriteLine("Your answer is correct!");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect, try again.");
                        double answerSeccondTry = double.Parse(Console.ReadLine());
                        if (answerSeccondTry==triangleSurcoonference(firstInput,secondInput))
                        {
                            Console.WriteLine("Well done!");
                            score += 0.5;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, press any key to continue.");
                            Console.ReadLine();
                        }
                    }
                }

                if (assigment == 2)
                {
                    Console.WriteLine($"Is it possible for triangle with sizes:{firstInput} , {secondInput}, {thirdInput} .\n type \"true\" or \"false\"");
                    bool answer = bool.Parse(Console.ReadLine().ToLower());
                    if (possibleTriangle(firstInput,secondInput,thirdInput) == answer )
                    {
                        Console.WriteLine("Your answer is correct!");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect, try again.");
                        bool answerSeccondTry = bool.Parse(Console.ReadLine());
                        if (answerSeccondTry == possibleTriangle(firstInput,secondInput,thirdInput))
                        {
                            Console.WriteLine("Well done!");
                            score += 0.5;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, press any key to continue.");
                            Console.ReadLine();
                        }
                    }
                }

                if (assigment == 3)
                {
                    Console.WriteLine($"What is the area of trapezoid with base A:{firstInput} ; base B:{secondInput} and height:{thirdInput}");
                    double answer = double.Parse(Console.ReadLine());
                    if (answer == trapezoidSurcunfer(firstInput,secondInput,thirdInput))
                    {
                        Console.WriteLine("Your answer is correct!");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect, try again.");
                        double answerSeccondTry = double.Parse(Console.ReadLine());
                        if (answerSeccondTry == trapezoidSurcunfer(firstInput, secondInput, thirdInput))
                        {
                            Console.WriteLine("Well done!");
                            score += 0.5;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, press any key to continue.");
                            Console.ReadLine();
                        }
                    }
                }

                if (assigment == 4)
                {
                    Console.WriteLine($"What is the volume of paralelepiped with side A:{firstInput} ; side B:{secondInput} and side C:{thirdInput}");
                    double answer = double.Parse(Console.ReadLine());
                    if (answer ==parallelepipedVolume(firstInput, secondInput, thirdInput))
                    {
                        Console.WriteLine("Your answer is correct!");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect, try again.");
                        double answerSeccondTry = double.Parse(Console.ReadLine());
                        if (answerSeccondTry == parallelepipedVolume(firstInput, secondInput, thirdInput))
                        {
                            Console.WriteLine("Well done!");
                            score += 0.5;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, press any key to continue.");
                            Console.ReadLine();
                        }
                    }
                }
                if (assigment == 5)
                {
                    Console.WriteLine($"What is the surface are of paralelepiped with side A:{firstInput} ; side B:{secondInput} and side C:{thirdInput}");
                    double answer = double.Parse(Console.ReadLine());
                    if (answer == parallepepipedSurfaceArea(firstInput, secondInput, thirdInput))
                    {
                        Console.WriteLine("Your answer is correct!");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect, try again.");
                        double answerSeccondTry = double.Parse(Console.ReadLine());
                        if (answerSeccondTry == parallepepipedSurfaceArea(firstInput, secondInput, thirdInput))
                        {
                            Console.WriteLine("Well done!");
                            score += 0.5;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, press any key to continue.");
                            Console.ReadLine();
                        }
                    }
                }
                if (assigment == 6)
                {
                    Console.WriteLine($"What is the volume of pyramid with side A:{firstInput} ; side B:{secondInput} and height C:{thirdInput}");
                    double answer = double.Parse(Console.ReadLine());
                    if (answer == pyramidVolume(firstInput, secondInput, thirdInput))
                    {
                        Console.WriteLine("Your answer is correct!");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect, try again.");
                        double answerSeccondTry = double.Parse(Console.ReadLine());
                        if (answerSeccondTry == pyramidVolume(firstInput, secondInput, thirdInput))
                        {
                            Console.WriteLine("Well done!");
                            score += 0.5;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, press any key to continue.");
                            Console.ReadLine();
                        }
                    }
                }

            }

            if (score<=1.5)
            {
                Console.WriteLine("You suck!");
            }
            else if (score<=2)
            {
                Console.WriteLine("You are medicore, study harder!");
            }
            else if (score <= 3.5)
            {
                Console.WriteLine("Good Job Lad!");
            }
            else if (score > 3.5)
            {
                Console.WriteLine("You are godlike!!!");
            }
        }

        static double triangleSurcoonference(double num1, double num2)
        {
            return num1 * num2 / 2;
        }
        static bool possibleTriangle (double num1, double num2, double num3)
            {
            return num1+num2>num3&&num1+num3>num2&&num2+num3>num1;
            }

        static double trapezoidSurcunfer (double num1, double num2, double num3)
        {
            return (num1 + num2)/2 * num3;
        }
        static double parallelepipedVolume (double num1, double num2, double num3)
        {
            return num1 * num2 * num3;
        }
        static double parallepepipedSurfaceArea(double num1, double num2, double num3)
        {
            return num1 * num2 * 2 + num2 * num3 * 2 + num1 * num3 * 2;
        }
        static double pyramidVolume (double num1, double num2, double num3)
        {
            return Math.Round(num1 * num2 * num3 / 3, 2);
        }



    }
}
