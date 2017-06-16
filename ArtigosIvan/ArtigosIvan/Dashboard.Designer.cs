namespace ArtigosIvan
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPublicaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicarArtigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verArtigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcRevvisoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opsADMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.opcAutoresToolStripMenuItem,
            this.opcRevvisoresToolStripMenuItem,
            this.opsADMToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.verPublicaçõesToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // verPublicaçõesToolStripMenuItem
            // 
            this.verPublicaçõesToolStripMenuItem.Name = "verPublicaçõesToolStripMenuItem";
            this.verPublicaçõesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.verPublicaçõesToolStripMenuItem.Text = "Ver Publicações";
            this.verPublicaçõesToolStripMenuItem.Click += new System.EventHandler(this.verPublicaçõesToolStripMenuItem_Click);
            // 
            // opcAutoresToolStripMenuItem
            // 
            this.opcAutoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicarArtigosToolStripMenuItem,
            this.verArtigosToolStripMenuItem});
            this.opcAutoresToolStripMenuItem.Name = "opcAutoresToolStripMenuItem";
            this.opcAutoresToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.opcAutoresToolStripMenuItem.Text = "Opções Autores";
            this.opcAutoresToolStripMenuItem.Visible = false;
            // 
            // publicarArtigosToolStripMenuItem
            // 
            this.publicarArtigosToolStripMenuItem.Name = "publicarArtigosToolStripMenuItem";
            this.publicarArtigosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.publicarArtigosToolStripMenuItem.Text = "Publicar Artigos";
            this.publicarArtigosToolStripMenuItem.Click += new System.EventHandler(this.publicarArtigosToolStripMenuItem_Click);
            // 
            // verArtigosToolStripMenuItem
            // 
            this.verArtigosToolStripMenuItem.Name = "verArtigosToolStripMenuItem";
            this.verArtigosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.verArtigosToolStripMenuItem.Text = "Ver Artigos";
            this.verArtigosToolStripMenuItem.Click += new System.EventHandler(this.verArtigosToolStripMenuItem_Click);
            // 
            // opcRevvisoresToolStripMenuItem
            // 
            this.opcRevvisoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artigosToolStripMenuItem});
            this.opcRevvisoresToolStripMenuItem.Name = "opcRevvisoresToolStripMenuItem";
            this.opcRevvisoresToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.opcRevvisoresToolStripMenuItem.Text = "Opções Revisores";
            this.opcRevvisoresToolStripMenuItem.Visible = false;
            // 
            // artigosToolStripMenuItem
            // 
            this.artigosToolStripMenuItem.Name = "artigosToolStripMenuItem";
            this.artigosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.artigosToolStripMenuItem.Text = "Revisar Artigos";
            this.artigosToolStripMenuItem.Click += new System.EventHandler(this.artigosToolStripMenuItem_Click);
            // 
            // opsADMToolStripMenuItem
            // 
            this.opsADMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1});
            this.opsADMToolStripMenuItem.Name = "opsADMToolStripMenuItem";
            this.opsADMToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.opsADMToolStripMenuItem.Text = "Opções ADM";
            this.opsADMToolStripMenuItem.Visible = false;
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.listarToolStripMenuItem1.Text = "Usuários";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArtigosIvan.Properties.Resources.uninove_logo__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opsADMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcRevvisoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicarArtigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verArtigosToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPublicaçõesToolStripMenuItem;
    }
}

