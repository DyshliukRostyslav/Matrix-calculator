namespace UnionMath
{
    partial class ResultForm
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
            this.twoGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTriangle = new System.Windows.Forms.Button();
            this.resultRange = new System.Windows.Forms.Button();
            this.resultTranspore = new System.Windows.Forms.Button();
            this.resultDeterminant = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.twoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // twoGroupBox
            // 
            this.twoGroupBox.Controls.Add(this.resultTriangle);
            this.twoGroupBox.Controls.Add(this.resultRange);
            this.twoGroupBox.Controls.Add(this.resultTranspore);
            this.twoGroupBox.Controls.Add(this.resultDeterminant);
            this.twoGroupBox.Controls.Add(this.resultDataGridView);
            this.twoGroupBox.Location = new System.Drawing.Point(71, 5);
            this.twoGroupBox.Name = "twoGroupBox";
            this.twoGroupBox.Size = new System.Drawing.Size(392, 386);
            this.twoGroupBox.TabIndex = 2;
            this.twoGroupBox.TabStop = false;
            this.twoGroupBox.Text = "Matrix";
            // 
            // resultTriangle
            // 
            this.resultTriangle.Location = new System.Drawing.Point(284, 298);
            this.resultTriangle.Name = "resultTriangle";
            this.resultTriangle.Size = new System.Drawing.Size(75, 23);
            this.resultTriangle.TabIndex = 9;
            this.resultTriangle.Text = "Triangle";
            this.resultTriangle.UseVisualStyleBackColor = true;
            this.resultTriangle.Click += new System.EventHandler(this.resultTriangle_Click);
            // 
            // resultRange
            // 
            this.resultRange.Location = new System.Drawing.Point(203, 298);
            this.resultRange.Name = "resultRange";
            this.resultRange.Size = new System.Drawing.Size(75, 23);
            this.resultRange.TabIndex = 9;
            this.resultRange.Text = "Rank";
            this.resultRange.UseVisualStyleBackColor = true;
            // 
            // resultTranspore
            // 
            this.resultTranspore.Location = new System.Drawing.Point(91, 298);
            this.resultTranspore.Name = "resultTranspore";
            this.resultTranspore.Size = new System.Drawing.Size(106, 23);
            this.resultTranspore.TabIndex = 8;
            this.resultTranspore.Text = "Transpose";
            this.resultTranspore.UseVisualStyleBackColor = true;
            this.resultTranspore.Click += new System.EventHandler(this.resultTranspore_Click);
            // 
            // resultDeterminant
            // 
            this.resultDeterminant.Location = new System.Drawing.Point(10, 298);
            this.resultDeterminant.Name = "resultDeterminant";
            this.resultDeterminant.Size = new System.Drawing.Size(75, 23);
            this.resultDeterminant.TabIndex = 6;
            this.resultDeterminant.Text = "Determinant";
            this.resultDeterminant.UseVisualStyleBackColor = true;
            this.resultDeterminant.Click += new System.EventHandler(this.resultDeterminant_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToResizeRows = false;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.ColumnHeadersVisible = false;
            this.resultDataGridView.Location = new System.Drawing.Point(10, 55);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.RowHeadersWidth = 10;
            this.resultDataGridView.Size = new System.Drawing.Size(376, 237);
            this.resultDataGridView.TabIndex = 4;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 403);
            this.Controls.Add(this.twoGroupBox);
            this.Name = "ResultForm";
            this.Text = "Result";
            this.twoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox twoGroupBox;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Button resultDeterminant;
        private System.Windows.Forms.Button resultTranspore;
        private System.Windows.Forms.Button resultRange;
        private System.Windows.Forms.Button resultTriangle;
    }
}