namespace sotsuken
{
    partial class BConfig
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
            this.vpnValueBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.keytext_checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.vpnValueBox.Location = new System.Drawing.Point(39, 132);
            this.vpnValueBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.vpnValueBox.Name = "vpnValueBox";
            this.vpnValueBox.Size = new System.Drawing.Size(532, 36);
            this.vpnValueBox.TabIndex = 18;
            this.vpnValueBox.Text = "自動";
            this.vpnValueBox.SelectedIndexChanged += new System.EventHandler(this.vpnValueBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 96);
            this.label1.TabIndex = 19;
            this.label1.Text = "VPNの種類を選択せして下さい\r\n\r\n管理者から伝えられた\r\nVPNの種類を選択してください。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(35, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "事前共有キー";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Enabled = false;
            this.KeyTextBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyTextBox.Location = new System.Drawing.Point(39, 279);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(531, 35);
            this.KeyTextBox.TabIndex = 20;
            this.KeyTextBox.UseSystemPasswordChar = true;
            // 
            // keytext_checkBox1
            // 
            this.keytext_checkBox1.AutoSize = true;
            this.keytext_checkBox1.Location = new System.Drawing.Point(39, 348);
            this.keytext_checkBox1.Name = "keytext_checkBox1";
            this.keytext_checkBox1.Size = new System.Drawing.Size(215, 22);
            this.keytext_checkBox1.TabIndex = 21;
            this.keytext_checkBox1.Text = "事前共有キーを表示する";
            this.keytext_checkBox1.UseVisualStyleBackColor = true;
            this.keytext_checkBox1.CheckedChanged += new System.EventHandler(this.keytext_checkBox1_CheckedChanged);
            // 
            // BConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.keytext_checkBox1);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vpnValueBox);
            this.Name = "BConfig";
            this.Size = new System.Drawing.Size(795, 449);
            this.Load += new System.EventHandler(this.BConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vpnValueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.CheckBox keytext_checkBox1;
    }
}
