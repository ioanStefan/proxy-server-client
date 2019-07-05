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

namespace proxy_server_client
{
    public partial class ProxyMain : Form
    {
        private Dictionary<string, Panel> panels = null;

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

        }

        private void btn_InternalHosts_Click(object sender, EventArgs e)
        {
            InternalHosts ihForm = new InternalHosts();
            ihForm.Show();
        }
    }
}
