using RoundRect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Point ps;
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

                if (this.lstPoints.Count >= 4)
                {
                    this.txtMsg.Text = "只能添加4个点，如果要重复测试请先点clear";
                    return;
                }


                this.lstPoints.Add(p);
                this.listBox1.Items.Add(p);
                switch (this.lstPoints.Count)
                {
                    case 1:
                        this.ps = p;
                        break;
                    case 2:
                        this.CalcOneOuterPointF(p);
                        break;
                    case 3:
                        this.CalcOneOuterPointF(p);
                        break;
                    case 4:
                        this.CalcOneOuterPointF(p);
                        this.CalcOneOuterPointF(this.lstPoints[0]);

                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                this.txtMsg.Text = ex.Message;
            }

        }

        private void CalcOneOuterPointF(Point pe)
        {
            this.listBox2.Items.Add(Calculator.CalcOutPointOf2(ps, pe));
            this.ps = pe;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.lstPoints.Clear();
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.txtMsg.Clear();
        }
    }
}
