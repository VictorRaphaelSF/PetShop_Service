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
using MySql;

namespace PetShopNV
{
    public partial class Localizar : Form
    {
        public Localizar()
        {
            InitializeComponent();

            tableloca.View = View.Details;
            tableloca.LabelEdit = true;
            tableloca.AllowColumnReorder = true;
            tableloca.FullRowSelect = true;
            tableloca.GridLines = true;

            tableloca.Columns.Add("ID", 40, HorizontalAlignment.Left);
            tableloca.Columns.Add("Nome", 130, HorizontalAlignment.Left);
            tableloca.Columns.Add("CPF", 110, HorizontalAlignment.Left);
            tableloca.Columns.Add("Telefone(Cel)", 110, HorizontalAlignment.Left);
        }

        private void btt_sair_Click(object sender, EventArgs e)
        {
            Cad_cliente cadcli = new Cad_cliente();
            cadcli.Show();
            this.Close();
        }

        private void btt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btt_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "CãoAmigo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                Application.Exit();
        }

        private void pesquisartext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            string search = "'%" + pesquisartext.Text + "%'";


            MySqlConnection conexao = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=db_petshop");

            string sql = "SELECT * FROM TB_CLIENTE WHERE nm_cliente LIKE " + search + "OR cd_cpf LIKE" + search + "OR cd_telefone LIKE" + search;

            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            MySqlDataReader reader = comando.ExecuteReader();

            tableloca.Items.Clear();

            while (reader.Read())
            {
                string[] row =
                {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                var linha_listview = new ListViewItem(row);

                tableloca.Items.Add(linha_listview);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Localizar_Load(object sender, EventArgs e)
        {

        }
    }
}
