namespace Diversity
{
    partial class CreateAvatar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAvatar));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbIm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bEnter = new System.Windows.Forms.Button();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txpssw = new System.Windows.Forms.TextBox();
            this.txUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRaEt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbRaEt = new System.Windows.Forms.ComboBox();
            this.cbFaTy = new System.Windows.Forms.ComboBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.rbADHD = new System.Windows.Forms.CheckBox();
            this.rbAsthma = new System.Windows.Forms.CheckBox();
            this.rbAutism = new System.Windows.Forms.CheckBox();
            this.rbBlind = new System.Windows.Forms.CheckBox();
            this.rbDeaf = new System.Windows.Forms.CheckBox();
            this.rbDyslexia = new System.Windows.Forms.CheckBox();
            this.rbParaplegic = new System.Windows.Forms.CheckBox();
            this.rbOther = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "people.jpeg");
            this.imageList1.Images.SetKeyName(1, "diversidad.jpg");
            // 
            // lbIm
            // 
            this.lbIm.Image = ((System.Drawing.Image)(resources.GetObject("lbIm.Image")));
            this.lbIm.Location = new System.Drawing.Point(-2, -12);
            this.lbIm.Name = "lbIm";
            this.lbIm.Size = new System.Drawing.Size(621, 930);
            this.lbIm.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 59;
            this.label5.Text = "Disabilty:";
            // 
            // bEnter
            // 
            this.bEnter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bEnter.Enabled = false;
            this.bEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnter.ForeColor = System.Drawing.Color.White;
            this.bEnter.Location = new System.Drawing.Point(187, 403);
            this.bEnter.Margin = new System.Windows.Forms.Padding(1);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(174, 62);
            this.bEnter.TabIndex = 51;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = false;
            this.bEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAge
            // 
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbAge.Location = new System.Drawing.Point(107, 136);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(191, 24);
            this.cbAge.TabIndex = 49;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(107, 100);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(191, 22);
            this.txName.TabIndex = 47;
            // 
            // txpssw
            // 
            this.txpssw.Location = new System.Drawing.Point(133, 63);
            this.txpssw.Name = "txpssw";
            this.txpssw.Size = new System.Drawing.Size(165, 22);
            this.txpssw.TabIndex = 46;
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(133, 16);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(165, 22);
            this.txUser.TabIndex = 45;
            this.txUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 27);
            this.label4.TabIndex = 44;
            this.label4.Text = "Family type:";
            // 
            // lbRaEt
            // 
            this.lbRaEt.AutoSize = true;
            this.lbRaEt.BackColor = System.Drawing.Color.White;
            this.lbRaEt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaEt.Location = new System.Drawing.Point(10, 170);
            this.lbRaEt.Name = "lbRaEt";
            this.lbRaEt.Size = new System.Drawing.Size(172, 54);
            this.lbRaEt.TabIndex = 43;
            this.lbRaEt.Text = "Racial and \r\nEthnic category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 42;
            this.label3.Text = "Age: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Password: ";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.White;
            this.lbUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(10, 12);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(127, 27);
            this.lbUser.TabIndex = 39;
            this.lbUser.Text = "Username: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 92);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // cbRaEt
            // 
            this.cbRaEt.FormattingEnabled = true;
            this.cbRaEt.Location = new System.Drawing.Point(197, 200);
            this.cbRaEt.Name = "cbRaEt";
            this.cbRaEt.Size = new System.Drawing.Size(231, 24);
            this.cbRaEt.TabIndex = 62;
            // 
            // cbFaTy
            // 
            this.cbFaTy.FormattingEnabled = true;
            this.cbFaTy.Location = new System.Drawing.Point(168, 240);
            this.cbFaTy.Name = "cbFaTy";
            this.cbFaTy.Size = new System.Drawing.Size(260, 24);
            this.cbFaTy.TabIndex = 63;
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.BackColor = System.Drawing.Color.White;
            this.lbNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNo.Location = new System.Drawing.Point(130, 42);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(171, 17);
            this.lbNo.TabIndex = 64;
            this.lbNo.Text = "Username already exists. ";
            this.lbNo.Visible = false;
            // 
            // rbADHD
            // 
            this.rbADHD.AutoSize = true;
            this.rbADHD.BackColor = System.Drawing.Color.White;
            this.rbADHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbADHD.Location = new System.Drawing.Point(32, 315);
            this.rbADHD.Name = "rbADHD";
            this.rbADHD.Size = new System.Drawing.Size(69, 21);
            this.rbADHD.TabIndex = 65;
            this.rbADHD.Text = "ADHD";
            this.rbADHD.UseVisualStyleBackColor = false;
            // 
            // rbAsthma
            // 
            this.rbAsthma.AutoSize = true;
            this.rbAsthma.BackColor = System.Drawing.Color.White;
            this.rbAsthma.ForeColor = System.Drawing.Color.Red;
            this.rbAsthma.Location = new System.Drawing.Point(155, 315);
            this.rbAsthma.Name = "rbAsthma";
            this.rbAsthma.Size = new System.Drawing.Size(77, 21);
            this.rbAsthma.TabIndex = 66;
            this.rbAsthma.Text = "Asthma";
            this.rbAsthma.UseVisualStyleBackColor = false;
            // 
            // rbAutism
            // 
            this.rbAutism.AutoSize = true;
            this.rbAutism.BackColor = System.Drawing.Color.White;
            this.rbAutism.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbAutism.Location = new System.Drawing.Point(278, 315);
            this.rbAutism.Name = "rbAutism";
            this.rbAutism.Size = new System.Drawing.Size(72, 21);
            this.rbAutism.TabIndex = 67;
            this.rbAutism.Text = "Autism";
            this.rbAutism.UseVisualStyleBackColor = false;
            // 
            // rbBlind
            // 
            this.rbBlind.AutoSize = true;
            this.rbBlind.BackColor = System.Drawing.Color.White;
            this.rbBlind.ForeColor = System.Drawing.Color.Blue;
            this.rbBlind.Location = new System.Drawing.Point(401, 315);
            this.rbBlind.Name = "rbBlind";
            this.rbBlind.Size = new System.Drawing.Size(61, 21);
            this.rbBlind.TabIndex = 68;
            this.rbBlind.Text = "Blind";
            this.rbBlind.UseVisualStyleBackColor = false;
            // 
            // rbDeaf
            // 
            this.rbDeaf.AutoSize = true;
            this.rbDeaf.BackColor = System.Drawing.Color.White;
            this.rbDeaf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbDeaf.Location = new System.Drawing.Point(32, 343);
            this.rbDeaf.Name = "rbDeaf";
            this.rbDeaf.Size = new System.Drawing.Size(60, 21);
            this.rbDeaf.TabIndex = 69;
            this.rbDeaf.Text = "Deaf";
            this.rbDeaf.UseVisualStyleBackColor = false;
            // 
            // rbDyslexia
            // 
            this.rbDyslexia.AutoSize = true;
            this.rbDyslexia.BackColor = System.Drawing.Color.White;
            this.rbDyslexia.ForeColor = System.Drawing.Color.Goldenrod;
            this.rbDyslexia.Location = new System.Drawing.Point(155, 343);
            this.rbDyslexia.Name = "rbDyslexia";
            this.rbDyslexia.Size = new System.Drawing.Size(82, 21);
            this.rbDyslexia.TabIndex = 70;
            this.rbDyslexia.Text = "Dyslexia";
            this.rbDyslexia.UseVisualStyleBackColor = false;
            // 
            // rbParaplegic
            // 
            this.rbParaplegic.AutoSize = true;
            this.rbParaplegic.BackColor = System.Drawing.Color.White;
            this.rbParaplegic.ForeColor = System.Drawing.Color.DeepPink;
            this.rbParaplegic.Location = new System.Drawing.Point(278, 342);
            this.rbParaplegic.Name = "rbParaplegic";
            this.rbParaplegic.Size = new System.Drawing.Size(97, 21);
            this.rbParaplegic.TabIndex = 71;
            this.rbParaplegic.Text = "Paraplegic";
            this.rbParaplegic.UseVisualStyleBackColor = false;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.BackColor = System.Drawing.Color.White;
            this.rbOther.ForeColor = System.Drawing.Color.Chocolate;
            this.rbOther.Location = new System.Drawing.Point(401, 343);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(66, 21);
            this.rbOther.TabIndex = 72;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = false;
            // 
            // CreateAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 913);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbParaplegic);
            this.Controls.Add(this.rbDyslexia);
            this.Controls.Add(this.rbDeaf);
            this.Controls.Add(this.rbBlind);
            this.Controls.Add(this.rbAutism);
            this.Controls.Add(this.rbAsthma);
            this.Controls.Add(this.rbADHD);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.cbFaTy);
            this.Controls.Add(this.cbRaEt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txpssw);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbRaEt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbIm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAvatar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAvatar";
            this.Load += new System.EventHandler(this.CreateAvatar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbIm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.ComboBox cbAge;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txpssw;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRaEt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbRaEt;
        private System.Windows.Forms.ComboBox cbFaTy;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.CheckBox rbADHD;
        private System.Windows.Forms.CheckBox rbAsthma;
        private System.Windows.Forms.CheckBox rbAutism;
        private System.Windows.Forms.CheckBox rbBlind;
        private System.Windows.Forms.CheckBox rbDeaf;
        private System.Windows.Forms.CheckBox rbDyslexia;
        private System.Windows.Forms.CheckBox rbParaplegic;
        private System.Windows.Forms.CheckBox rbOther;
    }
}