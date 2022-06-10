using Conexao.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Conexao.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> GetAllProdutos();
    }
}
