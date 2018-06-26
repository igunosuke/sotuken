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
            this.refresh = new System.Windows.Forms.Button();
            this.infobox = new System.Windows.Forms.TextBox();
            this.disconnectbutton = new System.Windows.Forms.Button();
            this.Mconfig_button = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(17, 38);
            this.connectbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(178, 48);
            this.connectbutton.TabIndex = 0;
            this.connectbutton.Text = "接続";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(14, 275);
            this.editbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(178, 48);
            this.editbutton.TabIndex = 1;
            this.editbutton.Text = "編集";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // vpnlist
            // 
            this.vpnlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vpnlist.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.vpnlist.FormattingEnabled = true;
            this.vpnlist.ItemHeight = 28;
            this.vpnlist.Location = new System.Drawing.Point(0, 0);
            this.vpnlist.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.vpnlist.Name = "vpnlist";
            this.vpnlist.Size = new System.Drawing.Size(244, 498);
            this.vpnlist.TabIndex = 2;
            this.vpnlist.SelectedIndexChanged += new System.EventHandler(this.vpnlist_SelectedIndexChanged);
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(14, 203);
            this.createbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(178, 48);
            this.createbutton.TabIndex = 3;
            this.createbutton.Text = "作成";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click_1);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(14, 359);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(178, 48);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "削除";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(240, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.refresh);
            this.splitContainer1.Panel1.Controls.Add(this.vpnlist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.infobox);
            this.splitContainer1.Size = new System.Drawing.Size(738, 498);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 5;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.refresh.Location = new System.Drawing.Point(202, 464);
            this.refresh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(42, 34);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "🔄";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // infobox
            // 
            this.infobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infobox.Enabled = false;
            this.infobox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.infobox.Location = new System.Drawing.Point(0, 0);
            this.infobox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.infobox.Multiline = true;
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(487, 498);
            this.infobox.TabIndex = 0;
            // 
            // disconnectbutton
            // 
            this.disconnectbutton.Location = new System.Drawing.Point(17, 123);
            this.disconnectbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.disconnectbutton.Name = "disconnectbutton";
            this.disconnectbutton.Size = new System.Drawing.Size(178, 48);
            this.disconnectbutton.TabIndex = 6;
            this.disconnectbutton.Text = "切断";
            this.disconnectbutton.UseVisualStyleBackColor = true;
            this.disconnectbutton.Click += new System.EventHandler(this.disconnectbutton_Click);
            // 
            // Mconfig_button
            // 
            this.Mconfig_button.Location = new System.Drawing.Point(14, 441);
            this.Mconfig_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Mconfig_button.Name = "Mconfig_button";
            this.Mconfig_button.Size = new System.Drawing.Size(178, 48);
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
            // vpnformInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 502);
            this.Controls.Add(this.disconnectbutton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Mconfig_button);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.connectbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vpnformInstance";
            this.Text = "VPNアプリ";
            this.Load += new System.EventHandler(this.vpn_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button deletebutton;
        public System.Windows.Forms.ListBox vpnlist;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox infobox;
        private System.Windows.Forms.Button disconnectbutton;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button Mconfig_button;
        private System.Windows.Forms.Timer timer;
    }
}

