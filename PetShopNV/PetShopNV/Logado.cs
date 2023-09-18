using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopNV
{
    public partial class Logado : Form
    {
        public Logado()
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
            Form1 Login = new Form1();
            Login.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Cad_cliente Cadastro = new Cad_cliente();
            Cadastro.Show();
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void btt_agendamento_Click(object sender, EventArgs e)
        {
            Agenda agendamento = new Agenda();
            agendamento.Show();
            this.Close();
        }

        private void btt_pet_Click(object sender, EventArgs e)
        {
            Cad_pet cadpet = new Cad_pet();
            cadpet.Show();
            this.Close();
        }
    }
}
