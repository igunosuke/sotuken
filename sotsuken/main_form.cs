﻿using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace sotsuken
{
    public partial class vpnformInstance : Form
    {
        public vpnformInstance()
        {
            InitializeComponent();
        }

        public vpnformInstance(vpnformInstance vpnformInstance)
        {
            this.vpnformInstance1 = vpnformInstance;
        }


        //変数宣言部
        List<List<string>> infolist = new List<List<string>>();
        string string_tmp;//都合よく使う存在
        public ArrayList configal = new ArrayList();//config管理
        private int tmp = 0;
        private bool CTflg = true;
        private vpnformInstance vpnformInstance1;

        private void vpn_Load(object sender, EventArgs e)
        {
            loadVPN();
            //configファイル読み込み
            string config = "";
            bool file_flg = true;
            while (file_flg)
            {
                try
                {
                    using (StreamReader sr = new StreamReader
                        ("config.txt", Encoding.GetEncoding("Shift_JIS")))
                    {
                        while ((config = sr.ReadLine()) != null)
                        {
                            configal.Add(config);
                        }
                    }
                    file_flg = false;
                }
                catch
                {
                    using (System.IO.FileStream hStream = System.IO.File.Create(@"./config.txt"))
                    {
                        if (hStream != null)
                        {
                            hStream.Close();
                        }
                        // 作成時に返される FileStream を利用して閉じる

                    }

                    //作成して書き込み
                    StreamWriter writer = new StreamWriter(@"./config.txt", false);
                    for (int i = 0; i < 3; i++)
                    {
                        writer.Write("0\r\n");
                        configal.Add("0\r\n");
                    }
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            }
            FontChenge();
        }

        public void fileSave()
        {
            //書き込み
            StreamWriter writer = new StreamWriter(@"./config.txt", false);
            for (int i = 0; i < 3; i++)
            {
                if (0 <= configal[i].ToString() .IndexOf("\r\n"))
                {
                 
                }
                else
                {
                    configal[i] += "\r\n"; 
                }

                writer.Write(configal[i].ToString());

            }
            if (writer != null)
            {
                writer.Close();
            }
        }
        private void connectbutton_Click(object sender, EventArgs e)
        {
            tmp = vpnlist.SelectedIndex;
            if (CTflg == true)
            {
                if (selectCheck() == true)
                {
                    //接続状態がDisconnectedなら接続、Connectedなら注意ウィンドウを出す
                    if (infolist[tmp][3] != "Connected")
                    {
                        using (var authForm = new authForm(this))
                        {
                            authForm.ShowDialog();
                            string_tmp = vpnlist.SelectedItem.ToString();
                            loadVPN();
                        }
                    }
                    else
                    {
                        MessageBox.Show("このVPNはすでに接続されています");
                    }
                    if (Regex.IsMatch(configal[0].ToString(), "0"))
                    {
                        loadVPN();
                        if (infolist[tmp][3] != "Disconnected")
                        {
                            IconShow(1, string_tmp);
                            CTflg = false;
                            timer.Start();
                        }
                    }

                }
            }
        }

        private void disconnectbutton_Click(object sender, EventArgs e)
        {
            if (selectCheck() == true)
            {
                int tmp = vpnlist.SelectedIndex;
                //接続状態がConnectedなら切断、Disconnectedなら注意ウィンドウを出す
                if (infolist[tmp][3] != "Disconnected ")
                {
                    disconnect(vpnlist.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("このVPNは接続されていません");
                }
                if (infolist[tmp][3] != "")
                {
                    string_tmp = vpnlist.SelectedItem.ToString();
                }
                loadVPN();
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (selectCheck() == true)
            {
                //editfomtにVPN情報を渡す
                using (var subForm = new editForm(this))
                {
                    //editForm表示

                    subForm.ShowDialog();
                }

                loadVPN();
            }
        }

        private void createbutton_Click_1(object sender, EventArgs e)
        {
            if (Regex.IsMatch(configal[2].ToString(), "1"))
            {
                using (BeginnerForm form = new BeginnerForm(this))
                {
                    //editForm表示
                    BeginnerForm bform = new BeginnerForm(this);
                    bform.StartPosition = FormStartPosition.CenterScreen;
                    bform.Show();
                }
            }
            else if (Regex.IsMatch(configal[2].ToString(), "2"))
            {
                using (var subForm = new editForm(null))
                {
                    //editForm表示
                    subForm.StartPosition = FormStartPosition.CenterScreen;
                    subForm.ShowDialog();
                }
            }
            else
            {
                //何も渡さずにediformを表示
                Create frm = new Create(this);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
            loadVPN();
        }

        private void vpnlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*-------------------------------------------選択行のVPN情報を表示------------------------------------------*/
            /*
           [0] 　VPM名
           [1]　 サーバーアドレス
           [2] 　トンネルタイプ
           [3]　 接続状態
           [4]　 DNSサーバアドレス
            */
            infobox.Clear();
            try
            {
                for (int i = 0; ; i++)
                {
                    if ((string)vpnlist.SelectedItem == infolist[i][0].ToString())
                    {
                        infobox.Text = ("VPN名\t\t：" + infolist[i][0] + "\r\nVPNサーバIP\t：" + infolist[i][1] + "\r\nトンネルタイプ\t：" + infolist[i][2] + "\r\n接続状態\t\t：" + infolist[i][3] + "\r\nDNSサーバIP\t：" + infolist[i][4]);
                        break;
                    }
                }
            }
            catch
            {
            }

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (selectCheck() == true)
            {
                string delSource = @"Remove-VpnConnection " + vpnlist.SelectedItem.ToString() + " -Force";

                RunPowerShell(delSource, 0,0);

                loadVPN();
            }

        }

        private void Mconfig_button_Click(object sender, EventArgs e)
        {
            ConfigShow();

        }


        //ここからメソッド

        public void loadVPN()
        {
            //更新のためにvpnlistをクリア
            vpnlist.Items.Clear();

            //更新のためにinfolistをクリア
            infolist.Clear();

            string src = @"vpnlist.txt";

            if (File.Exists(src))
            {
            }
            else
            {
                File.Create("vpnlist.txt");
            }

            // ファイル属性を取得
            FileAttributes fa = File.GetAttributes(src);
            // 読み取り専用属性を削除（他の属性は変更しない）
            fa = fa & ~FileAttributes.ReadOnly;
            File.SetAttributes(src, fa);
            //VPNデータをもって来てテキストに書き込もうね～
            string refreshsource = @"Get-VpnConnection | Out-File vpnlist.txt -Encoding UTF8";
            RunPowerShell(refreshsource, 1,0);

            string line = "";
            int vpncnt = 0;
            //取得したデータを取得するリスト
            ArrayList vl = new ArrayList();

            //直下から起動時に作ったtxtデータを持ってくる
            using (StreamReader sr = new StreamReader(
                "vpnlist.txt", Encoding.GetEncoding("UTF-8")))
            {

                //取得したデータをリストに格納
                while ((line = sr.ReadLine()) != null)
                {
                    vl.Add(line);
                }
            }

            //リストに格納したデータを絞って出力
            for (int i = 0; i < vl.Count; i++)
            {
                if (vl[i].ToString().Contains("Name") == true)
                {
                    vpnlist.Items.Add(((string)vl[i]).Remove(0, 24));
                    vpncnt++;
                }
            }

            //読み取り専用属性を追加する
            File.SetAttributes(src, FileAttributes.ReadOnly);

            /*
            各VPNのデータをinfolistに格納
            [0] 　VPM名
            [1]　 サーバーアドレス
            [2] 　トンネルタイプ
            [3]　 接続状態
            [4]　 DNSサーバアドレス
             */
            if (vpncnt != 0)
            {
                string[] infobuffer = new string[5];
                for (int i = 0; i < vl.Count; i++)
                {
                    if (vl[i].ToString().Contains("Name") == true)
                    {
                        infobuffer[0] = ((string)vl[i]).Remove(0, 24);
                    }
                    else if (vl[i].ToString().Contains("ServerAddress") == true)
                    {
                        infobuffer[1] = ((string)vl[i]).Remove(0, 24);
                    }
                    else if (vl[i].ToString().Contains("TunnelType") == true)
                    {
                        infobuffer[2] = ((string)vl[i]).Remove(0, 24);
                    }
                    else if (vl[i].ToString().Contains("ConnectionStatus") == true)
                    {
                        infobuffer[3] = ((string)vl[i]).Remove(0, 24);
                    }
                    else if (vl[i].ToString().Contains("DnsSuffix") == true)
                    {
                        infobuffer[4] = ((string)vl[i]).Remove(0, 24);

                        infolist.Add(new List<string>(new string[] { infobuffer[0], infobuffer[1], infobuffer[2], infobuffer[3], infobuffer[4] }));
                    }
                }
            }

        }

        public static void RunPowerShell(string strCmd, int flg,int mode) //flgは成功ウィンドウが必要な場合だけ出力するフラグ
        {

            //PowerShellのエラーを取得するためのオブジェクト
            try
            {
                IList objErrors = null;

                using (Runspace objRunspace = RunspaceFactory.CreateRunspace())
                {

                    objRunspace.Open();
                    RunspaceInvoke objRunspaceInvoke = new RunspaceInvoke(objRunspace);

                    //PowerShellコマンドを実行
                    Collection<PSObject> objResultCollection = objRunspaceInvoke.Invoke(strCmd, null, out objErrors);

                }
                if (flg == 0)
                    MessageBox.Show("コマンドを実行しました");
            }
            catch (Exception ex)
            {
                if (mode == 1) {
                    MessageBox.Show("同じ名前のvpnの作成をすることができません");
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public bool selectCheck()
        {
            bool flg = false;
            //何も選択していなければ確認ポップをだす
            if (vpnlist.SelectedItem == null)
            {
                MessageBox.Show("VPNを選択してください");
            }
            else
            {
                flg = true;
            }

            return flg;
        }

        /// <summary>
        /// アイコン表示
        /// </summary>
        /// <param name="flg">1の時接続を試みる</param>
        /// <param name="vpn_name">接続試みるvpn名を渡す</param>
        public void IconShow(int flg, string vpn_name)
        {
            if (flg == 1)
            {
                icon f1 = new icon(this);
                f1.GetVpnName(vpn_name);
                vpnformInstance v1 = new vpnformInstance(this);
                this.WindowState = FormWindowState.Minimized;
                f1.Show();

            }
        }
        private void ConfigShow()
        {
            config f1 = new config(this);
            f1.Show();
            

        }

        public void disconnect(string vpn_name)
        {
            string disSource = @"RasDial " + vpn_name + " /disconnect";
            RunPowerShell(disSource, 1,0);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadVPN();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CTflg = true;
            timer.Stop();
        }

       private void FontChenge()
        {
            //PrivateFontCollectionオブジェクトを作成する
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            //PrivateFontCollectionにフォントを追加する
            pfc.AddFontFile(@"./FONT/A-OTF-UDShinMGoPr6-Regular.otf");
            //同様にして、複数のフォントを追加できる
            //pfc.AddFontFile(@"FONT/AdobeFnt19.lst");

            //PrivateFontCollectionに追加されているフォントの名前を列挙する
            foreach (System.Drawing.FontFamily ff in pfc.Families)
            {
                Console.WriteLine(ff.Name);
            }

            //PrivateFontCollectionの先頭のフォントのFontオブジェクトを作成する
            System.Drawing.Font f =
                new System.Drawing.Font(pfc.Families[0], 12);

            //Labelコントロールのフォントに設定する
            infobox.Font = f;

            //後始末
            pfc.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectbutton_MouseEnter(object sender, EventArgs e)
        {
            connectbutton.BackgroundImage = Properties.Resources.接続;
        }

        private void connectbutton_MouseLeave(object sender, EventArgs e)
        {
            connectbutton.BackgroundImage = Properties.Resources.接続白;
        }

        private void disconnectbutton_MouseEnter(object sender, EventArgs e)
        {
            disconnectbutton.BackgroundImage = Properties.Resources.切断黄;
        }

        private void disconnectbutton_MouseLeave(object sender, EventArgs e)
        {
            disconnectbutton.BackgroundImage = Properties.Resources.切断;
        }

        private void createbutton_MouseEnter(object sender, EventArgs e)
        {
            createbutton.BackgroundImage = Properties.Resources.作成黄;
        }

        private void createbutton_MouseLeave(object sender, EventArgs e)
        {
            createbutton.BackgroundImage = Properties.Resources.作成;
        }

        private void editbutton_MouseEnter(object sender, EventArgs e)
        {
            editbutton.BackgroundImage = Properties.Resources.編集黄;
        }

        private void editbutton_MouseLeave(object sender, EventArgs e)
        {
            editbutton.BackgroundImage = Properties.Resources.編集;
        }

        private void deletebutton_MouseEnter(object sender, EventArgs e)
        {
            deletebutton.BackgroundImage = Properties.Resources.削除黄;
        }

        private void deletebutton_MouseLeave(object sender, EventArgs e)
        {
            deletebutton.BackgroundImage = Properties.Resources.削除;
        }
    }
}
