using System;
using System.Collections.Generic;
using System.Text;
using ExLayer.DAL.EF;
using ExLayer.DAL.Interfaces;

namespace ExLayer.DAL.Repositories
{
    class ParentsRepository : IRepository<Parents>
    {
        private ChaildContext db;

        public ParentsRepository(ChaildContext context)
        {
            this.db = context;
        }

        public IEnumerable<Parents> GetAll()
        {
            return db.Parents.Include(o => o.Phone);
        }

        public Parents Get(int id)
        {
            return db.Parents.Find(id);
        }

        public void Create(Parents order)
        {
            db.Parents.Add(order);
        }

        public void Update(Parents order)
        {
            db.Entry(order).State = EntityState.Modified;
        }
        public IEnumerable<Parents> Find(Func<Parents, Boolean> predicate)
        {
            return db.Parents.Include(o => o.Phone).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Parents order = db.Parents.Find(id);
            if (order != null)
                db.Parents.Remove(order);
        }
    }
}
