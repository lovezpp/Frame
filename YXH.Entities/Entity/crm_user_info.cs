using Dapper.Contrib.Extensions;
using System;

namespace YXH.Entities.Entity
{
    /// <summary>
    ///crm_user_info
    /// </summary>
    [Table("crm_user_info")]
    public class crm_user_info
    {
        /// <summary>
        /// crm_cst_guid
        /// </summary>		
        public string crm_cst_guid { get; set; }
        /// <summary>
        /// mobile
        /// </summary>		
        public string mobile { get; set; }
        /// <summary>
        /// name
        /// </summary>		
        public string name { get; set; }
        /// <summary>
        /// cardType
        /// </summary>		
        public string cardType { get; set; }
        /// <summary>
        /// cardID
        /// </summary>		
        public string cardID { get; set; }
        /// <summary>
        /// gender
        /// </summary>		
        public int? gender { get; set; }
        /// <summary>
        /// birthday
        /// </summary>		
        public string birthday { get; set; }
        /// <summary>
        /// createtime
        /// </summary>		
        public DateTime? createtime { get; set; }
        /// <summary>
        /// updatetime
        /// </summary>		
        public DateTime? updatetime { get; set; }
        /// <summary>
        /// cityid
        /// </summary>		
        public string cityid { get; set; }

    }
}
