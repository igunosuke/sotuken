﻿using System;
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
    public partial class authForm : Form
    {

        private vpnformInstance vpnformInstance;
        public  string vname = "NULL";
        private BeginnerForm beginnerForm;

        public authForm(vpnformInstance vpnformInstance)
        {
            InitializeComponent();

            this.vpnformInstance = vpnformInstance;
        }

        public authForm(BeginnerForm beginnerForm)
        {
            this.beginnerForm = beginnerForm;
        }

        public authForm()
        {
        }

        private void compButton_Click(object sender, EventArgs e)
        {
                string src="";
                src = ConnectSrcCreate(vname,userText.Text,passText.Text);
                if (src != "NULL")
                {
                    vpnformInstance.RunPowerShell(src, 1); this.Close();
                }
                else
                {
                    return;
                }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string ConnectSrcCreate(string vname,string user,string pass)
        {
            string src = @"rasdial.exe ";
            if (user != "" && pass != "")
            {
                src += vname + " " + user + " " + pass;
            }
            else
            {
                MessageBox.Show("入力に漏れがあります");
                src = "NULL";
            }
            MessageBox.Show(src);
            return src;
        }

        private void authForm_Load(object sender, EventArgs e)
        {
            if (vname == "NULL")
            {
                vname = vpnformInstance.vpnlist.SelectedItem.ToString();
            }
        }
    }
}
