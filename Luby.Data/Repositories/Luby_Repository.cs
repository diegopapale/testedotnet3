using Dapper;
using Luby.Business.Shared.Models.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Luby.Data.Repositories
{
    public class Luby_Repository
    {
        private readonly RepositoryBase _dbConnection;

        public Luby_Repository(string _connection)
        {
            _dbConnection = new RepositoryBase(_connection);
        }

        private SqlConnection SqlConnection => _dbConnection.ObterConexao();

        public async Task<IEnumerable<Retorno>> RetornarProgramadorPorMediaDeHoras() 
        {
            using (var conn = SqlConnection)
            {
                string sSQl = @"SELECT 
							        Programador.Nome AS Nome,
							        SUM(Horas.Qtde) AS Soma
							    FROM
								    Horas
							    INNER JOIN Programador ON Programador.Id = Horas.IdProgramador
						        GROUP BY Programador.Nome
                                ORDER BY Soma";

                return await conn.QueryAsync<Programador>(sSQl);
            }
        }

        public async Task<bool> InserirProgramador(Programador entity)
        {
            using (var conn = SqlConnection)
            {
                var _result = await conn.ExecuteAsync(
                    @"INSERT INTO Programador(Nome) VALUES (@Nome)",
                    new DynamicParameters(entity));

                return _result >= 0;
            }
        }

        public async Task<bool> InserirHoras(Horas entity)
        {
            using (var conn = SqlConnection)
            {
                var _result = await conn.ExecuteAsync(
                    @"INSERT INTO Horas(IdProgramador, Qtde, Data)
                    VALUES (@IdProgramador, Qtde, Data)",
                    new DynamicParameters(entity));

                return _result >= 0;
            }
        }
    }
}
