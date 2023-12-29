using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class MeanSquareMethod : Form
    {
        public MeanSquareMethod()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            string n = txt_n.Text;
            int count = Convert.ToInt32(txt_count.Text);
            MiddleSquareMethod middleSquareMethod = new MiddleSquareMethod(n);
            DataView.Columns.Clear();
            DataView.Rows.Clear();

            DataView.Columns.Add("X", "X");
            DataView.Columns.Add("Ri", "Ri");
            for (int i = 0; i < count; i++)
            {
                var xi = middleSquareMethod.Next();

                var x = xi.ToString();

                x = x.TrimStart('0');

                x = x.Replace(".", "");
                DataView.Rows.Add(xi,x);
            }

        }

        private void MeanSquareMethod_Load(object sender, EventArgs e)
        {
            btn_calc.Enabled = false;
        }

        private void CheckInputFields()
        {
            if (!string.IsNullOrEmpty(txt_n.Text) &&
                !string.IsNullOrEmpty(txt_count.Text))
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void txt_count_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }
    }
}
