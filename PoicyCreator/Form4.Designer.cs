namespace policy_creator1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.b4_del = new System.Windows.Forms.Button();
            this.tb_del = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b4_del
            // 
            this.b4_del.BackColor = System.Drawing.Color.Black;
            this.b4_del.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4_del.ForeColor = System.Drawing.Color.White;
            this.b4_del.Location = new System.Drawing.Point(131, 173);
            this.b4_del.Name = "b4_del";
            this.b4_del.Size = new System.Drawing.Size(85, 34);
            this.b4_del.TabIndex = 0;
            this.b4_del.Text = "Delete";
            this.b4_del.UseVisualStyleBackColor = false;
            this.b4_del.Click += new System.EventHandler(this.b4_del_Click);
            // 
            // tb_del
            // 
            this.tb_del.Location = new System.Drawing.Point(85, 116);
            this.tb_del.Name = "tb_del";
            this.tb_del.Size = new System.Drawing.Size(171, 20);
            this.tb_del.TabIndex = 1;
            this.tb_del.TextChanged += new System.EventHandler(this.tb_del_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the policy";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(345, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_del);
            this.Controls.Add(this.b4_del);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Delete Policy";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b4_del;
        private System.Windows.Forms.TextBox tb_del;
        private System.Windows.Forms.Label label1;
    }
}