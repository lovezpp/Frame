using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace YXH.Services.Dtos
{
    /// <summary>
    ///crm_user_info
    /// </summary>
    [DataContract(IsReference = true)]
    public partial class crm_user_infoDto
    {
        /// <summary>
        /// crm_cst_guid
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string crm_cst_guid { get; set; }
        /// <summary>
        /// mobile
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string mobile { get; set; }
        /// <summary>
        /// name
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string name { get; set; }
        /// <summary>
        /// cardType
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string cardType { get; set; }
        /// <summary>
        /// cardID
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string cardID { get; set; }
        /// <summary>
        /// gender
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public int? gender { get; set; }
        /// <summary>
        /// birthday
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string birthday { get; set; }
        /// <summary>
        /// createtime
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public DateTime? createtime { get; set; }
        /// <summary>
        /// updatetime
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public DateTime? updatetime { get; set; }
        /// <summary>
        /// cityid
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string cityid { get; set; }

    }
}
