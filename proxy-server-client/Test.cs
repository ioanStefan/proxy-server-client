using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

using Newtonsoft;
using Newtonsoft.Json;

namespace proxy_server_client
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            Models.GetProxyServers(cb_ProxyServers);
        }

        private async void btn_Test_Click(object sender, EventArgs e)
        {
            //string startTime = DateTime.Now.ToString("mm:ss");

            var stopwatch = new Stopwatch();

            stopwatch.Start();

            Dictionary<string, string> testData = new Dictionary<string, string>();

            testData.Add("server", cb_ProxyServers.Text);
            testData.Add("text", rtb_PlainText.Text);

            dynamic response = await Models.Test(testData);

            dynamic res = JsonConvert.DeserializeObject(response);

            rtb_Encrypted.Text = "iv: " + res.iv_1
                + "\n"
                + "Text Criptat: " + res.text_encrypted;

            rtb_ResponseEncrypted.Text = "iv: " + res.iv_2
                + "\n"
                + "Text Criptat: " + res.text2_encrypted;

            rtb_ResponseDecrypted.Text = res.text_decrypted;

            stopwatch.Stop();

            lbl_ResponseTime.Text = "Response Time: " + stopwatch.ElapsedMilliseconds;

            //string endTime = DateTime.Now.ToString("mm:ss");

            //lbl_ResponseTime.Text += " " + startTime + " - " + endTime;

        }
    }
}
