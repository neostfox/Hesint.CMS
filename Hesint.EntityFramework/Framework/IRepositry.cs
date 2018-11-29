using System;
using System.Collections.Generic;
using System.Text;

namespace Hesint.EntityFramework.Framework
{
    public interface IRepositry<T>
        where T : class
    {
        /// <summary>
        /// 操作单元
        /// </summary>
        IUnitOfWork unitOfWork { get; set; }


    }
}
