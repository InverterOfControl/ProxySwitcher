using ProxySwitcher.Properties;
using System;
using System.Windows.Forms;

namespace ProxySwitcher
{
    public class ProcessIcon : IDisposable
    {
        NotifyIcon notifyIcon;

        public ProcessIcon() {
            notifyIcon = new NotifyIcon();
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }

        internal void Display()
        {
            notifyIcon.MouseClick += new MouseEventHandler(notifyIcon_MouseClick);
            notifyIcon.Icon = Resources.proxy16x16;
            notifyIcon.Text = "Small Proxy Switcher";
            notifyIcon.Visible = true;

            // Attach a context menu.
            notifyIcon.ContextMenuStrip = new ContextMenu().Create();
        }

        void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            // Handle mouse button clicks.
            // do something useful
        }
    }
}
