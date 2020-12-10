using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace API.Store.DB_connection
{
    public class ConnectionProvider : IConnectionProvider
    {
        string connString;

        public ConnectionProvider(string connString)
        {
            this.connString = connString;
        }

        //创建连接对象
        public IDbConnection CreateConnection()
        {
            IDbConnection connection = new OracleConnection(connString);

            return connection;
        }
    }
}
