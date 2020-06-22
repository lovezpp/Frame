using System;
using System.Collections.Generic;
using System.Text;

namespace YXH.Services.IServices
{
    public interface ICaching
    {

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T GetCache<T>(string key) where T : class;

        /// <summary>
        /// 无过期的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Add(string key, object value);
        /// <summary>
        /// 绝对时间的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="absoluteTime"></param>
        void Add(string key, object value, DateTime absoluteTime);
        /// <summary>
        /// 相对时间的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="slidingTime"></param>
        void Add(string key, object value, TimeSpan slidingTime);

        /// <summary>
        /// 从 HttpContext.Current.Cache 中取回缓存对象
        /// </summary>
        /// <param name="key">缓存键</param>
        /// <returns>缓存对象</returns>
        object Get(string key);

        /// <summary>
        /// 比较缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Contain(string key);


        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key"></param>
        void Remove(string key);
    }
}
