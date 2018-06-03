namespace WindowsApplication2
{
    partial class StatRegression
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
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDblR = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtYintercept = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txtMeanY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMeanX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRoot
            // 
            this.txtRoot.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtRoot.Location = new System.Drawing.Point(211, 181);
            this.txtRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(211, 30);
            this.txtRoot.TabIndex = 122;
            this.txtRoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(55, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 121;
            this.label2.Text = "Рівняння регресії";
            // 
            // txtDblR
            // 
            this.txtDblR.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtDblR.Location = new System.Drawing.Point(210, 143);
            this.txtDblR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDblR.Name = "txtDblR";
            this.txtDblR.Size = new System.Drawing.Size(146, 30);
            this.txtDblR.TabIndex = 120;
            this.txtDblR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lb3.Location = new System.Drawing.Point(13, 143);
            this.lb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(189, 23);
            this.lb3.TabIndex = 119;
            this.lb3.Text = "Коефіцієнт кореляції =";
            // 
            // txtSlope
            // 
            this.txtSlope.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSlope.Location = new System.Drawing.Point(650, 107);
            this.txtSlope.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.Size = new System.Drawing.Size(151, 30);
            this.txtSlope.TabIndex = 118;
            this.txtSlope.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lb2.Location = new System.Drawing.Point(464, 105);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(178, 23);
            this.lb2.TabIndex = 117;
            this.lb2.Text = "Коефіціент регресії =";
            // 
            // txtYintercept
            // 
            this.txtYintercept.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtYintercept.Location = new System.Drawing.Point(650, 69);
            this.txtYintercept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYintercept.Name = "txtYintercept";
            this.txtYintercept.Size = new System.Drawing.Size(151, 30);
            this.txtYintercept.TabIndex = 116;
            this.txtYintercept.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb.Location = new System.Drawing.Point(421, 67);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(221, 23);
            this.lb.TabIndex = 115;
            this.lb.Text = "Прогнозований рівень y =";
            // 
            // txtMeanY
            // 
            this.txtMeanY.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMeanY.Location = new System.Drawing.Point(210, 105);
            this.txtMeanY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMeanY.Name = "txtMeanY";
            this.txtMeanY.Size = new System.Drawing.Size(146, 30);
            this.txtMeanY.TabIndex = 114;
            this.txtMeanY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.Location = new System.Drawing.Point(70, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 113;
            this.label1.Text = "Середнє по Y =";
            // 
            // txtMeanX
            // 
            this.txtMeanX.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMeanX.Location = new System.Drawing.Point(211, 69);
            this.txtMeanX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMeanX.Name = "txtMeanX";
            this.txtMeanX.Size = new System.Drawing.Size(146, 30);
            this.txtMeanX.TabIndex = 112;
            this.txtMeanX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(70, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 111;
            this.label5.Text = "Середнє по X =";
            // 
            // StatRegression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 294);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDblR);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.txtSlope);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txtYintercept);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtMeanY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMeanX);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StatRegression";
            this.Text = "Статистика по лінії регресії";
            this.Load += new System.EventHandler(this.StatRegression_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDblR;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txtSlope;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtYintercept;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtMeanY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMeanX;
        private System.Windows.Forms.Label label5;
    }
}