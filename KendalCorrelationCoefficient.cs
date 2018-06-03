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
    public partial class KendalCorrelationCoefficient : Form
    {
        private List<double> Ticker1;
        private List<double> Ticker2;
        public List<double> Ticker_1
        {
            get
            {
                return this.Ticker1;
            }
            set
            {
                this.Ticker1 = value;
            }
        }
        public List<double> Ticker_2
        {
            get
            {
                return this.Ticker2;
            }
            set
            {
                this.Ticker2 = value;
            }
        }

        public KendalCorrelationCoefficient(List<double> X, List<double> Y)
        {
            Ticker_1 = X;
            Ticker_2 = Y;
            InitializeComponent();
        }
        private void KendalCorrelationCoefficient_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < Ticker_1.Count; i++)
                listBox1.Items.Add(Ticker_1[i]);

            listBox2.Items.Clear();

            for (int i = 0; i < Ticker_2.Count; i++)
                listBox2.Items.Add(Ticker_2[i]);

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double NbrConcord, NbrDiscord, S;
            NbrConcord = 0;
            NbrDiscord = 0;
            S = 0;

            for (int i = 0; i < Ticker_1.Count - 1; i++)
            {
                for (int j = i + 1; j < Ticker_1.Count; j++)
                {

                    //Compute the number of concordant pairs
                    if (((Ticker_1[i] < Ticker_1[j]) & (Ticker_2[i] < Ticker_2[j])) | ((Ticker_1[i] > Ticker_1[j]) & (Ticker_2[i] > Ticker_2[j])))
                    {
                        NbrConcord++;
                    }
                    //Compute the number of discordant pairs
                    else if (((Ticker_1[i] > Ticker_1[j]) & (Ticker_2[i] < Ticker_2[j])) | ((Ticker_1[i] < Ticker_1[j]) & (Ticker_2[i] > Ticker_2[j])))
                    {
                        NbrDiscord++;
                    }
                }
            }
            S = NbrConcord - NbrDiscord;
            //Proportion with the total pairs
            double r = 2 * S / (Ticker_1.Count * (Ticker_1.Count - 1));

            txtS.Text = S.ToString("0.00#");
            txtResult.Text = r.ToString("0.00#");
            if (r < 1 && r > 0.7)
            {
                MessageBox.Show("Сильний прямий взаємозв'язок");
            }
            else if (r < 0.7 && r > 0.3)
            {
                MessageBox.Show("Слабкий прямий взаємозв'язок");
            }
            else if (r < 0.3 && r > -0.3)
            {
                MessageBox.Show("Взаємозв'язок відсутній");
            }
            else if (r < -0.3 && r > -0.7)
            {
                MessageBox.Show("Слабкий обернений взаємозв'язок");
            }
            else if (r < -0.7 && r > -1)
            {
                MessageBox.Show("Сильний обернений взаємозв'язок");
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void TxtResult_TextChanged(object sender, EventArgs e) { }
    }
}
