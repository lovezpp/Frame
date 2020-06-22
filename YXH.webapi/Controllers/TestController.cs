using Microsoft.AspNetCore.Mvc;
using YXH.Services.IServices;

namespace YXH.webapi.Controllers
{
    [Route("api/YXH/[controller]")]
    [ApiController]
    public class TestController :BaseController
    {

        private readonly ITestService _service;
        private readonly IScheduleService _scheduleService;
        private readonly Icrm_user_infoService _crm_User_InfoService;
        public TestController(ITestService service, Icrm_user_infoService crm_User_InfoService, IScheduleService scheduleService)
        {
            _crm_User_InfoService = crm_User_InfoService;
            _scheduleService = scheduleService;
            _service = service;
        }

        [Route("GetList")]
        [HttpPost]
        public object GetList([FromForm]string requestString)
        {
            var result = new object();

            try
            {
                result = _service.Query();
            }
            catch (System.Exception ex)
            {

                throw;
            }

            return result;
        }


        [Route("Query")]
        [HttpPost]
        public object Query([FromForm]string requestString)
        {
            var result = new object();


            result = new
            {
                v1 = _crm_User_InfoService.Query(),
                v2 = _scheduleService.Query()
            };

            return result;
        }

    }
}
