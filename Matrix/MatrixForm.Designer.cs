namespace UnionMath
{
    partial class MatrixForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oneGroupBox = new System.Windows.Forms.GroupBox();
            this.oneTriangle = new System.Windows.Forms.Button();
            this.oneRange = new System.Windows.Forms.Button();
            this.oneTranspose = new System.Windows.Forms.Button();
            this.oneDeterminant = new System.Windows.Forms.Button();
            this.oneDataGridView = new System.Windows.Forms.DataGridView();
            this.oneColumns = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.oneRows = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.twoGroupBox = new System.Windows.Forms.GroupBox();
            this.twoTriangle = new System.Windows.Forms.Button();
            this.twoRange = new System.Windows.Forms.Button();
            this.twoTranspose = new System.Windows.Forms.Button();
            this.twoDeterminant = new System.Windows.Forms.Button();
            this.twoDataGridView = new System.Windows.Forms.DataGridView();
            this.twoColumns = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.twoRows = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.MulConstButton = new System.Windows.Forms.Button();
            this.MulConstTextBox = new System.Windows.Forms.TextBox();
            this.oneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneRows)).BeginInit();
            this.twoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoRows)).BeginInit();
            this.SuspendLayout();
            // 
            // oneGroupBox
            // 
            this.oneGroupBox.Controls.Add(this.oneTriangle);
            this.oneGroupBox.Controls.Add(this.oneRange);
            this.oneGroupBox.Controls.Add(this.oneTranspose);
            this.oneGroupBox.Controls.Add(this.oneDeterminant);
            this.oneGroupBox.Controls.Add(this.oneDataGridView);
            this.oneGroupBox.Controls.Add(this.oneColumns);
            this.oneGroupBox.Controls.Add(this.label2);
            this.oneGroupBox.Controls.Add(this.oneRows);
            this.oneGroupBox.Controls.Add(this.label1);
            this.oneGroupBox.Location = new System.Drawing.Point(12, 12);
            this.oneGroupBox.Name = "oneGroupBox";
            this.oneGroupBox.Size = new System.Drawing.Size(392, 386);
            this.oneGroupBox.TabIndex = 0;
            this.oneGroupBox.TabStop = false;
            this.oneGroupBox.Text = "Matrix 1";
            // 
            // oneTriangle
            // 
            this.oneTriangle.Location = new System.Drawing.Point(284, 298);
            this.oneTriangle.Name = "oneTriangle";
            this.oneTriangle.Size = new System.Drawing.Size(75, 23);
            this.oneTriangle.TabIndex = 8;
            this.oneTriangle.Text = "Triangle";
            this.oneTriangle.UseVisualStyleBackColor = true;
            this.oneTriangle.Click += new System.EventHandler(this.oneTriangle_Click);
            // 
            // oneRange
            // 
            this.oneRange.Location = new System.Drawing.Point(203, 298);
            this.oneRange.Name = "oneRange";
            this.oneRange.Size = new System.Drawing.Size(75, 23);
            this.oneRange.TabIndex = 7;
            this.oneRange.Text = "Rank";
            this.oneRange.UseVisualStyleBackColor = true;
            this.oneRange.Click += new System.EventHandler(this.oneRange_Click);
            // 
            // oneTranspose
            // 
            this.oneTranspose.Location = new System.Drawing.Point(91, 299);
            this.oneTranspose.Name = "oneTranspose";
            this.oneTranspose.Size = new System.Drawing.Size(106, 23);
            this.oneTranspose.TabIndex = 6;
            this.oneTranspose.Text = "Transpose";
            this.oneTranspose.UseVisualStyleBackColor = true;
            this.oneTranspose.Click += new System.EventHandler(this.oneTranspose_Click);
            // 
            // oneDeterminant
            // 
            this.oneDeterminant.Location = new System.Drawing.Point(10, 299);
            this.oneDeterminant.Name = "oneDeterminant";
            this.oneDeterminant.Size = new System.Drawing.Size(75, 23);
            this.oneDeterminant.TabIndex = 5;
            this.oneDeterminant.Text = "Determinant";
            this.oneDeterminant.UseVisualStyleBackColor = true;
            this.oneDeterminant.Click += new System.EventHandler(this.oneDeterminant_Click);
            // 
            // oneDataGridView
            // 
            this.oneDataGridView.AllowUserToAddRows = false;
            this.oneDataGridView.AllowUserToDeleteRows = false;
            this.oneDataGridView.AllowUserToResizeRows = false;
            this.oneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oneDataGridView.ColumnHeadersVisible = false;
            this.oneDataGridView.Location = new System.Drawing.Point(10, 55);
            this.oneDataGridView.Name = "oneDataGridView";
            this.oneDataGridView.RowHeadersVisible = false;
            this.oneDataGridView.RowHeadersWidth = 10;
            this.oneDataGridView.Size = new System.Drawing.Size(376, 237);
            this.oneDataGridView.TabIndex = 4;
            this.oneDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.oneDataGridView_EditingControlShowing);
            // 
            // oneColumns
            // 
            this.oneColumns.Location = new System.Drawing.Point(268, 18);
            this.oneColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.oneColumns.Name = "oneColumns";
            this.oneColumns.Size = new System.Drawing.Size(42, 20);
            this.oneColumns.TabIndex = 3;
            this.oneColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.oneColumns.ValueChanged += new System.EventHandler(this.oneColumns_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of columns";
            // 
            // oneRows
            // 
            this.oneRows.Location = new System.Drawing.Point(96, 18);
            this.oneRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.oneRows.Name = "oneRows";
            this.oneRows.Size = new System.Drawing.Size(42, 20);
            this.oneRows.TabIndex = 1;
            this.oneRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.oneRows.ValueChanged += new System.EventHandler(this.oneRows_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of rows";
            // 
            // twoGroupBox
            // 
            this.twoGroupBox.Controls.Add(this.twoTriangle);
            this.twoGroupBox.Controls.Add(this.twoRange);
            this.twoGroupBox.Controls.Add(this.twoTranspose);
            this.twoGroupBox.Controls.Add(this.twoDeterminant);
            this.twoGroupBox.Controls.Add(this.twoDataGridView);
            this.twoGroupBox.Controls.Add(this.twoColumns);
            this.twoGroupBox.Controls.Add(this.label3);
            this.twoGroupBox.Controls.Add(this.twoRows);
            this.twoGroupBox.Controls.Add(this.label4);
            this.twoGroupBox.Location = new System.Drawing.Point(482, 12);
            this.twoGroupBox.Name = "twoGroupBox";
            this.twoGroupBox.Size = new System.Drawing.Size(392, 386);
            this.twoGroupBox.TabIndex = 1;
            this.twoGroupBox.TabStop = false;
            this.twoGroupBox.Text = "Matrix 2";
            // 
            // twoTriangle
            // 
            this.twoTriangle.Location = new System.Drawing.Point(284, 298);
            this.twoTriangle.Name = "twoTriangle";
            this.twoTriangle.Size = new System.Drawing.Size(75, 23);
            this.twoTriangle.TabIndex = 9;
            this.twoTriangle.Text = "Triangle";
            this.twoTriangle.UseVisualStyleBackColor = true;
            this.twoTriangle.Click += new System.EventHandler(this.twoTriangle_Click);
            // 
            // twoRange
            // 
            this.twoRange.Location = new System.Drawing.Point(203, 298);
            this.twoRange.Name = "twoRange";
            this.twoRange.Size = new System.Drawing.Size(75, 23);
            this.twoRange.TabIndex = 8;
            this.twoRange.Text = "Rank";
            this.twoRange.UseVisualStyleBackColor = true;
            this.twoRange.Click += new System.EventHandler(this.twoRange_Click);
            // 
            // twoTranspose
            // 
            this.twoTranspose.Location = new System.Drawing.Point(91, 299);
            this.twoTranspose.Name = "twoTranspose";
            this.twoTranspose.Size = new System.Drawing.Size(106, 23);
            this.twoTranspose.TabIndex = 7;
            this.twoTranspose.Text = "Transpose";
            this.twoTranspose.UseVisualStyleBackColor = true;
            this.twoTranspose.Click += new System.EventHandler(this.twoTranspore_Click);
            // 
            // twoDeterminant
            // 
            this.twoDeterminant.Location = new System.Drawing.Point(10, 299);
            this.twoDeterminant.Name = "twoDeterminant";
            this.twoDeterminant.Size = new System.Drawing.Size(75, 23);
            this.twoDeterminant.TabIndex = 6;
            this.twoDeterminant.Text = "Determinant";
            this.twoDeterminant.UseVisualStyleBackColor = true;
            this.twoDeterminant.Click += new System.EventHandler(this.twoDeterminant_Click);
            // 
            // twoDataGridView
            // 
            this.twoDataGridView.AllowUserToAddRows = false;
            this.twoDataGridView.AllowUserToDeleteRows = false;
            this.twoDataGridView.AllowUserToResizeRows = false;
            this.twoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.twoDataGridView.ColumnHeadersVisible = false;
            this.twoDataGridView.Location = new System.Drawing.Point(10, 55);
            this.twoDataGridView.Name = "twoDataGridView";
            this.twoDataGridView.RowHeadersVisible = false;
            this.twoDataGridView.RowHeadersWidth = 10;
            this.twoDataGridView.Size = new System.Drawing.Size(376, 237);
            this.twoDataGridView.TabIndex = 4;
            // 
            // twoColumns
            // 
            this.twoColumns.Location = new System.Drawing.Point(268, 18);
            this.twoColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.twoColumns.Name = "twoColumns";
            this.twoColumns.Size = new System.Drawing.Size(42, 20);
            this.twoColumns.TabIndex = 3;
            this.twoColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.twoColumns.ValueChanged += new System.EventHandler(this.twoColumns_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of columns";
            // 
            // twoRows
            // 
            this.twoRows.Location = new System.Drawing.Point(96, 18);
            this.twoRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.twoRows.Name = "twoRows";
            this.twoRows.Size = new System.Drawing.Size(42, 20);
            this.twoRows.TabIndex = 1;
            this.twoRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.twoRows.ValueChanged += new System.EventHandler(this.twoRows_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of rows";
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumButton.Location = new System.Drawing.Point(420, 17);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(47, 42);
            this.sumButton.TabIndex = 2;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // subButton
            // 
            this.subButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subButton.Location = new System.Drawing.Point(420, 65);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(47, 42);
            this.subButton.TabIndex = 3;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplicationButton.Location = new System.Drawing.Point(420, 113);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(47, 42);
            this.MultiplicationButton.TabIndex = 4;
            this.MultiplicationButton.Text = "*";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // MulConstButton
            // 
            this.MulConstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MulConstButton.Location = new System.Drawing.Point(446, 161);
            this.MulConstButton.Name = "MulConstButton";
            this.MulConstButton.Size = new System.Drawing.Size(21, 20);
            this.MulConstButton.TabIndex = 5;
            this.MulConstButton.Text = "*";
            this.MulConstButton.UseVisualStyleBackColor = true;
            this.MulConstButton.Click += new System.EventHandler(this.MulConstButton_Click);
            // 
            // MulConstTextBox
            // 
            this.MulConstTextBox.Location = new System.Drawing.Point(420, 161);
            this.MulConstTextBox.Name = "MulConstTextBox";
            this.MulConstTextBox.Size = new System.Drawing.Size(20, 20);
            this.MulConstTextBox.TabIndex = 6;
            this.MulConstTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MulConstTextBox_KeyPress);
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 410);
            this.Controls.Add(this.MulConstTextBox);
            this.Controls.Add(this.MulConstButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.twoGroupBox);
            this.Controls.Add(this.oneGroupBox);
            this.Name = "MatrixForm";
            this.Text = "Matrix Calculator";
            this.oneGroupBox.ResumeLayout(false);
            this.oneGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneRows)).EndInit();
            this.twoGroupBox.ResumeLayout(false);
            this.twoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox oneGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown oneRows;
        private System.Windows.Forms.NumericUpDown oneColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView oneDataGridView;
        private System.Windows.Forms.GroupBox twoGroupBox;
        private System.Windows.Forms.DataGridView twoDataGridView;
        private System.Windows.Forms.NumericUpDown twoColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown twoRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button oneDeterminant;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button twoDeterminant;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button MulConstButton;
        private System.Windows.Forms.TextBox MulConstTextBox;
        private System.Windows.Forms.Button oneTranspose;
        private System.Windows.Forms.Button twoTranspose;
        private System.Windows.Forms.Button oneRange;
        private System.Windows.Forms.Button twoRange;
        private System.Windows.Forms.Button oneTriangle;
        private System.Windows.Forms.Button twoTriangle;
    }
}