using System;
using System.Runtime.Serialization;

namespace YXH.Services.Dtos
{
    public class EntityMetadataDto
    {

        [DataMember(EmitDefaultValue = true)]
        public int? SYS_Del { set; get; }

        [DataMember(EmitDefaultValue = true)]
        public DateTime? SYS_CreateTime { set; get; }

        [DataMember(EmitDefaultValue = true)]
        public string SYS_CreateUser { set; get; }

        [DataMember(EmitDefaultValue = true)]
        public DateTime? SYS_UpdateTime { set; get; }

        [DataMember(EmitDefaultValue = true)]
        public string SYS_UpdateUser { set; get; }

        [DataMember(EmitDefaultValue = true)]
        public string SYS_Remark { set; get; }
    }
}