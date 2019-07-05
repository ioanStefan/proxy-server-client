using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy_server_client
{
    interface IConfig
    {
        Dictionary<string, dynamic> config { get; set; }

    }
}
