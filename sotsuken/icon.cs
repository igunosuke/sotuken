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
    public partial class icon : Form
    {
        private vpnformInstance vpnFormInstance;
        public icon()
        {
            InitializeComponent();
        }

        public icon(vpnformInstance vpnformInstance)
        {
            this.vpnformInstance = vpnformInstance;
        }

        //変数宣言部
        public static string vpn_name;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //マウスを左クリックした場合と動かした場合のイベントをロードする
            pictureBox1.MouseDown += new MouseEventHandler(MouseDownEvent);
            pictureBox1.MouseMove += new MouseEventHandler(MouseMoveEvent);
            this.ControlBox = false;
        }
        //マウスポインタの宣言
        private Point mousePoint;
        private vpnformInstance vpnformInstance;

        //マウスを左クリックしているとき
        private void MouseDownEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X,e.Y);
            }
        }

        //マウスを動かした時
        private void MouseMoveEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //this.Left += e.X - mousePoint.X;
                //this.Top += e.Y - mousePoint.Y;
                this.Left = Cursor.Position.X + mousePoint.X*-1;
                this.Top = Cursor.Position.Y + mousePoint.Y*-1;
                //または、つぎのようにする
                //this.Location = new Point(
                //this.Location.X + e.X - mousePoint.X,
                //this.Location.Y + e.Y - mousePoint.Y);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vpnformInstance f1 = new vpnformInstance();
            f1.disconnect(vpn_name);
            MessageBox.Show(vpn_name);
            this.Close();
        }
        
        //メソッド
        public void GetVpnName(string name) 
        {
            vpn_name = name;
        }

<<<<<<< HEAD

=======
        private void icon_Load(object sender, EventArgs e)
        {
            if (Regex.IsMatch(vpnFormInstance.configal[1].ToString(), "1"))
            {
                this.Disconnect.Visible = false;
                Disconnect.Enabled = false;
            }
        }
>>>>>>> parent of f84bd07... 06/19
    }
}
