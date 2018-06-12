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
        public string vname="j";
        public string Ip="j";

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

    }


}
