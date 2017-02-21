namespace ProxySwitcher
{
    /// <summary>
    /// Simple DTO
    /// </summary>
    public class ProxyEntry
    {
        public string Address { get; set; }

        public int Port { get; set; }

        public ProxyEntry(string host)
        {
            if (host.Contains(":"))
            {
                var parts = host.Split(':');
                Address = parts[0];
                int testVal = 80;
                if (int.TryParse(parts[1], out testVal))
                {
                    Port = testVal;
                }
            }
        }

        public ProxyEntry(string host, int port) {
            if(!string.IsNullOrWhiteSpace(host)) {
                Address = host;   
            }

            if(port != 0 && port != 80) {
                Port = port;
            }
        }

        public override string ToString()
        {
            if(Port != 0 && Port != 80) {
                return string.Join(":", Address, Port);
            }

            return Address;
        }
    }
}
