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
		private ZedGraph.ZedGraphControl z1;
        private IContainer components;
        List<double> ValuesX;
        private Button Stat;
        List<double> ValuesY;
		public RegressionLine(List<double> Xvalues,List<double> Yvalues)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            //
            ValuesX = Xvalues;
            ValuesY = Yvalues;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.z1 = new ZedGraph.ZedGraphControl();
            this.Stat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(-3, 0);
            this.z1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z1.Name = "z1";
            this.z1.ScrollGrace = 0D;
            this.z1.ScrollMaxX = 0D;
            this.z1.ScrollMaxY = 0D;
            this.z1.ScrollMaxY2 = 0D;
            this.z1.ScrollMinX = 0D;
            this.z1.ScrollMinY = 0D;
            this.z1.ScrollMinY2 = 0D;
            this.z1.Size = new System.Drawing.Size(1248, 742);
            this.z1.TabIndex = 0;
            // 
            // Stat
            // 
            this.Stat.BackColor = System.Drawing.Color.Teal;
            this.Stat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stat.ForeColor = System.Drawing.SystemColors.Control;
            this.Stat.Location = new System.Drawing.Point(917, 33);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(286, 72);
            this.Stat.TabIndex = 1;
            this.Stat.Text = "Статистика по лінії регресії";
            this.Stat.UseVisualStyleBackColor = false;
            this.Stat.Click += new System.EventHandler(this.Stat_Click);
            // 
            // RegressionLine
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1243, 735);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.z1);
            this.Name = "RegressionLine";
            this.Text = "Лінія регресії";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

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

		private void Form1_Load( object sender, EventArgs e )
		{
            //X
            double[] x = new double[ValuesX.Count];
            for(int i =0;i<x.Length;i++)
            {
                x[i] = ValuesX[i];
            }
            //Y
            double[] y = new double[ValuesY.Count];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = ValuesY[i];
            }
            //anomaly_delete

            // create pointpairlist
            PointPairList list = new PointPairList(x,y);
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
            StatRegression stat = new StatRegression(ValuesX,ValuesY);
            stat.Show();
        }
    }
}
