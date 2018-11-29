using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hesint.EntityFramework
{
    /// <summary>
    /// 数据库上下文注入器
    /// </summary>
    public static class DbContextRegister
    {
        /// <summary>
        /// 数据库读取上下文注入。
        /// </summary>
        /// <param name="services">DI容器</param>
        /// <param name="connectionString">数据库连接上下文</param>
        public static void RegisterReadDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ReadDbContext>(a => a.UseNpgsql(connectionString));
        }

        /// <summary>
        /// 数据库操作上下文注入
        /// </summary>
        /// <param name="services">DI容器</param>
        /// <param name="connectionString">数据库连接上下文</param>
        public static void RegisterOperateDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OperatDbContext>(a => a.UseNpgsql(connectionString));
        }
    }
}
