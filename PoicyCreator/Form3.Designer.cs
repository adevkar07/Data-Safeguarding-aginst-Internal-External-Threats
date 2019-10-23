namespace policy_creator1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.l_search = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.b_search = new System.Windows.Forms.Button();
            this.cledit_images = new System.Windows.Forms.CheckedListBox();
            this.cledit_office = new System.Windows.Forms.CheckedListBox();
            this.cledit_av = new System.Windows.Forms.CheckedListBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.l_edit_desc = new System.Windows.Forms.Label();
            this.tb_edit_desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // l_search
            // 
            this.l_search.AutoSize = true;
            this.l_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_search.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_search.ForeColor = System.Drawing.Color.White;
            this.l_search.Location = new System.Drawing.Point(41, 31);
            this.l_search.Name = "l_search";
            this.l_search.Size = new System.Drawing.Size(155, 21);
            this.l_search.TabIndex = 0;
            this.l_search.Text = "Enter Policy Name ";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(207, 30);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(173, 20);
            this.tb_search.TabIndex = 1;
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.Color.Black;
            this.b_search.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_search.ForeColor = System.Drawing.Color.White;
            this.b_search.Location = new System.Drawing.Point(503, 21);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(81, 34);
            this.b_search.TabIndex = 2;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = false;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // cledit_images
            // 
            this.cledit_images.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cledit_images.FormattingEnabled = true;
            this.cledit_images.Items.AddRange(new object[] {
            "png",
            "tiff",
            "jpeg/jpg"});
            this.cledit_images.Location = new System.Drawing.Point(44, 139);
            this.cledit_images.Name = "cledit_images";
            this.cledit_images.Size = new System.Drawing.Size(120, 94);
            this.cledit_images.TabIndex = 3;
            this.cledit_images.SelectedIndexChanged += new System.EventHandler(this.png_SelectedIndexChanged);
            // 
            // cledit_office
            // 
            this.cledit_office.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cledit_office.FormattingEnabled = true;
            this.cledit_office.Items.AddRange(new object[] {
            "doc/xls/ppt",
            "pdf",
            "pptx/docx/xlsx",
            "iso"});
            this.cledit_office.Location = new System.Drawing.Point(222, 139);
            this.cledit_office.Name = "cledit_office";
            this.cledit_office.Size = new System.Drawing.Size(120, 94);
            this.cledit_office.TabIndex = 4;
            this.cledit_office.SelectedIndexChanged += new System.EventHandler(this.cledit_office_SelectedIndexChanged);
            // 
            // cledit_av
            // 
            this.cledit_av.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cledit_av.FormattingEnabled = true;
            this.cledit_av.Items.AddRange(new object[] {
            "mkv",
            "wav/avi",
            "gif"});
            this.cledit_av.Location = new System.Drawing.Point(423, 139);
            this.cledit_av.Name = "cledit_av";
            this.cledit_av.Size = new System.Drawing.Size(120, 94);
            this.cledit_av.TabIndex = 5;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Black;
            this.bt_save.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(503, 273);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 32);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // l_edit_desc
            // 
            this.l_edit_desc.AutoSize = true;
            this.l_edit_desc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_edit_desc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_edit_desc.ForeColor = System.Drawing.Color.White;
            this.l_edit_desc.Location = new System.Drawing.Point(44, 74);
            this.l_edit_desc.Name = "l_edit_desc";
            this.l_edit_desc.Size = new System.Drawing.Size(146, 21);
            this.l_edit_desc.TabIndex = 7;
            this.l_edit_desc.Text = "Enter Description";
            // 
            // tb_edit_desc
            // 
            this.tb_edit_desc.Location = new System.Drawing.Point(207, 73);
            this.tb_edit_desc.Name = "tb_edit_desc";
            this.tb_edit_desc.Size = new System.Drawing.Size(173, 20);
            this.tb_edit_desc.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(612, 317);
            this.Controls.Add(this.tb_edit_desc);
            this.Controls.Add(this.l_edit_desc);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.cledit_av);
            this.Controls.Add(this.cledit_office);
            this.Controls.Add(this.cledit_images);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.l_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.CheckedListBox cledit_images;
        private System.Windows.Forms.CheckedListBox cledit_office;
        private System.Windows.Forms.CheckedListBox cledit_av;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label l_edit_desc;
        private System.Windows.Forms.TextBox tb_edit_desc;
    }
}