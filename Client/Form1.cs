
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
namespace Client
{
    public partial class Form1 : Form
    {

        private TcpClient client = new TcpClient();
        private NetworkStream ns;
        private int portNumber;

        private static Image GetDesktop()
        {
            Rectangle bound = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bound.Width, bound.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);

            return screenshot;
        }

        private void SendDesktop()
        {
            BinaryFormatter bf = new BinaryFormatter();
            ns = client.GetStream();
            bf.Serialize(ns, GetDesktop());
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            share.Enabled = false;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            portNumber = int.Parse(port.Text);
            try
            {
                client.Connect(ip.Text, portNumber);
                connect.Text = "Connected";
                MessageBox.Show("Connected to the server");
                connect.Enabled = false;
                share.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server!!!");
                connect.Text = "Not Connected";
            }
        }

        private void share_Click(object sender, EventArgs e)
        {
            if (share.Text.StartsWith("Share"))
            {
                timer1.Start();
                share.Text = "Stop Sharing";
            }
            else
            {
                timer1.Stop();
                share.Text = "Share Desktop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDesktop();
        }
    }
}
