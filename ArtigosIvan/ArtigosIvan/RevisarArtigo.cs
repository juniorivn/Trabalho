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
    public partial class Publicar_Artigo : Form
    {
        //public string UsuarioSelecionado = "";
        private Conexao conn;
        private MySqlConnection ConnectOpen;
        public Publicar_Artigo()

        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDataBase();
            popularLista();
            
        }

        public void popularLista()
        {
            //Pegar conexão da tela de login
            var conn = Login.ConnectOpen;
            string sqlCommand = "Select * from artigos";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void Publicar_Artigo_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Pegar conexão da tela de login
            var conn = Login.ConnectOpen;
            if (comboBox1.Text == "Autor")
            {
                string sqlCommand = "Select * from artigos where autor = '" + txtPesquisar.Text + "'";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            else if (comboBox1.Text == "Categoria")
            {
                string sqlCommand = "Select * from artigos where categoria = '" + txtPesquisar.Text + "'";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
          }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = Login.Usuario;
            string status = "Publicado";
            StringBuilder mysql = new StringBuilder();
            mysql.Append(" update artigos set ");
            mysql.Append(" feedback = @feedback, ");
            mysql.Append(" revisor = @revisor, ");
            mysql.Append(" conteudo = @conteudo, ");
            mysql.Append(" status = @status ");
            mysql.Append(" where id = @id ");

            MySqlCommand command = null;
            
            try
            {
                command = new MySqlCommand(mysql.ToString(), ConnectOpen);
                command.Parameters.Add(new MySqlParameter("@feedback", txtFeed.Text));
                command.Parameters.Add(new MySqlParameter("@revisor", nome));
                command.Parameters.Add(new MySqlParameter("@conteudo", txtConteudo.Text));
                command.Parameters.Add(new MySqlParameter("@status", status));
                command.Parameters.Add(new MySqlParameter("@id", Convert.ToInt32(txtId.Text)));
                command.ExecuteNonQuery();

                MessageBox.Show("Atualizado com sucesso");
                popularLista();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
            txtPesquisar.Text = "Pesquisar artigos";
            txtFeed.Text = "Escrever feedcak";
            txtConteudo.Text = "Conteudo";

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtConteudo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var nome = Login.Usuario;
            string status = "Cancelado";
            StringBuilder mysql = new StringBuilder();
            mysql.Append(" update artigos set ");
            mysql.Append(" feedback = @feedback, ");
            mysql.Append(" revisor = @revisor, ");
            mysql.Append(" conteudo = @conteudo, ");
            mysql.Append(" status = @status ");
            mysql.Append(" where id = @id ");

            MySqlCommand command = null;

            try
            {
                command = new MySqlCommand(mysql.ToString(), ConnectOpen);
                command.Parameters.Add(new MySqlParameter("@feedback", txtFeed.Text));
                command.Parameters.Add(new MySqlParameter("@revisor", nome));
                command.Parameters.Add(new MySqlParameter("@conteudo", txtConteudo.Text));
                command.Parameters.Add(new MySqlParameter("@status", status));
                command.Parameters.Add(new MySqlParameter("@id", Convert.ToInt32(txtId.Text)));
                command.ExecuteNonQuery();

                MessageBox.Show("Atualizado com sucesso");
                popularLista();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
            txtPesquisar.Text = "Pesquisar artigos";
            txtFeed.Text = "Escrever feedcak";
            txtConteudo.Text = "Conteudo"; 

        }

        private void txtFeed_Click(object sender, EventArgs e)
        {
            txtFeed.Clear();
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }
    }
}
