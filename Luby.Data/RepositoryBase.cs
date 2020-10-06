using System.Data;
using System.Data.SqlClient;

namespace Luby.Data
{
    public class RepositoryBase
    {
        public RepositoryBase(string _stringConexao)
        {
            ConnectionString = _stringConexao;
        }

        public string ConnectionString { get; private set; }

        public SqlConnection ObterConexao()
        {
            var connection = new SqlConnection(ConnectionString);

            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }
    }
}
