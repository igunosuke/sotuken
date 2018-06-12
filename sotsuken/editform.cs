using System;
using System.Windows.Forms;

namespace sotsuken
{
    public partial class editForm : Form
    {

        //mainFormのインスタンス格納用
        private vpnformInstance vpnformInstance;

        public editForm(vpnformInstance vpnformInstance)
        {
            InitializeComponent();

            //vpnFormのインスタンス取得
            this.vpnformInstance = vpnformInstance;

            //editbuttonから来たなら選択していたVPN名をvpnnameに格納
            if (vpnformInstance != null)
            {
                nametext.Text = this.vpnformInstance.vpnlist.SelectedItem.ToString();

            }
        }

        private void vpnValueBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((string)vpnValueBox.SelectedItem == "事前共有キーを使ったL2TP/IPSec")
            {
                secretKeyBox.Enabled = true;
            }
            else
            {
                secretKeyBox.Enabled = false;
            }
        }

        public editForm()
        {
        }

        private void compbutton_Click(object sender, EventArgs e)
        {
            //必須事項が記入されているか確かめる
            bool checkflg = check(nametext.Text,iptext.Text);
            if(checkflg == false)
            {
                MessageBox.Show("入力事項を確認してください");
                return;
            }

            //流すためのソースを作成
            string src;
            if (vpnformInstance == null)
            {
                src = "Add-VpnConnection";   //作成ボタンで開いたなら
            }
            else
            {
                src = "Set-VpnConnection";   //編集ボタンで開いたなら
            }

            string vpnValue = vpnValueChange((string)vpnValueBox.SelectedItem, secretKeyBox.Text);
            string AuthMethod = "Chap";

            src = src + " -Name " + nametext.Text + " -ServerAddress " + iptext.Text +" -TunnelType "+ vpnValue + " -AuthenticationMethod " + AuthMethod+" -Force";

            vpnformInstance.RunPowerShell(src,0);

            this.Close();

        }

        public void canbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //メソッド宣言部
        /// <summary>
        /// 入力が正しいかの確認
        /// </summary>
        /// <param name="name">宛先名</param>
        /// <param name="ip">宛先IP</param>
        /// <returns>ただしければtrue間違っていればfalse</returns>
        public bool check(string name, string ip) {
            bool checkflg = false;

            if (name != "" && ip != "" )
            {
                if (ipcheck(ip) == true) {
                    checkflg = true;
                }
            }

            return checkflg;
        }

        /// <summary>
        /// ipアドレスの確認
        /// </summary>
        /// <param name="ipadd">確認するip</param>
        /// <returns></returns>
        public bool ipcheck(string ipadd)
        {
            bool checkflg = false;
            System.Net.IPAddress address;

            if (System.Net.IPAddress.TryParse(ipadd, out address))
            {
                // IPアドレスをチェック
                checkflg = true;

            }

            return checkflg;
        }

        public string vpnValueChange(string VpnSelect,string key)
        {
            string vpnValue = "Automatic";

            /*
            自動
            PPTP
            証明書を使ったL2TP/IPsec
            事前共有キーを使ったL2TP/IPSec
            SSTP
            IKEv2
             */
            switch (VpnSelect)
            {
                case "PPTP":
                    vpnValue = "PPTP";
                    break;
                case "証明書を使ったL2TP/IPsec":
                    vpnValue = "L2TP";
                    break;
                case "事前共有キーを使ったL2TP/IPSec":
                    vpnValue = "L2TP -L2tpPsk " + key;
                    break;
                case "SSTP":
                    vpnValue = "SSIP";
                    break;
                case "IKEv2":
                    vpnValue = "IKEv2";
                    break;
            }

            return vpnValue;
        }

        /// <summary>
        /// shellに渡すVPN接続コマンドを作成します。引数は実際にコマンドで使用するパラメータに対応します。
        /// </summary>
        /// <param name="addOrSet">作成か編集かの部分。</param>
        /// <param name="name">接続先名</param>
        /// <param name="srvAddress">接続先IPアドレス(文字列)</param>
        /// <param name="tunnelType">メニューで選ばれたトンネル方式</param>
        /// <param name="authMethod">認証方式。デフォルト(引数なし)でCHAP指定</param>
        /// <returns>成形されたstring型のShellコマンド。</returns>
        public string vpnConnectionString(string addOrSet, string name, string srvAddress, string tunnelType, string authMethod = "chap")
        {
            return addOrSet + " -Name " + name + " -ServerAddress " + srvAddress + " -TunnelType " + tunnelType + " -AuthenticationMethod " + authMethod + " -Force";
        }

    }
}
