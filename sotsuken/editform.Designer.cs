namespace sotsuken
{
    partial class editForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nametext = new System.Windows.Forms.TextBox();
            this.iptext = new System.Windows.Forms.TextBox();
            this.compbutton = new System.Windows.Forms.Button();
            this.canbutton = new System.Windows.Forms.Button();
            this.vpnValueBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.secretKeyBox = new System.Windows.Forms.TextBox();
            this.keytext_checkbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nametext.Location = new System.Drawing.Point(12, 175);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(292, 26);
            this.nametext.TabIndex = 0;
            // 
            // iptext
            // 
            this.iptext.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.iptext.Location = new System.Drawing.Point(12, 277);
            this.iptext.Name = "iptext";
            this.iptext.Size = new System.Drawing.Size(292, 26);
            this.iptext.TabIndex = 2;
            // 
            // compbutton
            // 
            this.compbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.compbutton.BackgroundImage = global::sotsuken.Properties.Resources.完了白;
            this.compbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compbutton.FlatAppearance.BorderSize = 0;
            this.compbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compbutton.Location = new System.Drawing.Point(253, 708);
            this.compbutton.Name = "compbutton";
            this.compbutton.Size = new System.Drawing.Size(99, 39);
            this.compbutton.TabIndex = 6;
            this.compbutton.UseVisualStyleBackColor = true;
            this.compbutton.Click += new System.EventHandler(this.compbutton_Click);
            this.compbutton.MouseEnter += new System.EventHandler(this.compbutton_MouseEnter);
            this.compbutton.MouseLeave += new System.EventHandler(this.compbutton_MouseLeave);
            // 
            // canbutton
            // 
            this.canbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canbutton.BackgroundImage = global::sotsuken.Properties.Resources.キャンセル;
            this.canbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.canbutton.FlatAppearance.BorderSize = 0;
            this.canbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canbutton.Location = new System.Drawing.Point(358, 708);
            this.canbutton.Name = "canbutton";
            this.canbutton.Size = new System.Drawing.Size(99, 39);
            this.canbutton.TabIndex = 7;
            this.canbutton.UseVisualStyleBackColor = true;
            this.canbutton.Click += new System.EventHandler(this.canbutton_Click);
            this.canbutton.MouseEnter += new System.EventHandler(this.canbutton_MouseEnter);
            this.canbutton.MouseLeave += new System.EventHandler(this.canbutton_MouseLeave);
            // 
            // vpnValueBox
            // 
            this.vpnValueBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.vpnValueBox.FormattingEnabled = true;
            this.vpnValueBox.Items.AddRange(new object[] {
            "自動",
            "PPTP",
            "証明書を使ったL2TP/IPsec",
            "事前共有キーを使ったL2TP/IPSec",
            "SSTP",
            "IKEv2"});
            this.vpnValueBox.Location = new System.Drawing.Point(12, 360);
            this.vpnValueBox.Name = "vpnValueBox";
            this.vpnValueBox.Size = new System.Drawing.Size(292, 27);
            this.vpnValueBox.TabIndex = 17;
            this.vpnValueBox.Text = "事前共有キーを使ったL2TP/IPSec";
            this.vpnValueBox.SelectedIndexChanged += new System.EventHandler(this.vpnValueBox_SelectionChangeCommitted);
            this.vpnValueBox.SelectionChangeCommitted += new System.EventHandler(this.vpnValueBox_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "＊は必須項目です";
            // 
            // secretKeyBox
            // 
            this.secretKeyBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.secretKeyBox.Location = new System.Drawing.Point(12, 464);
            this.secretKeyBox.Name = "secretKeyBox";
            this.secretKeyBox.Size = new System.Drawing.Size(292, 26);
            this.secretKeyBox.TabIndex = 19;
            this.secretKeyBox.UseSystemPasswordChar = true;
            // 
            // keytext_checkbox
            // 
            this.keytext_checkbox.AutoSize = true;
            this.keytext_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.keytext_checkbox.Location = new System.Drawing.Point(14, 509);
            this.keytext_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.keytext_checkbox.Name = "keytext_checkbox";
            this.keytext_checkbox.Size = new System.Drawing.Size(144, 16);
            this.keytext_checkbox.TabIndex = 21;
            this.keytext_checkbox.Text = "事前共有キーを表示する";
            this.keytext_checkbox.UseVisualStyleBackColor = false;
            this.keytext_checkbox.CheckedChanged += new System.EventHandler(this.keytext_checkbox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::sotsuken.Properties.Resources.タイトル;
            this.pictureBox1.Location = new System.Drawing.Point(18, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::sotsuken.Properties.Resources.VPN名;
            this.pictureBox2.Location = new System.Drawing.Point(12, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::sotsuken.Properties.Resources.サーバーアドレス;
            this.pictureBox3.Location = new System.Drawing.Point(12, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::sotsuken.Properties.Resources.VPNの種類;
            this.pictureBox4.Location = new System.Drawing.Point(12, 318);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(159, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::sotsuken.Properties.Resources.事前共有キー;
            this.pictureBox5.Location = new System.Drawing.Point(12, 412);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(174, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Image = global::sotsuken.Properties.Resources.ロゴ;
            this.pictureBox6.Location = new System.Drawing.Point(-68, 454);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(312, 321);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sotsuken.Properties.Resources.エディットフォーム背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 764);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.keytext_checkbox);
            this.Controls.Add(this.secretKeyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vpnValueBox);
            this.Controls.Add(this.canbutton);
            this.Controls.Add(this.compbutton);
            this.Controls.Add(this.iptext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editForm";
            this.Text = "editForm";
            this.Load += new System.EventHandler(this.editForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox iptext;
        private System.Windows.Forms.Button compbutton;
        private System.Windows.Forms.Button canbutton;
        private System.Windows.Forms.ComboBox vpnValueBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox secretKeyBox;
        private System.Windows.Forms.CheckBox keytext_checkbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}