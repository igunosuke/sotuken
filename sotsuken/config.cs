using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sotsuken
{
    public partial class config : Form
    {
        private vpnformInstance vpnFormInstance;

        public config()
        {
            InitializeComponent();
        }

        public config(vpnformInstance instance)
        {
            InitializeComponent();
            this.vpnFormInstance = instance;
            
        }

        private void Disconnect_off_CheckedChanged(object sender, EventArgs e)
        {
            if (Disconnect_off.Checked == true)
            {
                //vpnformInstance v1 = new vpnformInstance();

                vpnFormInstance.configal[1] = "1\r\n";

            }
            else
            {
                vpnFormInstance.configal[1] = "0\r\n";
            }
        }

        private void Cexit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Csave_button_Click(object sender, EventArgs e)
        {
            vpnFormInstance.fileSave();
        }

        private void icon_off_CheckedChanged(object sender, EventArgs e)
        {
            
            if (icon_off.Checked == true)
            {
                //vpnformInstance v1 = new vpnformInstance();
                
                vpnFormInstance.configal[0] = "1\r\n";

            }
            else
            {
                vpnFormInstance.configal[0] = "0\r\n";
            }

            
        }

        private void config_Load(object sender, EventArgs e)
        {
            if (vpnFormInstance.configal[0].ToString() == "1\r\n")
            {
                icon_off.Checked = true;
            }
            if (vpnFormInstance.configal[1].ToString() == "1\r\n")
            {
                Disconnect_off.Checked = true;
            }
        }
    }
}
