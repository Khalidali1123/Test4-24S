namespace Test4_24S
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = textBox2.Text;
            string z = textBox3.Text;
            string f = textBox4.Text;

            x = y;
            y = z;
            z = f;

            textBox2.Text = x.ToString();
            textBox3.Text = y.ToString();
            textBox4.Text = z.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
