using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemproHeranca
{
    internal class FuncionarioN2 : Pai
    {
      
        public int Idade { get; set; }

        public override double participacaoLucro()
        {
            return 1200 * 0.05;
        }
    }
}
