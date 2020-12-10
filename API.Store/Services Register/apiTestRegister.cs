using API.Store.DB_connection;
using API.Store.Table_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Store.Services_Register
{
    public class apiTestRegister: DbContext, IapiTestRegister
    {
        private IapiTestContext _iapiTestContext;
        public apiTestRegister(IConnectionProvider connectionProvider) : base(connectionProvider) { }

        public IapiTestContext iapiTestContext =>
            _iapiTestContext ?? (_iapiTestContext = new apiTestContext(_connection, _transaction));
    }
}
