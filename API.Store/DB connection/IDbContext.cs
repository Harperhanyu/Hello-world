using System;
using System.Collections.Generic;
using System.Text;

namespace API.Store.DB_connection
{
    public interface IDbContext : IDisposable
    {
        void Commit();
    }
}
