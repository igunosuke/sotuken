namespace sotsuken
{
    partial class UserSetUp
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.compButton = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(173, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 50);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // compButton
            // 
            this.compButton.Location = new System.Drawing.Point(380, 341);
            this.compButton.Name = "compButton";
            this.compButton.Size = new System.Drawing.Size(110, 50);
            this.compButton.TabIndex = 8;
            this.compButton.Text = "完了";
            this.compButton.UseVisualStyleBackColor = true;
            this.compButton.Click += new System.EventHandler(this.compButton_Click);
            // 
            // passText
            // 
            this.passText.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passText.Location = new System.Drawing.Point(69, 270);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(255, 31);
            this.passText.TabIndex = 5;
            // 
            // userText
            // 
            this.userText.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userText.Location = new System.Drawing.Point(69, 144);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(255, 31);
            this.userText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(66, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "パスワード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(65, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ユーザー名";
            // 
            // UserSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.compButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserSetUp";
            this.Size = new System.Drawing.Size(795, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button compButton;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
