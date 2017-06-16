using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace ArtigosIvan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            

        }

        public string Nome { get; set; }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            var frmLogin = new Login();
           // frmLogin.MdiParent = this;
            frmLogin.ShowDialog();



            var cs = new Cadastrar();

            

            if (Login.perfilUsuario == 3)
            {
                opcAutoresToolStripMenuItem.Visible = true;
                opcRevvisoresToolStripMenuItem.Visible = true;
                opsADMToolStripMenuItem.Visible = true;
       
            }
            else if (Login.perfilUsuario == 1)
            {
                opcAutoresToolStripMenuItem.Visible = true;
            }
            else if (Login.perfilUsuario == 2)
            {
                opcAutoresToolStripMenuItem.Visible = true;
                opcRevvisoresToolStripMenuItem.Visible = true;
            }


        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastrar = new Cadastrar();
            cadastrar.MdiParent = this;
            cadastrar.Show();
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listar = new Listar();
            listar.MdiParent = this;
            listar.Show();
            this.listarToolStripMenuItem1.Text = "Listar";
        }

        private void publicarArtigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var publicar = new EscreverArtigo();
            publicar.MdiParent = this;
            publicar.Show();
            this.publicarArtigosToolStripMenuItem.Text = "Publicar Artigo";
        }

        private void artigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var revisar = new Publicar_Artigo();
            revisar.MdiParent = this;
            revisar.Show();
            this.artigosToolStripMenuItem.Text = "Revisar";
        }

        private void verArtigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var revisar = new Ver_Artigos();
            revisar.MdiParent = this;
            revisar.Show();
            this.verArtigosToolStripMenuItem.Text = "Ver Artigos";
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verPublicaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var publicacoes = new Pulicacoes();
            publicacoes.MdiParent = this;
            publicacoes.Show();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"C:\Users\Ivan-Lari\Downloads\Trabalho\Manual.docx");
        }
    }
}
