using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace servertest1
{
    public partial class Form1 : Form
    {
        private TcpListener _listener;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse(txtServerIP.Text);
            int port = int.Parse(txtPort.Text);

            _listener = new TcpListener(ipAddress, port);
            _listener.Start();
            AddMessage("Server started.");
            btnStartServer.Enabled = false;

            // Start listening for connections in a separate thread
            var listenerThread = new System.Threading.Thread(ListenForClients);
            listenerThread.Start();
        }
        private void ListenForClients()
        {
            try
            {
                while (true)
                {
                    TcpClient client = _listener.AcceptTcpClient();
                    var clientThread = new System.Threading.Thread(HandleClient);
                    clientThread.Start(client);
                }
            }
            catch (SocketException ex)
            {
                AddMessage("Error: " + ex.Message);
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            NetworkStream stream = tcpClient.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string domain = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            domain = domain.Trim();

            string response = ResolveDNS(domain);
            byte[] responseBuffer = Encoding.ASCII.GetBytes(response);
            stream.Write(responseBuffer, 0, responseBuffer.Length);

            stream.Close();
            tcpClient.Close();
        }

        private string ResolveDNS(string domain)
        {
            try
            {
                IPAddress[] addresses = Dns.GetHostAddresses(domain);
                if (addresses.Length > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (IPAddress address in addresses)
                    {
                        sb.AppendLine($"{domain} resolves to {address}");
                    }
                    return sb.ToString();
                }
                else
                {
                    return $"No IP address found for the domain '{domain}'.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private void AddMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { AddMessage(message); }));
            }
            else
            {
                txtServerLog.AppendText(message + Environment.NewLine);
            }
        }
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            if (_listener != null)
            {
                _listener.Stop();
            }
        }
    }
}
