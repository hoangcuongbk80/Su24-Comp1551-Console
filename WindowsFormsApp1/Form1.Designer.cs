namespace WindowsFormsApp1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_swap = new System.Windows.Forms.Button();
            this.tb_swap_1 = new System.Windows.Forms.TextBox();
            this.tb_swap_2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_second = new System.Windows.Forms.TextBox();
            this.tb_first = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.cb_operator = new System.Windows.Forms.ComboBox();
            this.bt_equal = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_write_text = new System.Windows.Forms.Button();
            this.bt_read_text = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Say_Hi
            // 
            this.bt_Say_Hi.BackColor = System.Drawing.Color.Violet;
            this.bt_Say_Hi.Location = new System.Drawing.Point(75, 49);
            this.bt_Say_Hi.Name = "bt_Say_Hi";
            this.bt_Say_Hi.Size = new System.Drawing.Size(184, 81);
            this.bt_Say_Hi.TabIndex = 0;
            this.bt_Say_Hi.Text = "Say Hi";
            this.bt_Say_Hi.UseVisualStyleBackColor = false;
            this.bt_Say_Hi.Click += new System.EventHandler(this.bt_Say_Hi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.bt_Say_Hi);
            this.groupBox1.Location = new System.Drawing.Point(21, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Greeting";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.tb_swap_2);
            this.groupBox2.Controls.Add(this.tb_swap_1);
            this.groupBox2.Controls.Add(this.bt_swap);
            this.groupBox2.Location = new System.Drawing.Point(393, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Swap";
            // 
            // bt_swap
            // 
            this.bt_swap.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_swap.Location = new System.Drawing.Point(226, 51);
            this.bt_swap.Name = "bt_swap";
            this.bt_swap.Size = new System.Drawing.Size(184, 81);
            this.bt_swap.TabIndex = 0;
            this.bt_swap.Text = "Swap";
            this.bt_swap.UseVisualStyleBackColor = false;
            this.bt_swap.Click += new System.EventHandler(this.bt_swap_Click);
            // 
            // tb_swap_1
            // 
            this.tb_swap_1.Location = new System.Drawing.Point(27, 73);
            this.tb_swap_1.Name = "tb_swap_1";
            this.tb_swap_1.Size = new System.Drawing.Size(186, 38);
            this.tb_swap_1.TabIndex = 3;
            // 
            // tb_swap_2
            // 
            this.tb_swap_2.Location = new System.Drawing.Point(428, 73);
            this.tb_swap_2.Name = "tb_swap_2";
            this.tb_swap_2.Size = new System.Drawing.Size(186, 38);
            this.tb_swap_2.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Bisque;
            this.groupBox3.Controls.Add(this.bt_equal);
            this.groupBox3.Controls.Add(this.cb_operator);
            this.groupBox3.Controls.Add(this.tb_result);
            this.groupBox3.Controls.Add(this.tb_second);
            this.groupBox3.Controls.Add(this.tb_first);
            this.groupBox3.Location = new System.Drawing.Point(21, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1022, 167);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculator";
            // 
            // tb_second
            // 
            this.tb_second.Location = new System.Drawing.Point(419, 73);
            this.tb_second.Name = "tb_second";
            this.tb_second.Size = new System.Drawing.Size(183, 38);
            this.tb_second.TabIndex = 4;
            // 
            // tb_first
            // 
            this.tb_first.Location = new System.Drawing.Point(27, 73);
            this.tb_first.Name = "tb_first";
            this.tb_first.Size = new System.Drawing.Size(186, 38);
            this.tb_first.TabIndex = 3;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(811, 73);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(186, 38);
            this.tb_result.TabIndex = 5;
            // 
            // cb_operator
            // 
            this.cb_operator.FormattingEnabled = true;
            this.cb_operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cb_operator.Location = new System.Drawing.Point(249, 73);
            this.cb_operator.Name = "cb_operator";
            this.cb_operator.Size = new System.Drawing.Size(121, 39);
            this.cb_operator.TabIndex = 6;
            // 
            // bt_equal
            // 
            this.bt_equal.Location = new System.Drawing.Point(641, 66);
            this.bt_equal.Name = "bt_equal";
            this.bt_equal.Size = new System.Drawing.Size(131, 51);
            this.bt_equal.TabIndex = 7;
            this.bt_equal.Text = "=";
            this.bt_equal.UseVisualStyleBackColor = true;
            this.bt_equal.Click += new System.EventHandler(this.bt_equal_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.bt_read_text);
            this.groupBox4.Controls.Add(this.bt_write_text);
            this.groupBox4.Location = new System.Drawing.Point(21, 491);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1022, 517);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File Process";
            // 
            // bt_write_text
            // 
            this.bt_write_text.BackColor = System.Drawing.Color.Turquoise;
            this.bt_write_text.Location = new System.Drawing.Point(60, 64);
            this.bt_write_text.Name = "bt_write_text";
            this.bt_write_text.Size = new System.Drawing.Size(274, 51);
            this.bt_write_text.TabIndex = 7;
            this.bt_write_text.Text = "Write Text File";
            this.bt_write_text.UseVisualStyleBackColor = false;
            this.bt_write_text.Click += new System.EventHandler(this.bt_write_text_Click);
            // 
            // bt_read_text
            // 
            this.bt_read_text.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_read_text.Location = new System.Drawing.Point(382, 64);
            this.bt_read_text.Name = "bt_read_text";
            this.bt_read_text.Size = new System.Drawing.Size(274, 51);
            this.bt_read_text.TabIndex = 8;
            this.bt_read_text.Text = "Read Text File";
            this.bt_read_text.UseVisualStyleBackColor = false;
            this.bt_read_text.Click += new System.EventHandler(this.bt_read_text_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 165);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(957, 331);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1471, 999);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FGW";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Say_Hi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_swap_2;
        private System.Windows.Forms.TextBox tb_swap_1;
        private System.Windows.Forms.Button bt_swap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_operator;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.TextBox tb_second;
        private System.Windows.Forms.TextBox tb_first;
        private System.Windows.Forms.Button bt_equal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_write_text;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_read_text;
    }
}

