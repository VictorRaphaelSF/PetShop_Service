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
using MySql.Data;


namespace PetShopNV
{
    public partial class Cad_pet : Form
    {
        public Cad_pet()
        {
            InitializeComponent();
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

        private void btt_sair_Click(object sender, EventArgs e)
        {
            Logado cadcliente = new Logado();
            cadcliente.Show();
            this.Close();
        }

        private void btt_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cpftext.Text) && !string.IsNullOrEmpty(nmpet.Text) && !string.IsNullOrEmpty(nmraca.Text) && cpftext.Text.Length == 11)
            {
                MySqlConnection conexao = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=db_petshop");
                string cpf = cpftext.Text;
                string petName = nmpet.Text;
                string racaName = nmraca.Text;
                string sql = "SELECT cd_cpf FROM TB_CLIENTE WHERE cd_cpf = @cpf";

                MySqlCommand logar = new MySqlCommand(sql, conexao);
                logar.Parameters.AddWithValue("@cpf", cpf);
                conexao.Open();
                MySqlDataReader dataRead;
                dataRead = logar.ExecuteReader();
                bool hasRows = dataRead.HasRows;

                if (hasRows)
                {
                    conexao.Close();

                    conexao.Open();
                    MySqlCommand id = new MySqlCommand("SELECT cd_cliente, nm_cliente FROM TB_CLIENTE WHERE cd_cpf = @cpf", conexao);
                    id.Parameters.AddWithValue("@cpf", cpf);
                    MySqlDataReader dr;
                    dr = id.ExecuteReader();
                    bool hascdcliente = dr.Read();

                    if (hascdcliente)
                    {
                        int cdcliente = dr.GetInt32(0);
                        string nomecliente = dr["nm_cliente"].ToString();
                        conexao.Close();

                        conexao.Open();
                        MySqlCommand insert = new MySqlCommand("INSERT INTO TB_PET (nm_pet, pet_porte, cd_cliente) VALUES ('" + petName + "', '" + racaName + "', '" + cdcliente + "')", conexao);
                        insert.ExecuteNonQuery();

                        MessageBox.Show("O pet foi cadastrado com sucesso");
                        cpftext.Clear();
                        nmpet.Clear();
                        nmraca.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tutor inexistente!");
                    }
                }
                else
                {
                    MessageBox.Show("Tutor inexistente!");
                }

                conexao.Close();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
        }

        private void txtPullCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomePet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cad_pet_Load(object sender, EventArgs e)
        {

        }

        private void btt_localizar_Click(object sender, EventArgs e)
        {
            Localizar location = new Localizar();
            location.Show();
            this.Close();
        }
    }
 }
