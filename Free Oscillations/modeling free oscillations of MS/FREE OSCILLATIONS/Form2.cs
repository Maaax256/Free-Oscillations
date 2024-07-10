using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;


namespace FREE_OSCILLATIONS
{
    public partial class Form2 : Form
    {
        static public Point Center;
        StreamReader sr = new StreamReader("Count_file.txt");// создать файл

        PointPairList list_fi_t = new PointPairList();

        GraphPane MyFirstPane = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sr.Close(); sr.Dispose();
            Close();
        }

        private void button_grafik_Click(object sender, EventArgs e)
        {
            string buffer;

            list_fi_t.Clear();
            sr = new StreamReader("Count_file.txt");

            while (!sr.EndOfStream)
            {
                buffer = sr.ReadLine();
                buffer = buffer.Trim();
                string[] my = buffer.Split(' ');
                double t = Convert.ToDouble(my[0]);
                double fi = Convert.ToDouble(my[1]);
                //double alfa  = Convert.ToDouble(my[2]);

                list_fi_t.Add(t, fi);
            }
            sr.Close();

            MyFirstPane = zedGraphControl1.GraphPane;

            MyFirstPane.CurveList.Clear();

            MyFirstPane.Title.Text = "";
            MyFirstPane.XAxis.Title.Text = " t, [s]";
            MyFirstPane.YAxis.Title.Text = " fi(t), [rad]";

            LineItem myFirstCurve = MyFirstPane.AddCurve("fi(t)", list_fi_t, Color.BlueViolet);
            //в  точках
            myFirstCurve.Symbol.IsVisible = false;

            myFirstCurve.Line.IsSmooth = true;
            //ширина 
            myFirstCurve.Line.Width = 2.0f;

            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();

            {
                zedGraphControl1.Invalidate();
            }
            sr.Dispose();
            //Form1 frm1 = new Form1();
            label10.Text = "k=" + Math.Round(Form1.k, 4) + "рад/с";
            label11.Text = "T=" + Math.Round(Form1.T, 4) + "c";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MyFirstPane = zedGraphControl1.GraphPane;
            MyFirstPane.Title.Text = "";
            MyFirstPane.XAxis.Title.Text = " t";
            MyFirstPane.YAxis.Title.Text = " fi(t)";
        }
    }
}
