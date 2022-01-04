using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carter;
using Safra.Infra.Data;
using Microsoft.AspNetCore.Http;
using Carter.Response;

namespace Safra.APIShares.Modules
{
    public class OperacoesModule : CarterModule
    {
        public readonly EfRepositoryOP efRepository;

        public OperacoesModule()
        {
            efRepository = new EfRepositoryOP();
        }
    }
}