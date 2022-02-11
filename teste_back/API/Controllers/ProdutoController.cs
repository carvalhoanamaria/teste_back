using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly ProdutoService _produtoService;

        public ProdutoController(ILogger<ProdutoController> logger, ProdutoService produtoService )
        {
            _logger = logger;
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarProduto([FromQuery] int produtoId)
        {
            return Ok(await _produtoService.BuscarProdutoPorId(produtoId));
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarProduto([FromQuery] int produtoId)
        {
            return Ok(await _produtoService.DeletarProduto(produtoId));
        }

    }
}
