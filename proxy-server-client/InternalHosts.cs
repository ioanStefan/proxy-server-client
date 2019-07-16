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
    public partial class InternalHosts : Form
    {
        public InternalHosts()
        {
            InitializeComponent();

            Models.GetInternalHosts(lb_InternalHosts);
        }

        async private void btn_UpdateHost_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> internalHost = new Dictionary<string, string>();

            internalHost.Add("host", tb_pdHostname.Text);
            internalHost.Add("port", tb_pdPort.Text);
            internalHost.Add("key", tb_pdSecredKey.Text);
            internalHost.Add("encAlgorithm", cb_pdAlgorithm.Text);
            internalHost.Add("details", rtb_InternalHostDetails.Text);

            bool response = await Models.UpdateInternalHost(internalHost);

            Notify(response);

            if (response)
            {
                Models.GetProxyConfig();

                for (int i = 0; i <= 100000000; i++)
                {

                }


            }
        }

        async private void btn_RemoveHost_Click(object sender, EventArgs e)
        {
            bool response = await Models.RemoveInternalHost(tb_pdHostname.Text);

            Notify(response);

            if (response)
            {
                Models.GetProxyConfig();

                for (int i = 0; i <= 100000000; i++) { }

                Models.GetInternalHosts(lb_InternalHosts);

                ClearInputs("update");
            }
        }

        async private void btn_AddNewHost_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> server = new Dictionary<string, string>();

            server.Add("host", tb_NewInternalHostIP.Text);
            server.Add("port", tb_NewInternalHostPort.Text);
            server.Add("key", tb_newSecredKey.Text);
            server.Add("encAlgorithm", cb_newAlgorithm.Text);
            server.Add("details", rtb_NewInternalHostDetails.Text);

            bool response = await Models.AddNewInternalHost(server);

            Notify(response);

            if (response)
            {
                Models.GetProxyConfig();
                for (int i = 0; i <= 100000000; i++) { }

                lb_InternalHosts.Items.Add(tb_NewInternalHostIP.Text);

                ClearInputs("new");
            }
        }

        private void lb_InternalHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic internalHost = Models.GetInternalHostDetails(lb_InternalHosts.SelectedItem.ToString());

            tb_pdHostname.Text = internalHost.host;
            tb_pdPort.Text = internalHost.port;
            tb_pdSecredKey.Text = internalHost.key;
            cb_pdAlgorithm.Text = internalHost.encAlgorithm;
            rtb_InternalHostDetails.Text = internalHost.details;
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
            switch (inputs)
            {
                case "new":
                    tb_NewInternalHostIP.Clear();
                    tb_NewInternalHostPort.Clear();
                    tb_newSecredKey.Clear();
                    cb_newAlgorithm.Text = "";
                    rtb_NewInternalHostDetails.Clear();
                    break;
                case "update":
                    tb_pdHostname.Clear();
                    tb_pdPort.Clear();
                    tb_pdSecredKey.Clear();
                    cb_pdAlgorithm.Text = "";
                    rtb_InternalHostDetails.Clear();
                    break;
                default:
                    break;
            }
        }
    }
}
