using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sotsuken
{
    public partial class BConfig : UserControl
    {
        public BConfig()
        {
            InitializeComponent();
        }

        private string tunneltype = "";
        private BeginnerForm b1 = new BeginnerForm();

        private void vpnValueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vpnValueBox.Text == "事前共有キーを使ったL2TP/IPSec")
            {
                KeyTextBox.Enabled = true;
            }
            else {
                KeyTextBox.Enabled = false;
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            BeginnerForm f1 = new BeginnerForm();
            editForm e1 = new editForm();
            tunneltype = e1.vpnValueChange((string)vpnValueBox.SelectedItem,KeyTextBox.Text);
            f1.ConfigNext(true,KeyTextBox.Text,tunneltype);           
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            BeginnerForm f1 = new BeginnerForm();
            f1.ConfigNext(false, null,null);
        }

        /// <summary>
        /// listの選択した設定と事前共有キーを渡す
        /// </summary>
        /// <returns>[0]:設定 [1]:事前共有キー</returns>
        public string[] ConfigKeyGet()
        {
            string[] date = new string[2];
            date[0] = (string)vpnValueBox.SelectedItem;
            date[1] = KeyTextBox.Text;

            return date;
        }

        private void BConfig_Load(object sender, EventArgs e)
        {
            string[] date = new string[5];
            date = b1.Getdate();
            if (date[4] == "true")
            {
                KeyTextBox.Text = date[3];
            }
        }
    }
}
