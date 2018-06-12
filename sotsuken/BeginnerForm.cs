using System;
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
    public partial class BeginnerForm : Form
    {
        //変数宣言部
        public static string name = "";
        public static string Ip = "";
        public static string Key = "";
        public static string tunnelType = "";
        public static string tunnelTypeStr = "";
        private static int page = 0;
        public static string addOrSet;
        public static set_title set_ctr;
        public static VpnNameIPSet vpn_ctr;
        public static BConfig config_ctr;
        public static set_end end_ctr;
        public static UserSetUp user_ctr;
        public static check check_ctr;

        vpnformInstance vpnformInstance;

        //変数宣言部
        public BeginnerForm(vpnformInstance vpnformInstance)
        {
            InitializeComponent();

            //vpnFormのインスタンス取得
            this.vpnformInstance = vpnformInstance;


            //ユーザーコントロール初期化
            set_ctr = new set_title();
            vpn_ctr = new VpnNameIPSet();
            config_ctr = new BConfig();
            end_ctr = new set_end();
            user_ctr = new UserSetUp();
            check_ctr = new check();


            //panelに追加
            field_panel.Controls.Add(set_ctr);
            field_panel.Controls.Add(vpn_ctr);
            field_panel.Controls.Add(config_ctr);
            field_panel.Controls.Add(end_ctr);
            field_panel.Controls.Add(user_ctr);
            field_panel.Controls.Add(check_ctr);

            //視覚化
            PageMove(0);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            page = GetPage();
            switch (page)
            {
                case 0:
                    this.Close();
                    break;
                case 1:
                    PageMove(0);
                    break;
                case 2:                   
                    PageMove(1);
                    break;
                case 3:
                    ButonnTextReprint(0);
                    PageMove(2);
                    break;
                case 4:
                    ButonnTextReprint(1);
                    this.Close();
                    break;
                case 5:
                    PageMove(4);
                    break;
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            page = GetPage();
            string[] date = new string[2];
            editForm e1 = new editForm();
            string scr;
            switch (page)
            {
                case 0: //0ページ目
                    PageMove(1);
                    break;
                case 1://1ページ目
                    date = vpn_ctr.NameIPGet();
                    Ip = date[0];
                    name = date[1];
                    if (e1.check(name,Ip)==false) {
                        MessageBox.Show("入力が正しくありません");
                    }
                    else {
                        PageMove(2);
                    }
                    break;
                case 2://2ページ目
                    date = config_ctr.ConfigKeyGet();
                    tunnelTypeStr = date[0];
                    Key = date[1];
                    tunnelType = e1.vpnValueChange(tunnelTypeStr,Key);
                    if (Key == "" && tunnelType == "L2TP -L2tpPsk ")
                    {
                        MessageBox.Show("事前共有キーの入力がされていません");
                    }
                    else
                    {
                        PageMove(3);
                        ButonnTextReprint(1);
                    }
                    break;
                case 3: //3ページ目
                        //vpn作成
                    addOrSet = @"Add-VpnConnection";
                    scr = e1.vpnConnectionString(addOrSet, name, Ip, tunnelType);
                    vpnformInstance.RunPowerShell(scr, 0);
                    ButonnTextReprint(2);
                    PageMove(4);
                    break;
                case 4://4ページ目
                    PageMove(5);
                    break;
            }  
        }

        private void BeginnerForm_Load(object sender, EventArgs e)
        {
            ButonnTextReprint(0);
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            page = GetPage();
            if (page == 4) {
            }
            else
            {
                this.Close();
            }
        }

        //メソッド↓

        public BeginnerForm()
        {
        }

        //ユーザーコントロールの表示云々


        /// <summary>
        /// configのメソッド
        /// </summary>
        /// <param name="flg">戻る:false,次へ:true</param>
        /// <param name="key">事前共有キー</param>
        /// <param name="tunneltype">vpnの種類</param>
        public void ConfigNext(bool flg, string key, string tunneltype) {

            if (flg)
            {
                if (key == "" && tunneltype == "L2TP -L2tpPsk ")
                {
                    MessageBox.Show("事前共有キーの入力がされていません");
                }
                else
                {
                    Key = key;
                    tunnelType = tunneltype;
                    PageMove(3);
                }
            }
            else {
                PageMove(1);
            }

        }


        /// <summary>
        /// check用めそっど
        /// </summary>
        /// <param name="tmp">戻る:1,次へ:0</param>
        public void CheckCtr(int tmp) {
            switch (tmp)
            {
                case 0:
                    PageMove(4);
                    break;
                case 1:
                    PageMove(2);
                    break;
            }
        }

     
        /// <summary>
        /// UserSetで使うためのメソッド
        /// </summary>
        /// <param name="flg">戻るボタンはfalse接続はtrue</param>
        /// <param name="user">ユーザー名</param>
        /// <param name="pass">パスワード</param>
        public void UserSet(bool flg, string user, string pass)
        {
            if (flg)
            {
                string src = "";
                authForm a1 = new authForm();

                src = a1.ConnectSrcCreate(name,user,pass);
                vpnformInstance.RunPowerShell(src, 0);             
            }
            else
            {
                PageMove(4);
            }
        }

        /// <summary>
        /// string[4]を返します[0]:接続名[1]:接続IP[2]:VPN種類[3]:事前共有キー
        /// </summary>
        /// <returns></returns>
        public string[] ConfigGet() {
            string[] config = new string[4];
            config[0] = name;
            config[1] = Ip;
            config[2] = tunnelTypeStr;
            config[3] = Key;

                return config;
        }

        /// <summary>
        /// らくらく設定の画面をきりかえるためのメソッド
        /// </summary>
        /// <param name="page">0～5の値を指定します。</param>
        public void PageMove(int page)
        {
            switch (page)
            {
                case 0:
                    set_ctr.Visible = true;
                    vpn_ctr.Visible = false;
                    config_ctr.Visible = false;
                    check_ctr.Visible = false;
                    end_ctr.Visible = false;
                    user_ctr.Visible = false;

                    break;
                case 1:
                    set_ctr.Visible = false;
                    vpn_ctr.Visible = true;
                    config_ctr.Visible = false;
                    check_ctr.Visible = false;
                    end_ctr.Visible = false;
                    user_ctr.Visible = false;

                    break;
                case 2:
                    set_ctr.Visible = false;
                    vpn_ctr.Visible = false;
                    config_ctr.Visible = true;
                    check_ctr.Visible = false;
                    end_ctr.Visible = false;
                    user_ctr.Visible = false;
                    break;
                case 3:
                    set_ctr.Visible = false;
                    vpn_ctr.Visible = false;
                    config_ctr.Visible = false;
                    check_ctr.Visible = true;
                    end_ctr.Visible = false;
                    user_ctr.Visible = false;
                    break;
                case 4:
                    set_ctr.Visible = false;
                    vpn_ctr.Visible = false;
                    config_ctr.Visible = false;
                    check_ctr.Visible = false;
                    end_ctr.Visible = true;
                    user_ctr.Visible = false;
                    break;
                case 5:
                    set_ctr.Visible = false;
                    vpn_ctr.Visible = false;
                    config_ctr.Visible = false;
                    check_ctr.Visible = false;
                    end_ctr.Visible = false;
                    user_ctr.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// パネルで表示しているpageを取得する
        /// </summary>
        /// <returns></returns>
       public int GetPage()
        {
            int page=9;
            while (true)
            {
                if (set_ctr.Visible == true) { page = 0; break; }
                
                if (vpn_ctr.Visible == true) { page = 1; break; }

                if (config_ctr.Visible == true) { page = 2; break; }

                if (check_ctr.Visible == true) { page = 3; break; }

                if (end_ctr.Visible == true) { page = 4; break; }

                if (user_ctr.Visible == true) { page = 5; break; }

            }
            return page;
        }

        /// <summary>
        /// フォームのボタン表示を変えるためのメソッド
        /// </summary>
        /// <param name="tmp"></param>
        public void ButonnTextReprint(int tmp)
        {
            switch (tmp)
            {
                case 0:
                    Next_button.Visible = true;
                    Back_button.Text = "戻る";
                    Next_button.Text = "次へ";
                    Cancel_button.Text = "キャンセル";
                    break;
                case 1:
                    Next_button.Visible = true;
                    Next_button.Text = "完了";
                    Back_button.Text = "戻る";
                    break;
                case 2:
                    Next_button.Visible = false;
                    Back_button.Text = "終了";
                    Cancel_button.Text = "接続";
                    break;
                case 3:
                    
                    break;


            }
        }


    }
}
