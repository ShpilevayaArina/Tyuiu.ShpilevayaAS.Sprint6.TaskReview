using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ShpilevayaAS.Sprint6.TaskReview.V27.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int sum = 0;

            if (c < rows && k < l && l < columns)
            {
                for (int j = k; j <= l; j++)
                {
                    if (array[c,j] % 2 == 0)
                    {
                        sum += array[c, j];
                    }
                }
            }
            return sum;
        }
    }
}
