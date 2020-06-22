using System;
using System.Collections.Generic;
using System.Text;
using YXH.Entities.Entity;
using YXH.Entities.IRepository;
using YXH.Repository.DBContext;

namespace YXH.Repository.Repository
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {

        public ScheduleRepository(DBContext.DBContext dBContext) : base(dBContext)
        {
        }
    }
}
