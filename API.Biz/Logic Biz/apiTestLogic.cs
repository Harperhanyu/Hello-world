using API.Biz.Services_Biz;
using API.Store.Model.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Biz.Logic_Biz
{
    public class apiTestLogic
    {
        private apiTestBizServices _apiTestBizServices;
        public apiTestLogic(apiTestBizServices testBizServices)
        {
            _apiTestBizServices = testBizServices;
        }

        public IList<apiTestModel> QueryMethod(int id)
        {
            return _apiTestBizServices.QueryMethod(id);
        }
    }
}
