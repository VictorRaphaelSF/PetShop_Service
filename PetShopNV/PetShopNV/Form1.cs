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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btt_login_Click(object sender, EventArgs e)
        {
            string login = usuariotext.Text;

            if (usuariotext.Text == "admin" && senhatext.Text == "admin")
            {

                {
                    Logado TelaPrincipal = new Logado();
                    TelaPrincipal.Show();
                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("Login ou senha invalidos!", "CãoAmigo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void usuariotext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
