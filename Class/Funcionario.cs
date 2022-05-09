using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnica2_WF.Class
{
    public class Funcionario
    { 
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Funcionario(int codigo, string nome, string senha)
        {
            Codigo = codigo;
            Nome = nome;
            Senha = senha;
        }

        public Funcionario(int codigo)
        {
            Codigo = codigo;
        }

        public Funcionario()
        {

        }

        public static List<Funcionario> InitializeFuncionario()
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            funcionario.Add(new Funcionario(0, "Max", "1234"));
            funcionario.Add(new Funcionario(01, "Andre", "1234"));
            funcionario.Add(new Funcionario(02, "Renata", "1234"));
            return funcionario;
        }

        public override string ToString()
        {
            return "Código: " + Codigo + " - Nome:" + Nome.ToString();
        }

        internal void Remove(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
