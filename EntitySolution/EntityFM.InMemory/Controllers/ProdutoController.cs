using EntityFM.Modelos;
using EntityFM.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EntityFM.InMemory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutoController(IProdutoServico produtoServico)
        {
            this._produtoServico = produtoServico;
        }

        [HttpGet]
        [Route("{codigoBarras}")]
        public async Task<IActionResult> Get(string codigoBarras)
        {
            var produto = await this._produtoServico.Obter(codigoBarras);

            if (produto == null)
                return NoContent();

            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Produto produto)
        {
            await this._produtoServico.Cadastrar(produto);

            return Ok();

        }        
    }
}
