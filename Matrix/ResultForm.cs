using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnionMath
{
    public partial class ResultForm : Form
    {
        Matrix matrix;
        public ResultForm(Matrix ma)
        {
            InitializeComponent();
            matrix = ma.Clone();
            FillMatrix();
        }

        private void FillMatrix()
        {
            for (int i = 0; i < matrix.Columns; i++)
            {
                resultDataGridView.Columns.Add("", "");
                resultDataGridView.Columns[i].Width = 25;
            }
            for (int i = 0; i < matrix.Rows; i++)
            {
                resultDataGridView.Rows.Add();
            }
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    resultDataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            if (matrix.Rows != matrix.Columns)
            {
                resultTranspore.Enabled = false;
                resultDeterminant.Enabled = false;
                resultRange.Enabled = false;
            }
        }

        private void resultDeterminant_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FuncMatrix.Determinant(matrix).ToString());
        }

        private void resultTranspore_Click(object sender, EventArgs e)
        {
            Matrix m = new Matrix(resultDataGridView.Rows.Count, resultDataGridView.Columns.Count);
            for (int i = 0; i < resultDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < resultDataGridView.Columns.Count; j++)
                {
                    if (resultDataGridView.Rows[i].Cells[j].Value == null)
                        m[i, j] = 0;
                    else
                        m[i, j] = double.Parse(resultDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(~m);
            fr.Show();
        }

        private void resultTriangle_Click(object sender, EventArgs e)
        {
            Matrix m = new Matrix(resultDataGridView.Rows.Count, resultDataGridView.Columns.Count);
            for (int i = 0; i < resultDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < resultDataGridView.Columns.Count; j++)
                {
                    if (resultDataGridView.Rows[i].Cells[j].Value == null)
                        m[i, j] = 0;
                    else
                        m[i, j] = double.Parse(resultDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(FuncMatrix.Triangle(m));
            fr.Show();
        }
    }
}
