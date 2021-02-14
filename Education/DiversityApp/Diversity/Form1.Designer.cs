namespace Diversity
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btAcceder = new System.Windows.Forms.Button();
            this.txUsu = new System.Windows.Forms.TextBox();
            this.txContra = new System.Windows.Forms.TextBox();
            this.lbPs = new System.Windows.Forms.Label();
            this.lbUsu = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Button();
            this.lbIm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAcceder
            // 
            this.btAcceder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcceder.ForeColor = System.Drawing.Color.White;
            this.btAcceder.Location = new System.Drawing.Point(262, 428);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(157, 51);
            this.btAcceder.TabIndex = 14;
            this.btAcceder.Text = "Log In";
            this.btAcceder.UseVisualStyleBackColor = false;
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // txUsu
            // 
            this.txUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsu.Location = new System.Drawing.Point(262, 320);
            this.txUsu.Name = "txUsu";
            this.txUsu.Size = new System.Drawing.Size(157, 34);
            this.txUsu.TabIndex = 13;
            // 
            // txContra
            // 
            this.txContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txContra.Location = new System.Drawing.Point(262, 382);
            this.txContra.Name = "txContra";
            this.txContra.PasswordChar = '*';
            this.txContra.Size = new System.Drawing.Size(157, 34);
            this.txContra.TabIndex = 12;
            // 
            // lbPs
            // 
            this.lbPs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPs.ForeColor = System.Drawing.Color.White;
            this.lbPs.Location = new System.Drawing.Point(115, 378);
            this.lbPs.Name = "lbPs";
            this.lbPs.Size = new System.Drawing.Size(126, 30);
            this.lbPs.TabIndex = 11;
            this.lbPs.Text = "Password: ";
            this.lbPs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsu
            // 
            this.lbUsu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsu.ForeColor = System.Drawing.Color.White;
            this.lbUsu.Location = new System.Drawing.Point(113, 316);
            this.lbUsu.Name = "lbUsu";
            this.lbUsu.Size = new System.Drawing.Size(128, 30);
            this.lbUsu.TabIndex = 10;
            this.lbUsu.Text = "User: ";
            this.lbUsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signIn
            // 
            this.signIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.ForeColor = System.Drawing.Color.White;
            this.signIn.Location = new System.Drawing.Point(262, 485);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(157, 51);
            this.signIn.TabIndex = 15;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = false;
            this.signIn.Click += new System.EventHandler(this.btAcceder_Click_1);
            // 
            // lbIm
            // 
            this.lbIm.Image = ((System.Drawing.Image)(resources.GetObject("lbIm.Image")));
            this.lbIm.Location = new System.Drawing.Point(-16, -24);
            this.lbIm.Name = "lbIm";
            this.lbIm.Size = new System.Drawing.Size(0, 0);
            this.lbIm.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 883);
            this.Controls.Add(this.lbIm);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.btAcceder);
            this.Controls.Add(this.txUsu);
            this.Controls.Add(this.txContra);
            this.Controls.Add(this.lbPs);
            this.Controls.Add(this.lbUsu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAcceder;
        private System.Windows.Forms.TextBox txUsu;
        private System.Windows.Forms.TextBox txContra;
        private System.Windows.Forms.Label lbPs;
        private System.Windows.Forms.Label lbUsu;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Label lbIm;
    }
}

