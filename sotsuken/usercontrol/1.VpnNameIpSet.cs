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
    public partial class VpnNameIPSet : UserControl
    {

        private BeginnerForm b1 = new BeginnerForm();

        public VpnNameIPSet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 接続名,IPアドレス取得 string[]=date
        /// </summary>
        /// <returns>[0]:IPアドレス,[1]:接続名</returns>
        public string[] NameIPGet()
        {
            string[] date = new string[2];
            date[0] = ip_textbox.Text;
            date[1] = nametext.Text;
            return date;
        }

        private void VpnNameIPSet_VisibleChanged(object sender, EventArgs e)
        {
            string[] date = new string[5];
            date = b1.Getdate();
            if (date[4] == "true")
            {
                ip_textbox.Text = date[0];
                nametext.Text = date[1];
            }
        }
    }


}
