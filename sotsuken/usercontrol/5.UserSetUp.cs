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
        private BeginnerForm b1;

        public UserSetUp()
        {
            InitializeComponent();
            b1 = new BeginnerForm();
        }

        private void compButton_Click(object sender, EventArgs e)
        {
            b1.UserSet(true,userText.Text,passText.Text);
            FindForm().Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            b1.UserSet(false,null,null);
        }

        /// <summary>
        ///ユーザー情報を返すメソッド
        /// </summary>
        /// <returns>0:ユーザー名 1:パスワード</returns>
        public string[] UserGet()
        {
            string[] date = new string[2];
            date[0] = userText.Text;
            date[1] = passText.Text;
            
            return date;
        }
    }
}
