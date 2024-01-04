namespace App_Bunifu_UI
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltab1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbltab2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltab3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.animator1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tab12 = new App_Bunifu_UI.tab1();
            this.tab22 = new App_Bunifu_UI.tab2();
            this.tab31 = new App_Bunifu_UI.tab3();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.bunifuCustomLabel8);
            this.header.Controls.Add(this.bunifuCustomLabel6);
            this.header.Controls.Add(this.bunifuCustomLabel4);
            this.header.Controls.Add(this.bunifuCustomLabel7);
            this.header.Controls.Add(this.bunifuCustomLabel5);
            this.header.Controls.Add(this.bunifuCustomLabel3);
            this.header.Controls.Add(this.bunifuCustomLabel2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Controls.Add(this.pictureBox1);
            this.animator1.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(853, 217);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.animator1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(809, 15);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.animator1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(17, 15);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel8.Enabled = false;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(407, 160);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(82, 21);
            this.bunifuCustomLabel8.TabIndex = 2;
            this.bunifuCustomLabel8.Text = "Following";
            this.bunifuCustomLabel8.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Enabled = false;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(293, 160);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(62, 21);
            this.bunifuCustomLabel6.TabIndex = 2;
            this.bunifuCustomLabel6.Text = "Photos";
            this.bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Enabled = false;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(185, 160);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(48, 21);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "Posts";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Enabled = false;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(424, 137);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(48, 23);
            this.bunifuCustomLabel7.TabIndex = 2;
            this.bunifuCustomLabel7.Text = "8.5k";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Enabled = false;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(303, 137);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(43, 23);
            this.bunifuCustomLabel5.TabIndex = 2;
            this.bunifuCustomLabel5.Text = "185";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Enabled = false;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(182, 137);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(54, 23);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "2391";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Enabled = false;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(215, 91);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(128, 21);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = ".Net Developer";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Enabled = false;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(204, 51);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(169, 30);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Laurence Verallo";
            // 
            // pictureBox1
            // 
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbltab1
            // 
            this.lbltab1.AutoSize = true;
            this.lbltab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lbltab1, BunifuAnimatorNS.DecorationType.None);
            this.lbltab1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab1.ForeColor = System.Drawing.Color.Gray;
            this.lbltab1.Location = new System.Drawing.Point(53, 265);
            this.lbltab1.Name = "lbltab1";
            this.lbltab1.Size = new System.Drawing.Size(51, 16);
            this.lbltab1.TabIndex = 2;
            this.lbltab1.Text = "ABOUT";
            this.lbltab1.Click += new System.EventHandler(this.lbltab1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(714, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbltab2
            // 
            this.lbltab2.AutoSize = true;
            this.lbltab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lbltab2, BunifuAnimatorNS.DecorationType.None);
            this.lbltab2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab2.ForeColor = System.Drawing.Color.Gray;
            this.lbltab2.Location = new System.Drawing.Point(158, 265);
            this.lbltab2.Name = "lbltab2";
            this.lbltab2.Size = new System.Drawing.Size(59, 16);
            this.lbltab2.TabIndex = 2;
            this.lbltab2.Text = "PHOTOS";
            this.lbltab2.Click += new System.EventHandler(this.lbltab2_Click);
            // 
            // lbltab3
            // 
            this.lbltab3.AutoSize = true;
            this.lbltab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.lbltab3, BunifuAnimatorNS.DecorationType.None);
            this.lbltab3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltab3.ForeColor = System.Drawing.Color.Gray;
            this.lbltab3.Location = new System.Drawing.Point(272, 265);
            this.lbltab3.Name = "lbltab3";
            this.lbltab3.Size = new System.Drawing.Size(46, 16);
            this.lbltab3.TabIndex = 2;
            this.lbltab3.Text = "POSTS";
            this.lbltab3.Click += new System.EventHandler(this.lbltab3_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.line.LineThickness = 3;
            this.line.Location = new System.Drawing.Point(45, 284);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(66, 26);
            this.line.TabIndex = 3;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tab12);
            this.panel2.Controls.Add(this.tab22);
            this.panel2.Controls.Add(this.tab31);
            this.animator1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(33, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 324);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // tab12
            // 
            this.tab12.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.tab12, BunifuAnimatorNS.DecorationType.None);
            this.tab12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab12.Location = new System.Drawing.Point(0, 0);
            this.tab12.Name = "tab12";
            this.tab12.Size = new System.Drawing.Size(794, 324);
            this.tab12.TabIndex = 1;
            // 
            // tab22
            // 
            this.tab22.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.tab22, BunifuAnimatorNS.DecorationType.None);
            this.tab22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab22.Location = new System.Drawing.Point(0, 0);
            this.tab22.Name = "tab22";
            this.tab22.Size = new System.Drawing.Size(794, 324);
            this.tab22.TabIndex = 0;
            // 
            // tab31
            // 
            this.tab31.AutoScroll = true;
            this.tab31.BackColor = System.Drawing.Color.WhiteSmoke;
            this.animator1.SetDecoration(this.tab31, BunifuAnimatorNS.DecorationType.None);
            this.tab31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab31.Location = new System.Drawing.Point(0, 0);
            this.tab31.Name = "tab31";
            this.tab31.Size = new System.Drawing.Size(794, 324);
            this.tab31.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 657);
            this.Controls.Add(this.line);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbltab3);
            this.Controls.Add(this.lbltab2);
            this.Controls.Add(this.lbltab1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel2);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab3;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltab1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition animator1;
        private tab2 tab22;
        private tab1 tab12;
        private tab3 tab31;
    }
}

