using random.Servies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace random
{
    public partial class LinearCongruentialGenerator : Form
    {
        public LinearCongruentialGenerator()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btncalc.Enabled = false;
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_x.Text);
            int a = Convert.ToInt32(txt_a.Text);
            int c = Convert.ToInt32(txt_c.Text);
            int m = Convert.ToInt32(txt_m.Text);
    
            int count = Convert.ToInt32(txt_count.Text);
           
            DataView.Columns.Clear();
            DataView.Rows.Clear();

            DataView.Columns.Add("Xi", "Xi");
            DataView.Columns.Add("Ri", "Ri");
            var randomNumberGenerator = new Servies.LinearCongruentialGenerator(x, a, c, m);

            for (int i = 0; i < count; i++)
            {
                var xi = randomNumberGenerator.Next();

                double ri = (double)xi / m;




                DataView.Rows.Add(xi, ri);


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_count_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();
        }

        private void CheckInputFields()
        {
            if (!string.IsNullOrEmpty(txt_x.Text) &&
                !string.IsNullOrEmpty(txt_a.Text) &&
                !string.IsNullOrEmpty(txt_c.Text) &&
                !string.IsNullOrEmpty(txt_m.Text) &&
                !string.IsNullOrEmpty(txt_count.Text))
            {
                btncalc.Enabled = true;
            }
            else
            {
                btncalc.Enabled = false;
            }
        }

        private void txt_m_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();

        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();

        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();

        }

        private void txt_x_TextChanged(object sender, EventArgs e)
        {
            CheckInputFields();

        }
    }
}
