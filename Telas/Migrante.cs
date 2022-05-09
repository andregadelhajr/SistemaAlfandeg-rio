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
    public partial class Migrante : Form
    {
        public static List<Funcionario> funcionario = Funcionario.InitializeFuncionario();
        public static List<Migrantes> migrantes = Migrantes.InitializeMigrantes();

        public Migrante()
        {
            InitializeComponent();
        }

        private void Migrante_Load(object sender, EventArgs e)
        {
            foreach (Funcionario func in funcionario)
            {
                cbbListFunc.Items.Add(func);
            }


        }

        public static bool ValidaCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
            {
                return false;
            }

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
            {
                if (valor[i] != valor[0])

                    igual = false;
            }

            if (igual || valor == "12345678909")
            {
                return false;
            }

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
            {
                numeros[i] = int.Parse(

                valor[i].ToString());
            }

            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += (10 - i) * numeros[i];
            }

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                {
                    return false;
                }
            }
            else if (numeros[9] != 11 - resultado)
            {
                return false;
            }

            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += (11 - i) * numeros[i];
            }

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                {
                    return false;
                }
            }
            else if (numeros[10] != 11 - resultado)
            {
                return false;
            }

            return true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstMigrantes.Items.Clear();
            foreach (Migrantes migrante in migrantes)
            {
                lstMigrantes.Items.Add(migrante);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            
            if (ValidaCPF(cpf) == true)
            {
                migrantes.Add(new Migrantes(codigo, nome, cpf));
            }
            else
            {
                MessageBox.Show("CPF Inválido");
            }

            /*foreach (Migrantes migrante in migrantes)
            {
                if (migrante.Nome == nome)
                {
                    migrante.Add(new Migrantes(codigo, nome, cpf));
                    MessageBox.Show("AVISO");
                }
            }*/
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            foreach (Migrantes migrante in migrantes)
            {
                if(migrante.Codigo == codigo)
                {
                    //migrantes.Remove(codigo);
                }
                else
                {
                    MessageBox.Show("Erro");
                }
                //migrante.Nome.Remove(codigo);
            }
        }
    }
}
