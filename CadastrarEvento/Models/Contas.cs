using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarEvento.Models
{
    public class Contas
    {
        public string Local {  get; set; }
        public string Nome { get; set; }
        public int Conv { get; set; }
        public DateTime DpckI { get; set; }
        public DateTime DpckF { get; set; }
        public int Duracao
        {
            get => DpckF.Subtract(DpckI).Days;
        }

        public double Valor
        {
            get
            {
                double total = Conv * 50;
                return total;
            }
        }
    }

}
