namespace LoginScreen
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.l_oldpass = new System.Windows.Forms.Label();
            this.l_newpass = new System.Windows.Forms.Label();
            this.l_connewpass = new System.Windows.Forms.Label();
            this.tb_oldpass = new System.Windows.Forms.TextBox();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.tb_connewpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_oldpass
            // 
            this.l_oldpass.AutoSize = true;
            this.l_oldpass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_oldpass.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_oldpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_oldpass.Location = new System.Drawing.Point(12, 51);
            this.l_oldpass.Name = "l_oldpass";
            this.l_oldpass.Size = new System.Drawing.Size(148, 21);
            this.l_oldpass.TabIndex = 0;
            this.l_oldpass.Text = "Enter Old Password";
            // 
            // l_newpass
            // 
            this.l_newpass.AutoSize = true;
            this.l_newpass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_newpass.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_newpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_newpass.Location = new System.Drawing.Point(12, 93);
            this.l_newpass.Name = "l_newpass";
            this.l_newpass.Size = new System.Drawing.Size(153, 21);
            this.l_newpass.TabIndex = 1;
            this.l_newpass.Text = "Enter New Password";
            // 
            // l_connewpass
            // 
            this.l_connewpass.AutoSize = true;
            this.l_connewpass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_connewpass.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_connewpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_connewpass.Location = new System.Drawing.Point(12, 137);
            this.l_connewpass.Name = "l_connewpass";
            this.l_connewpass.Size = new System.Drawing.Size(173, 21);
            this.l_connewpass.TabIndex = 2;
            this.l_connewpass.Text = "Confirm New Password";
            // 
            // tb_oldpass
            // 
            this.tb_oldpass.Location = new System.Drawing.Point(229, 52);
            this.tb_oldpass.Name = "tb_oldpass";
            this.tb_oldpass.Size = new System.Drawing.Size(100, 20);
            this.tb_oldpass.TabIndex = 3;
            this.tb_oldpass.TextChanged += new System.EventHandler(this.tb_oldpass_TextChanged);
            // 
            // tb_newpass
            // 
            this.tb_newpass.Location = new System.Drawing.Point(229, 93);
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(100, 20);
            this.tb_newpass.TabIndex = 4;
            this.tb_newpass.TextChanged += new System.EventHandler(this.tb_newpass_TextChanged);
            // 
            // tb_connewpass
            // 
            this.tb_connewpass.Location = new System.Drawing.Point(229, 137);
            this.tb_connewpass.Name = "tb_connewpass";
            this.tb_connewpass.Size = new System.Drawing.Size(100, 20);
            this.tb_connewpass.TabIndex = 5;
            this.tb_connewpass.TextChanged += new System.EventHandler(this.tb_connewpass_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(67, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(229, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(417, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_connewpass);
            this.Controls.Add(this.tb_newpass);
            this.Controls.Add(this.tb_oldpass);
            this.Controls.Add(this.l_connewpass);
            this.Controls.Add(this.l_newpass);
            this.Controls.Add(this.l_oldpass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_oldpass;
        private System.Windows.Forms.Label l_newpass;
        private System.Windows.Forms.Label l_connewpass;
        private System.Windows.Forms.TextBox tb_oldpass;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.TextBox tb_connewpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}