namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            new Form2(int.Parse(port.Text)).Show();
            listen.Enabled = false;

        }
    }
}
