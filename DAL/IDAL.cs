using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        void AddGood(Good good);
        void UpdateGood(Good good);
        List<Good> getAllGoods(Func<Good, bool> pred = null);
        List<Bucket> getAllBuckets(Func<Bucket, bool> pred = null);
        
    }
}
