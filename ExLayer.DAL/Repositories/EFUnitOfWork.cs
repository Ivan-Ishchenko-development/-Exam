using ExLayer.DAL.EF;
using ExLayer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLayer.DAL.Repositories
{
    class EFUnitOfWork : IUnitOfWork
    {
        private ChaildContext db;

        private ChaildRepository chaildRepository;
        private ParentsRepository parentsRepository;
        private GroupRepository groupRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new ChaildContext(connectionString);
        }
        public IRepository<Chaild> Chailds
        {
            get
            {
                if (chaildRepository == null)
                    chaildRepository = new ChaildRepository(db);
                return chaildRepository;
            }
        }

        public IRepository<Parents> Parents
        {
            get
            {
                if (parentsRepository == null)
                    parentsRepository = new ParentsRepository(db);
                return parentsRepository;
            }
        }

        public IRepository<Group> Group
        {
            get
            {
                if (groupRepository == null)
                    groupRepository = new GroupRepository(db);
                return groupRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
