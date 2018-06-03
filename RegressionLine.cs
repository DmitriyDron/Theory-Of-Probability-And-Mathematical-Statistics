using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ZedGraph;
using System.Collections.Generic;

namespace WindowsApplication2
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class RegressionLine : System.Windows.Forms.Form
    {
        private ZedGraphControl z1;
        private IContainer components;
        private ZedGraphControl zedGraphControl;
        private Button Stat;
        private List<double> Values_X;
        private List<double> Values_Y;
        public List<double> X_Values
        {
            get
            {
                return this.Values_X;
            }
            set
            {
                this.Values_X = value;
            }
        }
        public List<double> Y_Values
        {
            get
            {
                return this.Values_Y;
            }
            set
            {
                this.Values_Y = value;
            }
        }

        public RegressionLine(List<double> Xvalues, List<double> Yvalues)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            Values_X = Xvalues;
            Values_Y = Yvalues;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new Container();
            this.z1 = new ZedGraphControl();
            this.Stat = new Button();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // z1
            // 
            this.z1.Location = new Point(0, 0);
            this.z1.Margin = new Padding(4, 4, 4, 4);
            this.z1.Name = "z1";
            this.z1.ScrollGrace = 0D;
            this.z1.ScrollMaxX = 0D;
            this.z1.ScrollMaxY = 0D;
            this.z1.ScrollMaxY2 = 0D;
            this.z1.ScrollMinX = 0D;
            this.z1.ScrollMinY = 0D;
            this.z1.ScrollMinY2 = 0D;
            this.z1.Size = new Size(200, 185);
            this.z1.TabIndex = 0;
            // 
            // Stat
            // 
            this.Stat.Location = new Point(0, 0);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(75, 23);
            this.Stat.TabIndex = 0;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(-34, -14);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl.Name = "zedGraphControl1";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(816, 478);
            this.zedGraphControl.TabIndex = 1;
            this.zedGraphControl.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // RegressionLine
            // 
            this.ClientSize = new System.Drawing.Size(749, 451);
            this.Controls.Add(this.zedGraphControl);
            this.Name = "RegressionLine";
            this.Load += new System.EventHandler(this.RegressionLine_Load);
            this.ResumeLayout(false);

        }

        private void GetZ1()
        {
            this.z1.Location = new Point(-3, 0);
            this.z1.Margin = new Padding(4, 4, 4, 4);
            this.z1.Name = "z1";
            this.z1.ScrollGrace = 0D;
            this.z1.ScrollMaxX = 0D;
            this.z1.ScrollMaxY = 0D;
            this.z1.ScrollMaxY2 = 0D;
            this.z1.ScrollMinX = 0D;
            this.z1.ScrollMinY = 0D;
            this.z1.ScrollMinY2 = 0D;
            this.z1.Size = new Size(1248, 742);
            this.z1.TabIndex = 0;
        }

        private void GetRegressionLine()
        {
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1243, 735);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.z1);
            this.Name = "RegressionLine";
            this.Text = "Лінія регресії";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private void GetStat()
        {
            this.Stat.BackColor = System.Drawing.Color.Teal;
            this.Stat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stat.ForeColor = System.Drawing.SystemColors.Control;
            this.Stat.Location = new System.Drawing.Point(917, 33);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(286, 72);
            this.Stat.TabIndex = 1;
            this.Stat.Text = "Статистика по лінії регресії";
            this.Stat.UseVisualStyleBackColor = false;
            this.Stat.Click += new EventHandler(Stat_Click);
        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Menu());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //X
            double[] x = new double[Values_X.Count];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Values_X[i];
            }
            //Y
            double[] y = new double[Values_Y.Count];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = Values_Y[i];
            }
            //anomaly_delete

            // create pointpairlist
            PointPairList list = new PointPairList(x, y);
            // create regression pointpairlist, very simple!
            PointPairList regressionList = list.LinearRegression(list, list.Count);
            // add curve
            LineItem line = z1.GraphPane.AddCurve("Some curve", list, Color.Salmon,
            SymbolType.Circle);
            //отрисовка 
            line.Line.IsVisible = false;
            // add regression curve
            LineItem lineReg = z1.GraphPane.AddCurve("Linear regression", regressionList,
            Color.DarkRed, SymbolType.None);

            z1.IsShowPointValues = true;
            z1.AxisChange();
            z1.Invalidate();

        }

        private void Stat_Click(object sender, EventArgs e)
        {
            StatRegression stat = new StatRegression(Values_X, Values_Y);
            stat.Show();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void RegressionLine_Load(object sender, EventArgs e)
        {

        }
    }
}
