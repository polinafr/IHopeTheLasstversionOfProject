using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Bucket
    {
        private readonly List<Good> _goods;

        public Bucket()
        {
            this.CreationDateTime = DateTime.Now;
            this._goods = new List<Good>();
        }

        public Bucket(int? id = null, List<Good> goods = null)
        {
            this.Id = id ?? 0;
            this.CreationDateTime = DateTime.Now;
            this._goods = goods ?? new List<Good>();
        }

        public int Id { get; private set; }
        public DateTime CreationDateTime { get; private set; }
        public List<Good> Goods => _goods;



        public void AddGood(Good good)
        {
            _goods.Add(good);
        }
    }
}
