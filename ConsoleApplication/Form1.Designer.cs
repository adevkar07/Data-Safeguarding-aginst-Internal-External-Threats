namespace admin_USB
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_devid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_driveletter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_policy = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(302, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device ID of Connected USB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_devid
            // 
            this.tb_devid.Location = new System.Drawing.Point(104, 73);
            this.tb_devid.Name = "tb_devid";
            this.tb_devid.Size = new System.Drawing.Size(582, 22);
            this.tb_devid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drive Letter";
            // 
            // tb_driveletter
            // 
            this.tb_driveletter.Location = new System.Drawing.Point(326, 153);
            this.tb_driveletter.Name = "tb_driveletter";
            this.tb_driveletter.Size = new System.Drawing.Size(168, 22);
            this.tb_driveletter.TabIndex = 3;
            this.tb_driveletter.TextChanged += new System.EventHandler(this.driveletter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(104, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Policy Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(104, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Username";
            // 
            // tb_policy
            // 
            this.tb_policy.Location = new System.Drawing.Point(326, 206);
            this.tb_policy.Name = "tb_policy";
            this.tb_policy.Size = new System.Drawing.Size(168, 22);
            this.tb_policy.TabIndex = 6;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(326, 258);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(167, 22);
            this.tb_username.TabIndex = 7;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Black;
            this.save.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(326, 319);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(165, 35);
            this.save.TabIndex = 8;
            this.save.Text = "Save ";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(779, 366);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_policy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_driveletter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_devid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "User Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_devid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_driveletter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_policy;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button save;
    }
}

