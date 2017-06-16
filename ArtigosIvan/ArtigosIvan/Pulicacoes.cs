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
using System.Runtime.InteropServices;

namespace ArtigosIvan
{
    public partial class Pulicacoes : Form
    {
        private Conexao conn;
        private MySqlConnection ConnectOpen;
        public Pulicacoes()
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
            string status = "Publicado";
            string sqlCommand = "Select  titulo , conteudo , categoria , data , autor from artigos where status = '" + status + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, ConnectOpen);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void Pulicacoes_Load(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtConteudo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
