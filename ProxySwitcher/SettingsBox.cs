using System;
using System.Windows.Forms;

namespace ProxySwitcher
{
    public partial class SettingsBox : Form
    {
        public SettingsBox()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var newHost = this.proxyUrlTxt.Text;
            var newPort = this.proxyPortTxt.Text;

            ProxyEntry entry;

            if(!string.IsNullOrWhiteSpace(newHost)) {
                if(!string.IsNullOrWhiteSpace(newPort)) {
                    int testVal = 0;    
                    if(int.TryParse(newPort, out testVal)) {
                        entry = new ProxyEntry(newHost, testVal);
                    } else {
                        entry = new ProxyEntry(newHost);
                    }
                } else {
                    entry = new ProxyEntry(newHost);
                }

                ProxyControl.SetProxy(entry);
            }

            this.Close();
        }

        private void SettingsBox_Load(object sender, EventArgs e)
        {
            var currentEntry = ProxyControl.GetProxy();
            this.proxyUrlTxt.Text = currentEntry.Address;
            this.proxyPortTxt.Text = currentEntry.Port.ToString();
        }
        
    }
}
