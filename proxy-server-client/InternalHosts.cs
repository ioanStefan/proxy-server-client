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

        private void btn_UpdateHost_Click(object sender, EventArgs e)
        {

        }

        private void btn_RemoveHost_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddNewHost_Click(object sender, EventArgs e)
        {

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
    }
}
