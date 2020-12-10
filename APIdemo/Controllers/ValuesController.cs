using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Biz.Logic_Biz;
using API.Store.Model.API;
using Microsoft.AspNetCore.Mvc;

namespace APIdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly apiTestLogic _apiTestLogic;
        public ValuesController(apiTestLogic apiTest)
        {
            _apiTestLogic = apiTest;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 这是注释
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            IList<apiTestModel> result = _apiTestLogic.QueryMethod(id);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
