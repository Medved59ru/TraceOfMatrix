using System;


namespace TraceOfMatrix
{
    class InputOutput
    {
        public static void Print(int[,] matrix)
        {
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" {0,-3}", matrix[i, j]);
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" {0,-3}", matrix[i, j]);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
                
            }
        }
       
        public static int CheckConsole()
        {
            int enteredNumber;
            while (true)
            {
                Console.WriteLine("HУЖНО ВВЕСТИ ЦЕЛОЕ ЧИСЛО БОЛЬШЕ 0");
                bool parseResult = int.TryParse(Console.ReadLine(), out int numberFromConsole);
                if (parseResult == true && numberFromConsole > 0)
                {
                    enteredNumber = numberFromConsole;
                    break;
                }
            }
            return enteredNumber;
        }
    }
}
