namespace Delta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, ans1, ans2, ans3;
            a = double.Parse(tb_a.Text);
            b = double.Parse(tb_b.Text);
            c = double.Parse(tb_c.Text);
            ans1 = (-1 * b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            ans2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            ans3 = (Math.Pow(b, 2) - 4 * a * c);
            lb_answer1.Text = ans1.ToString("n2");
            lb_answer2.Text = ans2.ToString("n2");
            lb_answer3.Text = ans3.ToString("n2");

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}