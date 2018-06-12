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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iptext = new System.Windows.Forms.TextBox();
            this.compbutton = new System.Windows.Forms.Button();
            this.canbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signValueBox = new System.Windows.Forms.ComboBox();
            this.vpnValueBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.secretKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nametext.Location = new System.Drawing.Point(43, 50);
            this.nametext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(484, 35);
            this.nametext.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(38, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "＊VPN名";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "＊サーバアドレス";
            // 
            // iptext
            // 
            this.iptext.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.iptext.Location = new System.Drawing.Point(43, 148);
            this.iptext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.iptext.Name = "iptext";
            this.iptext.Size = new System.Drawing.Size(484, 35);
            this.iptext.TabIndex = 2;
            // 
            // compbutton
            // 
            this.compbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.compbutton.Location = new System.Drawing.Point(192, 577);
            this.compbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.compbutton.Name = "compbutton";
            this.compbutton.Size = new System.Drawing.Size(165, 58);
            this.compbutton.TabIndex = 6;
            this.compbutton.Text = "完了";
            this.compbutton.UseVisualStyleBackColor = true;
            this.compbutton.Click += new System.EventHandler(this.compbutton_Click);
            // 
            // canbutton
            // 
            this.canbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canbutton.Location = new System.Drawing.Point(367, 577);
            this.canbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.canbutton.Name = "canbutton";
            this.canbutton.Size = new System.Drawing.Size(165, 58);
            this.canbutton.TabIndex = 7;
            this.canbutton.Text = "キャンセル";
            this.canbutton.UseVisualStyleBackColor = true;
            this.canbutton.Click += new System.EventHandler(this.canbutton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(38, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "サインイン情報の種類";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(38, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "VPNの種類";
            // 
            // signValueBox
            // 
            this.signValueBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.signValueBox.FormattingEnabled = true;
            this.signValueBox.Items.AddRange(new object[] {
            "ユーザー名とパスワード",
            "スマートカード",
            "ワンタイムパスワード",
            "証明書"});
            this.signValueBox.Location = new System.Drawing.Point(48, 356);
            this.signValueBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.signValueBox.Name = "signValueBox";
            this.signValueBox.Size = new System.Drawing.Size(484, 36);
            this.signValueBox.TabIndex = 16;
            this.signValueBox.Text = "ユーザー名とパスワード";
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
            this.vpnValueBox.Location = new System.Drawing.Point(43, 256);
            this.vpnValueBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.vpnValueBox.Name = "vpnValueBox";
            this.vpnValueBox.Size = new System.Drawing.Size(484, 36);
            this.vpnValueBox.TabIndex = 17;
            this.vpnValueBox.Text = "自動";
            this.vpnValueBox.SelectedIndexChanged += new System.EventHandler(this.vpnValueBox_SelectionChangeCommitted);
            this.vpnValueBox.SelectionChangeCommitted += new System.EventHandler(this.vpnValueBox_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 537);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "＊は必須項目です";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(38, 444);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "＊事前共有キー";
            // 
            // secretKeyBox
            // 
            this.secretKeyBox.Enabled = false;
            this.secretKeyBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.secretKeyBox.Location = new System.Drawing.Point(48, 480);
            this.secretKeyBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.secretKeyBox.Name = "secretKeyBox";
            this.secretKeyBox.Size = new System.Drawing.Size(484, 35);
            this.secretKeyBox.TabIndex = 19;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 662);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secretKeyBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vpnValueBox);
            this.Controls.Add(this.signValueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.canbutton);
            this.Controls.Add(this.compbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iptext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editForm";
            this.Text = "editForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iptext;
        private System.Windows.Forms.Button compbutton;
        private System.Windows.Forms.Button canbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox signValueBox;
        private System.Windows.Forms.ComboBox vpnValueBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secretKeyBox;
    }
}