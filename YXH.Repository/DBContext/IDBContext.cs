using System;
using System.Collections.Generic;
using System.Text;

namespace YXH.Repository.DBContext
{
    public interface IDBContext : IDisposable
    {
        /// <summary>
        /// 是否已提交事务
        /// </summary>
        bool IsTransactionStarted { get; }


        /// <summary>
        /// 开启数据库事务
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// 提交事务
        /// </summary>
        void Commit();


        /// <summary>
        /// 事务回滚
        /// </summary>
        void Rollback();
    }
}
