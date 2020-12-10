using API.Biz.Logic_Biz;
using API.Biz.Services_Biz;
using API.Store.Model.API;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIdemo
{
    public static class SetupControllerServices
    {
        public static void SetupServices(this IServiceCollection services, IDBconfigure OracleDBconfigure)
        {
            services.AddSingleton<IDBconfigure>(OracleDBconfigure);

            services.AddScoped<apiTestBizServices>();
            
            services.AddScoped<apiTestLogic>();
        }
    }
}
