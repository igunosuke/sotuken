namespace sotsuken
{
    partial class BeginnerForm
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
            this.field_panel = new System.Windows.Forms.Panel();
            this.Back_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // field_panel
            // 
            this.field_panel.Location = new System.Drawing.Point(71, 113);
            this.field_panel.Margin = new System.Windows.Forms.Padding(2);
            this.field_panel.Name = "field_panel";
            this.field_panel.Size = new System.Drawing.Size(645, 506);
            this.field_panel.TabIndex = 0;
            this.field_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.field_panel_Paint);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.Transparent;
            this.Back_button.BackgroundImage = global::sotsuken.Properties.Resources.戻る;
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(241, 685);
            this.Back_button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(144, 48);
            this.Back_button.TabIndex = 1;
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            this.Back_button.MouseEnter += new System.EventHandler(this.Back_button_MouseEnter);
            this.Back_button.MouseLeave += new System.EventHandler(this.Back_button_MouseLeave);
            // 
            // Next_button
            // 
            this.Next_button.BackColor = System.Drawing.Color.Transparent;
            this.Next_button.BackgroundImage = global::sotsuken.Properties.Resources.次へ白;
            this.Next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next_button.FlatAppearance.BorderSize = 0;
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Location = new System.Drawing.Point(409, 685);
            this.Next_button.Margin = new System.Windows.Forms.Padding(2);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(144, 48);
            this.Next_button.TabIndex = 1;
            this.Next_button.UseVisualStyleBackColor = false;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            this.Next_button.MouseEnter += new System.EventHandler(this.Next_button_MouseEnter);
            this.Next_button.MouseLeave += new System.EventHandler(this.Next_button_MouseLeave);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.Transparent;
            this.Cancel_button.BackgroundImage = global::sotsuken.Properties.Resources.キャンセル;
            this.Cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel_button.FlatAppearance.BorderSize = 0;
            this.Cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_button.Location = new System.Drawing.Point(572, 685);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(144, 48);
            this.Cancel_button.TabIndex = 1;
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            this.Cancel_button.MouseEnter += new System.EventHandler(this.Cancel_button_MouseEnter);
            this.Cancel_button.MouseLeave += new System.EventHandler(this.Cancel_button_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::sotsuken.Properties.Resources.ロゴ;
            this.pictureBox5.Location = new System.Drawing.Point(-44, 519);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(250, 245);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::sotsuken.Properties.Resources.タイトル;
            this.pictureBox1.Location = new System.Drawing.Point(71, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // BeginnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::sotsuken.Properties.Resources.ビギナーフォーム背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 766);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.field_panel);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.pictureBox5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BeginnerForm";
            this.Text = "BeginnerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BeginnerForm_FormClosed);
            this.Load += new System.EventHandler(this.BeginnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel field_panel;
    }
}