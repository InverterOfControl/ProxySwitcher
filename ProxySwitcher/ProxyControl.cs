using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProxySwitcher
{
    /// <summary>
    /// Controlling-Class for proxy related things
    /// </summary>
    public class ProxyControl
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
        const string keyName = userRoot + "\\" + subkey;


        public static bool IsProxyEnabled()
        {
            var isEnabled = Registry.GetValue(keyName, "ProxyEnable", false);

            return Convert.ToBoolean(isEnabled);
        }

        public static void SetProxy(ProxyEntry proxy)
        {
            Registry.SetValue(keyName, "ProxyServer", proxy.ToString());

            ensureRefresh();
        }

        public static void SetProxyStatus(bool enable)
        {
            Registry.SetValue(keyName, "ProxyEnable", enable ? "1" : "0");
            ensureRefresh();
        }

        public static ProxyEntry GetProxy()
        {
            string host = Registry.GetValue(keyName, "ProxyServer", string.Empty).ToString();
            return new ProxyEntry(host);
        }
        private static void ensureRefresh()
        {
            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
    }
}
