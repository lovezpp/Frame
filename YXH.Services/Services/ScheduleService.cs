using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using YSH.Framework.Attribute;
using YXH.Entities.IRepository;
using YXH.Services.IServices;

namespace YXH.Services.Services
{
    [ServiceType(ServiceLifetime.Transient, typeof(IScheduleService))]
    public class ScheduleService : DisposeBase, IScheduleService
    {
        private readonly IScheduleRepository _ScheduleRepository;

        public ScheduleService(IScheduleRepository ScheduleRepository) :
            base(ScheduleRepository)
        {
            _ScheduleRepository = ScheduleRepository;
        }


        public object Query()
        {
            var result = new object();

            

            var list = _ScheduleRepository.ExecSql("select * from T_Schedule").ToList();



            result = list;

            return result;
        }

    }
}
