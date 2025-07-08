using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Client.Common
{
    /// <summary>
    /// 服务定位器
    /// </summary>
    public static class ServiceLocator
    {
        private static IServiceProvider _serviceProvider;

        /// <summary>
        /// 初始化服务定位器
        /// </summary>
        public static void ServiceLocatorInit()
        {
            var serviceCollection = new ServiceCollection();

            // 注册服务
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();

        }

        /// <summary>
        /// 注册服务
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(ServiceCollection services)
        {
            //services.AddSingleton<MainWindowViewModel>();

            //services.AddSingleton<IModBusService, ModBusService>();
        }

        /// <summary>
        /// 获取服务实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetService<T>()
        {
            if (_serviceProvider==null)
            {
                ServiceLocatorInit();
            }
            return _serviceProvider.GetService<T>();
        }

    }
}
