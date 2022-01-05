using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Safra.APIShares.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperacoesController :ControllerBase
    {        
        private readonly ILogger<Operacoes> _logger;

        public OperacoesController(ILogger<Operacoes> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Operacoes> Get()
        {   
            return Enumerable.Range(1, 5).Select(index => new Operacoes
            {
                idAcao =  1,
                DataOperacao = DateTime.Now.AddDays(index),
                CustoOperacao = 23,
                QuantidadePorOperacao = 5,
                RazaoSocial = "Refrescos Guararapes S.A",
                ValoDaAcao = 15,
                RetornoCotacao = 0,
                TipoOperacao = "C"
            })
            .ToArray();
        }

    }
}
