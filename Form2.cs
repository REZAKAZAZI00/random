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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace random
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_x.Text);
            int a = Convert.ToInt32(txt_a.Text);
            int c = Convert.ToInt32(txt_c.Text);
            int m = Convert.ToInt32(txt_m.Text);

            int count = Convert.ToInt32(txt_count.Text);

            var randomNumberGenerator = new LinearCongruentialGenerator(x, a, c, m);

            for (int i = 0; i < count; i++)
            {
               var xi=  randomNumberGenerator.Next();

                var ri =xi/ m;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
