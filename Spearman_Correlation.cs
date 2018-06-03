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
    public partial class Spearman_Correlation : Form
    {
        List<SamplePair_2> pairs;
        public Spearman_Correlation()
        {
            InitializeComponent();
        }
    
        private void Spearman_Correlation_Load(object sender, EventArgs e)
        {
            pairs = new List<SamplePair_2>();
          
          
        }
        private void ShowPairs()
        {
            lvwValues.Items.Clear();

            double SumX = 0.00, SumY = 0.00,
             SumD = 0.00;



            int i = 0;

            foreach (SamplePair_2 sp in pairs)
            {
                ListViewItem lviPair = new ListViewItem((i + 1).ToString());

                lviPair.SubItems.Add(sp.x.ToString("F"));
                lviPair.SubItems.Add(sp.y.ToString("F"));
                lviPair.SubItems.Add(sp.dx.ToString("0.0000#"));
                lviPair.SubItems.Add(sp.dy.ToString("0.0000#"));
                lviPair.SubItems.Add(sp.rank_d.ToString("0.0000#"));
                lvwValues.Items.Add(lviPair);
               
                i++;
            }

            foreach (SamplePair_2 sp in pairs)
            {
                SumX = sp.x;
                SumY = sp.y;
                SumD += Math.Pow((sp.x - sp.y),2);
                
            }

            ListViewItem lviTotals = new ListViewItem("Totals");
            lviTotals.SubItems.Add("Σx = " + SumX.ToString("F"));
            lviTotals.SubItems.Add("Σy = " + SumY.ToString("F"));
            lviTotals.SubItems.Add("Σd^2 = " + SumD.ToString("0.0000#"));
           
            lvwValues.Items.Add(lviTotals);
            pairs.Sort();
        }
        //end
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double x = 0.00, y = 0.00;

            if (txtX.Text == "")
            {
                MessageBox.Show("Введіть значення x.");
                return;
            }

            if (txtY.Text == "")
            {
                MessageBox.Show("Введіть значення y.");
                return;
            }

            try
            {
                x = double.Parse(txtX.Text);
            }
            catch (FormatException)
            {
            }

            try
            {
                y = double.Parse(txtY.Text);
            }
            catch (FormatException)
            {
            }

            SamplePair_2 pair = new SamplePair_2(x, y);
            pairs.Add(pair);
            ShowPairs();

            txtX.Text = "";
            txtY.Text = "";
            txtX.Focus();

            ShowPairs();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double SumX = 0.00, SumY = 0.00,
                SumD = 0.00, r = 0.00;
          

            foreach (SamplePair_2 sp in pairs)
            {
                SumX += sp.x;
                SumY += sp.y;
                SumD += Math.Pow((sp.x - sp.y), 2);
            }
            double N_Times_SumD = pairs.Count * SumD;

            double N = pairs.Count;
            r = 1 - (6 * (N_Times_SumD / ((Math.Pow(N, 3) - N))));
            txtN.Text = pairs.Count.ToString();
            txtResult.Text = r.ToString("0.00#");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pairs.Clear();
            lvwValues.Items.Clear();

            txtN.Text = "";
            txtX.Text = "";
            txtY.Text = "";
            
            txtResult.Text = "";
        }
    }
    public class SamplePair_2
    {
        public double x { get; set; }
        public double y { get; set; }

        public SamplePair_2(double X, double Y)
        {
            x = X;
            y = Y;
        }
        public double dx
        {
            get
            {
                return x;
            }
        }

        public double dy
        {
            get
            {
                return y;
            }
        }

        public double rank_d
        {
            get
            {
                return Math.Pow((dx-dy),2);
            }
        }
    }
}