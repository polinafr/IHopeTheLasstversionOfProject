using DAL.DbContextN;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories.BucketN
{
    public class BucketRepository : IBucketRepository
    {
        public int Create(Bucket bucket)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Buckets.Add(bucket);
                db.SaveChanges();

                return bucket.Id;
            }
        }

        public void Delete(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                Bucket bucketToDelete = db.Buckets.Find(id);
                db.Buckets.Remove(bucketToDelete);
                db.SaveChanges();
            }
        }

        public List<Bucket> GetAll()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Buckets.ToList();
            }
        }

        public List<Bucket> GetByDates(DateTime dateFrom, DateTime dateTo)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Buckets.Where(b => b.CreationDateTime >= dateFrom && b.CreationDateTime < dateTo).ToList();
            }
        }

        public Bucket GetById(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Buckets.Find(id);
            }
        }

        public void Update(Bucket bucket)
        {
            using (AppDbContext db = new AppDbContext())
            {
                Bucket bucketToUpdate = db.Buckets.Find(bucket.Id);
                if (bucketToUpdate == null)
                {
                    return;
                }

                db.Entry(bucketToUpdate).CurrentValues.SetValues(bucket);
                db.SaveChanges();
            }
        }
    }
}
