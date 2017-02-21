using System;
using System.Windows.Forms;

namespace ProxySwitcher
{
    public class ContextMenu
    {
        /// <summary>
        /// Is the About box displayed?
        /// </summary>
        bool isSettingsOpen = false;

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ContextMenuStrip</returns>
        public ContextMenuStrip Create()
        {
            bool isProxyEnabled = ProxyControl.IsProxyEnabled();
        
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Enable the proxy.
            item = new ToolStripMenuItem();
            item.Text = "Enable";
            item.Click += new EventHandler(Enable_Click);
            item.Enabled = !isProxyEnabled;
            menu.Items.Add(item);

            // Disable the proxy.
            item = new ToolStripMenuItem();
            item.Text = "Disable";
            item.Click += new EventHandler(Disable_Click);
            item.Enabled = isProxyEnabled;
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // The Settings.
            item = new ToolStripMenuItem();
            item.Text = "Settings";
            item.Click += new EventHandler(Settings_Click);
            menu.Items.Add(item);

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new System.EventHandler(Exit_Click);
            menu.Items.Add(item);

            return menu;
        }

        /// <summary>
        /// Handles the Click event of the Enable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Enable_Click(object sender, EventArgs e)
        {
            ProxyControl.SetProxyStatus(true);
        }

        /// <summary>
        /// Handles the Click event of the Disable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Disable_Click(object sender, EventArgs e)
        {
            ProxyControl.SetProxyStatus(false);
        }

        /// <summary>
        /// Handles the Click event of the Settings control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Settings_Click(object sender, EventArgs e)
        {
            if (!isSettingsOpen)
            {
                isSettingsOpen = true;
                new SettingsBox().ShowDialog();
                isSettingsOpen = false;
            }
        }

        /// <summary>
        /// Processes a menu item.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Exit_Click(object sender, EventArgs e)
        {
            // Quit without further ado.
            Application.Exit();
        }
    }
}
