using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace YXH.Services.Dtos
{
    /// <summary>
    ///T_Schedule
    /// </summary>
    [DataContract(IsReference = true)]
    public partial class ScheduleDto : EntityMetadataDto
    {
        /// <summary>
        /// ID
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string ID { get; set; }
        /// <summary>
        /// Acid
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string Acid { get; set; }
        /// <summary>
        /// Status
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public int? Status { get; set; }
        /// <summary>
        /// Name
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string Name { get; set; }
        /// <summary>
        /// Description
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string Description { get; set; }
        /// <summary>
        /// Project
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public string Project { get; set; }
        /// <summary>
        /// BeginTime
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public DateTime? BeginTime { get; set; }
        /// <summary>
        /// EndTime
        /// </summary>	
        [DataMember(EmitDefaultValue = true)]
        public DateTime? EndTime { get; set; }

    }
}
