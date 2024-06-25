namespace WindowsFormsApp2
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(445, 339);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(317, 38);
            this.tb_user.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(445, 430);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(317, 38);
            this.tb_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "Student",
            "Teacher"});
            this.cb_role.Location = new System.Drawing.Point(445, 244);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(317, 39);
            this.cb_role.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role";
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_login.Location = new System.Drawing.Point(445, 526);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(209, 60);
            this.bt_login.TabIndex = 6;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(210, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(689, 78);
            this.label4.TabIndex = 7;
            this.label4.Text = "Greenwich Vietnam";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(445, 642);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(260, 36);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Remember login";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 726);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}