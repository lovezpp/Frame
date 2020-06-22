using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace YXH.Entities.IRepository
{
    public interface IRepository<TEntity> : IDisposable
    {

        TEntity Get(object id);

        IEnumerable<TEntity> GetAll();

        bool Update(TEntity t);
        bool Update(TEntity t, IDbTransaction trans);
        bool Update(IList<TEntity> t);
        bool Update(IList<TEntity> t, IDbTransaction trans);


        long Insert(TEntity t);
        long Insert(TEntity t, IDbTransaction trans);
        long Insert(IList<TEntity> t);
        long Insert(IList<TEntity> t, IDbTransaction trans);

        //提供一个特殊的插入方法，用于匿名类插入
        long Insert<OtherT>(OtherT t) where OtherT : class;

        bool Delete(TEntity t);
        bool Delete(TEntity t, IDbTransaction trans);
        bool Delete(IList<TEntity> t);
        bool Delete(IList<TEntity> t, IDbTransaction trans);

        /// <summary>
        /// 执行sql  param可选
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">查询条件参数</param>
        /// <returns></returns>
        IEnumerable<TEntity> ExecSql(string sql, object param = null);


        /// <summary>
        /// 执行sql  param可选
        /// </summary>
        /// <typeparam name="TT"></typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="param">查询条件参数</param>
        /// <returns></returns>
        IEnumerable<TT> ExecSql<TT>(string sql, object param = null);

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        int Execute(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        int ExecSqlCount(string sql, object param = null);

        /// <summary>
        /// 开启事务
        /// </summary>
        /// <returns></returns>
        IDbTransaction BeginTransaction();
    }
}
