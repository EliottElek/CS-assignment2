namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDoctor f = new FormDoctor();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPatient f = new FormPatient();
            f.Show();
        }
    }
}