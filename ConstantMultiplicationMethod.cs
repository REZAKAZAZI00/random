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
    public partial class ConstantMultiplicationMethod : Form
    {
        public ConstantMultiplicationMethod()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            var k = txt_k.Text;
            var x = txt_x.Text;
            var count = Convert.ToInt32(num_count.Value);

            DataView.Columns.Clear();
            DataView.Rows.Clear();

            DataView.Columns.Add("Xi", "Xi");
            DataView.Columns.Add("Ri", "Ri");
            var ConstantMultiplicationMethod = new Servies.ConstantMultiplicationMethod(k, x);
            for (int i = 0; i < count; i++)
            {
                var xi = ConstantMultiplicationMethod.Next();

                var ri = xi.ToString();

                ri = ri.TrimStart('0');

                ri = ri.Replace(".", "");
                DataView.Rows.Add(xi, ri);
            }
        }

        private void ConstantMultiplicationMethod_Load(object sender, EventArgs e)
        {
            btncalc.Enabled = false;
        }
        private void CheckInputFields()
        {
            if (!string.IsNullOrEmpty(txt_x.Text) &&
                !string.IsNullOrEmpty(txt_k.Text) &&
                (num_count.Value != null && num_count.Value != 0)
                )
            {
                btncalc.Enabled = true;
            }
            else
            {
                btncalc.Enabled = false;
            }
        }

        private void txt_x_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void txt_k_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void num_count_ValueChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}
