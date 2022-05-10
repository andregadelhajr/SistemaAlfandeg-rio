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

namespace ProvaTecnica2_WF.Telas
{
    public partial class Funcionarios : Form
    {
        public static List<Funcionario> funcionarios = Funcionario.InitializeFuncionario();

        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Funcionario func in funcionarios)
            {
                listBox1.Items.Add(func);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            string senha = txtSenha.Text;

            funcionarios.Add(new Funcionario(codigo, nome, senha));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;

            funcionarios.Remove(funcionarios.Find(x => x.Codigo == codigo));

            /*foreach (Funcionario func in funcionarios)
            {
                func.Remove(codigo);
            }*/
        }
    }
}
