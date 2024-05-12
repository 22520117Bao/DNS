using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace clienttest1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverIP = txtServerIP.Text;
            int serverPort = int.Parse(txtPort.Text);
            string domain = txtDomain.Text;

            try
            {
                using (TcpClient client = new TcpClient(serverIP, serverPort))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(domain);
                    stream.Write(buffer, 0, buffer.Length);

                    buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    txtResult.Text = response;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtServerIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
