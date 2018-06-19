namespace sotsuken
{
    partial class check
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.VpnNameLabel = new System.Windows.Forms.Label();
            this.IpLabel = new System.Windows.Forms.Label();
            this.ConfigLabel = new System.Windows.Forms.Label();
            this.Keylabel = new System.Windows.Forms.Label();
            this.VpnName = new System.Windows.Forms.Label();
            this.Ip = new System.Windows.Forms.Label();
            this.Config = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VpnNameLabel
            // 
            this.VpnNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VpnNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VpnNameLabel.Location = new System.Drawing.Point(30, 32);
            this.VpnNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VpnNameLabel.Name = "VpnNameLabel";
            this.VpnNameLabel.Size = new System.Drawing.Size(179, 24);
            this.VpnNameLabel.TabIndex = 4;
            this.VpnNameLabel.Text = "接続名:";
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IpLabel.Location = new System.Drawing.Point(30, 114);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(179, 24);
            this.IpLabel.TabIndex = 5;
            this.IpLabel.Text = "接続先IPアドレス:\r\n";
            // 
            // ConfigLabel
            // 
            this.ConfigLabel.AutoSize = true;
            this.ConfigLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConfigLabel.Location = new System.Drawing.Point(30, 193);
            this.ConfigLabel.Name = "ConfigLabel";
            this.ConfigLabel.Size = new System.Drawing.Size(123, 24);
            this.ConfigLabel.TabIndex = 20;
            this.ConfigLabel.Text = "VPNの種類\r\n";
            this.ConfigLabel.VisibleChanged += new System.EventHandler(this.ConfigLabel_VisibleChanged);
            // 
            // Keylabel
            // 
            this.Keylabel.AutoSize = true;
            this.Keylabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Keylabel.Location = new System.Drawing.Point(30, 276);
            this.Keylabel.Name = "Keylabel";
            this.Keylabel.Size = new System.Drawing.Size(146, 24);
            this.Keylabel.TabIndex = 21;
            this.Keylabel.Text = "事前共有キー";
            // 
            // VpnName
            // 
            this.VpnName.AutoSize = true;
            this.VpnName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VpnName.Location = new System.Drawing.Point(309, 32);
            this.VpnName.Name = "VpnName";
            this.VpnName.Size = new System.Drawing.Size(72, 24);
            this.VpnName.TabIndex = 22;
            this.VpnName.Text = "NAME";
            // 
            // Ip
            // 
            this.Ip.AutoSize = true;
            this.Ip.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ip.Location = new System.Drawing.Point(309, 114);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(193, 24);
            this.Ip.TabIndex = 22;
            this.Ip.Text = "XXX.XXX.XXX.XXX";
            // 
            // Config
            // 
            this.Config.AutoSize = true;
            this.Config.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Config.Location = new System.Drawing.Point(309, 193);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(93, 24);
            this.Config.TabIndex = 22;
            this.Config.Text = "CONFIG";
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Key.Location = new System.Drawing.Point(309, 276);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(52, 24);
            this.Key.TabIndex = 22;
            this.Key.Text = "KEY";
            // 
            // check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Config);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.VpnName);
            this.Controls.Add(this.Keylabel);
            this.Controls.Add(this.ConfigLabel);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.VpnNameLabel);
            this.Name = "check";
            this.Size = new System.Drawing.Size(795, 449);
            this.Load += new System.EventHandler(this.check_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VpnNameLabel;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Label ConfigLabel;
        private System.Windows.Forms.Label Keylabel;
        private System.Windows.Forms.Label VpnName;
        private System.Windows.Forms.Label Ip;
        private System.Windows.Forms.Label Config;
        private System.Windows.Forms.Label Key;
    }
}
