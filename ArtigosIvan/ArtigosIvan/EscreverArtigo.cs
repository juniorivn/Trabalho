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
    public partial class EscreverArtigo : Form
    {
        public bool logado = false;
        private Conexao conn;
        private MySqlConnection ConnectOpen;
        public EscreverArtigo()
        {
            InitializeComponent();
            conn = new Conexao();
            ConnectOpen = conn.ConnectToDataBase();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = Login.Usuario;


            StringBuilder mysql = new StringBuilder();
            mysql.Append("INSERT INTO `artigos`(`autor`, `titulo`, `conteudo`, `categoria`, `data`, `status`)");
            mysql.Append("values (@autor, @titulo, @conteudo, @categoria, @data, @status)");
            MySqlCommand command = null;

            try
            {
                command = new MySqlCommand(mysql.ToString(), ConnectOpen);
                command.Parameters.Add(new MySqlParameter("@autor", nome));
                command.Parameters.Add(new MySqlParameter("@titulo", txtTitulo.Text));
                command.Parameters.Add(new MySqlParameter("@conteudo", txtConteudo.Text));
                command.Parameters.Add(new MySqlParameter("@categoria", cmbCategoria.Text));
                command.Parameters.Add(new MySqlParameter("@data", date.Value.Date));
                command.Parameters.Add(new MySqlParameter("@status", txtStatus.Text));

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar" + ex);
                throw;
            }
            txtConteudo.Clear();
            txtTitulo.Clear();
            
        }
    }
}
