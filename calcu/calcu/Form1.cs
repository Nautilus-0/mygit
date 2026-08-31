namespace calcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            a = Int32.Parse(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("La suma es: " + (a + b).ToString());

            textBox3.Text = (a + b).ToString(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }
    }
}
