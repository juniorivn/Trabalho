namespace ArtigosIvan
{
    partial class Login
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.ckbLogado = new System.Windows.Forms.CheckBox();
            this.lblEsqueceu = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblOla = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(330, 210);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(234, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "Digite seu usúario";
            this.txtLogin.UseWaitCursor = true;
            this.txtLogin.Click += new System.EventHandler(this.txtLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(330, 253);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(234, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "         ";
            this.txtSenha.UseWaitCursor = true;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            // 
            // ckbLogado
            // 
            this.ckbLogado.AutoSize = true;
            this.ckbLogado.Location = new System.Drawing.Point(330, 293);
            this.ckbLogado.Name = "ckbLogado";
            this.ckbLogado.Size = new System.Drawing.Size(113, 17);
            this.ckbLogado.TabIndex = 2;
            this.ckbLogado.Text = "Mantenha Logado";
            this.ckbLogado.UseVisualStyleBackColor = true;
            this.ckbLogado.UseWaitCursor = true;
            // 
            // lblEsqueceu
            // 
            this.lblEsqueceu.AutoSize = true;
            this.lblEsqueceu.Location = new System.Drawing.Point(327, 324);
            this.lblEsqueceu.Name = "lblEsqueceu";
            this.lblEsqueceu.Size = new System.Drawing.Size(89, 13);
            this.lblEsqueceu.TabIndex = 3;
            this.lblEsqueceu.TabStop = true;
            this.lblEsqueceu.Text = "Esqueceu Senha";
            this.lblEsqueceu.UseWaitCursor = true;
            this.lblEsqueceu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueceu_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(384, 389);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.UseWaitCursor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOla.Location = new System.Drawing.Point(426, 100);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(46, 33);
            this.lblOla.TabIndex = 5;
            this.lblOla.Text = "Olá";
            this.lblOla.UseWaitCursor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArtigosIvan.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(410, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOla);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblEsqueceu);
            this.Controls.Add(this.ckbLogado);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbLogado;
        private System.Windows.Forms.LinkLabel lblEsqueceu;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtLogin;
    }
}