﻿using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YXH.Entities.IRepository;
using YXH.Repository.DBContext;
using YXH.Repository.Repository;
using YXH.Services.IServices;
using YXH.Services.Services;

namespace YXH.webapi.ServiceCollectionExcention
{
    public static class ServiceCollectionExcention
    {
        /// <summary>
        /// 缓存的注入
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        //public static IServiceCollection AddCache(this IServiceCollection services)
        //{
        //    // 缓存注入
        //    services.AddScoped<ICaching, MemoryCaching>();
        //    services.AddSingleton<IMemoryCache>(factory =>
        //    {
        //        var cache = new MemoryCache(new MemoryCacheOptions());
        //        return cache;
        //    });
        //    services.UseRedisClient();
        //    // Redis注入
        //    //services.AddSingleton<IRedisCacheManager, RedisCacheManager>();
        //    return services;
        //}


        public static IServiceCollection IOC(this IServiceCollection services)
        {
            //System.Reflection.Assembly.Load("YXH.Services")

            services.AddService();
            services.AddRepository();

            //services.AddTransient<IScheduleRepository, ScheduleRepository>();
            //services.AddTransient<IScheduleService, ScheduleService>();

            return services;
        }


        private static void AddService(this IServiceCollection services)
        {
            var assemblyData = ((System.Type[])System.Reflection.Assembly.Load("YXH.Services").ExportedTypes).ToList();
            var interfaceData = assemblyData.Where(a => a.Namespace == "YXH.Services.IServices").ToList();
            var servicesData = assemblyData.Where(a => a.Namespace == "YXH.Services.Services" && a.Name != "DisposeBase").ToList();
            foreach (var interfaceItem in interfaceData)
            {
                var serviceItem = servicesData.Where(a => a.Name == interfaceItem.Name.Substring(1)).FirstOrDefault();
                if (serviceItem != null)
                {
                    services.AddTransient(interfaceItem, serviceItem);
                }
            }
        }

        private static void AddRepository(this IServiceCollection services)
        {
            var interfaceData = ((System.Type[])System.Reflection.Assembly.Load("YXH.Entities").ExportedTypes).Where(a => a.Namespace == "YXH.Entities.IRepository").ToList();
            var servicesData = ((System.Type[])System.Reflection.Assembly.Load("YXH.Repository").ExportedTypes).Where(a => a.Namespace == "YXH.Repository.Repository").ToList();
            foreach (var interfaceItem in interfaceData)
            {
                var serviceItem = servicesData.Where(a => a.Name == interfaceItem.Name.Substring(1)).FirstOrDefault();
                if (serviceItem != null)
                {
                    services.AddTransient(interfaceItem, serviceItem);
                }
            }
        }

        /// <summary>
        /// 数据库连接注入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="services"></param>
        /// <param name="setupAction"></param>
        /// <returns></returns>
        public static IServiceCollection AddDapperDBContext<T,TT>(this IServiceCollection services, Action<TT> setupAction) where T : DapperDBContext where TT: DapperDBContextOptions
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }
            services.AddOptions();
            services.Configure(setupAction);
            services.AddScoped<T, T>();
            return services;
        }
    }
}
