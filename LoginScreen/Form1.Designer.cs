namespace LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_admin = new System.Windows.Forms.Button();
            this.l_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.l_passforget = new System.Windows.Forms.Label();
            this.b_polcreate = new System.Windows.Forms.Button();
            this.b_adduser = new System.Windows.Forms.Button();
            this.b_enterpwd = new System.Windows.Forms.Button();
            this.b_changepwd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_admin
            // 
            this.b_admin.BackColor = System.Drawing.Color.Black;
            this.b_admin.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_admin.Location = new System.Drawing.Point(28, 73);
            this.b_admin.Name = "b_admin";
            this.b_admin.Size = new System.Drawing.Size(121, 39);
            this.b_admin.TabIndex = 1;
            this.b_admin.Text = "Admin";
            this.b_admin.UseVisualStyleBackColor = false;
            this.b_admin.Click += new System.EventHandler(this.b_admin_Click);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.BackColor = System.Drawing.Color.Blue;
            this.l_password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_password.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_password.Location = new System.Drawing.Point(239, 73);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(129, 21);
            this.l_password.TabIndex = 3;
            this.l_password.Text = "Enter password : ";
            this.l_password.Click += new System.EventHandler(this.l_password_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(405, 75);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(143, 20);
            this.tb_password.TabIndex = 4;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // l_passforget
            // 
            this.l_passforget.AutoSize = true;
            this.l_passforget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_passforget.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_passforget.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_passforget.Location = new System.Drawing.Point(321, 131);
            this.l_passforget.Name = "l_passforget";
            this.l_passforget.Size = new System.Drawing.Size(133, 21);
            this.l_passforget.TabIndex = 5;
            this.l_passforget.Text = "Forgot Password?";
            this.l_passforget.Click += new System.EventHandler(this.l_passforget_Click);
            // 
            // b_polcreate
            // 
            this.b_polcreate.BackColor = System.Drawing.Color.Black;
            this.b_polcreate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_polcreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_polcreate.Location = new System.Drawing.Point(665, 66);
            this.b_polcreate.Name = "b_polcreate";
            this.b_polcreate.Size = new System.Drawing.Size(108, 55);
            this.b_polcreate.TabIndex = 6;
            this.b_polcreate.Text = "Create Policy";
            this.b_polcreate.UseVisualStyleBackColor = false;
            this.b_polcreate.Click += new System.EventHandler(this.b_polcreate_Click);
            // 
            // b_adduser
            // 
            this.b_adduser.BackColor = System.Drawing.Color.Black;
            this.b_adduser.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_adduser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_adduser.Location = new System.Drawing.Point(665, 205);
            this.b_adduser.Name = "b_adduser";
            this.b_adduser.Size = new System.Drawing.Size(108, 59);
            this.b_adduser.TabIndex = 7;
            this.b_adduser.Text = "Add User";
            this.b_adduser.UseVisualStyleBackColor = false;
            this.b_adduser.Click += new System.EventHandler(this.b_adduser_Click);
            // 
            // b_enterpwd
            // 
            this.b_enterpwd.BackColor = System.Drawing.Color.Black;
            this.b_enterpwd.Font = new System.Drawing.Font("Constantia", 12F);
            this.b_enterpwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_enterpwd.Location = new System.Drawing.Point(239, 205);
            this.b_enterpwd.Name = "b_enterpwd";
            this.b_enterpwd.Size = new System.Drawing.Size(97, 59);
            this.b_enterpwd.TabIndex = 8;
            this.b_enterpwd.Text = "Login";
            this.b_enterpwd.UseVisualStyleBackColor = false;
            this.b_enterpwd.Click += new System.EventHandler(this.b_enterpwd_Click);
            // 
            // b_changepwd
            // 
            this.b_changepwd.BackColor = System.Drawing.Color.Black;
            this.b_changepwd.Font = new System.Drawing.Font("Constantia", 12F);
            this.b_changepwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_changepwd.Location = new System.Drawing.Point(405, 205);
            this.b_changepwd.Name = "b_changepwd";
            this.b_changepwd.Size = new System.Drawing.Size(116, 59);
            this.b_changepwd.TabIndex = 9;
            this.b_changepwd.Text = "Change Password";
            this.b_changepwd.UseVisualStyleBackColor = false;
            this.b_changepwd.Click += new System.EventHandler(this.b_changepwd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(28, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Decrypt Files";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(28, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "Process Snapshot";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(889, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_changepwd);
            this.Controls.Add(this.b_enterpwd);
            this.Controls.Add(this.b_adduser);
            this.Controls.Add(this.b_polcreate);
            this.Controls.Add(this.l_passforget);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.b_admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login As Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_admin;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label l_passforget;
        private System.Windows.Forms.Button b_polcreate;
        private System.Windows.Forms.Button b_adduser;
        private System.Windows.Forms.Button b_enterpwd;
        private System.Windows.Forms.Button b_changepwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

