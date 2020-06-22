using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using YSH.Framework.Attribute;
using YXH.Entities.Entity;
using YXH.Entities.IRepository;
using YXH.Services.Dtos;
using YXH.Services.IServices;

namespace YXH.Services.Services
{
    [ServiceType(ServiceLifetime.Transient, typeof(ITestService))]
    public class TestService : DisposeBase, ITestService
    {
        private readonly IScheduleRepository _ScheduleRepository;
        private readonly Icrm_user_infoRepository _crm_User_InfoRepository;

        public TestService(IScheduleRepository ScheduleRepository, Icrm_user_infoRepository crm_User_InfoRepository) :
            base(ScheduleRepository)
        {
            _crm_User_InfoRepository = crm_User_InfoRepository;
            _ScheduleRepository = ScheduleRepository;
        }


        public object Query()
        {
            var result = new object();

            result = new
            {
                v1 = _ScheduleRepository.ExecSql("select * from T_Schedule").ToList(),
                v2 = _crm_User_InfoRepository.ExecSql("select top 100 * from crm_user_info").ToList()
            };

            Schedule dto = new Schedule();


           
            using (var tran= _ScheduleRepository.BeginTransaction())
            {
                _ScheduleRepository.Insert(dto,tran);


                _crm_User_InfoRepository.Insert(new crm_user_info(), tran);
                tran.Commit();
            } 

            return result;
        }

    }
}
