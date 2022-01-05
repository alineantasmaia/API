using Carter;
using Safra.Infra.Data;
using Carter.ModelBinding;
using Carter.Request;
using Carter.Response;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Safra.APIShares.Modules
{
    public class OperacoesModule : CarterModule
    {
        public readonly EfRepositoryOP efRepository;
        
        public OperacoesModule()
        {
            Get("/operacao/", (req, res) =>
            {
                var operacoes = efRepository.GetAll();
                return res.WriteAsJsonAsync(operacoes);
            });

            Get("/operacao/{id:int}", (req, res) =>
            {
                var id = req.RouteValues.As<int>("id");
                var operacoes = efRepository.GetById(id);
                return res.Negotiate(operacoes);
            });

            Post("/operacao/", async (req, res) =>
            {
                var operacoes = await req.Bind<Operacoes>();

                //efRepository.Add(operacoes);                
                res.StatusCode = 201;
                await res.Negotiate(operacoes);
                return;
            });

            Put("/operacao/{id:int}", async (req, res) =>
            {
                var operacoes = await req.Bind<Operacoes>();

                //cliente.ClienteId = req.RouteValues.As<int>("id");
                //efRepository.Update(operacoes);                
                res.StatusCode = 204;
                return;
            });

            Delete("/operacao/{id:int}", (req, res) =>
            {
                var operacoes = req.Bind<Operacoes>();
                //operacoes.ClienteId = req.RouteValues.As<int>("id");
                //efRepository.Delete(operacoes);
                res.StatusCode = 204;
                return Task.CompletedTask;
            });

        }
    }
}