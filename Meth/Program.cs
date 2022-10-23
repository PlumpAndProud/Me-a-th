using System;
using System.Linq; // for Count

namespace Meth
{
    class Program
    {
        static void Main(string[] args)
        {

            //1st initialization 

            Console.WriteLine("Halo watchu want?");
            Console.WriteLine("1. Simple calculator!");

            int variable = Int32.Parse(Console.ReadLine());

            short error = 3;

            while (error != 69)
            {
                if (error == 1)
                {
                    Console.WriteLine("So watchu want?");
                    Console.WriteLine("1. Simple calculator!");

                    variable = Int32.Parse(Console.ReadLine());
                }
                else if(error == 0)
                {
                    Console.WriteLine("Is that all?");
                    Console.WriteLine("1. No?");
                    Console.WriteLine("69. Yes?");

                    variable = Int32.Parse(Console.ReadLine());
                }

                error = MyPurpose(variable);
            }
        }

        // Input: 
        // variable - user input selecting programme
        //
        // Output:
        // short error: 
        //      0 - no error
        //      1 - error
        //      69 - end programme

        public static short MyPurpose(int variable)
        {
            switch (variable)
            {
                case 1:
                    {
                        Calculator();
                        return 0;
                    }
                case 69:
                    {
                        return 69;
                    }
                default:
                    {
                        Console.WriteLine("Whot, that must've been a missinput");
                        return 1;
                    }
            }
        }

        public static void Calculator()
        {
            Console.WriteLine("Welcome to Simple Calculator." + "\nType in your equation.");

            string userInput = Console.ReadLine();

            char[] userInputInChars = userInput.ToCharArray();

            short operation = whatOperation(userInputInChars);
        }

        // Input: 
        // userInput - user input of equation eg. 12 + 12
        //
        // Output:
        // short operation: 
        //      1 - +
        //      2 - -
        //      3 - * 
        //      4 - / 
        //      5 - ^
        public static short whatOperation(char[] userInput)
        {
            
                int numberOfInput = userInput.Count();

                for(int i = 0; i <= numberOfInput; i++)
                {
                    switch (userInput[i])
                    {
                        case '+':
                            {
                                Console.WriteLine("Its addition");
                                return 1;
                            }
                        case '-':
                            {
                                Console.WriteLine("Its subtraction");
                                return 2;
                            }
                        case '*':
                            {
                                Console.WriteLine("Its multiplication");
                                return 3;
                            }
                        case '/':
                            {
                                Console.WriteLine("Its division");
                                return 4;
                            }
                        case '^':
                            {
                                Console.WriteLine("Its powering");
                                return 5;
                            }
                    }
                }
            return 0;
        }

    }
}
