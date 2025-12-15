using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Core
{
    public class CalculadoraAvancada
    {
        private readonly IConfiguracaoRepository _configuracaoRepository;

        public CalculadoraAvancada(IConfiguracaoRepository configuracaoRepository)
        {
            _configuracaoRepository = configuracaoRepository;
        }

        public decimal AplicarTaxa(decimal valor)
        {
            
            int taxa = _configuracaoRepository.ObterTaxaPadrao();

            
            return valor * (1 + (decimal)taxa / 100);
        }
    }
}
