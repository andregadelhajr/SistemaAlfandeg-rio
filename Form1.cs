using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvaTecnica2_WF.Telas;

namespace ProvaTecnica2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMigrante_Click(object sender, EventArgs e)
        {
            Telas.Migrante migrante = new Telas.Migrante();
            migrante.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Quer realmente sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios funcionario = new Telas.Funcionarios();
            funcionario.Show();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            Telas.Dado dados = new Telas.Dado();
            dados.Show();
        }
    }
}
