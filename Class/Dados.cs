using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnica2_WF.Class
{
    public class Dados
    {
        public int Trabalho { get; set; }
        public int Estudo { get; set; }
        public int Turismo { get; set; }
        public int Moradia { get; set; }
        public int Assuntos_Diplomaticos { get; set; }
        public double Populacao_Relativa { get; set; }

        public Dados(int trabalho, int estudo, int turismo, int moradia, int assuntos_Diplomaticos, double populacao_Relativa)
        {
            Trabalho = trabalho;
            Estudo = estudo;
            Turismo = turismo;
            Moradia = moradia;
            Assuntos_Diplomaticos = assuntos_Diplomaticos;
            Populacao_Relativa = populacao_Relativa;
        }

        /*public static List<Motoristas> InitializeMotoristas()
        {
            List<Motoristas> motoristas = new List<Motoristas>();

            motoristas.Add(new Motoristas("André", 0, 0));
            motoristas.Add(new Motoristas("João", 0, 0));
            motoristas.Add(new Motoristas("Rafael", 0, 0));
            motoristas.Add(new Motoristas("Arthur", 0, 0));
            return motoristas;
        }*/

        public override string ToString()
        {
            return Populacao_Relativa.ToString();
        }
    }
}
