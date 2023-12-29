namespace random
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectiveCooccurrenceMethod method = new CollectiveCooccurrenceMethod();

            method.Show();
            Hide();
        }

        private void btn_squar_Click(object sender, EventArgs e)
        {
            MeanSquareMethod method = new MeanSquareMethod();
            method.Show();
            Hide();
        }

        private void btn_multipli_Click(object sender, EventArgs e)
        {
            MultiplicativeMiddleMethod method = new MultiplicativeMiddleMethod();
            method.Show();
            Hide();
        }

        private void btn_liener_Click(object sender, EventArgs e)
        {
            LinearCongruentialGenerator congruentialGenerator = new LinearCongruentialGenerator();
            congruentialGenerator.Show();
            Hide();
        }

        private void btn_maltipleiconst_Click(object sender, EventArgs e)
        {
            ConstantMultiplicationMethod method = new ConstantMultiplicationMethod();

            method.Show();
            Hide();
        }
    }
}