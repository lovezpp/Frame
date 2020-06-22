using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using YXH.Entities.IRepository;
using YXH.Repository.DBContext;

namespace YXH.Repository.Repository
{

    public class Repository<T> : IRepository<T> where T : class
    {
        protected  DapperDBContext DBContext;
        private  IDbConnection DBConnection;

        public Repository(DapperDBContext db)
        {
            DBContext = db;
            DBConnection = db.Connection;
        }

        public long Insert(T t)
        {
            return DBConnection.Insert(t, DBContext.Transaction);
        }

        public long Insert(T t, IDbTransaction trans)
        {
            return DBConnection.Insert(t, trans);
        }

        public long Insert(IList<T> t)
        {
            return DBConnection.Insert(t, DBContext.Transaction);
        }

        public long Insert(IList<T> t, IDbTransaction trans)
        {
            return DBConnection.Insert(t, trans);
        }
        public long Insert<OtherT>(OtherT t) where OtherT : class
        {
            return DBConnection.Insert(t, DBContext.Transaction);
        }

        public bool Delete(T t)
        {
            return DBConnection.Delete(t);
        }
        public bool Delete(T t, IDbTransaction trans)
        {
            return DBConnection.Delete(t, trans);
        }
        public bool Delete(IList<T> t)
        {
            return DBConnection.Delete(t);
        }
        public bool Delete(IList<T> t, IDbTransaction trans)
        {
            return DBConnection.Delete(t, trans);
        }

        public bool Update(T t)
        {
            return DBConnection.Update<T>(t);
        }
        public bool Update(T t, IDbTransaction trans)
        {
            return DBConnection.Update<T>(t, trans);
        }

        public bool Update(IList<T> t)
        {
            return DBConnection.Update(t);
        }

        public bool Update(IList<T> t, IDbTransaction trans)
        {
            return DBConnection.Update(t, trans);
        }

        public T Get(object id)
        {
            return DBConnection.Get<T>(id);
        }
        public IEnumerable<T> GetAll()
        {
            return DBConnection.GetAll<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<T> ExecSql(string sql, object param = null)
        {
            return DBConnection.Query<T>(sql, param);
        }

        public IEnumerable<TT> ExecSql<TT>(string sql, object param = null)
        {
            return DBConnection.Query<TT>(sql, param);
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return DBConnection.Execute(sql, param, transaction, commandTimeout, commandType);
        }


        public int ExecSqlCount(string sql, object param)
        {
            return DBConnection.ExecuteScalar<int>(sql, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="buffered"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public IEnumerable<T> Query(string sql, object param, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return DBConnection.Query<T>(sql, param, transaction, buffered, commandTimeout, commandType);
        }

        /// <summary>
        /// 开启事务
        /// </summary>
        /// <returns></returns>
        public IDbTransaction BeginTransaction()
        {
            return DBConnection.BeginTransaction();
        }

        public void Dispose()
        {
            DBConnection?.Dispose();
            DBConnection?.Dispose();
        }
    }

}
