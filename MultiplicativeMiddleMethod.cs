using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class MultiplicativeMiddleMethod : Form
    {
        public MultiplicativeMiddleMethod()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {

            var x = txt_x.Text;
            var xPrime = txt_xPrime.Text;

            var count = Convert.ToInt32(num_count.Value);


            DataView.Columns.Clear();
            DataView.Rows.Clear();

            DataView.Columns.Add("Xi", "Xi");
            DataView.Columns.Add("Ri", "Ri");
            var randomNumberGenerator = new Servies.MultiplicativeMiddleMethod(xPrime,x);
            for (int i = 0; i < count; i++)
            {
                var xi = randomNumberGenerator.Next();

                var ri = xi.ToString();

                ri = ri.TrimStart('0');

                ri = ri.Replace(".", "");
                DataView.Rows.Add(xi, ri);


            }


        }


        private void CheckInputFields()
        {
            if (!string.IsNullOrEmpty(txt_x.Text) &&
                !string.IsNullOrEmpty(txt_xPrime.Text) &&
                (num_count.Value != null)
                )
            {
                btncalc.Enabled = true;
            }
            else
            {
                btncalc.Enabled = false;
            }
        }

        private void MultiplicativeMiddleMethod_Load(object sender, EventArgs e)
        {
            btncalc.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void txt_x_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void txt_xPrime_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }
    }
}
