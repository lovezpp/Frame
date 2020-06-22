using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace YXH.Repository.DBContext
{

    public abstract class DapperDBContext : IDBContext
    {
        #region 属性定义

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private readonly IDbConnection _connetion;

        /// <summary>
        /// 事务上下文
        /// </summary>
        private IDbTransaction _transaction;

        public IDbTransaction Transaction { get { return _transaction; } }

        /// <summary>
        /// 是否处于事务中
        /// </summary>
        public bool IsTransactionStarted { get; private set; }


        private readonly DapperDBContextOptions _options;

        #endregion


        #region 构造注入

        protected abstract IDbConnection CreateConnection(string connectionString);
        public DapperDBContext(IOptions<DapperDBContextOptions> optionsAccessor)
        {
            _options = optionsAccessor.Value;
            _connetion = CreateConnection(_options.Configuration);
            _connetion.Open();
        }

        #endregion


        #region 方法实现


        /// <summary>
        /// 开启事务
        /// </summary>
        public void BeginTransaction()
        {
            if (IsTransactionStarted)
                throw new InvalidOperationException("Transaction is already started.");
            IsTransactionStarted = true;
            _transaction = _connetion.BeginTransaction();
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        public void Commit()
        {
            if (!IsTransactionStarted)
                throw new InvalidOperationException("No transaction started.");

            _transaction.Commit();
            _transaction = null;

            IsTransactionStarted = false;
        }


        /// <summary>
        /// 回滚事务
        /// </summary>
        public void Rollback()
        {
            if (!IsTransactionStarted)
                throw new InvalidOperationException("No transaction started.");

            _transaction.Rollback();
            _transaction.Dispose();
            _transaction = null;

            IsTransactionStarted = false;

        }

        public IDbConnection Connection
        {
            get { return _connetion; }
        }

        #endregion


        #region 资源释放管理
        public void Dispose()
        {
            if (IsTransactionStarted)
                _transaction.Rollback();

            _connetion.Close();
            _connetion.Dispose();
        }

        #endregion



    }
}
