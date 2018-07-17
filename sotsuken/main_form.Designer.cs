namespace sotsuken
{
    partial class vpnformInstance
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.vpnlist = new System.Windows.Forms.ListBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.infobox = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.disconnectbutton = new System.Windows.Forms.Button();
            this.Mconfig_button = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // connectbutton
            // 
            this.connectbutton.AutoSize = true;
            this.connectbutton.BackColor = System.Drawing.Color.Transparent;
            this.connectbutton.BackgroundImage = global::sotsuken.Properties.Resources.接続白;
            this.connectbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectbutton.FlatAppearance.BorderSize = 0;
            this.connectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectbutton.Location = new System.Drawing.Point(19, 95);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(88, 33);
            this.connectbutton.TabIndex = 0;
            this.connectbutton.UseVisualStyleBackColor = false;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            this.connectbutton.MouseEnter += new System.EventHandler(this.connectbutton_MouseEnter);
            this.connectbutton.MouseLeave += new System.EventHandler(this.connectbutton_MouseLeave);
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.Color.Transparent;
            this.editbutton.BackgroundImage = global::sotsuken.Properties.Resources.編集;
            this.editbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbutton.FlatAppearance.BorderSize = 0;
            this.editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbutton.Location = new System.Drawing.Point(19, 209);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(88, 33);
            this.editbutton.TabIndex = 1;
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            this.editbutton.MouseEnter += new System.EventHandler(this.editbutton_MouseEnter);
            this.editbutton.MouseLeave += new System.EventHandler(this.editbutton_MouseLeave);
            // 
            // vpnlist
            // 
            this.vpnlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vpnlist.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.vpnlist.FormattingEnabled = true;
            this.vpnlist.ItemHeight = 19;
            this.vpnlist.Location = new System.Drawing.Point(0, 0);
            this.vpnlist.Name = "vpnlist";
            this.vpnlist.Size = new System.Drawing.Size(119, 446);
            this.vpnlist.TabIndex = 2;
            this.vpnlist.SelectedIndexChanged += new System.EventHandler(this.vpnlist_SelectedIndexChanged);
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.Color.Transparent;
            this.createbutton.BackgroundImage = global::sotsuken.Properties.Resources.作成;
            this.createbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createbutton.FlatAppearance.BorderSize = 0;
            this.createbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbutton.Location = new System.Drawing.Point(19, 171);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(88, 33);
            this.createbutton.TabIndex = 3;
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click_1);
            this.createbutton.MouseEnter += new System.EventHandler(this.createbutton_MouseEnter);
            this.createbutton.MouseLeave += new System.EventHandler(this.createbutton_MouseLeave);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.deletebutton.BackgroundImage = global::sotsuken.Properties.Resources.削除;
            this.deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebutton.FlatAppearance.BorderSize = 0;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Location = new System.Drawing.Point(19, 247);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(88, 33);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            this.deletebutton.MouseEnter += new System.EventHandler(this.deletebutton_MouseEnter);
            this.deletebutton.MouseLeave += new System.EventHandler(this.deletebutton_MouseLeave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(190, 87);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.vpnlist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.infobox);
            this.splitContainer1.Size = new System.Drawing.Size(364, 446);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 5;
            // 
            // infobox
            // 
            this.infobox.BackColor = System.Drawing.Color.White;
            this.infobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infobox.Enabled = false;
            this.infobox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.infobox.Location = new System.Drawing.Point(0, 0);
            this.infobox.Multiline = true;
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(241, 446);
            this.infobox.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.refresh.Location = new System.Drawing.Point(1, 1);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(25, 23);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "🔄";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // disconnectbutton
            // 
            this.disconnectbutton.BackColor = System.Drawing.Color.Transparent;
            this.disconnectbutton.BackgroundImage = global::sotsuken.Properties.Resources.切断;
            this.disconnectbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.disconnectbutton.FlatAppearance.BorderSize = 0;
            this.disconnectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectbutton.Location = new System.Drawing.Point(19, 133);
            this.disconnectbutton.Name = "disconnectbutton";
            this.disconnectbutton.Size = new System.Drawing.Size(88, 33);
            this.disconnectbutton.TabIndex = 6;
            this.disconnectbutton.UseVisualStyleBackColor = false;
            this.disconnectbutton.Click += new System.EventHandler(this.disconnectbutton_Click);
            this.disconnectbutton.MouseEnter += new System.EventHandler(this.disconnectbutton_MouseEnter);
            this.disconnectbutton.MouseLeave += new System.EventHandler(this.disconnectbutton_MouseLeave);
            // 
            // Mconfig_button
            // 
            this.Mconfig_button.Location = new System.Drawing.Point(19, 285);
            this.Mconfig_button.Name = "Mconfig_button";
            this.Mconfig_button.Size = new System.Drawing.Size(88, 33);
            this.Mconfig_button.TabIndex = 4;
            this.Mconfig_button.Text = "設定";
            this.Mconfig_button.UseVisualStyleBackColor = true;
            this.Mconfig_button.Click += new System.EventHandler(this.Mconfig_button_Click);
            // 
            // timer
            // 
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::sotsuken.Properties.Resources.タイトル;
            this.pictureBox1.Location = new System.Drawing.Point(19, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::sotsuken.Properties.Resources.ロゴ;
            this.pictureBox2.Location = new System.Drawing.Point(-41, 402);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::sotsuken.Properties.Resources.終了青;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(440, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vpnformInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sotsuken.Properties.Resources.メインフォーム背景;
            this.ClientSize = new System.Drawing.Size(598, 616);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.disconnectbutton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Mconfig_button);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vpnformInstance";
            this.Text = "vpnアプリ";
            this.Load += new System.EventHandler(this.vpn_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button deletebutton;
        public System.Windows.Forms.ListBox vpnlist;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox infobox;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button Mconfig_button;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button disconnectbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

