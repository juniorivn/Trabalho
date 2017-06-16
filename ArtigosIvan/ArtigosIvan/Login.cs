using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ArtigosIvan
{
    public partial class Login : Form
    {
        public bool logado = false;
        private Conexao conn;
        public static MySqlConnection ConnectOpen;
        //converter para static
        public static int perfilUsuario;

        public static string Usuario { get; set; }

        public Login()
        {
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDataBase();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strComand = "Select * from usuarios where usuario = '" + txtLogin.Text + "' and senha = '" + txtSenha.Text + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(strComand,ConnectOpen);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                logado = true;
                perfilUsuario = Convert.ToInt16(dt.Rows[0][2]);
                Usuario = txtLogin.Text;



            }
            else
                MessageBox.Show("Usuario Incorreto");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }

        private void lblEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
