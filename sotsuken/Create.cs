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
        public Create()
        {
            InitializeComponent();
        }

        private void BgCreate(object sender, EventArgs e)
        {
            using (var form = new BeginnerForm(null))
            {
                //editForm表示
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
                this.Close();
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
    }
}
