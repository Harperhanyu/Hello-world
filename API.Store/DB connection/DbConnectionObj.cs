using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace API.Store.DB_connection
{
    public abstract class DbConnectionObj
    {
        protected IDbConnection _Connection { get; private set; }
        protected IDbTransaction _Transaction { get; private set; }

        public DbConnectionObj(IDbConnection connection, IDbTransaction transaction)
        {
            _Connection = connection;
            _Transaction = transaction;
        }
    }
}
