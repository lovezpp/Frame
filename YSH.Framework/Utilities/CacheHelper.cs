using Microsoft.Extensions.Caching.Memory;
using System;

namespace YSH.Framework.Utilities
{
    public static class CacheHelper
    {
        private static IMemoryCache _cache;

        private static readonly object lockObj = new object();

        public static IMemoryCache Initializa()
        {
            if (_cache == null)
            {
                lock (lockObj)
                {
                    if (_cache == null)
                    {
                        _cache = new MemoryCache(new MemoryCacheOptions());
                    }
                }
            }
            return _cache;
        }



        public static T GetCache<T>(string key) where T : class
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));


            T v = null;
            Initializa().TryGetValue<T>(key, out v);


            return v;
        }

        #region Add
        /// <summary>
        /// 无过期的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Add(string key, object value)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));


            object v = null;
            if (Initializa().TryGetValue(key, out v))
                Initializa().Remove(key);
            Initializa().Set<object>(key, value);
        }

        /// <summary>
        /// 绝对时间的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="absoluteTime"></param>
        public static void Add(string key, object value, DateTime absoluteTime)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));


            object v = null;
            if (Initializa().TryGetValue(key, out v))
                Initializa().Remove(key);
            Initializa().Set<object>(key, value, absoluteTime);
        }

        /// <summary>
        /// 相对时间的缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="slidingTime"></param>
        public static void Add(string key, object value, TimeSpan slidingTime)
        {

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));


            object v = null;
            if (Initializa().TryGetValue(key, out v))
                Initializa().Remove(key);
            Initializa().Set<object>(key, value, slidingTime);
        }
        #endregion


        /// <summary>
        /// 从 HttpContext.Current.Cache 中取回缓存对象
        /// </summary>
        /// <param name="key">缓存键</param>
        /// <returns>缓存对象</returns>
        public static object Get(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            return Initializa().Get(key);
        }

        public static bool Contain(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            object v = null;
            return Initializa().TryGetValue<object>(key, out v);
        }

        public static void Remove(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            Initializa().Remove(key);
        }
    }
}
