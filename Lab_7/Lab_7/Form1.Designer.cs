namespace Lab_7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.XplZpl = new System.Windows.Forms.Button();
            this.XmZm = new System.Windows.Forms.Button();
            this.StopB = new System.Windows.Forms.Button();
            this.CW_Xm = new System.Windows.Forms.Button();
            this.CCW_Xpl = new System.Windows.Forms.Button();
            this.XTZX = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // XplZpl
            // 
            this.XplZpl.Location = new System.Drawing.Point(117, 18);
            this.XplZpl.Name = "XplZpl";
            this.XplZpl.Size = new System.Drawing.Size(100, 100);
            this.XplZpl.TabIndex = 0;
            this.XplZpl.Text = "X+";
            this.XplZpl.UseVisualStyleBackColor = true;
            this.XplZpl.Click += new System.EventHandler(this.XplZpl_Click);
            // 
            // XmZm
            // 
            this.XmZm.Location = new System.Drawing.Point(117, 230);
            this.XmZm.Name = "XmZm";
            this.XmZm.Size = new System.Drawing.Size(100, 100);
            this.XmZm.TabIndex = 1;
            this.XmZm.Text = "X-";
            this.XmZm.UseVisualStyleBackColor = true;
            this.XmZm.Click += new System.EventHandler(this.XmZm_Click);
            // 
            // StopB
            // 
            this.StopB.Location = new System.Drawing.Point(117, 124);
            this.StopB.Name = "StopB";
            this.StopB.Size = new System.Drawing.Size(100, 100);
            this.StopB.TabIndex = 2;
            this.StopB.Text = "Stop";
            this.StopB.UseVisualStyleBackColor = true;
            this.StopB.Click += new System.EventHandler(this.StopB_Click);
            // 
            // CW_Xm
            // 
            this.CW_Xm.Location = new System.Drawing.Point(11, 124);
            this.CW_Xm.Name = "CW_Xm";
            this.CW_Xm.Size = new System.Drawing.Size(100, 100);
            this.CW_Xm.TabIndex = 3;
            this.CW_Xm.Text = "CW";
            this.CW_Xm.UseVisualStyleBackColor = true;
            this.CW_Xm.Click += new System.EventHandler(this.CW_Xm_Click);
            // 
            // CCW_Xpl
            // 
            this.CCW_Xpl.Location = new System.Drawing.Point(223, 124);
            this.CCW_Xpl.Name = "CCW_Xpl";
            this.CCW_Xpl.Size = new System.Drawing.Size(100, 100);
            this.CCW_Xpl.TabIndex = 4;
            this.CCW_Xpl.Text = "CCW";
            this.CCW_Xpl.UseVisualStyleBackColor = true;
            this.CCW_Xpl.Click += new System.EventHandler(this.CCW_Xpl_Click);
            // 
            // XTZX
            // 
            this.XTZX.Location = new System.Drawing.Point(493, 178);
            this.XTZX.Name = "XTZX";
            this.XTZX.Size = new System.Drawing.Size(100, 100);
            this.XTZX.TabIndex = 5;
            this.XTZX.Text = "XT";
            this.XTZX.UseVisualStyleBackColor = true;
            this.XTZX.Click += new System.EventHandler(this.XTZX_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(493, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(164, 92);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "X        0\nTheta 0\nZ        0\n";
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(599, 178);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(108, 46);
            this.SaveB.TabIndex = 8;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // ExitB
            // 
            this.ExitB.Location = new System.Drawing.Point(599, 232);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(108, 46);
            this.ExitB.TabIndex = 9;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = true;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(451, 353);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 50;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(583, 370);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(134, 42);
            this.hScrollBar1.TabIndex = 11;
            this.hScrollBar1.Value = 50;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.XTZX);
            this.Controls.Add(this.CCW_Xpl);
            this.Controls.Add(this.CW_Xm);
            this.Controls.Add(this.StopB);
            this.Controls.Add(this.XmZm);
            this.Controls.Add(this.XplZpl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button XplZpl;
        private System.Windows.Forms.Button XmZm;
        private System.Windows.Forms.Button StopB;
        private System.Windows.Forms.Button CW_Xm;
        private System.Windows.Forms.Button CCW_Xpl;
        private System.Windows.Forms.Button XTZX;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

