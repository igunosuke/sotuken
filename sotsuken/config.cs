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
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
        }

        private void Disconnect_off_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cexit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
