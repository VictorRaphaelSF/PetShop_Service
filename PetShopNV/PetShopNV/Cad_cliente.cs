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
    public partial class Cad_cliente : Form
    {
        public Cad_cliente()
        {
            InitializeComponent();
        }

        private void btt_sair_Click(object sender, EventArgs e)
        {
            Logado Logado = new Logado();
            Logado.Show();
            this.Close();
        }

        private void btt_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "CãoAmigo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                Application.Exit();
        }

        private void btt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btt_login_Click(object sender, EventArgs e)
        {
                MySqlConnection conexao = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=db_petshop");

                string sql = "INSERT INTO TB_CLIENTE (nm_cliente, cd_cpf, cd_telefone) VALUES ('" + nmcliente.Text + "', '" + nmcpf.Text + "', '" + nmtelefone.Text + "') ";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();


                comando.ExecuteReader();


                MessageBox.Show("Cadastro sucedido!");

                Cad_pet cadpet = new Cad_pet();
                cadpet.Show();
                this.Close();

            {
                conexao.Close();
            }
                
        }

        private void btt_localizar_Click(object sender, EventArgs e)
        {
            Localizar location = new Localizar();
            location.Show();
            this.Close();
        }

        private void nmcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btt_localizar_Click_1(object sender, EventArgs e)
        {
            Localizar location = new Localizar();
            location.Show();
            this.Close();
        }

        private void Cad_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
