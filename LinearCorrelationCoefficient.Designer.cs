namespace WindowsApplication2
{
    partial class LinearCorrelationCoefficient
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
            this.lvwValues = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colXSquared = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYSquared = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colXY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtSumYSquare = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSumXSquare = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSumY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSumX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSumXY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxR = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxR)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwValues
            // 
            this.lvwValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colX,
            this.colY,
            this.colXSquared,
            this.colYSquared,
            this.colXY});
            this.lvwValues.FullRowSelect = true;
            this.lvwValues.GridLines = true;
            this.lvwValues.Location = new System.Drawing.Point(51, 39);
            this.lvwValues.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lvwValues.Name = "lvwValues";
            this.lvwValues.Size = new System.Drawing.Size(831, 624);
            this.lvwValues.TabIndex = 60;
            this.lvwValues.UseCompatibleStateImageBehavior = false;
            this.lvwValues.View = System.Windows.Forms.View.Details;
            this.lvwValues.SelectedIndexChanged += new System.EventHandler(this.lvwValues_SelectedIndexChanged);
            // 
            // colIndex
            // 
            this.colIndex.Text = "#";
            this.colIndex.Width = 40;
            // 
            // colX
            // 
            this.colX.Text = "x";
            this.colX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colX.Width = 70;
            // 
            // colY
            // 
            this.colY.Text = "y";
            this.colY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colY.Width = 70;
            // 
            // colXSquared
            // 
            this.colXSquared.Text = "x²";
            this.colXSquared.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colXSquared.Width = 90;
            // 
            // colYSquared
            // 
            this.colYSquared.Text = "y²";
            this.colYSquared.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colYSquared.Width = 90;
            // 
            // colXY
            // 
            this.colXY.Text = "xy";
            this.colXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colXY.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 819);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 99;
            this.label4.Text = "=";
            // 
            // txtSumYSquare
            // 
            this.txtSumYSquare.Location = new System.Drawing.Point(624, 736);
            this.txtSumYSquare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSumYSquare.Name = "txtSumYSquare";
            this.txtSumYSquare.Size = new System.Drawing.Size(122, 30);
            this.txtSumYSquare.TabIndex = 98;
            this.txtSumYSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 742);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 23);
            this.label9.TabIndex = 97;
            this.label9.Text = "Σy² =";
            // 
            // txtSumXSquare
            // 
            this.txtSumXSquare.Location = new System.Drawing.Point(624, 684);
            this.txtSumXSquare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSumXSquare.Name = "txtSumXSquare";
            this.txtSumXSquare.Size = new System.Drawing.Size(122, 30);
            this.txtSumXSquare.TabIndex = 96;
            this.txtSumXSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 690);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 23);
            this.label10.TabIndex = 95;
            this.label10.Text = "Σx² =";
            // 
            // txtSumY
            // 
            this.txtSumY.Location = new System.Drawing.Point(428, 736);
            this.txtSumY.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSumY.Name = "txtSumY";
            this.txtSumY.Size = new System.Drawing.Size(122, 30);
            this.txtSumY.TabIndex = 94;
            this.txtSumY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 742);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 93;
            this.label7.Text = "Σy =";
            // 
            // txtSumX
            // 
            this.txtSumX.Location = new System.Drawing.Point(428, 684);
            this.txtSumX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSumX.Name = "txtSumX";
            this.txtSumX.Size = new System.Drawing.Size(122, 30);
            this.txtSumX.TabIndex = 92;
            this.txtSumX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 691);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 91;
            this.label8.Text = "Σx =";
            // 
            // txtSumXY
            // 
            this.txtSumXY.Location = new System.Drawing.Point(238, 735);
            this.txtSumXY.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSumXY.Name = "txtSumXY";
            this.txtSumXY.Size = new System.Drawing.Size(120, 30);
            this.txtSumXY.TabIndex = 90;
            this.txtSumXY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 742);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 89;
            this.label6.Text = "Σxy =";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(238, 684);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(120, 30);
            this.txtN.TabIndex = 88;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 690);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 87;
            this.label5.Text = "n =";
            // 
            // pbxR
            // 
            this.pbxR.Location = new System.Drawing.Point(51, 792);
            this.pbxR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pbxR.Name = "pbxR";
            this.pbxR.Size = new System.Drawing.Size(435, 89);
            this.pbxR.TabIndex = 86;
            this.pbxR.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 1071);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 62);
            this.button2.TabIndex = 84;
            this.button2.Text = "Завершити роботу";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(510, 815);
            this.txtR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(111, 30);
            this.txtR.TabIndex = 83;
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(50, 683);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 85;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 1071);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 59);
            this.btnClear.TabIndex = 82;
            this.btnClear.Text = "Видалити/Вимкнути";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // LinearCorrelationCoefficient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 901);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSumYSquare);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSumXSquare);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSumY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSumX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSumXY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lvwValues);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LinearCorrelationCoefficient";
            this.Text = "Нормальний розподіл";
            this.Load += new System.EventHandler(this.LinearCorrelationCoefficient_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbxR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwValues;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colX;
        private System.Windows.Forms.ColumnHeader colY;
        private System.Windows.Forms.ColumnHeader colXSquared;
        private System.Windows.Forms.ColumnHeader colYSquared;
        private System.Windows.Forms.ColumnHeader colXY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSumYSquare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSumXSquare;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSumY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSumX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSumXY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}