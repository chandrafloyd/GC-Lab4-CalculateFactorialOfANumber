using System;

namespace Lab4_CalculateFactorialOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //WELCOME
            Console.WriteLine("Welcome to the Factorial Calculator!");

            //PROCESS
            bool ContinueProgram = true; //set to true for initial execution and to repeat
            while (ContinueProgram)  //do this as long as ContinueProgram is set to true
            {
                //INPUT -- will loop back to here
                    Console.WriteLine("");
                    Console.WriteLine("Enter an integer greater than 0 but less than 10:");
                    
                    long UserInput = long.Parse(Console.ReadLine());  //user input
                    long Factorial = 1;                               //this holds the result so that the loop can multiply against it
                    Console.WriteLine("");
    
                //PROCESS
                for (long i = 1; i <= UserInput; i++)
                    {
                        Factorial *= i;
                        Console.WriteLine(Factorial);
                    }

                //REPEAT?
                Console.WriteLine("Continue? Y/N");
                string Continue = Console.ReadLine();

                if (Continue == "Y")
                {
                    ContinueProgram = true;
                }

                else
                {
                    ContinueProgram = false;  //set to false to end the loop and exit
                    Console.WriteLine("Goodbye!");
                }

            }

        }

        //public static int CalculateFactorial(long Input) //method for multiplying out the factorial
        //{
        //    long Factorial = UserInput * (UserInput -1);
        //    return Factorial;
                    
        //}
    }
    
}
