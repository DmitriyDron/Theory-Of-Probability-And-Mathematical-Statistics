namespace WindowsApplication2
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbxValues = new System.Windows.Forms.ListBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbyValues = new System.Windows.Forms.ListBox();
            this.AddY = new System.Windows.Forms.Button();
            this.ClearY = new System.Windows.Forms.Button();
            this.ClearX = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.anomy = new System.Windows.Forms.Button();
            this.anomX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(193, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Лінія регресії";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(11, 539);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Гістограма по Х ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(193, 411);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Статистика по X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbxValues
            // 
            this.lbxValues.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbxValues.FormattingEnabled = true;
            this.lbxValues.ItemHeight = 19;
            this.lbxValues.Location = new System.Drawing.Point(11, 145);
            this.lbxValues.Margin = new System.Windows.Forms.Padding(4);
            this.lbxValues.Name = "lbxValues";
            this.lbxValues.Size = new System.Drawing.Size(294, 251);
            this.lbxValues.TabIndex = 3;
            this.lbxValues.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(10, 13);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(611, 81);
            this.txtValue.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(11, 99);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(293, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Додати вибірку Х";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbyValues
            // 
            this.lbyValues.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbyValues.FormattingEnabled = true;
            this.lbyValues.ItemHeight = 19;
            this.lbyValues.Location = new System.Drawing.Point(324, 145);
            this.lbyValues.Margin = new System.Windows.Forms.Padding(4);
            this.lbyValues.Name = "lbyValues";
            this.lbyValues.Size = new System.Drawing.Size(299, 251);
            this.lbyValues.TabIndex = 6;
            this.lbyValues.SelectedIndexChanged += new System.EventHandler(this.lbyValues_SelectedIndexChanged);
            // 
            // AddY
            // 
            this.AddY.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddY.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddY.ForeColor = System.Drawing.SystemColors.Control;
            this.AddY.Location = new System.Drawing.Point(324, 99);
            this.AddY.Margin = new System.Windows.Forms.Padding(4);
            this.AddY.Name = "AddY";
            this.AddY.Size = new System.Drawing.Size(298, 39);
            this.AddY.TabIndex = 7;
            this.AddY.Text = "Додати вибірку У";
            this.AddY.UseVisualStyleBackColor = false;
            this.AddY.Click += new System.EventHandler(this.AddY_Click);
            // 
            // ClearY
            // 
            this.ClearY.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClearY.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearY.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearY.Location = new System.Drawing.Point(446, 411);
            this.ClearY.Margin = new System.Windows.Forms.Padding(4);
            this.ClearY.Name = "ClearY";
            this.ClearY.Size = new System.Drawing.Size(176, 60);
            this.ClearY.TabIndex = 9;
            this.ClearY.Text = "Видалити Y";
            this.ClearY.UseVisualStyleBackColor = false;
            this.ClearY.Click += new System.EventHandler(this.ClearY_Click);
            // 
            // ClearX
            // 
            this.ClearX.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClearX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearX.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearX.Location = new System.Drawing.Point(11, 411);
            this.ClearX.Margin = new System.Windows.Forms.Padding(4);
            this.ClearX.Name = "ClearX";
            this.ClearX.Size = new System.Drawing.Size(175, 60);
            this.ClearX.TabIndex = 10;
            this.ClearX.Text = "Видалити X";
            this.ClearX.UseVisualStyleBackColor = false;
            this.ClearX.Click += new System.EventHandler(this.ClearX_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(193, 479);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 55);
            this.button4.TabIndex = 11;
            this.button4.Text = "Статистика по Y";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(446, 539);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 60);
            this.button5.TabIndex = 12;
            this.button5.Text = "Гістограма по У ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Normal
            // 
            this.Normal.BackColor = System.Drawing.Color.DodgerBlue;
            this.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal.ForeColor = System.Drawing.SystemColors.Control;
            this.Normal.Location = new System.Drawing.Point(11, 606);
            this.Normal.Margin = new System.Windows.Forms.Padding(4);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(293, 62);
            this.Normal.TabIndex = 13;
            this.Normal.Text = "Нормальний розподіл";
            this.Normal.UseVisualStyleBackColor = false;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(315, 606);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(307, 62);
            this.button7.TabIndex = 14;
            this.button7.Text = "Ненормальний розподіл";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // anomy
            // 
            this.anomy.BackColor = System.Drawing.Color.MidnightBlue;
            this.anomy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anomy.ForeColor = System.Drawing.SystemColors.Control;
            this.anomy.Location = new System.Drawing.Point(446, 476);
            this.anomy.Margin = new System.Windows.Forms.Padding(4);
            this.anomy.Name = "anomy";
            this.anomy.Size = new System.Drawing.Size(176, 58);
            this.anomy.TabIndex = 15;
            this.anomy.Text = "Видалити аномальні значення по У";
            this.anomy.UseVisualStyleBackColor = false;
            this.anomy.Click += new System.EventHandler(this.anomy_Click);
            // 
            // anomX
            // 
            this.anomX.BackColor = System.Drawing.Color.MidnightBlue;
            this.anomX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anomX.ForeColor = System.Drawing.SystemColors.Control;
            this.anomX.Location = new System.Drawing.Point(10, 479);
            this.anomX.Margin = new System.Windows.Forms.Padding(4);
            this.anomX.Name = "anomX";
            this.anomX.Size = new System.Drawing.Size(177, 55);
            this.anomX.TabIndex = 16;
            this.anomX.Text = "Видалити аномальні значення по Х";
            this.anomX.UseVisualStyleBackColor = false;
            this.anomX.Click += new System.EventHandler(this.anomX_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 675);
            this.Controls.Add(this.anomX);
            this.Controls.Add(this.anomy);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ClearX);
            this.Controls.Add(this.ClearY);
            this.Controls.Add(this.AddY);
            this.Controls.Add(this.lbyValues);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lbxValues);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Теорія ймовірностей та Математична статистика";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lbxValues;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbyValues;
        private System.Windows.Forms.Button AddY;
        private System.Windows.Forms.Button ClearY;
        private System.Windows.Forms.Button ClearX;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button anomy;
        private System.Windows.Forms.Button anomX;
    }
}