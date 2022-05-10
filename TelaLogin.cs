using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvaTecnica2_WF.Class;

namespace ProvaTecnica2_WF
{
    public partial class TelaLogin : Form
    {
        public static List<Funcionario> funcionario = Funcionario.InitializeFuncionario();

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuarioAdm = txtUsuario.Text;
            string senhaAdm = txtSenha.Text;
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            Form1 form1 = new Form1();
            TelaLogin telaLogin = new TelaLogin();

            foreach (Funcionario funcionarios in funcionario)
            {
                if (usuarioAdm == "Admin" && senhaAdm == "1234")
                {
                    form1.btnMigrante.Enabled = true;
                    form1.btnFuncionario.Enabled = true;
                    //telaLogin.Close();
                    form1.Show();
                }
                else if (usuario == funcionarios.Nome && senha == funcionarios.Senha)
                {
                    form1.btnMigrante.Enabled = true;
                    form1.btnFuncionario.Enabled = false;
                    //this.Close();
                    form1.ShowDialog();
                }
                telaLogin.Close();
            }
        }
    }
}
