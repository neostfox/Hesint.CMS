using System;
using System.Collections.Generic;
using System.Text;

namespace Hesint.EntityFramework.Framework
{
    public class RepositoryBase<T> : IRepositry<T>
        where T : class
    {
        public IUnitOfWork unitOfWork { get; set; }
    }
}
