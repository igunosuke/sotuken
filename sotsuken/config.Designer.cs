namespace sotsuken
{
    partial class config
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
            this.label1 = new System.Windows.Forms.Label();
            this.icon_off = new System.Windows.Forms.CheckBox();
            this.Disconnect_off = new System.Windows.Forms.CheckBox();
            this.Create_choice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Csave_button = new System.Windows.Forms.Button();
            this.Cexit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "設定";
            // 
            // icon_off
            // 
            this.icon_off.AutoSize = true;
            this.icon_off.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.icon_off.Location = new System.Drawing.Point(307, 68);
            this.icon_off.Name = "icon_off";
            this.icon_off.Size = new System.Drawing.Size(254, 37);
            this.icon_off.TabIndex = 1;
            this.icon_off.Text = "アイコンを非表示";
            this.icon_off.UseVisualStyleBackColor = true;
            this.icon_off.CheckedChanged += new System.EventHandler(this.icon_off_CheckedChanged);
            // 
            // Disconnect_off
            // 
            this.Disconnect_off.AutoSize = true;
            this.Disconnect_off.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Disconnect_off.Location = new System.Drawing.Point(307, 164);
            this.Disconnect_off.Name = "Disconnect_off";
            this.Disconnect_off.Size = new System.Drawing.Size(298, 37);
            this.Disconnect_off.TabIndex = 1;
            this.Disconnect_off.Text = "切断ボタンを非表示";
            this.Disconnect_off.UseVisualStyleBackColor = true;
            this.Disconnect_off.CheckedChanged += new System.EventHandler(this.Disconnect_off_CheckedChanged);
            // 
            // Create_choice
            // 
            this.Create_choice.FormattingEnabled = true;
            this.Create_choice.Items.AddRange(new object[] {
            "デフォルト",
            "らくらく作成",
            "カスタム作成"});
            this.Create_choice.Location = new System.Drawing.Point(188, 273);
            this.Create_choice.Name = "Create_choice";
            this.Create_choice.Size = new System.Drawing.Size(121, 26);
            this.Create_choice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(334, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "作成を押した際の動作";
            // 
            // Csave_button
            // 
            this.Csave_button.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Csave_button.Location = new System.Drawing.Point(134, 390);
            this.Csave_button.Name = "Csave_button";
            this.Csave_button.Size = new System.Drawing.Size(155, 71);
            this.Csave_button.TabIndex = 4;
            this.Csave_button.Text = "保存";
            this.Csave_button.UseVisualStyleBackColor = true;
            this.Csave_button.Click += new System.EventHandler(this.Csave_button_Click);
            // 
            // Cexit_button
            // 
            this.Cexit_button.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Cexit_button.Location = new System.Drawing.Point(462, 390);
            this.Cexit_button.Name = "Cexit_button";
            this.Cexit_button.Size = new System.Drawing.Size(155, 71);
            this.Cexit_button.TabIndex = 5;
            this.Cexit_button.Text = "終了";
            this.Cexit_button.UseVisualStyleBackColor = true;
            this.Cexit_button.Click += new System.EventHandler(this.Cexit_button_Click);
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 565);
            this.Controls.Add(this.Cexit_button);
            this.Controls.Add(this.Csave_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Create_choice);
            this.Controls.Add(this.Disconnect_off);
            this.Controls.Add(this.icon_off);
            this.Controls.Add(this.label1);
            this.Name = "config";
            this.Text = "config";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox icon_off;
        private System.Windows.Forms.CheckBox Disconnect_off;
        private System.Windows.Forms.ComboBox Create_choice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Csave_button;
        private System.Windows.Forms.Button Cexit_button;
    }
}