﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proxy_server_client
{
    static class Globals
    {
        public static string ProxyIP { get; set; }
        public static string Token { get; set; }

        public static bool ProxyServers { get; set; }
        public static bool ProxyTargets { get; set; }
        public static bool LocalHosts { get; set; }

        public static dynamic ProxyConfig { get; set; }
        public static dynamic ProxyTargetsList { get; set; }

        public static Form loginForm { get; set; }

        public static RichTextBox gRtbClientRequest { get; set; }
    }
}
