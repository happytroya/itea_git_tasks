using System.Reflection.Metadata;

namespace ExceptionsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            bool error = false;

            int attemps = 0;
            int maxAttemps = 3;
            do
            {
                Console.WriteLine("Choose operation + - * /");
                Methods.CalcAction = Console.ReadLine();

                Console.WriteLine("Enter first value: ");
                string firstValue = Console.ReadLine();

                Console.WriteLine("Enter second value: ");
                string secondValue = Console.ReadLine();

                try
                {
                    attemps++;

                    Methods.Calc(firstValue, secondValue);

                    success = true;
                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Unidentifined error");
                }
            }
            while (!success & !error);
        }
    }
}