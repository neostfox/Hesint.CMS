using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hesint.EntityFramework.Framework
{
    public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// 操作数据库读取上下文
        /// </summary>
        OperatDbContext OperatDb { get; set; }


        /// <summary>
        /// 读取数据库上下文
        /// </summary>
        ReadDbContext ReadDb { get; set; }


        /// <summary>
        /// 保存操作
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesSync();
    }
}
