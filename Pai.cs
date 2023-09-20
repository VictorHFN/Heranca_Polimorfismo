using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemproHeranca
{
    internal class Pai
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }

        public virtual double participacaoLucro()
        {
            return 1200 * 0.01;
        }

    }
}
// Polimorfismo