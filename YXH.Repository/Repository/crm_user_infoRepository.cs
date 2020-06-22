using System;
using System.Collections.Generic;
using System.Text;
using YXH.Entities.Entity;
using YXH.Entities.IRepository;

namespace YXH.Repository.Repository
{
    public class crm_user_infoRepository : Repository<crm_user_info>, Icrm_user_infoRepository
    {

        public crm_user_infoRepository(DBContext.MySqlDBContext dBContext) : base(dBContext)
        {
        }
    }
}
