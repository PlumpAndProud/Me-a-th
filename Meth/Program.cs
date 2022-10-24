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
            Console.WriteLine("69. Close program!");

            int variable = Int32.Parse(Console.ReadLine());

            short error = 3;

            while (error != 69)
            {
                if (error == 1)
                {
                    Console.WriteLine("So watchu want?");
                    Console.WriteLine("1. Simple calculator!");
                    Console.WriteLine("69. Close program!");
                    
                }
                else if(error == 0)
                {
                    Console.WriteLine("Is that all?");
                    Console.WriteLine("1. No?");
                    Console.WriteLine("2. Yes?");

                }

                variable = Int32.Parse(Console.ReadLine());
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
                char[] userInputArray = userInput.ToCharArray();

                operation = whatOperation(userInputArray);

                if (operation == 0)
                {
                    Console.WriteLine("Something went wrong please type your equation once again.");
                    userInput = Console.ReadLine();
                }
            }
        }

        // whatOperation
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
        public static short whatOperation(char[] userInput)
        {
            int numberOfInput = userInput.Count();

                for(int i = 0; i < numberOfInput; i++)
                {
                    
                switch (userInput[i])
                    {

                        case '+':
                            {
                                if(userInput[i + 1] == ' ')
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
            
            return 0;
        }

    }


}
