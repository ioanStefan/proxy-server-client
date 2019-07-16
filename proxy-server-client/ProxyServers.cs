using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proxy_server_client
{
    public partial class ProxyServers : Form
    {
        public ProxyServers()
        {
            InitializeComponent();
            Models.GetProxyServers(lbox_ProxyServers);
        }

        private async void btn_AddNewProxyServer_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> server = new Dictionary<string, string>();

            server.Add("hostname", tb_NewProxyServerIP.Text);
            server.Add("port", tb_NewProxyServerPort.Text);
            server.Add("encSecretKey", tb_newSecredKey.Text);
            server.Add("encAlgorithm", cb_newAlgorithm.Text);
            server.Add("details", rtb_NewProxyServerDetails.Text);

            bool response = await Models.AddNewProxyServer(server);

            dynamic proxyConfig = Globals.ProxyConfig;

            Notify(response);

            if (response)
            {
                Models.GetProxyConfig();

                lbox_ProxyServers.Items.Add(tb_NewProxyServerIP.Text);

                ClearInputs("new");                
            }
        }

        private async void btn_RemoveProxyServer_Click(object sender, EventArgs e)
        {
            bool response = await Models.RemoveProxy(tb_pdHostname.Text);

            Notify(response);

            if (response)
            {
                Models.GetProxyConfig();

                for (int i = 0; i <= 10000000; i++) { }

                Models.GetProxyServers(lbox_ProxyServers);

                ClearInputs("update");
            }

        }

        private async void btn_UpdateProxyServer_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> server = new Dictionary<string, string>();

            server.Add("hostname", tb_pdHostname.Text);
            server.Add("port", tb_pdPort.Text);
            server.Add("encSecretKey", tb_pdSecredKey.Text);
            server.Add("encAlgorithm", cb_pdAlgorithm.Text);
            server.Add("details", rtb_ProxyDetails.Text);

            bool response = await Models.UpdateProxy(server);

            Notify(response);

            if (response)
            {
                Models.GetProxyConfig();

                ClearInputs("update");
            }
        }

        private void ProxyServers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.ProxyServers = true;
        }

        private void lbox_ProxyServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic server = Models.GetProxyServerDetails(lbox_ProxyServers.SelectedItem.ToString());

            tb_pdHostname.Text = server.hostname;
            tb_pdPort.Text = server.port;
            tb_pdSecredKey.Text = server.encSecretKey;
            cb_pdAlgorithm.Text = server.encAlgorithm;
            rtb_ProxyDetails.Text = server.details;
        }

        private void Notify(bool type)
        {
            if (type)
                MessageBox.Show("Succes!");
            else
                MessageBox.Show("Verifica datele!");
        }

        private void ClearInputs(string inputs)
        {
            switch(inputs)
            {
                case "new":
                    tb_NewProxyServerIP.Clear();
                    tb_NewProxyServerPort.Clear();
                    tb_newSecredKey.Clear();
                    cb_newAlgorithm.Text = "";
                    rtb_NewProxyServerDetails.Clear();              
                    break;
                case "update":
                    tb_pdHostname.Clear();
                    tb_pdPort.Clear();
                    tb_pdSecredKey.Clear();
                    cb_pdAlgorithm.Text = "";
                    rtb_ProxyDetails.Clear();
                    break;
                default:
                    break;
            }
        }
    }
}
