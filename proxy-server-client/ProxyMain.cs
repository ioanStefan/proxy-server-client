using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using Newtonsoft;
using Newtonsoft.Json;
using System.Threading;

namespace proxy_server_client
{
    public partial class ProxyMain : Form
    {
        Thread thread = null;

        public ProxyMain()
        {
            InitializeComponent();

            Globals.ProxyServers = true;
            Globals.ProxyTargets = true;
            Globals.LocalHosts = true;

            Models.GetProxyConfig();

        }

        private void ProxyMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_OpenProxyConnection_Click(object sender, EventArgs e)
        {
            Process.Start("InetCpl.cpl");
        }

        private void btn_CloseProxyConnection_Click(object sender, EventArgs e)
        {
            Process.Start("InetCpl.cpl");
        }

        private void btn_ProxyServers_Click(object sender, EventArgs e)
        {

            if (Globals.ProxyServers)
            {
                Globals.ProxyServers = false;
                ProxyServers psFrm = new ProxyServers();
                psFrm.Show();
            }
        }

        private void btn_ProxyTargets_Click(object sender, EventArgs e)
        {
            ProxyTargets ptForm = new ProxyTargets();
            ptForm.Show();
        }

        private void btn_Text_Click(object sender, EventArgs e)
        {
            Test tForm = new Test();
            tForm.Show();
        }

        private void btn_ExitApplication_Click(object sender, EventArgs e)
        {
            Globals.loginForm.Close();
        }

        private void btn_InternalHosts_Click(object sender, EventArgs e)
        {
            InternalHosts ihForm = new InternalHosts();
            ihForm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        async private void btn_Send_Click(object sender, EventArgs e)
        {
            string ip = tb_IP.Text;
            string port = tb_Port.Text;
            string message = rtb_Message.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://" + ip + ":" + port);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Dictionary<string, string> data = new Dictionary<string, string>();

            data.Add("msg", message);

            dynamic content = new FormUrlEncodedContent(data);

            HttpResponseMessage response = await client.PostAsync("/", content);

            string res = await response.Content.ReadAsStringAsync();

            rtb_Response.Text += res + "\n -------------------------------------";
        }

        private void btn_StopServer_Click(object sender, EventArgs e)
        {
            thread.Abort();

            btn_StartServer.Enabled = true;
            btn_StopServer.Enabled = false;
        }

        private void btn_StartServer_Click(object sender, EventArgs e)
        {         
            Server srv = new Server();

            int port = Int32.Parse(tb_ServerPort.Text);

            thread = srv.Start(port);

            btn_StartServer.Enabled = false;
            btn_StopServer.Enabled = true;

            Globals.gRtbClientRequest = rtbClientRequest;
        }
    }
}
