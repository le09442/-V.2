namespace siwadon_5
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
            this.password1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sogin1 = new System.Windows.Forms.Button();
            this.login1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // password1
            // 
            this.password1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.password1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.password1.Location = new System.Drawing.Point(109, 388);
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(206, 22);
            this.password1.TabIndex = 7;
            this.password1.Text = "0944200422";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password\t";
            // 
            // username1
            // 
            this.username1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.username1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.username1.Location = new System.Drawing.Point(109, 359);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(206, 22);
            this.username1.TabIndex = 5;
            this.username1.Text = "siwadon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // sogin1
            // 
            this.sogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.sogin1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sogin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sogin1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.sogin1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sogin1.Location = new System.Drawing.Point(224, 417);
            this.sogin1.Name = "sogin1";
            this.sogin1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sogin1.Size = new System.Drawing.Size(91, 30);
            this.sogin1.TabIndex = 9;
            this.sogin1.Text = "Create";
            this.sogin1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sogin1.UseVisualStyleBackColor = false;
            this.sogin1.Click += new System.EventHandler(this.sogin1_Click);
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(156)))));
            this.login1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.login1.ForeColor = System.Drawing.Color.Black;
            this.login1.Location = new System.Drawing.Point(136, 417);
            this.login1.Name = "login1";
            this.login1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login1.Size = new System.Drawing.Size(82, 30);
            this.login1.TabIndex = 8;
            this.login1.Text = "Login";
            this.login1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.login1.UseVisualStyleBackColor = false;
            this.login1.Click += new System.EventHandler(this.login1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(335, 472);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sogin1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรไฟล์";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sogin1;
        private System.Windows.Forms.Button login1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}