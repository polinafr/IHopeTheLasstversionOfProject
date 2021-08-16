using DAL.Entities;
using System;
using System.Collections.Generic;

namespace DAL.Repositories.BucketN
{
    public interface IBucketRepository
    {
        Bucket GetById(int id);
        int Create(Bucket bucket);
        void Update(Bucket bucket);
        void Delete(int id);
        List<Bucket> GetByDates(DateTime dateFrom, DateTime dateTo);
        List<Bucket> GetAll();
    }
}
