using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using YSH.Framework.Attribute;
using YXH.Entities.Entity;
using YXH.Entities.IRepository;
using YXH.Repository.DBContext;

namespace YXH.Repository.Repository
{
    [ServiceType(ServiceLifetime.Transient, typeof(IScheduleRepository))]
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {

        public ScheduleRepository(DBContext.DBContext dBContext) : base(dBContext)
        {
        }
    }
}
