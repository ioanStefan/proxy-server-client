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
    public partial class ProxyTargets : Form
    {
        public ProxyTargets()
        {
            InitializeComponent();
            Models.GetProxyServers(cb_ProxyServers);
            Models.GetProxyServers(cb_NewTargetProxyServer);
        }

        private void cb_ProxyServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hostname = cb_ProxyServers.Text;

            Models.GetProxyTargets(hostname, lb_ProxyTargets);
        }

        private async void btn_UpdateProxyTarget_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> target = new Dictionary<string, string>();

            target.Add("host", tb_tdHost.Text);
            target.Add("port", tb_tdPort.Text);
            target.Add("details", rtb_Details.Text);

            bool response = await Models.UpdateTarget(target);

            Notify(response);
        }

        private async void btn_AddNewTarget_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> target = new Dictionary<string, string>();

            target.Add("proxy", cb_NewTargetProxyServer.Text);
            target.Add("host", tb_NewTargetHost.Text);
            target.Add("port", tb_NewTargetPort.Text);
            target.Add("details", rtb_NewTargetDetails.Text);

            bool response = await Models.AddTarget(target);

            Notify(response);
        }

        private void lb_ProxyTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hostname = lb_ProxyTargets.SelectedItem.ToString();

            dynamic target = Models.GetProxyTargetDetails(hostname);

            if (target != null)
            {
                tb_tdHost.Text = target.host;
                tb_tdPort.Text = target.port;
                rtb_Details.Text = target.details;
            }
        }

        private void Notify(bool type)
        {
            if (type)
                MessageBox.Show("Succes!");
            else
                MessageBox.Show("Verifica datele!");
        }

        async private void btn_RemoveProxyTarget_Click(object sender, EventArgs e)
        {
            bool response = await Models.RemoveTarget(tb_tdHost.Text);

            Notify(response);

            if (response)
                ClearInputs("update");
        }


        private void ClearInputs(string inputs)
        {
            switch (inputs)
            {
                case "new":
                    tb_NewTargetHost.Clear();
                    tb_NewTargetPort.Clear();
                    rtb_NewTargetDetails.Clear();                    
                    break;
                case "update":
                    tb_tdHost.Clear();
                    tb_tdPort.Clear();
                    rtb_Details.Clear();               
                    break;
                default:
                    break;
            }
        }
    }
}
