using DAL.DbContextN;
using DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories.GoodN
{
    public class GoodRepository : IGoodRepository
    {
        public int Create(Good good)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Goods.Add(good);
                db.SaveChanges();

                return good.Id;
            }
        }

        public void Delete(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                Good goodToDelete = db.Goods.Find(id);
                db.Goods.Remove(goodToDelete);
                db.SaveChanges();
            }
        }

        public List<Good> GetAll()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Goods.ToList();
            }
        }

        public Good GetById(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Goods.Find(id);
            }
        }

        public void Update(Good bucket)
        {
            using (AppDbContext db = new AppDbContext())
            {
                Good goodToUpdate = db.Goods.Find(bucket.Id);
                if (goodToUpdate == null)
                {
                    return;
                }

                db.Entry(goodToUpdate).CurrentValues.SetValues(bucket);
                db.SaveChanges();
            }
        }

        public List<Good> GetByBucketId(int bucketId)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Goods.Where(g => g.BucketId == bucketId).ToList();
            }
        }
    }
}
