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
    public partial class Cadastrar : Form
    {
        public bool logado = false;
        private Conexao conn;
        private MySqlConnection ConnectOpen;
        public Cadastrar()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDataBase();

            if (Login.perfilUsuario == 3)
            {
                
                lblPerfil.Visible = true;
                cmbPerfil.Visible = true;

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            StringBuilder mysql = new StringBuilder();
            mysql.Append("INSERT INTO `usuarios`(`usuario`, `senha`, `perfil`)");
            mysql.Append("values (@usuario, @senha, @perfil)");
            MySqlCommand command = null;

            int perfilSeleted = 0;
            switch (cmbPerfil.Text)
            {
                case "Autores":
                    perfilSeleted = 1;
                    break;
                case "Revisores":
                    perfilSeleted = 2;
                    break;
                case "Gerente":
                    perfilSeleted = 3;
                    break;
                default:
                    perfilSeleted = 1;
                    break;
            }

            try
            {
                command = new MySqlCommand(mysql.ToString(), ConnectOpen);
                command.Parameters.Add(new MySqlParameter("@usuario", txtUsuario.Text));
                command.Parameters.Add(new MySqlParameter("@senha", txtSenha.Text));
                command.Parameters.Add(new MySqlParameter("@perfil", perfilSeleted));
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
            txtSenha.Clear();
            txtUsuario.Clear();
            cmbPerfil.Text = "Selecione";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }
    }
}
