using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;
using YXH.Services.IServices;

namespace YXH.Services.Services
{
    public class MemoryCaching : ICaching
    {
        private readonly IMemoryCache _cache;

        public MemoryCaching(IMemoryCache cache)
        {
            _cache = cache;
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T GetCache<T>(string key) where T : class
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            T v = null;
            _cache.TryGetValue<T>(key, out v);

            return v;
        }

        #region Add
        /// <summary>
        /// 无过期的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, object value)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));


            object v = null;
            if (_cache.TryGetValue(key, out v))
                _cache.Remove(key);
            _cache.Set<object>(key, value);
        }

        /// <summary>
        /// 绝对时间的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="absoluteTime"></param>
        public void Add(string key, object value, DateTime absoluteTime)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));


            object v = null;
            if (_cache.TryGetValue(key, out v))
                _cache.Remove(key);
            _cache.Set<object>(key, value, absoluteTime);
        }

        /// <summary>
        /// 相对时间的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="slidingTime"></param>
        public void Add(string key, object value, TimeSpan slidingTime)
        {

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));


            object v = null;
            if (_cache.TryGetValue(key, out v))
                _cache.Remove(key);
            _cache.Set<object>(key, value, slidingTime);
        }
        #endregion


        /// <summary>
        /// 从 HttpContext.Current.Cache 中取回缓存对象
        /// </summary>
        /// <param name="key">缓存键</param>
        /// <returns>缓存对象</returns>
        public object Get(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            return _cache.Get(key);
        }

        /// <summary>
        /// 比较缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contain(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            object v = null;
            return _cache.TryGetValue<object>(key, out v);
        }

        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            _cache.Remove(key);
        }

    }
}
