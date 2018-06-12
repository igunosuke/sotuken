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
        public check()
        {
            InitializeComponent();
        }

 

        private void check_Load(object sender, EventArgs e)
        {
            reprint();
        }

        /// <summary>
        /// BeginnerFormからメソッドを呼び出しラベルに反映する。
        /// </summary>
        private void reprint() {
            BeginnerForm b1 = new BeginnerForm();
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
    }
}
