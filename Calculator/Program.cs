using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my calculator!");
            string again = "Y";
            while (again == "Y")
            {
                Console.WriteLine("Enter arithmetic operation: \n+ addition \n- subtraction \n* multiplication \n/ division \n^ exponentiation \n!n factorial");
                string oper = Console.ReadLine();
                switch (oper)
                {
                    case "+":
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the first number:");
                                double firstNumberPlus = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter the second number:");
                                double secondNumberPlus = Convert.ToDouble(Console.ReadLine());
                        
                                double totalPlus = firstNumberPlus + secondNumberPlus;
                                Console.WriteLine($"Addition {firstNumberPlus} and {secondNumberPlus} equally {totalPlus}.");
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The first or second number was entered incorrect. Try again.");
                            }   
                            
                        }
                        break;
                    }
                    case "-":
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the first number:");
                                double firstNumberSubtraction = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter the second number:");
                                double secondNumberSubtraction = Convert.ToDouble(Console.ReadLine());

                                double totalSubtraction = firstNumberSubtraction - secondNumberSubtraction;
                                Console.WriteLine($"Subtraction {firstNumberSubtraction}  and  {secondNumberSubtraction}  equally  {totalSubtraction}.");
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The first or second number was entered incorrect. Try again.");
                            }
                        }
                        break;
                    }
                    case "*":
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the first number:");
                                double firstNumberMultiplication = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter the second number:");
                                double secondNumberMultiplication = Convert.ToDouble(Console.ReadLine());

                                double totalMultiplication = firstNumberMultiplication * secondNumberMultiplication;
                                Console.WriteLine($"Multiplication {firstNumberMultiplication} and {secondNumberMultiplication} equally {totalMultiplication}.");
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The first or second number was entered incorrect. Try again.");
                            }
                        }
                        break;
                    }
                    case "/":
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the first number:");
                                double firstNumberDivision = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter the second number:");
                                double secondNumberDivision = Convert.ToDouble(Console.ReadLine());
                                if (secondNumberDivision != 0)
                                {
                                    double totalDivision = firstNumberDivision / secondNumberDivision;
                                    Console.WriteLine($"Division {firstNumberDivision} and {secondNumberDivision} equally {totalDivision}.");
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Division by zero is prohibited.");
                                }
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The first or second number was entered incorrect. Try again.");
                            }
                        }
                        break;
                    }
                    case "^":
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the number:");
                                double number = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter exponentiation:");
                                double exponentiation = Convert.ToDouble(Console.ReadLine());

                                double totalExponentiation = Math.Pow(number, exponentiation);
                                Console.WriteLine($"Exponentiation {number} to {exponentiation} equally {totalExponentiation}.");
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The number or exponentiation was entered incorrect. Try again.");
                            }
                        }
                        break;
                    }
                    case "!n":
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter the number:");
                                double numberFactorial = Convert.ToDouble(Console.ReadLine());

                                double totalFactorial = Factorial(numberFactorial);
                                Console.WriteLine($"Factorial {numberFactorial} equally {totalFactorial}.");
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The number was entered incorrectly. Try again.");
                            } 
                        }
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Unknown arithmetic operation.");
                        break;
                    }
                }
                Console.WriteLine("Want to start again? \nYes - press \"Y\" \nNo - Any key");
                again = Console.ReadLine();
            }
        }
        static double Factorial(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}


