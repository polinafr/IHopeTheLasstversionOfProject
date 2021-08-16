using DAL.Entities;
using DAL.Enums;
using DAL.Repositories.BucketN;
using DAL.Repositories.GoodN;
using System.Collections.Generic;

namespace LaughingPalmTree_Demo
{
    class Program
    {
        /// <summary>
        /// IT IS AN EXAMPLE HOW TO USE METHODS FROM DAL
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IBucketRepository bucketRepository = new BucketRepository();
            IGoodRepository goodRepository = new GoodRepository();

            // Create new bucket and save it to DB
            Bucket bucket1 = new Bucket();
            int createdBucket1Id = bucketRepository.Create(bucket1);

            // Get created bucket By Id
            Bucket createdBucket1 = bucketRepository.GetById(createdBucket1Id);

            // Create new good, add to bucket and update bucket in DB
            Good good1 = new Good(10, "Test Shop", 2, GoodType.Nutrition, "Apple");
            good1.AddToBucket(createdBucket1Id);
            goodRepository.Create(good1);

            // Update good
            good1.ChangePrice(5);
            goodRepository.Update(good1);

            // Get all goods in bucket
            List<Good> bucketGoods = goodRepository.GetByBucketId(createdBucket1.Id);

            // Get all goods, all buckets
            List<Good> allGoods = goodRepository.GetAll();
            List<Bucket> allBuckets = bucketRepository.GetAll();
        }
    }
}
