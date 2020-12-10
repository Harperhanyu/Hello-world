using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace API.Store.DB_connection
{
    public interface IConnectionProvider
    {
        IDbConnection CreateConnection();
    }
}
