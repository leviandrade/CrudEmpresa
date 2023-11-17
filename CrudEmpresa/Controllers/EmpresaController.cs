using CrudEmpresa.Dominio.Entidades;
using CrudEmpresa.Infra.Data.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace CrudEmpresa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<EmpresaController> _logger;

        public EmpresaController(ILogger<EmpresaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Empresa>> Listar()
        {
            var lst = await new EmpresaRepositorio().Listar();
            return lst;
        }
        [HttpPost]
        public async Task Incluir(Empresa empresa)
        {
            await new EmpresaRepositorio().Inserir(empresa);
        }

        [HttpPut]
        public async Task Atualizar(Empresa empresa)
        {
            await new EmpresaRepositorio().Atualizar(empresa);
        }

        [HttpGet("ObterTeste")]
        public async Task<List<Empresa>> ObterTeste()
        {
            return await new EmpresaRepositorio().Burcar(p => p.Id == 1);
        }
        [HttpGet("ObterPorId/{id}")]
        public async Task<Empresa> ObterPorId(int id)
        {
            return await new EmpresaRepositorio().ObterPorId(id);
        }
        [HttpGet("ListarComInclude")]
        public async Task<List<Empresa>> ListarComInclude()
        {
            return await new EmpresaRepositorio().ListarComInclude();
        }
    }
}