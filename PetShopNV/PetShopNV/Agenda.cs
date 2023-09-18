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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void nmcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmtelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmcliente_TextChanged(object sender, EventArgs e)
        {

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
            Logado Logado = new Logado();
            Logado.Show();
            this.Close();
        }

        private void btt_loca_Click(object sender, EventArgs e)
        {
            {
              string cpf = nmcliente.Text;
              string conexao = "datasource=127.0.0.1;port=3306;username=root;password=root;database=db_petshop";
            
                using (MySqlConnection connection = new MySqlConnection(conexao))
                {
                    connection.Open();
                    string sql = @"SELECT p.nm_pet, t.nm_cliente FROM TB_CLIENTE t LEFT JOIN TB_PET p ON t.cd_cliente = p.cd_cliente WHERE t.cd_cpf = @cpf";

                     using (MySqlCommand command = new MySqlCommand(sql, connection))
                     {
                        command.Parameters.AddWithValue("@cpf", cpf);

                         using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    cbboxpet.Items.Clear();

                                    while (reader.Read())
                                    {
                                        string nmpeet = reader["nm_pet"].ToString();
                                        string cliente = reader["nm_cliente"].ToString();
                                        txt_nmusu.Text = cliente;
                                        cbboxpet.Items.Add(nmpeet);
                                    }
                                    cbboxpet.SelectedIndex = 0;
                                }
                                else
                                {
                                    MessageBox.Show("Pet não encontrado");
                                }
                         }
                     }
                }
            }
        }

        private void cbboxpet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }

        private void btt_agendar_Click(object sender, EventArgs e)
        {
            if (cbboxpet.SelectedItem != null && cbboxmes.SelectedItem != null &&
                cbboxdia.SelectedItem != null && ccbboxhora.SelectedItem != null &&
                cbboxserviço.SelectedItem != null && !string.IsNullOrEmpty(nmvalor.Text))
            {
                string petSelecionado = cbboxpet.SelectedItem.ToString();

                int dia, mes;
                if (int.TryParse(cbboxdia.SelectedItem.ToString(), out dia) &&
                    int.TryParse(cbboxmes.SelectedItem.ToString(), out mes))
                {
                    int hora = Convert.ToInt32(ccbboxhora.SelectedItem);
                    int minuto = Convert.ToInt32(ccbboxhora.SelectedItem);

                    string tipoServico = cbboxserviço.SelectedItem.ToString();
                    string valorServico = nmvalor.Text;

                    string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password = root; database = db_petshop";
                    using (MySqlConnection conexao = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conexao.Open();
                            string cpf = nmcliente.Text;
                            string sql = "SELECT cd_cliente FROM TB_CLIENTE WHERE cd_cpf = @cpf";
                            using (MySqlCommand commandTutor = new MySqlCommand(sql, conexao))
                            {
                                commandTutor.Parameters.AddWithValue("@cpf", cpf);
                                object cddcliente = commandTutor.ExecuteScalar();

                                if (cddcliente != null)
                                {
                                    int cdcliente = Convert.ToInt32(cddcliente);

                                    string ssql = "SELECT cd_pet FROM TB_PET WHERE nm_pet = @pet AND cd_cliente = @cliente";
                                    using (MySqlCommand commandPet = new MySqlCommand(ssql, conexao))
                                    {
                                        commandPet.Parameters.AddWithValue("@pet", petSelecionado);
                                        commandPet.Parameters.AddWithValue("@cliente", cdcliente);
                                        object cdpet = commandPet.ExecuteScalar();

                                        if (cdpet != null)
                                        {
                                            int cddpet = Convert.ToInt32(cdpet);

                                            string sqlAgendamento = "SELECT cd_servico FROM TB_SERVICO WHERE dt_servico = @dataServico";

                                            using (MySqlCommand cmdAgendamento = new MySqlCommand(sqlAgendamento, conexao))
                                            {
                                                DateTime dataServico = new DateTime(DateTime.Now.Year, mes, dia, hora, minuto, 0);
                                                cmdAgendamento.Parameters.AddWithValue("@dataServico", dataServico);
                                                object existingAgendamentoId = cmdAgendamento.ExecuteScalar();

                                                if (existingAgendamentoId == null)
                                                {
                                                    string agenda = "INSERT INTO TB_SERVICO (dt_servico, tp_servico, vl_servico, cd_cliente, cd_pet) " +
                                                        "VALUES (@dtServico, @tpServico, @vlServico, @cdCliente, @cdPet)";
                                                    using (MySqlCommand connection = new MySqlCommand(agenda, conexao))
                                                    {
                                                        connection.Parameters.AddWithValue("@dtServico", dataServico);
                                                        connection.Parameters.AddWithValue("@tpServico", tipoServico);
                                                        connection.Parameters.AddWithValue("@vlServico", valorServico);
                                                        connection.Parameters.AddWithValue("@cdCliente", cdcliente);
                                                        connection.Parameters.AddWithValue("@cdPet", cdpet);

                                                        connection.ExecuteNonQuery();

                                                        MessageBox.Show("Pet agendado com sucesso!!");
                                                        cbboxpet.SelectedIndex = -1;
                                                        cbboxdia.SelectedIndex = -1;
                                                        cbboxmes.SelectedIndex = -1;
                                                        ccbboxhora.SelectedIndex = -1;
                                                        cbboxserviço.SelectedIndex = -1;
                                                        nmvalor.Text = "";
                                                        nmcliente.Text = "";
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Este horario ja foi agendado");
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Não foi possível encontrar o codigo do cliente.");
                                }
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao agendar o serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private DataTable ObterDadosServico()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=db_petshop";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string sql = "SELECT TB_PET.nm_pet AS Pet, TB_CLIENTE.nm_cliente AS Cliente, vl_servico as 'Valor', tp_servico as 'Serviço', dt_servico as 'Data'" +
                             "FROM TB_SERVICO " +
                             "JOIN TB_CLIENTE ON TB_SERVICO.cd_cliente = TB_CLIENTE.cd_cliente " +
                             "JOIN TB_PET ON TB_SERVICO.cd_pet = TB_PET.cd_pet " +
                             "ORDER BY dt_servico ASC";

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        private void btt_carregar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ObterDadosServico();
            DataGrid.DataSource = dataTable;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

