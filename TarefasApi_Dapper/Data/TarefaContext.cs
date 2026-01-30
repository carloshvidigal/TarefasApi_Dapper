using System.Data;

namespace TarefasApi_Dapper.Data
{
    public class TarefaContext
    {
        public delegate Task<IDbConnection> GetConnection(); 
    }
}
