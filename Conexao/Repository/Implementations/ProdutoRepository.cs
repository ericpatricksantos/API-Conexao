using Conexao.Model;
using Conexao.Repository.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conexao.Repository.Implementations
{
    public class ProdutoRepository : IProdutoRepository
    {
        private IConfiguration _configuration;

        //Injeção de Dependencia 
        //Precisa instanciar o configuration para ele acessar o appsettings.json
        public ProdutoRepository(IConfiguration configuration)
        {

            _configuration = configuration;
        }

        public async Task<List<Produto>> GetAllProdutos()
        {
            try
            {
                string connectionString = Environment.GetEnvironmentVariable("ConnectionString");

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "select id Id, nome Nome from produtos";
                    conn.Open();
                    List<Produto> produtos = (await conn.QueryAsync<Produto>(sql: query)).ToList();
                    conn.Close();
                    return produtos;
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
