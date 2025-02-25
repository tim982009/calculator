namespace 簡易版計算機
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = 0;
            if (label1.Text == "+")
            {
                num = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            }
            if (label1.Text == "-")
            {
                num = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            }
            if (label1.Text == "*")
            {
                num = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            }
            if (label1.Text == "/")
            {
                num = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            }

            textBox3.Text = num.ToString();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "/";
        }
    }
}