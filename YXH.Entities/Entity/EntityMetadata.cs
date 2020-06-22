using System;

namespace YXH.Entities.Entity
{
    public class EntityMetadata
    {
        public int? SYS_Del { set; get; }
        public DateTime? SYS_CreateTime { set; get; }
        public string SYS_CreateUser { set; get; }
        public DateTime? SYS_UpdateTime { set; get; }
        public string SYS_UpdateUser { set; get; }
        public string SYS_Remark { set; get; }
    }
}