using API.Store.DB_connection;
using API.Store.Table_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Store.Services_Register
{
    public interface IapiTestRegister : IDbContext
    {
        IapiTestContext iapiTestContext { get; }
    }
}
