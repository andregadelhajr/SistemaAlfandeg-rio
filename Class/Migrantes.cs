using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnica2_WF.Class
{
    public class Migrantes
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Motivo { get; set; }
        public string CPF { get; set; }
        public DateTime Data { get; set; }
        public int CodFuncionario { get; set; }

        public Migrantes(int codigo, string nome, string cpf)
        {
            Codigo = codigo;
            Nome = nome;
            CPF = cpf;
            //Nacionalidade = nacionalidade;
            //Passaporte = passaporte;
        }

        public Migrantes(int codigo)
        {
            Codigo = codigo;
        }

        public static List<Migrantes> InitializeMigrantes()
        {
            List<Migrantes> migrantes = new List<Migrantes>();

            migrantes.Add(new Migrantes(0, "Andre", "11111111111"));
            migrantes.Add(new Migrantes(1, "Renata", "22222222222"));
            migrantes.Add(new Migrantes(2, "Rafael", "33333333333"));
            return migrantes;
        }

        public override string ToString()
        {
            return "Código" + Codigo + " - Nome " + Nome.ToString();
        }

    }
}
