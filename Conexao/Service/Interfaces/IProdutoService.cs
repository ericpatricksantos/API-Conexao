using Conexao.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Conexao.Service.Interfaces
{
    public interface IProdutoService
    {
        Task<List<Produto>> GetAllProdutos();
    }
}
