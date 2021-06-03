using Microsoft.VisualStudio.TestTools.UnitTesting;
using TraceOfMatrix;
using System;

namespace TraceMatrixTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void GetTraceTest()
        {
            int[,] matrix = new int[3, 3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            int result = Matrix.GetTraceOf(matrix);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void FillMatrixTest()
        {
            int[,] matrix = new int[2, 2];
            Matrix.FillThe(matrix);
            
            Assert.IsNotNull(matrix[0, 0]);
            Assert.IsNotNull(matrix[0, 1]);
            Assert.IsNotNull(matrix[1, 0]);
            Assert.IsNotNull(matrix[1, 1]);


        }
    }
}
