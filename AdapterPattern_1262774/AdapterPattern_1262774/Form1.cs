using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPattern_1262774
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdapterMath_Click(object sender, EventArgs e)
        {
            try
            {
                INewMath am = new AdapterMath();
                double[] A = { 3.7, 8.4, 6.3 };
                double res = am.ComputeAvgNew(A);
                MessageBox.Show("Result = " + res.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdapterMath2_Click(object sender, EventArgs e)
        {
            try
            {
                INewMath am = new AdapterMath();
                double[] A = { 3.7, 8.4, 6.3 };
                int res = am.ComputeAvgRound(A);
                MessageBox.Show("Result (Rounded Avg) = " + res.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdapter2Way_Click(object sender, EventArgs e)
        {
            IExistingMath im = new MathAdapterTwoWay();
            double res = im.ComputeAvg(7.3f, 6.4f, 8.5f);
            MessageBox.Show("Two-Way Adapter: Avg from legacy = " + res.ToString());

            INewMath inm = new MathAdapterTwoWay();
            double[] Arr = { 7.3, 6.4, 8.5 };
            double res2 = inm.ComputeAvgNew(Arr);
            MessageBox.Show("Two-Way Adapter: Avg from new = " + res2.ToString());
        }


        private void btnObjectAdapter_Click(object sender, EventArgs e)
        {
            IMathTarget mathTarget = new AdapterMath2();
            double[] Arr = { 7.3, 6.4, 8.5 };
            double avg = mathTarget.ComputeAvgNew(Arr);
            MessageBox.Show("Object Adapter: Avg = " + avg.ToString());
        }

    }
}
