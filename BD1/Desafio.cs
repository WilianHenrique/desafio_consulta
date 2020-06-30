using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BD1
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MySqlConnectionStringBuilder string_conexao = new MySqlConnectionStringBuilder();
            string_conexao.Server =   textBoxSERVIDOR.Text ;
            string_conexao.UserID =  textBoxUSUARIO.Text;
            string_conexao.Password = textBoxSENHA.Text;
            string_conexao.Database = textBoxBANCO.Text;

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = string_conexao.ConnectionString;

            try
            {
                conexao.Open();
                MessageBox.Show("Conectado!");
                try
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandText = textBoxSQL.Text;
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Erro ao criar tabela!");
                }
            }

            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao conectar!");
            }



            finally
            {
                conexao.Close();
            }
        }

        
    }
}
