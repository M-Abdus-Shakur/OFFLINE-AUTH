namespace OFFLINE_AUTH
{
    partial class Form1
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
            this.License_TB = new Siticone.UI.WinForms.SiticoneTextBox();
            this.login_btn = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // License_TB
            // 
            this.License_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.License_TB.DefaultText = "";
            this.License_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.License_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.License_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.License_TB.DisabledState.Parent = this.License_TB;
            this.License_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.License_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.License_TB.FocusedState.Parent = this.License_TB;
            this.License_TB.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.License_TB.HoveredState.Parent = this.License_TB;
            this.License_TB.Location = new System.Drawing.Point(13, 53);
            this.License_TB.Name = "License_TB";
            this.License_TB.PasswordChar = '\0';
            this.License_TB.PlaceholderText = "License";
            this.License_TB.SelectedText = "";
            this.License_TB.ShadowDecoration.Parent = this.License_TB;
            this.License_TB.Size = new System.Drawing.Size(402, 36);
            this.License_TB.TabIndex = 0;
            // 
            // login_btn
            // 
            this.login_btn.BorderColor = System.Drawing.Color.Silver;
            this.login_btn.BorderThickness = 1;
            this.login_btn.CheckedState.Parent = this.login_btn;
            this.login_btn.CustomImages.Parent = this.login_btn;
            this.login_btn.FillColor = System.Drawing.Color.White;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.HoveredState.Parent = this.login_btn;
            this.login_btn.Location = new System.Drawing.Point(128, 111);
            this.login_btn.Name = "login_btn";
            this.login_btn.ShadowDecoration.Parent = this.login_btn;
            this.login_btn.Size = new System.Drawing.Size(131, 45);
            this.login_btn.TabIndex = 1;
            this.login_btn.Text = "ENTER";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 239);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.License_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneTextBox License_TB;
        private Siticone.UI.WinForms.SiticoneButton login_btn;
    }
}

