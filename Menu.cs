using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace WindowsApplication2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        List<double> Xvalues;
        List<double> Yvalues;
        private void Menu_Load(object sender, EventArgs e)
        {
            Xvalues = new List<double>();
            Yvalues = new List<double>();
        }
        void ShowValuesX()
        {
            lbxValues.Items.Clear();

            for (int i = 0; i < Xvalues.Count; i++)
                lbxValues.Items.Add(Xvalues[i]);
        }
        void ShowValuesY()
        {
            lbyValues.Items.Clear();

            for (int i = 0; i < Yvalues.Count; i++)
                lbyValues.Items.Add(Yvalues[i]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RegressionLine frm1 = new RegressionLine(Xvalues,Yvalues);
            {
                frm1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Histograms frm2 = new Histograms(Xvalues);
            {
                frm2.Show();
            }
        }
        //STATISTIC
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //
            stringBuilder.Append("Математичне очікування дорівнює : " + MathExpectation(Xvalues));
            stringBuilder.Append("\n\nДисперсия : " + Variance(Xvalues));
            stringBuilder.Append("\n\nСереднє квадратичне відхилення : " + Deviation(Xvalues));
            stringBuilder.Append("\n\nМода : "+Mode(Xvalues).ToString("0.000#"));
            stringBuilder.Append("\n\nВерхня інтервальна межа : " + UpperBound(Xvalues) + "\nНижня інтервальна межа : "+LowerBound(Xvalues));
            stringBuilder.Append("\n\nКоефіцієнт Асиметрії : " + AssymetryCoef(Xvalues));
            stringBuilder.Append("\n\nКоефіцієнт Ексцессу : " + ExcessCoef(Xvalues));
            stringBuilder.Append("\n\nЗакон розподілу за коефіцієнтом Асиметрії : " + AsymetryLaw(Xvalues) + "\n\nЗакон розподілу за коефіцієнтом Ексцессу : " + ExcessLaw(Xvalues));
            //stringBuilder.Append("\n-----------------------------------------------------------------\n");
            //stringBuilder.Append("\nАномальні значення виборки : "+AnomalyNums(Xvalues,Yvalues)+"\n");
            //stringBuilder.Append("\n-----------------------------------------------------------------");
            //stringBuilder.Append("\n\nНове Математичне очікування дорівнює : " + MathExpectation(Xvalues));
            //stringBuilder.Append("\n\nНова Дисперсия : " + Variance(Xvalues));
            //stringBuilder.Append("\n\nНове Середнє квадратичне відхилення : " + Deviation(Xvalues));
            //stringBuilder.Append("\n\nНова Мода : " + Mode(Xvalues));
            //stringBuilder.Append("\n\nВерхня інтервальна межа : " + UpperBound(Xvalues) + "\nНижня інтервальна межа : " + LowerBound(Xvalues)); //OPTIONAL - скорее всего надо будет удалить это
            //stringBuilder.Append("\n\nКоефіцієнт Асиметрії : " + AssymetryCoef(Xvalues));
            //stringBuilder.Append("\n\nКоефіцієнт Ексцессу : " + ExcessCoef(Xvalues));
            //stringBuilder.Append("\n\nЗакон розподілу за коефіцієнтом Асиметрії : " + AsymetryLaw(Xvalues) + "\n\nЗакон розподілу за коефіцієнтом Ексцессу : " + ExcessLaw(Xvalues));
            //
            MessageBox.Show(stringBuilder.ToString());
        }
        //VARIANCE
        double Variance(List<double> inputValues)
        {
            double variance = 0;
            double mean = MathExpectation(inputValues);
            for (int i = 0; i < inputValues.Count; i++)
            {
                variance += Math.Pow((inputValues[i] - mean), 2);
            }
            return variance / (inputValues.Count);
        }
        //MATH_EXPECTION
        double MathExpectation(List<double> inputValues)
        {
            double result = 0;
            double sum = 0;
            foreach (double x in inputValues)
            {
                sum += x;
            }
          return result = sum / inputValues.Count;
        }
        //DEVIATION
        double Deviation(List<double> inputValues)
        {
            double result = Variance(inputValues);
            return Math.Sqrt(result);
        }
        //AssYMETRY
        double AssymetryCoef(List<double> inputValues)
        {
            double mean = MathExpectation(inputValues);
            //
            double centralMoment = 0;
            for (int i = 0; i < inputValues.Count; i++)
            {
                centralMoment += (Math.Pow((inputValues[i] - mean), 3));
            }
            //
            double u3 = centralMoment ;
            return u3/((Math.Pow(Deviation(inputValues),3))*inputValues.Count);
        }
        //EXCESS
        double ExcessCoef(List<double> inputValues)
        {
            double mean = MathExpectation(inputValues);
            //
            double centralMoment = 0;
            for (int i = 0; i < inputValues.Count; i++)
            {
                centralMoment += (Math.Pow((inputValues[i] - mean), 4));
            }
            //
            double u4 = centralMoment;
            return ((u4 / ((Math.Pow(Deviation(inputValues), 4))* inputValues.Count))-3);
        }
        //ANOMALY_NUMS
        string AnomalyNums(List<double> inputValuesX,List<double> inputValuesY)
        {
            string anomalyNums = null;
            double anomalyCoef = 1.96; 
            //
            foreach (double x in inputValuesX.ToArray())
            {
                if( (Math.Abs(x-MathExpectation(inputValuesX))/Deviation(inputValuesX)) > anomalyCoef )
                {
                    anomalyNums += " "+x.ToString()+",";
                    inputValuesX.Remove(x);
                    inputValuesY.Remove(x);
                    //rec
                    AnomalyNums(inputValuesX,inputValuesY);
                }

            }
            //
            return anomalyNums;
        }
        //MODE
        double Mode (List<double> inputValues)
        {
            var groups = inputValues.GroupBy(v => v);
            double maxCount = groups.Max(g => g.Count());
            double mode = groups.First(g => g.Count() == maxCount).Key;
            //
            return mode;
        }
        //UPPER_BOUND
        double UpperBound(List<double> inputValues)
        {
            double anomalyCoef = 1.96;
            double upperbound = (anomalyCoef * Deviation(inputValues)) / Math.Sqrt(inputValues.Count);
            return MathExpectation(inputValues)+ upperbound;
        }
        //LOWER_BOUND
        double LowerBound(List<double> inputValues)
        {
            double anomalyCoef = 1.96;
            double lowerbound = (anomalyCoef * Deviation(inputValues)) / Math.Sqrt(inputValues.Count);
            return MathExpectation(inputValues) - lowerbound;
        }
        //ASYMETRY_LAW
        string AsymetryLaw(List<double> inputValues)
        {
            string result = null;
            if(AssymetryCoef(inputValues)>0)
            {
                result = "Мода знаходиться лівіше за середнє значення, а отже діаграма право-випадна";
            }
            else
            {
                result = "Мода знаходиться правіше за середнє значення, а отже діаграма ліво-випадна";
            }
            return result;
        }
        //EXCESS_LAW
        string ExcessLaw(List<double> inputValues)
        {
            string result = null;
            if(ExcessCoef(inputValues)>0)
            {
                result = "Крива розподілення островершинна";
            }
            else
            {
                result = "Крива розподілена плосковершинна";
            }
            return result;
        }
        //
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // This the value that will be added to the text box
            double value = 0.00;
            // Check that the user entered a value in the text box
            if (txtValue.Text.Length == 0)
            {
                MessageBox.Show("You must enter a value.", "Warning!");
                return;
            }
            try
            {
                string[] subStrings = txtValue.Text.Split(',');
                foreach (string x in subStrings)
                {
                    value = double.Parse(x, CultureInfo.InvariantCulture);
                    Xvalues.Add(value);
                }
                ShowValuesX();
                txtValue.Text = "";
                txtValue.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("The value you entered is invalid.",
                                "Warning!");
            }

        }
        private void AddY_Click(object sender, EventArgs e)
        {
            // This the value that will be added to the text box
            double value ;
            // Check that the user entered a value in the text box
            if (txtValue.Text.Length == 0)
            {
                MessageBox.Show("You must enter a value.", "Warning");
                return;
            }

            try
            {
                string[] subStrings = txtValue.Text.Split(',');
                foreach (string x in subStrings)
                {
                    value = double.Parse(x, CultureInfo.InvariantCulture);
                    Yvalues.Add(value);
                }
                ShowValuesY();
                txtValue.Text = "";
                txtValue.Focus();
            }

            catch (FormatException)
            {
                MessageBox.Show("The value you entered is invalid.",
                                "Warning!");
            }
        }

        private void lbyValues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ClearY_Click(object sender, EventArgs e)
        {
            lbyValues.Items.Clear();
            Yvalues.Clear();
        }

        private void ClearX_Click_1(object sender, EventArgs e)
        {
                lbxValues.Items.Clear();
            Xvalues.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //
            stringBuilder.Append("Математичне очікування дорівнює : " + MathExpectation(Yvalues));
            stringBuilder.Append("\n\nДисперсия : " + Variance(Yvalues));
            stringBuilder.Append("\n\nСереднє квадратичне відхилення : " + Deviation(Yvalues));
            stringBuilder.Append("\n\nМода : " + Mode(Yvalues).ToString("0.000#"));
            stringBuilder.Append("\n\nВерхня інтервальна межа : " + UpperBound(Yvalues) + "\nНижня інтервальна межа : " + LowerBound(Yvalues));
            stringBuilder.Append("\n\nКоефіцієнт Асиметрії : " + AssymetryCoef(Yvalues));
            stringBuilder.Append("\n\nКоефіцієнт Ексцессу : " + ExcessCoef(Yvalues));
            stringBuilder.Append("\n\nЗакон розподілу за коефіцієнтом Асиметрії : " + AsymetryLaw(Yvalues) + "\n\nЗакон розподілу за коефіцієнтом Ексцессу : " + ExcessLaw(Yvalues));
            //stringBuilder.Append("\n-----------------------------------------------------------------\n");
            //stringBuilder.Append("\n\nНове Математичне очікування дорівнює : " + MathExpectation(Yvalues));
            //stringBuilder.Append("\n\nНова Дисперсия : " + Variance(Yvalues));
            //stringBuilder.Append("\n\nНове Середнє квадратичне відхилення : " + Deviation(Yvalues));
            //stringBuilder.Append("\n\nНова Мода : " + Mode(Yvalues));
            //stringBuilder.Append("\n\nВерхня інтервальна межа : " + UpperBound(Yvalues) + "\nНижня інтервальна межа : " + LowerBound(Yvalues)); //OPTIONAL - скорее всего надо будет удалить это
            //stringBuilder.Append("\n\nКоефіцієнт Асиметрії : " + AssymetryCoef(Yvalues));
            //stringBuilder.Append("\n\nКоефіцієнт Ексцессу : " + ExcessCoef(Yvalues));
            //stringBuilder.Append("\n\nЗакон розподілу за коефіцієнтом Асиметрії : " + AsymetryLaw(Yvalues) + "\n\nЗакон розподілу за коефіцієнтом Ексцессу : " + ExcessLaw(Yvalues));
            //
            MessageBox.Show(stringBuilder.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Histograms frm2 = new Histograms(Yvalues);
            
                frm2.Show();
            
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            double[] X = new double[Xvalues.Count];
            double[] Y = new double[Yvalues.Count];
            //
            for (int i = 0; i < Xvalues.Count; i++)
            {
                X[i] = Xvalues[i];
            }
            for (int i = 0; i < Yvalues.Count; i++)
            {
                Y[i] = Yvalues[i];
            }
            LinearCorrelationCoefficient example = new LinearCorrelationCoefficient(X, Y);
            example.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            KendalCorrelationCoefficient example = new KendalCorrelationCoefficient(Xvalues, Yvalues);
            example.Show();
        }

        private void anomy_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //
            stringBuilder.Append("\nАномальні значення виборки : " + AnomalyNums(Yvalues, Xvalues) + "\n");
            //
            MessageBox.Show(stringBuilder.ToString());
        }

        private void anomX_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //
            stringBuilder.Append("\nАномальні значення виборки : " + AnomalyNums(Xvalues, Yvalues) + "\n");
            //
            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
