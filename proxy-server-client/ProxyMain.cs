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

            panels = new Dictionary<string, Panel>();

            panels.Add("pHome", panel_Home);
            panels.Add("pProxyServers", panel_ProxyServers);
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
            //HidePanels();
            panels["pProxyServers"].Visible = true;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            HidePanels();
            panels["pHome"].Visible = true;
        }

        private void HidePanels()
        {
            foreach (string panel in panels.Keys)
            {
                panels[panel].Visible = false;
            }

        }

    }
}
