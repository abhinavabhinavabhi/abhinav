namespace example
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
            this.qualification = new System.Windows.Forms.GroupBox();
            this.adminradio = new System.Windows.Forms.RadioButton();
            this.facultyradio = new System.Windows.Forms.RadioButton();
            this.studentradio = new System.Windows.Forms.RadioButton();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.qualification.SuspendLayout();
            this.SuspendLayout();
            // 
            // qualification
            // 
            this.qualification.Controls.Add(this.adminradio);
            this.qualification.Controls.Add(this.facultyradio);
            this.qualification.Controls.Add(this.studentradio);
            this.qualification.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.qualification.Location = new System.Drawing.Point(93, 116);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(357, 51);
            this.qualification.TabIndex = 0;
            this.qualification.TabStop = false;
            this.qualification.Text = "qualification";
            // 
            // adminradio
            // 
            this.adminradio.AutoSize = true;
            this.adminradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminradio.Location = new System.Drawing.Point(244, 25);
            this.adminradio.Name = "adminradio";
            this.adminradio.Size = new System.Drawing.Size(70, 20);
            this.adminradio.TabIndex = 2;
            this.adminradio.TabStop = true;
            this.adminradio.Text = "Admin";
            this.adminradio.UseVisualStyleBackColor = true;
            // 
            // facultyradio
            // 
            this.facultyradio.AutoSize = true;
            this.facultyradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyradio.Location = new System.Drawing.Point(131, 26);
            this.facultyradio.Name = "facultyradio";
            this.facultyradio.Size = new System.Drawing.Size(77, 20);
            this.facultyradio.TabIndex = 1;
            this.facultyradio.TabStop = true;
            this.facultyradio.Text = "Faculty";
            this.facultyradio.UseVisualStyleBackColor = true;
            // 
            // studentradio
            // 
            this.studentradio.AutoSize = true;
            this.studentradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentradio.Location = new System.Drawing.Point(30, 28);
            this.studentradio.Name = "studentradio";
            this.studentradio.Size = new System.Drawing.Size(69, 17);
            this.studentradio.TabIndex = 0;
            this.studentradio.TabStop = true;
            this.studentradio.Text = "Student";
            this.studentradio.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(199, 196);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 20);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(199, 241);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 20);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(80, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(215, 295);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(131, 32);
            this.login.TabIndex = 5;
            this.login.Text = "login";
            this.login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "america",
            "newyork",
            "india"});
            this.comboBox1.Location = new System.Drawing.Point(199, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 394);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.qualification);
            this.Name = "Form1";
            this.Text = "Form1";
            this.qualification.ResumeLayout(false);
            this.qualification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox qualification;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton adminradio;
        private System.Windows.Forms.RadioButton facultyradio;
        private System.Windows.Forms.RadioButton studentradio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

