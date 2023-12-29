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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace random
{
    public partial class CollectiveCooccurrenceMethod : Form
    {
        public CollectiveCooccurrenceMethod()
        {
            InitializeComponent();
        }

        private void CollectiveCooccurrenceMethod_Load(object sender, EventArgs e)
        {
            btncalc.Enabled = false;
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            var m = Convert.ToInt32(txt_m.Text);
            var n = Convert.ToInt32(num_n.Value);
            int count = n;
            var x = txt_x.Text;
            string[] numbers = x.Split(',');

            numbers = numbers.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            int[] Numbers = Array.ConvertAll(numbers, int.Parse);
            var collectiveCooccurrenceMethod = new Servies.CollectiveCooccurrenceMethod(Numbers, n, m);



            DataView.Columns.Clear();
            DataView.Rows.Clear();

            DataView.Columns.Add("Xi", "Xi");
            DataView.Columns.Add("Ri", "Ri");

            for (int i = 0; i < count; i++)
            {

                var xi = collectiveCooccurrenceMethod.Next();

                DataView.Rows.Add(xi, xi);

            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CheckInputFields()
        {
            if (!string.IsNullOrEmpty(txt_m.Text) &&
                !string.IsNullOrEmpty(txt_x.Text) &&
                (num_n.Value != null && num_n.Value != 0)
                )
            {
                btncalc.Enabled = true;
            }
            else
            {
                btncalc.Enabled = false;
            }
        }

        private void num_n_ValueChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void txt_m_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_x_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}
