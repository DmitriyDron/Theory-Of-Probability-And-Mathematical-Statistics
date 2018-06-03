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
        public List<double> X_Values;
        public List<double> Y_Values;

        public List<double> XValues
        {
            get
            {
                return this.X_Values;
            }
            set
            {
                this.X_Values = value;
            }
        }
        public List<double> YValues
        {
            get
            {
                return this.Y_Values;
            }
            set
            {
                this.Y_Values = value;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            XValues = new List<double>();
            YValues = new List<double>();
        }
        void ShowValuesX()
        {
            lbxValues.Items.Clear();

            for (int i = 0; i < XValues.Count; i++)
                lbxValues.Items.Add(XValues[i]);
        }
        void ShowValuesY()
        {
            lbyValues.Items.Clear();

            for (int i = 0; i < YValues.Count; i++)
                lbyValues.Items.Add(YValues[i]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RegressionLine regressionLine = new RegressionLine(XValues, YValues);
            {
                regressionLine.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Histograms histograms = new Histograms(XValues);
            {
                histograms.Show();
            }
        }
        //STATISTIC
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Математичне очікування дорівнює : " + MathExpectation(XValues));
            stringBuilder.Append("\n\nДисперсия : " + Variance(XValues));
            stringBuilder.Append("\n\nСереднє квадратичне відхилення : " + Deviation(XValues));
            stringBuilder.Append("\n\nМода : " + Mode(XValues).ToString("0.000#"));
            stringBuilder.Append("\n\nВерхня інтервальна межа : " + UpperBound(XValues) + "\nНижня інтервальна межа : " + LowerBound(XValues));
            stringBuilder.Append("\n\nКоефіцієнт Асиметрії : " + AssymetryCoef(XValues));
            stringBuilder.Append("\n\nКоефіцієнт Ексцессу : " + ExcessCoef(XValues));
            stringBuilder.Append("\n\nЗакон розподілу за коефіцієнтом Асиметрії : " + AsymetryLaw(XValues) + "\n\nЗакон розподілу за коефіцієнтом Ексцессу : " + ExcessLaw(XValues));
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
            return centralMoment / ((Math.Pow(Deviation(inputValues), 3)) * inputValues.Count);
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
            return ((u4 / ((Math.Pow(Deviation(inputValues), 4)) * inputValues.Count)) - 3);
        }
        //ANOMALY_NUMS
        string AnomalyNums(List<double> inputValuesX, List<double> inputValuesY)
        {
            string anomalyNums = null;
            double anomalyCoef = 1.96;
            //
            foreach (double x in inputValuesX.ToArray())
            {
                if ((Math.Abs(x - MathExpectation(inputValuesX)) / Deviation(inputValuesX)) > anomalyCoef)
                {
                    anomalyNums += " " + x.ToString() + ",";
                    inputValuesX.Remove(x);
                    inputValuesY.Remove(x);
                    //rec
                    AnomalyNums(inputValuesX, inputValuesY);
                }

            }
            //
            return anomalyNums;
        }
        //MODE
        double Mode(List<double> inputValues)
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
            return MathExpectation(inputValues) + upperbound;
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
            if (AssymetryCoef(inputValues) > 0)
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
            if (ExcessCoef(inputValues) > 0)
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
                    XValues.Add(value);
                }
                ShowValuesX();
                txtValue.Text = "";
                txtValue.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("The value you entered is invalid.", "Warning!");
            }

        }
        private void AddY_Click(object sender, EventArgs e)
        {
            // This the value that will be added to the text box
            double value;
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
                    YValues.Add(value);
                }
                ShowValuesY();
                txtValue.Text = "";
                txtValue.Focus();
            }

            catch (FormatException)
            {
                MessageBox.Show("The value you entered is invalid.", "Warning!");
            }
        }

        private void lbyValues_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ClearY_Click(object sender, EventArgs e)
        {
            lbyValues.Items.Clear();
            YValues.Clear();
        }
        private void ClearX_Click_1(object sender, EventArgs e)
        {
            lbxValues.Items.Clear();
            XValues.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //
            stringBuilder.Append("Математичне очікування дорівнює : " + MathExpectation(YValues));
            stringBuilder.Append("\n\nДисперсия : " + Variance(YValues));
            stringBuilder.Append("\n\nСереднє квадратичне відхилення : " + Deviation(YValues));
            stringBuilder.Append("\n\nМода : " + Mode(YValues).ToString("0.000#"));
            stringBuilder.Append("\n\nВерхня інтервальна межа : " + UpperBound(YValues) + "\nНижня інтервальна межа : " + LowerBound(YValues));
            stringBuilder.Append("\n\nКоефіцієнт Асиметрії : " + AssymetryCoef(YValues));
            stringBuilder.Append("\n\nКоефіцієнт Ексцессу : " + ExcessCoef(YValues));
            stringBuilder.Append("\n\nЗакон розподілу за коефіцієнтом Асиметрії : " + AsymetryLaw(YValues) + "\n\nЗакон розподілу за коефіцієнтом Ексцессу : " + ExcessLaw(YValues));
            MessageBox.Show(stringBuilder.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Histograms frm2 = new Histograms(YValues);

            frm2.Show();

        }

        private void Normal_Click(object sender, EventArgs e)
        {
            double[] X = new double[XValues.Count];
            double[] Y = new double[YValues.Count];
            //
            for (int i = 0; i < XValues.Count; i++)
            {
                X[i] = XValues[i];
            }
            for (int i = 0; i < YValues.Count; i++)
            {
                Y[i] = YValues[i];
            }
            LinearCorrelationCoefficient example = new LinearCorrelationCoefficient(X, Y);
            example.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            KendalCorrelationCoefficient example = new KendalCorrelationCoefficient(XValues, YValues);
            example.Show();
        }

        private void anomy_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //
            stringBuilder.Append("\nАномальні значення виборки : " + AnomalyNums(YValues, XValues) + "\n");
            //
            MessageBox.Show(stringBuilder.ToString());
        }

        private void anomX_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //
            stringBuilder.Append("\nАномальні значення виборки : " + AnomalyNums(XValues, YValues) + "\n");
            //
            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
