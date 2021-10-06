using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using UI.Commands;
using UI.MVVM.Model;
using UI.UC;

namespace UI.MVVM.VM
{
    public class GoodVM : INotifyPropertyChanged, IVM
    {

        private GoodModel goodM;

        public event PropertyChangedEventHandler PropertyChanged;

        public string path { get; set; }
        private ImageSource img;

        public ImageSource ProductImage
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
                if (null != PropertyChanged)
                    PropertyChanged(this, new PropertyChangedEventArgs("ProductImage"));
            }
        }

        public string Description
        {
            get
            {
                return Product.Description;
            }
            set
            {
                Product.Description = value;
                if (null != PropertyChanged)
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }

        public int Rating
        {
            get
            {
                return Product.Rating;
            }
            set
            {
                Product.Rating = value;
                if (null != PropertyChanged)
                    PropertyChanged(this, new PropertyChangedEventArgs("Rating"));
            }
        }
        public Good Product { get; set; }

        public GoodVM (Good good, GoodModel goodModel)
        {
            Product = good;
            this.goodM = goodModel;
            UpdateProduct = new UpdateGoodCMD();
            UpdateProduct.UpdateEvent += Item_UpdateEvent;
            path = Product.SerialKey + ".jpg";
            if (!File.Exists(path))
            {
                path = "newImage.jpg";
            }
            LoadImageFromURI();
        }

        public void LoadImageFromURI()
        {
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri(path, UriKind.Relative);
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.EndInit();
            ProductImage = src;
        }




        public UpdateGoodCMD UpdateGood { get; set; }

        public void Item_UpdateEvent()
        {
            goodM.UpdateGood(Product);
        }







    }

}
