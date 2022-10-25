using Gouro.Core.DomainObjects;
using System;

namespace Gouro.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot 
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
