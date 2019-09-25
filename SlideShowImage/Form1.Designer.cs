namespace SlideShowImage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.txtRight = new System.Windows.Forms.Button();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picImage4 = new System.Windows.Forms.PictureBox();
            this.picImage3 = new System.Windows.Forms.PictureBox();
            this.picImage2 = new System.Windows.Forms.PictureBox();
            this.picImage1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lựaChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoChuyểnẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dừngChuyểnẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.txtRight);
            this.panel1.Controls.Add(this.picMain);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 274);
            this.panel1.TabIndex = 0;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLeft.Image = global::SlideShowImage.Properties.Resources.iconfinder_icon_ios7_arrow_back_211686;
            this.btnLeft.Location = new System.Drawing.Point(145, 85);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(43, 75);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // txtRight
            // 
            this.txtRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRight.Image = global::SlideShowImage.Properties.Resources.iconfinder_icon_ios7_arrow_forward_2116881;
            this.txtRight.Location = new System.Drawing.Point(571, 85);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(41, 75);
            this.txtRight.TabIndex = 8;
            this.txtRight.UseVisualStyleBackColor = false;
            this.txtRight.Click += new System.EventHandler(this.txtRight_Click);
            // 
            // picMain
            // 
            this.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMain.Location = new System.Drawing.Point(211, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(342, 271);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 5;
            this.picMain.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picImage4);
            this.panel2.Controls.Add(this.picImage3);
            this.panel2.Controls.Add(this.picImage2);
            this.panel2.Controls.Add(this.picImage1);
            this.panel2.Location = new System.Drawing.Point(12, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 120);
            this.panel2.TabIndex = 1;
            // 
            // picImage4
            // 
            this.picImage4.Location = new System.Drawing.Point(601, 3);
            this.picImage4.Name = "picImage4";
            this.picImage4.Size = new System.Drawing.Size(122, 114);
            this.picImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage4.TabIndex = 3;
            this.picImage4.TabStop = false;
            // 
            // picImage3
            // 
            this.picImage3.Location = new System.Drawing.Point(421, 3);
            this.picImage3.Name = "picImage3";
            this.picImage3.Size = new System.Drawing.Size(122, 114);
            this.picImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage3.TabIndex = 2;
            this.picImage3.TabStop = false;
            // 
            // picImage2
            // 
            this.picImage2.Location = new System.Drawing.Point(211, 3);
            this.picImage2.Name = "picImage2";
            this.picImage2.Size = new System.Drawing.Size(122, 114);
            this.picImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage2.TabIndex = 1;
            this.picImage2.TabStop = false;
            // 
            // picImage1
            // 
            this.picImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage1.Location = new System.Drawing.Point(27, 3);
            this.picImage1.Name = "picImage1";
            this.picImage1.Size = new System.Drawing.Size(122, 114);
            this.picImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage1.TabIndex = 0;
            this.picImage1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 24);
            this.panel3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lựaChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lựaChọnToolStripMenuItem
            // 
            this.lựaChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoChuyểnẢnhToolStripMenuItem,
            this.dừngChuyểnẢnhToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.lựaChọnToolStripMenuItem.Name = "lựaChọnToolStripMenuItem";
            this.lựaChọnToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.lựaChọnToolStripMenuItem.Text = "Option";
            // 
            // autoChuyểnẢnhToolStripMenuItem
            // 
            this.autoChuyểnẢnhToolStripMenuItem.Name = "autoChuyểnẢnhToolStripMenuItem";
            this.autoChuyểnẢnhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoChuyểnẢnhToolStripMenuItem.Text = "Auto chuyển ảnh";
            this.autoChuyểnẢnhToolStripMenuItem.Click += new System.EventHandler(this.autoChuyểnẢnhToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dừngChuyểnẢnhToolStripMenuItem
            // 
            this.dừngChuyểnẢnhToolStripMenuItem.Name = "dừngChuyểnẢnhToolStripMenuItem";
            this.dừngChuyểnẢnhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dừngChuyểnẢnhToolStripMenuItem.Text = "Dừng chuyển ảnh";
            this.dừngChuyểnẢnhToolStripMenuItem.Click += new System.EventHandler(this.dừngChuyểnẢnhToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slider Show";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picImage4;
        private System.Windows.Forms.PictureBox picImage3;
        private System.Windows.Forms.PictureBox picImage2;
        private System.Windows.Forms.PictureBox picImage1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button txtRight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lựaChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoChuyểnẢnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem dừngChuyểnẢnhToolStripMenuItem;
    }
}

