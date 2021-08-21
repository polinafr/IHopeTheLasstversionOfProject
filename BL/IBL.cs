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
        Dictionary<float, Good> GetGoodsRatio();
        Dictionary<int, Good> GetBoughtGoodsQuantity();

    }
}
