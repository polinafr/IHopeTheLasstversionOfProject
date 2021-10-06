using UI.MVVM.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace UI.MVVM.VM
{
    public class RecommendedGoodsVM
    {
        public Good good { get; set; }
        GoodModel goodModel = new GoodModel();
        public string path { get; set; }
        public ImageSource img { get; set; }

        public void ImgFromURI()
        {
            BitmapImage sourceIMG = new BitmapImage();
            sourceIMG.BeginInit();
            sourceIMG.UriSource = new Uri(path, UriKind.Relative);
            sourceIMG.CacheOption = BitmapCacheOption.OnLoad;
            sourceIMG.EndInit();
            img = sourceIMG;
        }

        public RecommendedGoodsVM(Good tempGood, GoodModel model)
        {
            this.good = tempGood;
            this.goodModel = model;
            path = tempGood.SerialKey + ".jpg";
            if (!File.Exists(path))
            {
                path = "temporary.jpg";
            }
            ImgFromURI();

        }

    }
}
