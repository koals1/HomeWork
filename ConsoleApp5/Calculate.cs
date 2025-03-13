//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace ConsoleApp5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool isRunning = true;

//            while (isRunning)
//            {
//                try
//                {
//                    Console.Clear();
//                    Console.WriteLine("Calculator for Number System Conversion");
//                    Console.WriteLine("---------------------------------------");
//                    Console.WriteLine("Choose conversion direction:");
//                    Console.WriteLine("1. Decimal to Binary");
//                    Console.WriteLine("2. Decimal to Octal");
//                    Console.WriteLine("3. Decimal to Hexadecimal");
//                    Console.WriteLine("4. Binary to Decimal");
//                    Console.WriteLine("5. Octal to Decimal");
//                    Console.WriteLine("6. Hexadecimal to Decimal");
//                    Console.WriteLine("0. Exit");
//                    Console.Write("\nYour choice: ");

//                    string choice = Console.ReadLine();

//                    switch (choice)
//                    {
//                        case "0":
//                            isRunning = false;
//                            break;
//                        case "1":
//                            ConvertDecimalToBinary();
//                            break;
//                        case "2":
//                            ConvertDecimalToOctal();
//                            break;
//                        case "3":
//                            ConvertDecimalToHexadecimal();
//                            break;
//                        case "4":
//                            ConvertBinaryToDecimal();
//                            break;
//                        case "5":
//                            ConvertOctalToDecimal();
//                            break;
//                        case "6":
//                            ConvertHexadecimalToDecimal();
//                            break;
//                        default:
//                            Console.WriteLine("Invalid choice. Please select an option from the menu.");
//                            break;
//                    }

//                    if (isRunning)
//                    {
//                        Console.WriteLine("\nPress any key to continue...");
//                        Console.ReadKey();
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Error: {ex.Message}");
//                    Console.WriteLine("\nPress any key to continue...");
//                    Console.ReadKey();
//                }
//            }
//        }

//        static void ConvertDecimalToBinary()
//        {
//            Console.Write("\nEnter a decimal number: ");
//            if (!TryParseInt(Console.ReadLine(), out int decimalNumber))
//                return;

//            string binaryResult = Convert.ToString(decimalNumber, 2);
//            Console.WriteLine($"Decimal {decimalNumber} = Binary {binaryResult}");
//        }

//        static void ConvertDecimalToOctal()
//        {
//            Console.Write("\nEnter a decimal number: ");
//            if (!TryParseInt(Console.ReadLine(), out int decimalNumber))
//                return;

//            string octalResult = Convert.ToString(decimalNumber, 8);
//            Console.WriteLine($"Decimal {decimalNumber} = Octal {octalResult}");
//        }

//        static void ConvertDecimalToHexadecimal()
//        {
//            Console.Write("\nEnter a decimal number: ");
//            if (!TryParseInt(Console.ReadLine(), out int decimalNumber))
//                return;

//            string hexResult = Convert.ToString(decimalNumber, 16).ToUpper();
//            Console.WriteLine($"Decimal {decimalNumber} = Hexadecimal {hexResult}");
//        }

//        static void ConvertBinaryToDecimal()
//        {
//            Console.Write("\nEnter a binary number: ");
//            string input = Console.ReadLine();
//            if (!IsValidInput(input, 2))
//                return;

//            if (!TryParseInt(input, out int decimalValue, 2))
//                return;

//            Console.WriteLine($"Binary {input} = Decimal {decimalValue}");
//        }

//        static void ConvertOctalToDecimal()
//        {
//            Console.Write("\nEnter an octal number: ");
//            string input = Console.ReadLine();
//            if (!IsValidInput(input, 8))
//                return;

//            if (!TryParseInt(input, out int decimalValue, 8))
//                return;

//            Console.WriteLine($"Octal {input} = Decimal {decimalValue}");
//        }

//        static void ConvertHexadecimalToDecimal()
//        {
//            Console.Write("\nEnter a hexadecimal number: ");
//            string input = Console.ReadLine();
//            if (!IsValidInput(input, 16))
//                return;

//            if (!TryParseInt(input, out int decimalValue, 16))
//                return;

//            Console.WriteLine($"Hexadecimal {input} = Decimal {decimalValue}");
//        }

//        static bool IsValidInput(string input, int baseSystem)
//        {
//            if (string.IsNullOrWhiteSpace(input))
//            {
//                Console.WriteLine("Input cannot be empty.");
//                return false;
//            }

//            const string allowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//            foreach (char c in input.ToUpper())
//            {
//                if (allowedChars.IndexOf(c) == -1 || allowedChars.IndexOf(c) >= baseSystem)
//                {
//                    Console.WriteLine($"Invalid character '{c}' for base {baseSystem}.");
//                    return false;
//                }
//            }

//            return true;
//        }

//        static bool TryParseInt(string input, out int result, int fromBase = 10)
//        {
//            try
//            {
//                result = Convert.ToInt32(input, fromBase);
//                return true;
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Invalid number format.");
//                result = 0;
//                return false;
//            }
//            catch (OverflowException)
//            {
//                Console.WriteLine("Number is out of range for an int.");
//                result = 0;
//                return false;
//            }
//            catch (ArgumentException)
//            {
//                Console.WriteLine("Invalid argument for the conversion.");
//                result = 0;
//                return false;
//            }
//        }
//    }
//}
