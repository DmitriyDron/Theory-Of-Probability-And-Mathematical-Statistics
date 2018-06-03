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
        
        List<double> Ticker1;
        List<double> Ticker2;
        public KendalCorrelationCoefficient(List<double> X,List<double> Y)
        {
            Ticker1 = X;
            Ticker2 = Y;
            InitializeComponent();
        }
       
        private void lvwValues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KendalCorrelationCoefficient_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            for (int i = 0; i < Ticker1.Count; i++)
                listBox1.Items.Add(Ticker1[i]);

            //
            listBox2.Items.Clear();

            for (int i = 0; i < Ticker2.Count; i++)
                listBox2.Items.Add(Ticker2[i]);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double NbrConcord, NbrDiscord, S;
            NbrConcord = 0;
            NbrDiscord = 0;
            S = 0;

            for (int i = 0; i < Ticker1.Count - 1; i++)
            {
                for (int j = i + 1; j < Ticker1.Count; j++)
                {

                    //Compute the number of concordant pairs
                    if (((Ticker1[i] < Ticker1[j]) & (Ticker2[i] < Ticker2[j])) | ((Ticker1[i] > Ticker1[j]) & (Ticker2[i] > Ticker2[j])))
                    {
                        NbrConcord++;
                    }
                    //Compute the number of discordant pairs
                    else if (((Ticker1[i] > Ticker1[j]) & (Ticker2[i] < Ticker2[j])) | ((Ticker1[i] < Ticker1[j]) & (Ticker2[i] > Ticker2[j])))
                    {
                        NbrDiscord++;
                    }
                }
            }
            S = NbrConcord - NbrDiscord;
            //Proportion with the total pairs
            double r = 2 * S / (Ticker1.Count * (Ticker1.Count - 1));

            txtS.Text = S.ToString("0.00#");
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
