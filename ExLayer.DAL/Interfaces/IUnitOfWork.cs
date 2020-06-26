using System;
using System.Collections.Generic;
using System.Text;

namespace ExLayer.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        
        IRepository<Chaild> Chailds { get; }
        IRepository<Parents> Parents { get; }
        IRepository<Group> Groups { get; }
        void Save();
    }
}
