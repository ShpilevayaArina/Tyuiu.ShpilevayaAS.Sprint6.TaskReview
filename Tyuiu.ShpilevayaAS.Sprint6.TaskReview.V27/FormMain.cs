using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShpilevayaAS.Sprint6.TaskReview.V27.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint6.TaskReview.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        int[,] array;
        public static int GenerateRandomNechetNumber(int x, int y)
        {
            Random rnd = new Random();
            int number = 0;
            do
            {
                number = rnd.Next(x, y);
            }
            while (number % 2 != 0);
            return number;
        }
        public static int GenerateRandomChetNumber(int x, int y)
        {
            Random rnd = new Random();
            int number = 0;
            do
            {
                number = rnd.Next(x, y);
            }
            while (number % 2 == 0);
            return number;
        }
        private void buttonDone_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Convert.ToInt32(textBoxNRows_SAS.Text);
                int columns = Convert.ToInt32(textBoxMColumns_SAS.Text);
                Random rnd = new Random();

                int start = Convert.ToInt32(textBoxN1_SAS.Text);
                int stop = Convert.ToInt32(textBoxN2_SAS.Text);

                array = new int[rows, columns];
               

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if ((i == 0) || (i % 2 == 0 ))
                        {
                            array[i, j] = rnd.Next(start, stop);
                            if (array[i, j] % 2 != 0)
                            {
                                array[i, j] = array[i, j] + 1;
                            }

                            if (array[i,j] > stop)
                            {
                                array[i, j] = array[i, j] - 2;
                            }
                        }
                        else
                        {
                            array[i, j] = rnd.Next(start, stop);
                            if (array[i, j] % 2 == 0)
                            {
                                array[i, j] = array[i, j] + 1;
                            }
                            if (array[i, j] > stop)
                            {
                                array[i, j] = array[i, j] - 2;
                            }
                        }

                    }
                }

                dataGridViewMatrix_SAS.ColumnCount = columns;
                dataGridViewMatrix_SAS.RowCount = rows;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMatrix_SAS.Columns[i].Width = 25;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int oj = 0; oj < columns; oj++)
                    {
                        dataGridViewMatrix_SAS.Rows[r].Cells[oj].Value = array[r, oj];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_SAS_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(textBoxR_SAS.Text);
                int k = Convert.ToInt32(textBoxK_SAS.Text);
                int l = Convert.ToInt32(textBoxL_SAS.Text);

                textBoxResult_SAS.Text = Convert.ToString(ds.GetMatrix(array, c, k, l));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
