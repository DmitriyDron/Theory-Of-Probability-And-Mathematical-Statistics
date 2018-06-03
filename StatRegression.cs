using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class StatRegression : Form
    {
        private List<double> _X_Values;
        private List<double> _Y_Values;
        public List<double> X_Values
        {
            get
            {
                return this._X_Values;
            }
            set
            {
                this._X_Values = value;
            }
        }
        public List<double> Y_Values
        {
            get
            {
                return this._Y_Values;
            }
            set
            {
                this._Y_Values = value;
            }
        }

        public StatRegression(List<double> X , List<double> Y)
        {
            X_Values = X;
            Y_Values = Y;
            InitializeComponent();
        }

        private void StatRegression_Load(object sender, EventArgs e)
        {
            double sumOfX = 0;
            double sumOfY = 0;
            double sumOfXSq = 0;
            double sumOfYSq = 0;
            double ssX = 0;
            double ssY = 0;
            double sumCodeviates = 0;
            double sCo = 0;
            double count = X_Values.Count;

            for (int ctr = 0; ctr < X_Values.Count; ctr++)
            {
                double x = X_Values[ctr];
                double y = Y_Values[ctr];
                sumCodeviates += x * y;
                sumOfX += x;
                sumOfY += y;
                sumOfXSq += x * x;
                sumOfYSq += y * y;
            }
            ssX = sumOfXSq - ((sumOfX * sumOfX) / count);
            ssY = sumOfYSq - ((sumOfY * sumOfY) / count);
            double RNumerator = (count * sumCodeviates) - (sumOfX * sumOfY);
            double RDenom = (count * sumOfXSq - (sumOfX * sumOfX))
             * (count * sumOfYSq - (sumOfY * sumOfY));
            sCo = sumCodeviates - ((sumOfX * sumOfY) / count);

            double meanX = sumOfX / count;
            double meanY = sumOfY / count;
            double dblR = RNumerator / Math.Sqrt(RDenom);
            double rsquared = dblR * dblR;
            double yintercept = meanY - ((sCo / ssX) * meanX);
            double slope = sCo / ssX;
            txtMeanX.Text = meanX.ToString("0.00#");
            txtMeanY.Text = meanY.ToString("0.00#");
            txtDblR.Text = dblR.ToString("0.00#");;
            txtYintercept.Text = yintercept.ToString("0.00#");
            txtSlope.Text = slope.ToString("0.00#");
            txtRoot.Text = "y=" + slope.ToString("0.00#") + "x+" + yintercept.ToString("0.00#");
        }
    }
}
