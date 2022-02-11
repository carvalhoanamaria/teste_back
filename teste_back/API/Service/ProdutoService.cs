using System;
using System.Net.Http;
using System.Threading.Tasks;
using API.Service.Base;

namespace API.Service
{
    public class ProdutoService : HttpClientBase
    {
        public ProdutoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Produto> BuscarProdutoPorId(int produtoId)
        {
           var produto = await Get<Produto>(Environment.GetEnvironmentVariable("URI_SERVICE_PRODUTO")+ "/"+produtoId);
           return produto;    
        }

        public async Task AlterarProduto(Guid produtoId)
        {
            await Task.Run(() =>
            {
                new NotImplementedException();
            });
        }

        public async Task BuscarTodos()
        {
            await Task.Run(() =>
            {
                new NotImplementedException();
            });
        }

        public async Task<Produto> DeletarProduto(int produtoId)
        {
             var produto = await Delete<Produto>(Environment.GetEnvironmentVariable("URI_SERVICE_PRODUTO") + "/" + produtoId, );
           return produto;
        }
    }
}
