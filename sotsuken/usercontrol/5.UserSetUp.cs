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
    public partial class UserSetUp : UserControl
    {


        public UserSetUp()
        {
            InitializeComponent();
        }

        /// <summary>
        ///ユーザー情報を返すメソッド.0:ユーザー名 1:パスワード
        /// </summary>
        /// <returns>0:ユーザー名 1:パスワード</returns>
        public string[] UserGet()
        {
            string[] date = new string[2];
            date[0] = userText.Text;
            date[1] = passText.Text;

            return date;
        }

        private void password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (password_checkbox.Checked)
            {
                passText.UseSystemPasswordChar = false;
            }
            else
            {
                passText.UseSystemPasswordChar = true;
            }
        }
    }
}
