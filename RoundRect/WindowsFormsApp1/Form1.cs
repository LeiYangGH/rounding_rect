using RoundRect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Point> lstPoints = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Point p = new Point(
                    Convert.ToInt32(this.txtX.Text),
                    Convert.ToInt32(this.txtY.Text));
                this.lstPoints.Add(p);
                this.listBox1.Items.Add(p);
                if (this.lstPoints.Count == 4)
                {
                    foreach (PointF pf in Calculator.CalcRectRoundingPoints(
                        this.lstPoints.ToArray()))
                    {
                        this.listBox2.Items.Add(pf);
                    }
                }
            }
            catch (Exception ex)
            {
                this.txtMsg.Text = ex.Message;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lstPoints.Clear();
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
        }
    }
}
