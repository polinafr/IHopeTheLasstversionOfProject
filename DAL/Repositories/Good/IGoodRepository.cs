using DAL.Entities;
using System.Collections.Generic;

namespace DAL.Repositories.GoodN
{
    public interface IGoodRepository
    {
        Good GetById(int id);
        int Create(Good bucket);
        void Update(Good bucket);
        void Delete(int id);
        List<Good> GetByBucketId(int bucketId);
        List<Good> GetAll();
    }
}
