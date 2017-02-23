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

        private ToolStripMenuItem enableItem;
        private ToolStripMenuItem disableItem;

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ContextMenuStrip</returns>
        public ContextMenuStrip Create()
        {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Enable the proxy.
            enableItem = new ToolStripMenuItem();
            enableItem.Text = "Enable";
            enableItem.Click += new EventHandler(Enable_Click);
            enableItem.Enabled = !ProxyControl.IsProxyEnabled();
            menu.Items.Add(enableItem);

            // Disable the proxy.
            disableItem = new ToolStripMenuItem();
            disableItem.Text = "Disable";
            disableItem.Click += new EventHandler(Disable_Click);
            disableItem.Enabled = ProxyControl.IsProxyEnabled();
            menu.Items.Add(disableItem);

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
            enableItem.Enabled = !enableItem.Enabled;
            disableItem.Enabled = !disableItem.Enabled;
            ProxyControl.SetProxyStatus(true);
        }

        /// <summary>
        /// Handles the Click event of the Disable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void Disable_Click(object sender, EventArgs e)
        {
            enableItem.Enabled = !enableItem.Enabled;
            disableItem.Enabled = !disableItem.Enabled;
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
