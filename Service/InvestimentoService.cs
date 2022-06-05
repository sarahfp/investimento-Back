using investimento_back.Model;

namespace investimento_back.Service
{
    public class InvestimentoService : IInvestimentoService
    {
        public List<Investimento> GetInvestimentos()
        {
            List<Investimento> investimentos = new()
            {
                new Investimento(1, "CDB", "Renda Fixa", 15000),
                new Investimento(2, "LCI", "Renda Fixa", 1234)
            };
            return investimentos;
        }
    }
}
