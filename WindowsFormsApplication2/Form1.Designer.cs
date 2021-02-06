namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Quit_button = new System.Windows.Forms.Button();
            this.Plot_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.File5_sel_Box = new System.Windows.Forms.TextBox();
            this.File4_sel_Box = new System.Windows.Forms.TextBox();
            this.File3_sel_Box = new System.Windows.Forms.TextBox();
            this.File2_sel_Box = new System.Windows.Forms.TextBox();
            this.File1_sel_Box = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.File5_sel_button = new System.Windows.Forms.Button();
            this.File4_sel_button = new System.Windows.Forms.Button();
            this.File3_sel_button = new System.Windows.Forms.Button();
            this.File2_sel_button = new System.Windows.Forms.Button();
            this.File1_sel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 515);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(976, 25);
            this.progressBar1.TabIndex = 41;
            // 
            // Quit_button
            // 
            this.Quit_button.Location = new System.Drawing.Point(901, 563);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(94, 26);
            this.Quit_button.TabIndex = 40;
            this.Quit_button.Text = "Quit";
            this.Quit_button.UseVisualStyleBackColor = true;
            this.Quit_button.Click += new System.EventHandler(this.Quit_button_Click);
            // 
            // Plot_button
            // 
            this.Plot_button.Location = new System.Drawing.Point(786, 563);
            this.Plot_button.Name = "Plot_button";
            this.Plot_button.Size = new System.Drawing.Size(104, 26);
            this.Plot_button.TabIndex = 39;
            this.Plot_button.Text = "Plot";
            this.Plot_button.UseVisualStyleBackColor = true;
            this.Plot_button.Click += new System.EventHandler(this.Compute_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(15, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(978, 256);
            this.listBox1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "ファイル５：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "ファイル４：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "ファイル３：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "ファイル２：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "ファイル１：";
            // 
            // File5_sel_Box
            // 
            this.File5_sel_Box.Location = new System.Drawing.Point(112, 152);
            this.File5_sel_Box.Name = "File5_sel_Box";
            this.File5_sel_Box.Size = new System.Drawing.Size(773, 19);
            this.File5_sel_Box.TabIndex = 32;
            this.File5_sel_Box.TextChanged += new System.EventHandler(this.File5_sel_Box_TextChanged);
            // 
            // File4_sel_Box
            // 
            this.File4_sel_Box.Location = new System.Drawing.Point(112, 116);
            this.File4_sel_Box.Name = "File4_sel_Box";
            this.File4_sel_Box.Size = new System.Drawing.Size(773, 19);
            this.File4_sel_Box.TabIndex = 31;
            this.File4_sel_Box.TextChanged += new System.EventHandler(this.File4_sel_Box_TextChanged);
            // 
            // File3_sel_Box
            // 
            this.File3_sel_Box.Location = new System.Drawing.Point(112, 81);
            this.File3_sel_Box.Name = "File3_sel_Box";
            this.File3_sel_Box.Size = new System.Drawing.Size(773, 19);
            this.File3_sel_Box.TabIndex = 30;
            this.File3_sel_Box.TextChanged += new System.EventHandler(this.File3_sel_Box_TextChanged);
            // 
            // File2_sel_Box
            // 
            this.File2_sel_Box.Location = new System.Drawing.Point(112, 46);
            this.File2_sel_Box.Name = "File2_sel_Box";
            this.File2_sel_Box.Size = new System.Drawing.Size(773, 19);
            this.File2_sel_Box.TabIndex = 29;
            this.File2_sel_Box.TextChanged += new System.EventHandler(this.File2_sel_Box_TextChanged);
            // 
            // File1_sel_Box
            // 
            this.File1_sel_Box.Location = new System.Drawing.Point(112, 11);
            this.File1_sel_Box.Name = "File1_sel_Box";
            this.File1_sel_Box.Size = new System.Drawing.Size(773, 19);
            this.File1_sel_Box.TabIndex = 28;
            this.File1_sel_Box.TextChanged += new System.EventHandler(this.File1_sel_Box_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(81, 477);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(127, 19);
            this.textBox10.TabIndex = 43;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "銘柄番号：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // File5_sel_button
            // 
            this.File5_sel_button.Location = new System.Drawing.Point(901, 146);
            this.File5_sel_button.Name = "File5_sel_button";
            this.File5_sel_button.Size = new System.Drawing.Size(90, 29);
            this.File5_sel_button.TabIndex = 48;
            this.File5_sel_button.Text = "Select File";
            this.File5_sel_button.UseVisualStyleBackColor = true;
            this.File5_sel_button.Click += new System.EventHandler(this.File5_sel_button_Click);
            // 
            // File4_sel_button
            // 
            this.File4_sel_button.Location = new System.Drawing.Point(901, 111);
            this.File4_sel_button.Name = "File4_sel_button";
            this.File4_sel_button.Size = new System.Drawing.Size(91, 29);
            this.File4_sel_button.TabIndex = 47;
            this.File4_sel_button.Text = "Select File";
            this.File4_sel_button.UseVisualStyleBackColor = true;
            this.File4_sel_button.Click += new System.EventHandler(this.File4_sel_button_Click);
            // 
            // File3_sel_button
            // 
            this.File3_sel_button.Location = new System.Drawing.Point(901, 76);
            this.File3_sel_button.Name = "File3_sel_button";
            this.File3_sel_button.Size = new System.Drawing.Size(92, 29);
            this.File3_sel_button.TabIndex = 46;
            this.File3_sel_button.Text = "Select File";
            this.File3_sel_button.UseVisualStyleBackColor = true;
            this.File3_sel_button.Click += new System.EventHandler(this.File3_sel_button_Click);
            // 
            // File2_sel_button
            // 
            this.File2_sel_button.Location = new System.Drawing.Point(901, 41);
            this.File2_sel_button.Name = "File2_sel_button";
            this.File2_sel_button.Size = new System.Drawing.Size(92, 28);
            this.File2_sel_button.TabIndex = 45;
            this.File2_sel_button.Text = "Select File";
            this.File2_sel_button.UseVisualStyleBackColor = true;
            this.File2_sel_button.Click += new System.EventHandler(this.File2_sel_button_Click);
            // 
            // File1_sel_button
            // 
            this.File1_sel_button.Location = new System.Drawing.Point(901, 6);
            this.File1_sel_button.Name = "File1_sel_button";
            this.File1_sel_button.Size = new System.Drawing.Size(92, 29);
            this.File1_sel_button.TabIndex = 44;
            this.File1_sel_button.Text = "Select File";
            this.File1_sel_button.UseVisualStyleBackColor = true;
            this.File1_sel_button.Click += new System.EventHandler(this.File1_sel_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 609);
            this.Controls.Add(this.File5_sel_button);
            this.Controls.Add(this.File4_sel_button);
            this.Controls.Add(this.File3_sel_button);
            this.Controls.Add(this.File2_sel_button);
            this.Controls.Add(this.File1_sel_button);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.Plot_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.File5_sel_Box);
            this.Controls.Add(this.File4_sel_Box);
            this.Controls.Add(this.File3_sel_Box);
            this.Controls.Add(this.File2_sel_Box);
            this.Controls.Add(this.File1_sel_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Quit_button;
        private System.Windows.Forms.Button Plot_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox File5_sel_Box;
        private System.Windows.Forms.TextBox File4_sel_Box;
        private System.Windows.Forms.TextBox File3_sel_Box;
        private System.Windows.Forms.TextBox File2_sel_Box;
        private System.Windows.Forms.TextBox File1_sel_Box;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button File5_sel_button;
        private System.Windows.Forms.Button File4_sel_button;
        private System.Windows.Forms.Button File3_sel_button;
        private System.Windows.Forms.Button File2_sel_button;
        private System.Windows.Forms.Button File1_sel_button;
    }
}

