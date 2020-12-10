using API.Store.Model.API;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Store.Table_Repository
{
    public interface IapiTestContext
    {
        IList<apiTestModel> Query(int uid);
        bool Insert(apiTestModel insertObj);
        bool Modify(apiTestModel updateObj);
        bool Delete(string id);
    }
}
