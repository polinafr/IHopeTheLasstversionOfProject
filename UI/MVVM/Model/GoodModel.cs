using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DAL.Enums;
using BL;

namespace UI.MVVM.Model
{
    
        public class GoodModel
        {
            private IBL BL;
            public GoodModel()
            {
                BL = new BLimp();
            }

            public void Init()
            {
                BL.Initialize();
            }

            public List<Good> GetGoods(BE.Enums.GoodType type)
            {
                return BL.getListOfGoods(x => x.Type == type);
            }

            public List<List<Good>> GetRecommendations() // probably typing problem
            {
                return BL.getRecommendations();
            }
        

            public List<Good> GetBucketsForPeriodOfTime(DateTime since, DateTime to)
            {
                return BL.getListOfBuckets(x => x.CreationDateTime>=since && x.CreationDateTime<=to);
            }

            //public IEnumerable<IGrouping<DateTime, Good>> GetDateGroups()
            //{
            //    return BL.GetDateGroups();
            //}

            //public List<Tuple<string, string>> getAllProductsTupleNameKey()
            //{
            //    return BL.getAllProductsTupleNameKey();
            //}

            public void CreateRecommendations()
            {
                BL.CreateRecommendationsPDF();
            }


           // public IEnumerable<IGrouping<string, IGrouping<DateTime, Item>>> groupByDate()
            //{
            //    return bl.groupByDate();
           // }


            public void UpdateGood(Good good)
            {
                BL.UpdateGood(good);
            }

            //public void RemoveItem(Item item)
            //{
            //    bl.RemoveItem(item.ItemId);
            //}

        }
    
}
