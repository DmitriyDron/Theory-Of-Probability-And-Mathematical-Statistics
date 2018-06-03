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
   public partial class LinearCorrelationCoefficient : Form
    {

        private double[] X_Value;
        private double[] Y_Value;
        private List<SamplePair> _Pairs;
        private SamplePair[] _samplePair;
        public double [] X
        {
            get
            {
                return this.X_Value;
            }
            set
            {
                this.X_Value = value;
            }
        }
        public double [] Y
        {
            get
            {
                return this.Y_Value;
            }
            set
            {
                this.Y_Value = value;
            }
        }
        public List<SamplePair> Pairs
        {
            get
            {
                return this._Pairs;
            }
            set
            {
                this._Pairs = value;
            }
        }
        public SamplePair[] samplePair
        {
            get
            {
                return this._samplePair;
            }
            set
            {
                this._samplePair = value;
            }
        }

        //
        public LinearCorrelationCoefficient(double[] Xvalues, double[] Yvalues)
        {
            //
            InitializeComponent();
            X = Xvalues;
            Y = Yvalues;
            X = new double[Xvalues.Length];
            Y = new double[Yvalues.Length];
            //
            for (int i = 0; i < Xvalues.Length; i++)
            {
                X[i] = Xvalues[i];
            }
            for (int i = 0; i < Yvalues.Length; i++)
            {
                Y[i] = Yvalues[i];
            }
            //
            samplePair = new SamplePair[Xvalues.Length];
            //
            for (int i = 0; i < Xvalues.Length; i++)
            {
                samplePair[i] = new SamplePair(X[i], Y[i]);
            }
        }
        //
        private void LinearCorrelationCoefficient_Load(object sender, EventArgs e)
        {
            Pairs = new List<SamplePair>();
            ShowPairs();
        }
        private void ShowPairs()
        {
            lvwValues.Items.Clear();

            double SumX = 0.00, SumY = 0.00,
                   SumXSquare = 0.00, SumYSquare = 0.00,
                   SumXY = 0.00;

            int i = 0;
            foreach (SamplePair sp in samplePair)
            {
                ListViewItem lviPair = new ListViewItem((i + 1).ToString());

                lviPair.SubItems.Add(sp.x.ToString("F"));
                lviPair.SubItems.Add(sp.y.ToString("F"));
                lviPair.SubItems.Add(sp.xSquared.ToString("0.0000#"));
                lviPair.SubItems.Add(sp.ySquared.ToString("0.0000#"));
                lviPair.SubItems.Add(sp.xy.ToString("0.0000#"));
                lvwValues.Items.Add(lviPair);

                i++;
            }

            foreach (SamplePair sp in samplePair)
            {
                SumX += sp.x;
                SumY += sp.y;
                SumXSquare += (sp.x * sp.x);
                SumYSquare += (sp.y * sp.y);
                SumXY += (sp.x * sp.y);
            }

            ListViewItem lviTotals = new ListViewItem("Totals");
            lviTotals.SubItems.Add("?x = " + SumX.ToString("F"));
            lviTotals.SubItems.Add("?y = " + SumY.ToString("F"));
            lviTotals.SubItems.Add("?x? = " + SumXSquare.ToString("0.0000#"));
            lviTotals.SubItems.Add("?y? = " + SumYSquare.ToString("0.0000#"));
            lviTotals.SubItems.Add("?xy = " + SumXY.ToString("0.0000#"));
            lvwValues.Items.Add(lviTotals);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e) { }
        private void btnClear_Click_1(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowPairs();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double SumX = 0.00, SumY = 0.00,
                SumXSquare = 0.00, SumYSquare = 0.00,
                SumXY = 0.00, r = 0.00;

            foreach (SamplePair sp in samplePair)
            {
                SumX += sp.x;
                SumY += sp.y;
                SumXSquare += (sp.x * sp.x);
                SumYSquare += (sp.y * sp.y);
                SumXY += (sp.x * sp.y);
            }

            double NTimesSumXY = samplePair.Length * SumXY;
            double SumXTimesSumY = SumX * SumY;
            double SquareRoot1 = samplePair.Length * SumXSquare - Math.Pow(SumX, 2);
            double SquareRoot2 = samplePair.Length * SumYSquare - Math.Pow(SumY, 2);

            r = (NTimesSumXY - SumXTimesSumY) / (Math.Sqrt(SquareRoot1) * Math.Sqrt(SquareRoot2));

            txtN.Text = samplePair.Length.ToString();
            txtSumX.Text = SumX.ToString("F");
            txtSumY.Text = SumY.ToString("F");
            txtSumXSquare.Text = SumXSquare.ToString();
            txtSumYSquare.Text = SumYSquare.ToString();
            txtSumXY.Text = SumXY.ToString("F");

            txtR.Text = r.ToString("0.00#");
            if (r < 1 && r > 0.9)
            {
                MessageBox.Show("Сильний прямий взаємозв'язок");
            }
            else if (r < 0.9 && r > 0.3)
            {
                MessageBox.Show("Слабкий прямий взаємозв'язок");
            }
            else if (r < 0.3 && r > -0.3)
            {
                MessageBox.Show("Взаємозв'язок відсутній");
            }
            else if (r < -0.3 && r > -0.9)
            {
                MessageBox.Show("Слабкий обернений взаємозв'язок");
            }
            else if (r < -0.9 && r > -1)
            {
                MessageBox.Show("Сильний обернений взаємозв'язок");
            }
        }

        private void LinearCorrelationCoefficient_Load_1(object sender, EventArgs e)
        {
            ShowPairs();
        }

        private void lvwValues_SelectedIndexChanged(object sender, EventArgs e) { }
    }
    public class SamplePair
    {
        public double x { get; set; }
        public double y { get; set; }

        public SamplePair(double X, double Y)
        {
            x = X;
            y = Y;
        }
        public double xSquared
        {
            get
            {
                return x * x;
            }
        }

        public double ySquared
        {
            get
            {
                return y * y;
            }
        }

        public double xy
        {
            get
            {
                return x * y;
            }
        }
    }
}
