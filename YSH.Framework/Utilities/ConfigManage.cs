using Microsoft.Extensions.Configuration;

namespace YSH.Framework.Utilities
{
    /// <summary>
    /// 程序配置管理类
    /// </summary>
    public static class ConfigManage
    {
        public static IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("Config/Config.json");
        private static IConfigurationRoot config;

        static ConfigManage()
        {
            config = builder.Build();
        }

        /// <summary>
        /// 根据key获取配置的对应值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            return config.GetSection(key).Value;
        }

    }
}
