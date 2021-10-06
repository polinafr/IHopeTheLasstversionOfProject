using DAL.Entities;
using DAL.Repositories.BucketN;
using DAL.Repositories.GoodN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALimp : IDAL
    {
        IBucketRepository bucketRepository = new BucketRepository();
        IGoodRepository goodRepository = new GoodRepository();

        public void AddGood(Good good)
        {
            goodRepository.Create(good);
        }

        public List<Bucket> getAllBuckets(Func<Bucket, bool> pred = null)
        {
            return bucketRepository.GetAll();
        }

        public List<Good> getAllGoods(Func<Good, bool> pred = null)
        {
            return goodRepository.GetAll();
        }

        public void UpdateGood(Good good)// as if the good received is already updated
        {
            goodRepository.Update(good);
        }
    }
}
