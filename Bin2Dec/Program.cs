using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Bin2Dec Converter ---");
            Console.Write("Enter up to 8 binary digits (0 or 1):");
            string bin = Console.ReadLine();
            
            //Size Validation
            if (bin.Length > 8)
            {
                Console.WriteLine("Error: Maximum limit of 8 digits exceeded.");
                return;
            }

            double decimalFinal = 0;
            bool validEnter = true;
            
            //Right-to-left string processing
            for (int i = 0; i < bin.Length; i++)
            {
                char bit = bin[bin.Length - 1 - i];

                if (bit == '0' || bit == '1')
                {
                    if (bit == '1')
                    {
                        //The mathematical function: Value = 2 raised to the bit position.
                        decimalFinal += Math.Pow(2, i);
                    }
                }
                else
                {
                    validEnter = false;
                    break;
                }
            }

            if (validEnter)
            {
                Console.WriteLine($"Decimal result: {decimalFinal}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input! Use only 0 or 1.");
            }
        }
    }
}