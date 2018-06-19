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
    public partial class check : UserControl
    {

        BeginnerForm b1 = new BeginnerForm();

        public check(BeginnerForm b2)
        {
            InitializeComponent();
            b1 = b2;
        }



        private void check_Load(object sender, EventArgs e)
        {
            reprint();
        }

        /// <summary>
        /// BeginnerFormからメソッドを呼び出しラベルに反映する。
        /// </summary>
        private void reprint() {
            
            string[] config = new string[4];
            config = b1.ConfigGet();
            VpnName.Text = config[0];
            Ip.Text = config[1];
            Config.Text = config[2];
            Key.Text = config[3];
        }

        private void ConfigLabel_VisibleChanged(object sender, EventArgs e)
        {
            reprint();
        }

        public void VpnNameLabel_Click(object sender, EventArgs e)
        {
            b1.PageMove(1);
            b1.ButonnTextReprint(0);
        }

        private void IpLabel_Click(object sender, EventArgs e)
        {
            b1.PageMove(1);
            b1.ButonnTextReprint(0);
        }

        private void ConfigLabel_Click(object sender, EventArgs e)
        {
            b1.PageMove(2);
            b1.ButonnTextReprint(0);
        }

        private void Keylabel_Click(object sender, EventArgs e)
        {
            b1.PageMove(2);
            b1.ButonnTextReprint(0);
        }

        private void check_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
