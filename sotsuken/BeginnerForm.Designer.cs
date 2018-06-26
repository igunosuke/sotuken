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
            this.SuspendLayout();
            // 
            // field_panel
            // 
            this.field_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.field_panel.Location = new System.Drawing.Point(0, 0);
            this.field_panel.Name = "field_panel";
            this.field_panel.Size = new System.Drawing.Size(795, 449);
            this.field_panel.TabIndex = 0;
            this.field_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.field_panel_Paint);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(373, 509);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(119, 48);
            this.Back_button.TabIndex = 1;
            this.Back_button.Text = "戻る";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(515, 509);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(119, 48);
            this.Next_button.TabIndex = 1;
            this.Next_button.Text = "次へ";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(657, 509);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(119, 48);
            this.Cancel_button.TabIndex = 1;
            this.Cancel_button.Text = "キャンセル";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // BeginnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 601);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.field_panel);
            this.Name = "BeginnerForm";
            this.Text = "BeginnerForm";
            this.Load += new System.EventHandler(this.BeginnerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel field_panel;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}