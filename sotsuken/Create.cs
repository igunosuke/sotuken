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
    public partial class Create : Form
    {
        vpnformInstance vpnformInstance;

        public Create(vpnformInstance vform)
        {
            vpnformInstance = vform;
            InitializeComponent();
        }

        
        private void BgCreate(object sender, EventArgs e)
        {
            using (BeginnerForm form = new BeginnerForm(vpnformInstance))
            {
                //editForm表示
                BeginnerForm bform = new BeginnerForm(vpnformInstance);
                bform.Show();
            }

        }

        private void CsCreate(object sender, EventArgs e)
        {
            using (var subForm = new editForm(null))
            {
                //editForm表示
                subForm.StartPosition = FormStartPosition.CenterScreen;
                subForm.ShowDialog();
                this.Close();
            }
        }

        private void Create_Load_1(object sender, EventArgs e)
        {

        }

        private void Create_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("初めての方はらくらく作成推奨です");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.らくらく作成黄;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.らくらく作成;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.カスタム作成黄;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.カスタム作成;
        }
    }
}
