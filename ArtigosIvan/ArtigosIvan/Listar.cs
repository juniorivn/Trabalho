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
    public partial class Listar : Form
    {
        public string UsuarioSelecionado = "";
        private Conexao conn;
        private MySqlConnection ConnectOpen;
        public Listar()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDataBase();
            popularLista();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
           

        }

        public void popularLista()
        {
            //Pegar conexão da tela de login
            var conn = Login.ConnectOpen;
            string sqlCommand = "Select * from usuarios";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Selecione um USUÁRIO");
            }
            else
            {
                StringBuilder mysql = new StringBuilder();
                mysql.Append(" update usuarios set ");
                mysql.Append(" senha = @senha, ");
                mysql.Append(" perfil = @perfil ");
                mysql.Append(" where usuario = @usuario");

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
                    command.Parameters.Add(new MySqlParameter("@senha", txtSenha.Text));
                    command.Parameters.Add(new MySqlParameter("@perfil", perfilSeleted));
                    command.Parameters.Add(new MySqlParameter("@usuario", txtUsuario.Text));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Atualizado com sucesso");
                    popularLista();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar" + ex);
                    throw;
                }

               
            }
            txtPesquisar.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
            cmbPerfil.Text = "Selecione";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSenha.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String perfilSeleted = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (perfilSeleted == "1")
            {
                cmbPerfil.Text = "Autores";
            }
            else if (perfilSeleted == "2")
            {
                cmbPerfil.Text = "Revisores";
            }
            else
            {
                cmbPerfil.Text = "Gerente";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            var conn = Login.ConnectOpen;
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Selecione um USUÁRIO");
            }
            else
            {

                DialogResult result = MessageBox.Show("Deseja REALMENTE excluir?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK))
                return;
            string mysql = "Delete from usuarios where usuario = @usuario";
            MySqlCommand command = null;
            command = new MySqlCommand(mysql.ToString(), ConnectOpen);
            command.Parameters.Add(new MySqlParameter("@usuario", txtUsuario.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Excluido com sucesso");
            
        }
            popularLista();
            txtPesquisar.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
            cmbPerfil.Text = "Selecione";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var conn = Login.ConnectOpen;
            if (cmbPes.Text == "Usuario")
            {
                string sqlCommand = "Select * from usuarios where usuario = '" + txtPesquisar.Text + "'";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   dataGridView1.DataSource = dt;
                }
            }
            else if (cmbPes.Text == "Perfil")
            {
                int perfilSeleted = Convert.ToInt32(txtPesquisar.Text);

                string sqlCommand = "Select * from usuarios where perfil = '" + perfilSeleted + "'";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }

        }
    }
}
