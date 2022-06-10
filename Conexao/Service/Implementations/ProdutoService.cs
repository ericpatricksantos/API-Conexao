using Conexao.Model;
using Conexao.Repository.Interfaces;
using Conexao.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Conexao.Service.Implementations
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
     
        public Task<List<Produto>> GetAllProdutos()
        {
            return _produtoRepository.GetAllProdutos();
        }
        
    }
}
