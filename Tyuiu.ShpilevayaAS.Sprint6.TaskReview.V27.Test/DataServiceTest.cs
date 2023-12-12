using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint6.TaskReview.V27.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint6.TaskReview.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 1, 4, 7, 2, 7 },
                                          { 4, 7, 8, 9, 2 },
                                          { 3, 2, 1, 4, 3 },
                                          { 2, 3, 4, 5, 8 },
                                          { 7, 2, 3, 6, 1 } };
            int c = 2;
            int k = 0;
            int l = 3;
            int res = ds.GetMatrix(mas2, c, k, l);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
