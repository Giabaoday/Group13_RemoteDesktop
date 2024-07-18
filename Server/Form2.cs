using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Net;
using System.Text.Json;
using System.Runtime.Serialization;
namespace Server
{
    public partial class Form2 : Form
    {

        private readonly int port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream ns;

        private readonly Thread Listening;
        private readonly Thread GetDesktop;
        public Form2(int Port)
        {
            port = Port;
            client = new TcpClient();
            Listening = new Thread(StartListening);
            GetDesktop = new Thread(ReceiveDesktop);

            InitializeComponent();
        }

        private void StartListening()
        {
            while (!client.Connected)
            {
                server.Start();
                client = server.AcceptTcpClient();
            }
            GetDesktop.Start();
        }

 
        private void ReceiveDesktop()
        {
            BinaryFormatter bf = new BinaryFormatter();
            while (client.Connected)
            {
                ns = client.GetStream();
                pictureBox1.Image = (Image)bf.Deserialize(ns);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Any,port);
            Listening.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
