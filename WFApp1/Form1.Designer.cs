namespace WFApp1
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
            this.bt_Say_Hi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_swap_1 = new System.Windows.Forms.TextBox();
            this.tb_swap_2 = new System.Windows.Forms.TextBox();
            this.bt_swap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_write_Text = new System.Windows.Forms.Button();
            this.bt_read_text = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Say_Hi
            // 
            this.bt_Say_Hi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bt_Say_Hi.Location = new System.Drawing.Point(22, 51);
            this.bt_Say_Hi.Name = "bt_Say_Hi";
            this.bt_Say_Hi.Size = new System.Drawing.Size(197, 67);
            this.bt_Say_Hi.TabIndex = 0;
            this.bt_Say_Hi.Text = "Say Hi";
            this.bt_Say_Hi.UseVisualStyleBackColor = false;
            this.bt_Say_Hi.Click += new System.EventHandler(this.bt_Say_Hi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.bt_Say_Hi);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Greeting";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.bt_swap);
            this.groupBox2.Controls.Add(this.tb_swap_2);
            this.groupBox2.Controls.Add(this.tb_swap_1);
            this.groupBox2.Location = new System.Drawing.Point(315, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Swap";
            // 
            // tb_swap_1
            // 
            this.tb_swap_1.Location = new System.Drawing.Point(6, 77);
            this.tb_swap_1.Name = "tb_swap_1";
            this.tb_swap_1.Size = new System.Drawing.Size(118, 38);
            this.tb_swap_1.TabIndex = 3;
            // 
            // tb_swap_2
            // 
            this.tb_swap_2.Location = new System.Drawing.Point(341, 76);
            this.tb_swap_2.Name = "tb_swap_2";
            this.tb_swap_2.Size = new System.Drawing.Size(146, 38);
            this.tb_swap_2.TabIndex = 4;
            // 
            // bt_swap
            // 
            this.bt_swap.Location = new System.Drawing.Point(175, 76);
            this.bt_swap.Name = "bt_swap";
            this.bt_swap.Size = new System.Drawing.Size(117, 47);
            this.bt_swap.TabIndex = 3;
            this.bt_swap.Text = "Swap";
            this.bt_swap.UseVisualStyleBackColor = true;
            this.bt_swap.Click += new System.EventHandler(this.bt_swap_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.bt_read_text);
            this.groupBox3.Controls.Add(this.bt_write_Text);
            this.groupBox3.Location = new System.Drawing.Point(12, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(844, 465);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text Process";
            // 
            // bt_write_Text
            // 
            this.bt_write_Text.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.bt_write_Text.Location = new System.Drawing.Point(20, 66);
            this.bt_write_Text.Name = "bt_write_Text";
            this.bt_write_Text.Size = new System.Drawing.Size(223, 54);
            this.bt_write_Text.TabIndex = 0;
            this.bt_write_Text.Text = "Write Text File";
            this.bt_write_Text.UseVisualStyleBackColor = false;
            this.bt_write_Text.Click += new System.EventHandler(this.bt_write_Text_Click);
            // 
            // bt_read_text
            // 
            this.bt_read_text.BackColor = System.Drawing.Color.Salmon;
            this.bt_read_text.Location = new System.Drawing.Point(276, 66);
            this.bt_read_text.Name = "bt_read_text";
            this.bt_read_text.Size = new System.Drawing.Size(223, 54);
            this.bt_read_text.TabIndex = 4;
            this.bt_read_text.Text = "Read Text File";
            this.bt_read_text.UseVisualStyleBackColor = false;
            this.bt_read_text.Click += new System.EventHandler(this.bt_read_text_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(792, 287);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 827);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Say_Hi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_swap;
        private System.Windows.Forms.TextBox tb_swap_2;
        private System.Windows.Forms.TextBox tb_swap_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_read_text;
        private System.Windows.Forms.Button bt_write_Text;
    }
}

