using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using Newtonsoft;
using Newtonsoft.Json;

namespace proxy_server_client
{
    static class Models
    {
        // Această metodă încarcă Serverele Proxy
        // într-o componentă de tip ListBox
        public static void GetProxyServers(ListBox listBox)
        {            
            dynamic servers = Globals.ProxyConfig.servers;        

            foreach(dynamic server in servers)
            {
                listBox.Items.Add(server.hostname);
            }
        }

        // Această metodă încarcă Serverele Proxy
        // într-o componentă de tip ComboBox
        public static void GetProxyServers(ComboBox comboBox)
        {
            dynamic servers = Globals.ProxyConfig.servers;

            comboBox.Items.Add("");

            foreach(dynamic server in servers)
            {
                comboBox.Items.Add(server.hostname);
            }
        }

        public static void GetInternalHosts(ListBox listBox)
        {
            dynamic internalHosts = Globals.ProxyConfig.internalHosts;

            foreach(dynamic host in internalHosts)
            {
                listBox.Items.Add(host.host);
            }
        }

        public static dynamic GetInternalHostDetails(string host)
        {
            dynamic internalHosts = Globals.ProxyConfig.internalHosts;

            foreach (dynamic ih in internalHosts)
            {
                if (ih.host == host)
                    return ih;
            }

            return null;
        }

        // Metoda returnează proprietățile unui Server Proxy
        public static dynamic GetProxyServerDetails(string hostname)
        {
            dynamic servers = Globals.ProxyConfig.servers;

            foreach (dynamic server in servers)
            {
                if (server.hostname == hostname)

                    return server;
            }

            return null;
        }

        // Metoda încarcă resursele unui Server Proxy
        // într-o componentă de tip ListBox
        public static void GetProxyTargets(string hostname, ListBox listBox)
        {
            dynamic servers = Globals.ProxyConfig.servers;

            foreach(dynamic server in servers)
            {
                if(server.hostname == hostname)
                {
                    dynamic targets = server.proxyTo;

                    foreach(dynamic target in targets)
                    {
                        listBox.Items.Add(target.host);
                    }

                    Globals.ProxyTargetsList = targets;

                    break;
                }
            }

        }

        // Metoda returnează proprietățile unei resurse
        public static dynamic GetProxyTargetDetails(string hostname)
        {
            foreach (dynamic target in Globals.ProxyTargetsList)
            {
                if (target.host == hostname)
                {
                    return target;
                }
            }

            return null;
        }

        // Metoda adaugă un nou Server Proxy
        public static async Task<bool> AddNewProxyServer(Dictionary<string, string> server)
        {
            HttpClient client = ConfigClient();          
            dynamic response = await PostData(client, "/config/servers", server);
            return response;
        }

        // Metoda returnează fișierul de configure
        // config.json
        public static async void GetProxyConfig()
        {
            HttpClient client = ConfigClient();

            dynamic response = await GetData(client, "/config/servers");

            dynamic config = JsonConvert.DeserializeObject(response);
            Globals.ProxyConfig = config.configuration;

        }

        // Metoda modifică proprietățile asociate
        // unui Server Proxy
        public static async Task<bool> UpdateProxy(Dictionary<string, string> server)
        {
            HttpClient client = ConfigClient();

            dynamic response = await PutData(client, "/config/servers", server);

            return response;

        }

        // Metoda elimină din fișierul de configurare
        // un Server Proxy
        public static async Task<bool> RemoveProxy(string server)
        {
            HttpClient client = ConfigClient();

            dynamic response = await DeleteData(client, "/config/servers/" + server);

            return response;
        }

        // Metoda adaugă o resursă nouă
        public static async Task<bool> AddTarget(Dictionary<string, string> target)
        {
            HttpClient client = ConfigClient();

            dynamic response = await PostData(client, "/config/targets", target);

            return response;
        }

        // Metoda modifică proprietățile unei resurse
        public static async Task<bool> UpdateTarget(Dictionary<string, string> target)
        {
            HttpClient client = ConfigClient();

            dynamic response = await PutData(client, "/config/targets", target);

            return response;

        }

        // Metoda utilizată pentru testarea
        // funcțiilor de criptare/decriptare
        public static async Task<dynamic> Test(Dictionary<string, string> data)
        {
            HttpClient client = ConfigClient();

            dynamic content = new FormUrlEncodedContent(data);

            HttpResponseMessage response = await client.PostAsync("/test", content);

            dynamic res = await response.Content.ReadAsStringAsync();

            return res;
        }

        // Metoda adaugă un nouă resursă internă
        public static async Task<bool> AddNewInternalHost(Dictionary<string, string> server)
        {
            HttpClient client = ConfigClient();

            dynamic response = await PostData(client, "/config/internal", server);

            return response;
        }

        // Metoda modifică proprietățile unei resurse interne
        public static async Task<bool> UpdateInternalHost(Dictionary<string, string> server)
        {
            HttpClient client = ConfigClient();

            dynamic response = await PutData(client, "/config/internal", server);

            return response;

        }

        // Metoda elimină o resursă internă
        public static async Task<bool> RemoveInternalHost(string server)
        {
            HttpClient client = ConfigClient();

            dynamic response = await DeleteData(client, "/config/internal/" + server);

            return response;
        }

        // Metodă globală care permite
        // executarea cererilor de tip GET
        private static async Task<dynamic> GetData(HttpClient client, string route)
        {
            HttpResponseMessage response = await client.GetAsync(route);

            dynamic obj = null;

            if (response.IsSuccessStatusCode)
                obj = await response.Content.ReadAsStringAsync();

            return obj;
        }

        // Metodă globală care permite
        // executarea cererilor de tip POST
        private static async Task<dynamic> PostData(HttpClient client, string route, Dictionary<string, string> data)
        {
            dynamic content = new FormUrlEncodedContent(data);

            HttpResponseMessage response = await client.PostAsync(route, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        // Metodă globală care permite
        // executarea cererilor de tip PUT
        private static async Task<dynamic> PutData(HttpClient client, string route, Dictionary<string, string> data)
        {
            dynamic content = new FormUrlEncodedContent(data);

            HttpResponseMessage response = await client.PutAsync(route, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        // Metodă globală care permite
        // executarea cererilor de tip DELETE
        private static async Task<dynamic> DeleteData(HttpClient client, string route)
        {

            HttpResponseMessage response = await client.DeleteAsync(route);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        // Metodă globală în care se configurează
        // obiectul client prin care se trimit cererile
        private static HttpClient ConfigClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://" + Globals.ProxyIP);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
