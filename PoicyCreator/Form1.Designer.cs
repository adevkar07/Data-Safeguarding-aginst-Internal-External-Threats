namespace policy_creator1
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
            this.pc_add = new System.Windows.Forms.Button();
            this.pc_edit = new System.Windows.Forms.Button();
            this.pc_del = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pc_add
            // 
            this.pc_add.BackColor = System.Drawing.Color.Black;
            this.pc_add.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_add.Location = new System.Drawing.Point(470, 22);
            this.pc_add.Margin = new System.Windows.Forms.Padding(4);
            this.pc_add.Name = "pc_add";
            this.pc_add.Size = new System.Drawing.Size(100, 38);
            this.pc_add.TabIndex = 0;
            this.pc_add.Text = "Add Policy";
            this.pc_add.UseVisualStyleBackColor = false;
            this.pc_add.Click += new System.EventHandler(this.pc_add_Click);
            // 
            // pc_edit
            // 
            this.pc_edit.BackColor = System.Drawing.Color.Black;
            this.pc_edit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_edit.Location = new System.Drawing.Point(470, 90);
            this.pc_edit.Margin = new System.Windows.Forms.Padding(4);
            this.pc_edit.Name = "pc_edit";
            this.pc_edit.Size = new System.Drawing.Size(100, 40);
            this.pc_edit.TabIndex = 1;
            this.pc_edit.Text = "Edit Policy";
            this.pc_edit.UseVisualStyleBackColor = false;
            this.pc_edit.Click += new System.EventHandler(this.pc_edit_Click);
            // 
            // pc_del
            // 
            this.pc_del.BackColor = System.Drawing.Color.Black;
            this.pc_del.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_del.Location = new System.Drawing.Point(470, 163);
            this.pc_del.Margin = new System.Windows.Forms.Padding(4);
            this.pc_del.Name = "pc_del";
            this.pc_del.Size = new System.Drawing.Size(100, 38);
            this.pc_del.TabIndex = 2;
            this.pc_del.Text = "Delete";
            this.pc_del.UseVisualStyleBackColor = false;
            this.pc_del.Click += new System.EventHandler(this.pc_del_Click);
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.Black;
            this.b_exit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_exit.ForeColor = System.Drawing.Color.White;
            this.b_exit.Location = new System.Drawing.Point(470, 239);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(100, 34);
            this.b_exit.TabIndex = 4;
            this.b_exit.Text = "Done";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(46, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(327, 232);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(643, 327);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.pc_del);
            this.Controls.Add(this.pc_edit);
            this.Controls.Add(this.pc_add);
            this.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Policy Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pc_add;
        private System.Windows.Forms.Button pc_edit;
        private System.Windows.Forms.Button pc_del;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

