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
public partial class Histograms : Form
    {
        private ZedGraphControl ZedGraphControl;
        private List<double> Values_Construct;
        public ZedGraphControl ZedGraph
        {
            get
            {
                return this.ZedGraphControl;
            }
            set
            {
                ZedGraphControl = value;
            }
        }
        public List<double> ValuesConstruct
        {
            get
            {
                return this.Values_Construct;
            }
            set
            {
                Values_Construct = value;
            }
        }

        public Histograms(List<double> inputValues)
        {
            InitializeComponent1();
            ValuesConstruct = inputValues;
        }
        #region Windows Form Designer generated code
        
        private void InitializeComponent1()
        {
            this.ZedGraph = new ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.ZedGraph.Location = new Point(0, 0);
            this.ZedGraph.Name = "zedGraphControl1";
            this.ZedGraph.Size = new Size(680, 414);
            this.ZedGraph.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new Size(5, 13);
            this.ClientSize = new Size(680, 414);
            this.Controls.Add(this.ZedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.Load += new EventHandler(Form1_Load);

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //Получим панель для рисования
            GraphPane pane = ZedGraph.GraphPane;
            // Очистим список кривых
            pane.CurveList.Clear();
            int items_count = 5;
            // Подписи под столбиками
            string[] names = new string[items_count];
            // Высота столбиков
            //X
            double[] values = new double[ValuesConstruct.Count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = ValuesConstruct[i];
            }
            // Заполним данные
            for (int i = 0; i < items_count; i++)
            {
                names[i] = string.Format("Значение {0}", i);
            }

            // Создадим кривую-гистограмму
            // Первый параметр - название кривой для легенды
            // Второй параметр - значения для оси X, т.к. у нас по этой оси будет идти текст, а функция ожидает тип параметра double[], то пока передаем null
            // Третий параметр - значения для оси Y
            // Четвертый параметр - цвет
            BarItem curve = pane.AddBar("Гистограмма", null, values, Color.AntiqueWhite);

            // Настроим ось X так, чтобы она отображала текстовые данные
            pane.XAxis.Type = AxisType.Text;

            // Уставим для оси наши подписи
            pane.XAxis.Scale.TextLabels = names;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            ZedGraph.AxisChange();
            ZedGraph.IsShowPointValues = true;
            // Обновляем график
            ZedGraph.Invalidate();

        }
        private void Histograms_Load(object sender, EventArgs e) { }
    }
}
