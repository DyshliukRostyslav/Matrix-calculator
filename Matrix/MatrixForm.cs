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
    public partial class MatrixForm : Form
    {
        public MatrixForm()
        {
            InitializeComponent();
            OneFillMatrix();
            TwoFillMatrix();
        }
        private void OneFillMatrix ()
        {
            oneDataGridView.Rows.Clear();
            oneDataGridView.Columns.Clear();
            for (int i = 0; i < oneColumns.Value; i++)
            {
                oneDataGridView.Columns.Add("","");
                oneDataGridView.Columns[i].Width = 25;
            }
            for (int i = 0; i < oneRows.Value; i++)
            {
                oneDataGridView.Rows.Add();
            }
        }

        private void TwoFillMatrix()
        {
            twoDataGridView.Rows.Clear();
            twoDataGridView.Columns.Clear();
            for (int i = 0; i < twoColumns.Value; i++)
            {
                twoDataGridView.Columns.Add("", "");
                twoDataGridView.Columns[i].Width = 25;
            }
            for (int i = 0; i < twoRows.Value; i++)
            {
                twoDataGridView.Rows.Add();
            }
        }

        private void oneRows_ValueChanged(object sender, EventArgs e)
        {
            OneFillMatrix();
            oneDeterminant.Enabled = EqualityOne();
            sumButton.Enabled = Equality();
            subButton.Enabled = Equality();
            oneTranspose.Enabled = EqualityOne();
            oneRange.Enabled = EqualityOne();
            MultiplicationButton.Enabled = EqualityRowsWithColumns();
        }

        private void oneColumns_ValueChanged(object sender, EventArgs e)
        {
            OneFillMatrix();
            oneDeterminant.Enabled = EqualityOne();
            sumButton.Enabled = Equality();
            subButton.Enabled = Equality();
            oneTranspose.Enabled = EqualityOne();
            oneRange.Enabled = EqualityOne();
            MultiplicationButton.Enabled = EqualityRowsWithColumns();
        }

        private void twoRows_ValueChanged(object sender, EventArgs e)
        {
            TwoFillMatrix();
            twoDeterminant.Enabled = EqualityTwo();
            sumButton.Enabled = Equality();
            subButton.Enabled = Equality();
            twoTranspose.Enabled = EqualityTwo();
            twoRange.Enabled = EqualityTwo();
            MultiplicationButton.Enabled = EqualityRowsWithColumns();
        }

        private void twoColumns_ValueChanged(object sender, EventArgs e)
        {
            TwoFillMatrix();
            twoDeterminant.Enabled = EqualityTwo();
            sumButton.Enabled = Equality();
            subButton.Enabled = Equality();
            twoTranspose.Enabled = EqualityTwo();
            twoRange.Enabled = EqualityTwo();
            MultiplicationButton.Enabled = EqualityRowsWithColumns();
        }

        private bool EqualityOne()
        {
            if (oneRows.Value == oneColumns.Value)
                return true;
            else
                return false;
        }
        private bool EqualityTwo()
        {
            if (twoRows.Value == twoColumns.Value)
                return true;
            else
                return false;
        }
        private bool Equality()
        {
            if (oneRows.Value == twoRows.Value && oneColumns.Value == twoColumns.Value)
                return true;
            else
                return false;
        }

        private bool EqualityRowsWithColumns()
        {
            if (oneColumns.Value == twoRows.Value)
                return true;
            else
                return false;
        }

        private void oneDeterminant_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix(oneDataGridView.Rows.Count, oneDataGridView.Columns.Count);
            for(int i = 0; i < oneDataGridView.Rows.Count; i++)
            {
                for(int j = 0; j < oneDataGridView.Columns.Count; j++)
                {
                    if (oneDataGridView.Rows[i].Cells[j].Value == null)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = double.Parse(oneDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            MessageBox.Show(FuncMatrix.Determinant(matrix).ToString());
        }
        

        private void twoDeterminant_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix(twoDataGridView.Rows.Count, twoDataGridView.Columns.Count);
            for (int i = 0; i < twoDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < twoDataGridView.Columns.Count; j++)
                {
                    if (twoDataGridView.Rows[i].Cells[j].Value == null)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = double.Parse(twoDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            MessageBox.Show(FuncMatrix.Determinant(matrix).ToString());
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            Matrix mA = new Matrix(oneDataGridView.Rows.Count, oneDataGridView.Columns.Count);
            Matrix mB = new Matrix(twoDataGridView.Rows.Count, twoDataGridView.Columns.Count);
            for (int i = 0; i < oneDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < oneDataGridView.Columns.Count; j++)
                {
                    if (oneDataGridView.Rows[i].Cells[j].Value == null)
                        mA[i, j] = 0;
                    else
                        mA[i, j] = double.Parse(oneDataGridView.Rows[i].Cells[j].Value.ToString());
                    if (twoDataGridView.Rows[i].Cells[j].Value == null)
                        mB[i, j] = 0;
                    else
                        mB[i, j] = double.Parse(twoDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(mA +mB);
            fr.Show();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            Matrix mA = new Matrix(oneDataGridView.Rows.Count, oneDataGridView.Columns.Count);
            Matrix mB = new Matrix(twoDataGridView.Rows.Count, twoDataGridView.Columns.Count);
            for (int i = 0; i < oneDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < oneDataGridView.Columns.Count; j++)
                {
                    if (oneDataGridView.Rows[i].Cells[j].Value == null)
                        mA[i, j] = 0;
                    else
                        mA[i, j] = double.Parse(oneDataGridView.Rows[i].Cells[j].Value.ToString());
                    if (twoDataGridView.Rows[i].Cells[j].Value == null)
                        mB[i, j] = 0;
                    else
                        mB[i, j] = double.Parse(twoDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(mA - mB);
            fr.Show();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            Matrix mA = new Matrix(oneDataGridView.Rows.Count, oneDataGridView.Columns.Count);
            Matrix mB = new Matrix(twoDataGridView.Rows.Count, twoDataGridView.Columns.Count);
            for (int i = 0; i < oneDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < oneDataGridView.Columns.Count; j++)
                {
                    if (oneDataGridView.Rows[i].Cells[j].Value == null)
                        mA[i, j] = 0;
                    else
                        mA[i, j] = double.Parse(oneDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            for (int i = 0; i < twoDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < twoDataGridView.Columns.Count; j++)
                {
                    if (twoDataGridView.Rows[i].Cells[j].Value == null)
                        mB[i, j] = 0;
                    else
                        mB[i, j] = double.Parse(twoDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(mA * mB);
            fr.Show();
        }

        private void MulConstButton_Click(object sender, EventArgs e)
        {
            Matrix mA = new Matrix(oneDataGridView.Rows.Count, oneDataGridView.Columns.Count);
            for (int i = 0; i < oneDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < oneDataGridView.Columns.Count; j++)
                {
                    if (oneDataGridView.Rows[i].Cells[j].Value == null)
                        mA[i, j] = 0;
                    else
                        mA[i, j] = double.Parse(oneDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm((mA) * (MulConstTextBox.Text != string.Empty ? double.Parse(MulConstTextBox.Text) : 1));
            fr.Show();
        }

        private void oneTranspose_Click(object sender, EventArgs e)
        {
            Matrix mA = new Matrix(oneDataGridView.Rows.Count, oneDataGridView.Columns.Count);
            for (int i = 0; i < oneDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < oneDataGridView.Columns.Count; j++)
                {
                    if (oneDataGridView.Rows[i].Cells[j].Value == null)
                        mA[i, j] = 0;
                    else
                        mA[i, j] = double.Parse(oneDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(~mA);
            fr.Show();
        }

        private void twoTranspore_Click(object sender, EventArgs e)
        {
            Matrix mB = new Matrix(twoDataGridView.Rows.Count, twoDataGridView.Columns.Count);
            for (int i = 0; i < twoDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < twoDataGridView.Columns.Count; j++)
                {
                    if (twoDataGridView.Rows[i].Cells[j].Value == null)
                        mB[i, j] = 0;
                    else
                        mB[i, j] = double.Parse(twoDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(~mB);
            fr.Show();
        }

        private void MulConstTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void oneDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string vlCell = ((TextBox)sender).Text;
            bool temp = (vlCell.IndexOf(".") == -1);
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void oneRange_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix(oneDataGridView.Rows.Count, oneDataGridView.Columns.Count);
            for (int i = 0; i < oneDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < oneDataGridView.Columns.Count; j++)
                {
                    if (oneDataGridView.Rows[i].Cells[j].Value == null)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = double.Parse(oneDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            MessageBox.Show(FuncMatrix.Rank(matrix).ToString());
        }

        private void twoRange_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix(twoDataGridView.Rows.Count, twoDataGridView.Columns.Count);
            for (int i = 0; i < twoDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < twoDataGridView.Columns.Count; j++)
                {
                    if (twoDataGridView.Rows[i].Cells[j].Value == null)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = double.Parse(twoDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            MessageBox.Show(FuncMatrix.Rank(matrix).ToString());
        }

        private void oneTriangle_Click(object sender, EventArgs e)
        {
            Matrix mA = new Matrix(oneDataGridView.Rows.Count, oneDataGridView.Columns.Count);
            for (int i = 0; i < oneDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < oneDataGridView.Columns.Count; j++)
                {
                    if (oneDataGridView.Rows[i].Cells[j].Value == null)
                        mA[i, j] = 0;
                    else
                        mA[i, j] = double.Parse(oneDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(FuncMatrix.Triangle(mA));
            fr.Show();
        }

        private void twoTriangle_Click(object sender, EventArgs e)
        {
            Matrix mB = new Matrix(twoDataGridView.Rows.Count, twoDataGridView.Columns.Count);
            for (int i = 0; i < twoDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < twoDataGridView.Columns.Count; j++)
                {
                    if (twoDataGridView.Rows[i].Cells[j].Value == null)
                        mB[i, j] = 0;
                    else
                        mB[i, j] = double.Parse(twoDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            ResultForm fr = new ResultForm(FuncMatrix.Triangle(mB));
            fr.Show();
        }
    }
}
