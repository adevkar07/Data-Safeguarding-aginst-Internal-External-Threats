namespace policy_creator1
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
            this.tb_namepol = new System.Windows.Forms.TextBox();
            this.tb_desc_pol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cl_images = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cl_office = new System.Windows.Forms.CheckedListBox();
            this.cl_av = new System.Windows.Forms.CheckedListBox();
            this.rb_image = new System.Windows.Forms.RadioButton();
            this.rb_office = new System.Windows.Forms.RadioButton();
            this.rb_av = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tb_namepol
            // 
            this.tb_namepol.Location = new System.Drawing.Point(354, 28);
            this.tb_namepol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_namepol.Name = "tb_namepol";
            this.tb_namepol.Size = new System.Drawing.Size(430, 28);
            this.tb_namepol.TabIndex = 0;
            // 
            // tb_desc_pol
            // 
            this.tb_desc_pol.Location = new System.Drawing.Point(354, 89);
            this.tb_desc_pol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_desc_pol.Name = "tb_desc_pol";
            this.tb_desc_pol.Size = new System.Drawing.Size(430, 28);
            this.tb_desc_pol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cl_images
            // 
            this.cl_images.FormattingEnabled = true;
            this.cl_images.Items.AddRange(new object[] {
            "png",
            "tiff",
            "jpeg/jpg"});
            this.cl_images.Location = new System.Drawing.Point(80, 307);
            this.cl_images.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cl_images.Name = "cl_images";
            this.cl_images.Size = new System.Drawing.Size(178, 96);
            this.cl_images.TabIndex = 6;
            this.cl_images.SelectedIndexChanged += new System.EventHandler(this.cl_images_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(759, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cl_office
            // 
            this.cl_office.FormattingEnabled = true;
            this.cl_office.Items.AddRange(new object[] {
            "doc/xls/ppt",
            "pdf",
            "pptx/docx/xlsx",
            "iso"});
            this.cl_office.Location = new System.Drawing.Point(354, 307);
            this.cl_office.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cl_office.Name = "cl_office";
            this.cl_office.Size = new System.Drawing.Size(178, 96);
            this.cl_office.TabIndex = 8;
            this.cl_office.SelectedIndexChanged += new System.EventHandler(this.cl_office_SelectedIndexChanged);
            // 
            // cl_av
            // 
            this.cl_av.FormattingEnabled = true;
            this.cl_av.Items.AddRange(new object[] {
            "mkv",
            "wav/avi",
            "gif"});
            this.cl_av.Location = new System.Drawing.Point(628, 307);
            this.cl_av.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cl_av.Name = "cl_av";
            this.cl_av.Size = new System.Drawing.Size(178, 96);
            this.cl_av.TabIndex = 9;
            this.cl_av.SelectedIndexChanged += new System.EventHandler(this.cl_av_SelectedIndexChanged);
            // 
            // rb_image
            // 
            this.rb_image.AutoSize = true;
            this.rb_image.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_image.Location = new System.Drawing.Point(80, 268);
            this.rb_image.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rb_image.Name = "rb_image";
            this.rb_image.Size = new System.Drawing.Size(86, 27);
            this.rb_image.TabIndex = 10;
            this.rb_image.TabStop = true;
            this.rb_image.Text = "Images";
            this.rb_image.UseVisualStyleBackColor = true;
            this.rb_image.CheckedChanged += new System.EventHandler(this.rb_image_CheckedChanged);
            // 
            // rb_office
            // 
            this.rb_office.AutoSize = true;
            this.rb_office.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_office.Location = new System.Drawing.Point(354, 268);
            this.rb_office.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rb_office.Name = "rb_office";
            this.rb_office.Size = new System.Drawing.Size(78, 27);
            this.rb_office.TabIndex = 11;
            this.rb_office.TabStop = true;
            this.rb_office.Text = "Office";
            this.rb_office.UseVisualStyleBackColor = true;
            this.rb_office.CheckedChanged += new System.EventHandler(this.rb_office_CheckedChanged);
            // 
            // rb_av
            // 
            this.rb_av.AutoSize = true;
            this.rb_av.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_av.Location = new System.Drawing.Point(628, 268);
            this.rb_av.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rb_av.Name = "rb_av";
            this.rb_av.Size = new System.Drawing.Size(144, 27);
            this.rb_av.TabIndex = 12;
            this.rb_av.TabStop = true;
            this.rb_av.Text = "Audio / Video";
            this.rb_av.UseVisualStyleBackColor = true;
            this.rb_av.CheckedChanged += new System.EventHandler(this.rb_av_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(890, 461);
            this.Controls.Add(this.rb_av);
            this.Controls.Add(this.rb_office);
            this.Controls.Add(this.rb_image);
            this.Controls.Add(this.cl_av);
            this.Controls.Add(this.cl_office);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cl_images);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_desc_pol);
            this.Controls.Add(this.tb_namepol);
            this.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form2";
            this.Text = "Add Policies";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_namepol;
        private System.Windows.Forms.TextBox tb_desc_pol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox cl_office;
        private System.Windows.Forms.CheckedListBox cl_av;
        public System.Windows.Forms.RadioButton rb_image;
        public System.Windows.Forms.RadioButton rb_office;
        public System.Windows.Forms.RadioButton rb_av;
        public System.Windows.Forms.CheckedListBox cl_images;
    }
}