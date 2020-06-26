using ExLayer.DAL.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLayer.DAL.Repositories
{
    class GroupRepository : IRepository<Group>
    {
        private ChaildContext db;

        public GroupRepository(ChaildContext context)
        {
            this.db = context;
        }

        public IEnumerable<Group> GetAll()
        {
            return db.Groups;
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public void Create(Group book)
        {
            db.Groups.Add(book);
        }

        public void Update(Group book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Group> Find(Func<Group, Boolean> predicate)
        {
            return db.Groups.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Group book = db.Groups.Find(id);
            if (book != null)
                db.Groups.Remove(book);
        }
    }
}
