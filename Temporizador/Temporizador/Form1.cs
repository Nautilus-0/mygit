namespace Temporizador
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        int seg = 0;
        int min = 0;
        int hrs = 0;
        bool encendido = false; 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            if (min == 60)
            {
                hrs++;
                min = 0;
            }
            DateTime tiemp = DateTime.Now;

            label1.Text = tiemp.ToString("HH:mm:ss");
            label2.Text = tiemp.ToString("dd/MM/yyyy");
            label3.Text = "tiempo trans: hrs:" + hrs + "/min:" + min + "/seg:" + seg;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(encendido == false)
            {
                encendido = true;
                timer1.Enabled = false;
                button1.Text = "Prender";

            }
            else
            {
                encendido = false;
                timer1.Enabled = true;
                button1.Text = "Apagar";

            }
        }
    }
}
