namespace Attendance_System
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTextBoxuser = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxpass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1login = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Attendance_System.Properties.Resources.GrCv;
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTextBoxuser
            // 
            this.metroTextBoxuser.Location = new System.Drawing.Point(69, 168);
            this.metroTextBoxuser.Name = "metroTextBoxuser";
            this.metroTextBoxuser.Size = new System.Drawing.Size(189, 23);
            this.metroTextBoxuser.TabIndex = 1;
            // 
            // metroTextBoxpass
            // 
            this.metroTextBoxpass.Location = new System.Drawing.Point(69, 241);
            this.metroTextBoxpass.Name = "metroTextBoxpass";
            this.metroTextBoxpass.PasswordChar = '*';
            this.metroTextBoxpass.Size = new System.Drawing.Size(190, 23);
            this.metroTextBoxpass.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(69, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "User:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(69, 220);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password:";
            // 
            // metroButton1login
            // 
            this.metroButton1login.Location = new System.Drawing.Point(183, 292);
            this.metroButton1login.Name = "metroButton1login";
            this.metroButton1login.Size = new System.Drawing.Size(75, 23);
            this.metroButton1login.TabIndex = 5;
            this.metroButton1login.Text = "Login";
            this.metroButton1login.Click += new System.EventHandler(this.metroButton1login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(352, 327);
            this.Controls.Add(this.metroButton1login);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxpass);
            this.Controls.Add(this.metroTextBoxuser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxuser;
        private MetroFramework.Controls.MetroTextBox metroTextBoxpass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1login;
    }
}