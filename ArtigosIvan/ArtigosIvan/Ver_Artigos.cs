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
    public partial class Ver_Artigos : Form
    {
       
        private Conexao conn;
        private MySqlConnection ConnectOpen;
      
        public Ver_Artigos()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDataBase();
            popularLista();

        }

        public void popularLista()
        {
            //Pegar conexão da tela de login
            //Pegar conexão da tela de login
            var nome = Login.Usuario;
            var conn = Login.ConnectOpen;
            string sqlCommand = "Select * from artigos where autor = '"+ nome +"'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
              var nome = Login.Usuario;
              var conn = Login.ConnectOpen;
             
               if (comboBox1.Text == "Categoria")
              {
                  string sqlCommand = "Select * from artigos where autor  = '" + nome + "' and categoria = '" + txtPesquisar.Text + "'";
                  DataTable dt = new DataTable();
                  MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
                  da.Fill(dt);
                  if (dt.Rows.Count > 0)
                  {
                      dataGridView1.DataSource = dt;
                  }
              }
            txtPesquisar.Text = "Pesquisar artigos";
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFeed.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtConteudo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void txtFeed_Click(object sender, EventArgs e)
        {
            txtFeed.Clear();
        }
    }
}
