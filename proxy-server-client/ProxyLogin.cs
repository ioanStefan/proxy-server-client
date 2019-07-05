using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace proxy_server_client
{
    public partial class ProxyLogin : Form
    {
		static HttpClient client = null;


        public ProxyLogin()
        {
            InitializeComponent();

            tb_IP.Text = "192.168.1.7:3010";
            tb_token.Text = "TOKEN";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_Connect_Click(object sender, EventArgs e)
        {
			//	Create new client
			client = new HttpClient();
			//  Initialize connection
			client.BaseAddress = new Uri("http://localhost:3000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            dynamic res = await ConnectToProxy();

            //lbl_Response.Text = res;
        }

        static async Task<dynamic> ConnectToProxy()
        {
            HttpResponseMessage response = await client.GetAsync("config/connection");

            dynamic obj = "";

            if (response.IsSuccessStatusCode)
            {
                obj = await response.Content.ReadAsStringAsync();
            }

            return obj;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Globals.ProxyIP = tb_IP.Text;
            Globals.Token = tb_token.Text;

            ProxyMain pMain = new ProxyMain();
            pMain.Show();
        }
    }
}
