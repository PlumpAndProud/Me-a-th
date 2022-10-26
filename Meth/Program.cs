using System;
using System.Linq; // for Count
using System.Collections.Generic; //for List<>

namespace Meth
{
    class Program
    {
        static void Main(string[] args)
        {

            //1st initialization 

            int variable = 0;

            Console.WriteLine("Halo watchu want?");
            Console.WriteLine("1. Simple calculator!");
            Console.WriteLine("69. Close program!");

            Int32.TryParse(Console.ReadLine(), out variable);

            short error = 3;

            while (error != 69)
            {
                if (error == 1)
                {
                    Console.WriteLine("So watchu want?");
                    Console.WriteLine("1. Simple calculator!");
                    Console.WriteLine("69. Close program!");

                    Int32.TryParse(Console.ReadLine(), out variable);

                }
                else if(error == 0)
                {
                    Console.WriteLine("Is that all?");
                    Console.WriteLine("1. No?");
                    Console.WriteLine("2. Yes?");

                    Int32.TryParse(Console.ReadLine(), out variable);

                }

                if (variable == 2)
                {
                    Environment.Exit(0);
                }


                error = MyPurpose(variable);
            }
        }

        // MyPurpose
        //
        // Input: 
        // variable - user input selecting programme
        //
        // Output:
        // short error: 
        //      0 - no error
        //      1 - error

        public static short MyPurpose(int variable)
        {
            switch (variable)
            {
                case 1:
                    {
                        Calculator();
                        return 0;
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
            short operation = 0;

            Console.WriteLine("Welcome to Simple Calculator." + "\nType in your equation.");

            string userInput = Console.ReadLine();

            while (operation == 0)
            {
                var list = new List<char>();

                char[] userInputArray = userInput.ToCharArray();

                for(int i = 0; i < userInput.Length; i++)
                {
                    list.Add(userInputArray[i]);
                }

                operation = whatOperation(list);

                if (operation == 0)
                {
                    Console.WriteLine("Something went wrong please type your equation once again.");
                    userInput = Console.ReadLine();
                }
            }
        }

        // whatOperation    https://stackoverflow.com/questions/1836959/how-to-add-to-end-of-array-c
        //
        // Input: 
        // userInput - user input of equation eg. 12 + 12
        //
        // Output:
        // short operation: 
        //      0 - error
        //      1 - +
        //      2 - -
        //      3 - * 
        //      4 - / 
        //      5 - ^
        public static short whatOperation(List<char> list)
        {
            int numberOfInput = list.Count();

            list.Add('.');

            char[] userInput = list.ToArray();

            for (int i = 0; i < numberOfInput; i++)
            {
                if (userInput[i + 1] == ' ' && userInput[i + 1] != '.')
                {
                    switch (userInput[i])
                    {

                        case '+':
                            {
                                if (userInput[i + 1] == ' ')
                                {
                                    Console.WriteLine("Its addition");
                                    return 1;
                                }
                                break;
                            }
                        case '-':
                            {
                                if (userInput[i + 1] == ' ')
                                {
                                    Console.WriteLine("Its subtraction");
                                    return 2;
                                }
                                break;
                            }
                        case '*':
                            {
                                if (userInput[i + 1] == ' ')
                                {
                                    Console.WriteLine("Its multiplication");
                                    return 3;
                                }
                                break;
                            }
                        case '/':
                            {
                                if (userInput[i + 1] == ' ')
                                {
                                    Console.WriteLine("Its division");
                                    return 4;
                                }
                                break;
                            }
                        case '^':
                            {
                                if (userInput[i + 1] == ' ')
                                {
                                    Console.WriteLine("Its powering");
                                    return 5;
                                }
                                break;
                            }
                    }
            }

            }
            
            return 0;
        }

    }


}
