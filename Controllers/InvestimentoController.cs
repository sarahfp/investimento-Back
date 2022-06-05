using investimento_back.Model;
using investimento_back.Service;
using Microsoft.AspNetCore.Mvc;

namespace investimento_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestimentoController : ControllerBase
    {

        private readonly IInvestimentoService _investimentoService;

        public InvestimentoController(IInvestimentoService investimentoService)
        {
            _investimentoService = investimentoService;
        }

        [HttpGet(Name = "GetInvestimentos")]
        public List<Investimento> Get()
        {
            return _investimentoService.GetInvestimentos();
        }
    }
}
