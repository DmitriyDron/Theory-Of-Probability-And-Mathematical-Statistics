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
        private ZedGraphControl zedGraph;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        List<double> ValuesConstruct;

        public Histograms(List<double> inputValues)
        {
            InitializeComponent1();
            ValuesConstruct = inputValues;
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>1
        private void InitializeComponent1()
        {
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraph.Location = new System.Drawing.Point(0, 0);
            this.zedGraph.Name = "zedGraphControl1";
            this.zedGraph.Size = new System.Drawing.Size(680, 414);
            this.zedGraph.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(680, 414);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(Form1_Load);

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых
            pane.CurveList.Clear();
            int itemscount = 5;
            // Подписи под столбиками
            string[] names = new string[itemscount];
            // Высота столбиков
            //X
            double[] values = new double[ValuesConstruct.Count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = ValuesConstruct[i];
            }
            // Заполним данные
            for (int i = 0; i < itemscount; i++)
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
            zedGraph.AxisChange();
            zedGraph.IsShowPointValues = true;
            // Обновляем график
            zedGraph.Invalidate();

        }
    }
}
