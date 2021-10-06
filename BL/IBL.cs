using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;
using DAL.Enums;


namespace BL
{
    public enum GraphType { Columns, Pie };
    public interface IBL
    {

        bool saveToPDF(Dictionary<Good, float> statistics, GraphType type);
        List<List<Good>> getRecommendations(List<Good> currentBucketsGoods);
        Dictionary<Good, float> GetGoodsRatio();
        Dictionary<Good, int> GetBoughtGoodsQuantity();
        void Initialize();
        List<Good> getListOfGoods(Func<Good, bool> condition);
        List<Good> getListOfGoods();
        List<Bucket> getListOfBuckets(Func<Bucket, bool> condition);
        List<Bucket> getListOfBuckets();
        void CreateRecommendationsPDF();
        bool UpdateGood(Good good);
        void AddGood(Good good);

    }
}
