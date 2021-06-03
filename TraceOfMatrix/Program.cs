using System;

namespace TraceOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "СЛЕД МАТРИЦЫ";

            Console.Write("ВВЕДИТЕ КОЛИЧЕСТВО СТРОК. ");
            var rowQuantity = InputOutput.CheckConsole();

            Console.Write("ВВЕДИТЕ КОЛИЧЕСТВО СТОЛБЦОВ. ");
            var columnQuantity = InputOutput.CheckConsole();

            int[,] matrix = new int[rowQuantity, columnQuantity];

            Matrix.FillThe(matrix);
            InputOutput.Print(matrix);
                    
            Console.WriteLine("След матрицы равен:  {0}", Matrix.GetTraceOf(matrix));
        }

               
    }
}
