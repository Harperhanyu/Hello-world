using API.Store.DB_connection;
using API.Store.Model.API;
using API.Store.Services_Register;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Biz.Services_Biz
{
    public class apiTestBizServices
    {
        private IConnectionProvider iconnectionProvider;
        public apiTestBizServices(IDBconfigure iDBconfigure)
        {
            iconnectionProvider = new ConnectionProvider(iDBconfigure.connStr);
        }
        public IList<apiTestModel> QueryMethod(int id)
        {
            IList<apiTestModel> SiteFin;
            using (IapiTestRegister context = new apiTestRegister(iconnectionProvider))
            {
                SiteFin = context.iapiTestContext.Query(id);
                context.Commit();
            }
            return SiteFin;
        }
    }
}
