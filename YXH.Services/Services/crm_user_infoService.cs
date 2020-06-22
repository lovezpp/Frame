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
    [ServiceType(ServiceLifetime.Transient, typeof(Icrm_user_infoService))]
    public class crm_user_infoService : DisposeBase, Icrm_user_infoService
    {
        private readonly Icrm_user_infoRepository _crm_user_infoRepository;

        public crm_user_infoService(Icrm_user_infoRepository crm_user_infoRepository) :
            base(crm_user_infoRepository)
        {
            _crm_user_infoRepository = crm_user_infoRepository;
        }


        public object Query()
        {
            var result = new object();



            var list = _crm_user_infoRepository.ExecSql("select top 100 * from crm_user_info").ToList();



            result = list;

            return result;
        }

    }
}
