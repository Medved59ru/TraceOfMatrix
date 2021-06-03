using System;


namespace TraceOfMatrix
{
    public class Matrix
    {
        public static void FillThe(int [,] matrix)
        {
            
            Random filler = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <matrix.GetLength(1); j++)
                {
                    matrix[i, j] = filler.Next(0, 100);
                }
            }
           
        }

        public static int GetTraceOf (int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }

                }
                
            }
            return sum;
        }
    }
}
