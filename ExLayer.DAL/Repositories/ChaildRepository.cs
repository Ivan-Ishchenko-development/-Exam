using System;
using System.Collections.Generic;
using System.Text;
using ExLayer.DAL.EF;
using ExLayer.DAL.Interfaces;

namespace ExLayer.DAL.Repositories
{
    class ChaildRepository : IRepository<Chaild>
    {
        private ChaildContext db;
 
        public ChaildRepository(ChaildContext context)
        {
            this.db = context;
        }

        public IEnumerable<Chaild> GetAll()
        {
            return db.Chailds;
        }

        public Chaild Get(int id)
        {
            return db.Chailds.Find(id);
        }

        public void Create(Chaild book)
        {
            db.Chailds.Add(book);
        }

        public void Update(Chaild book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Chaild> Find(Func<Chaild, Boolean> predicate)
        {
            return db.Chailds.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Chaild book = db.Chailds.Find(id);
            if (book != null)
                db.Chailds.Remove(book);
        }
    }
}
