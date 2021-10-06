using UI.Commands;
using UI.MVVM.Model;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

namespace UI.MVVM.VM
{
    public class RecommendationVM
    {
        public PDFCreationCMD RecommendationsINPDF { get; set; }
       // public CreatePDFCommand CreatePDFDays { get; set; }
        public string Pop_UpMessage { get; set; }
        public bool PopUpEnabled { get; set; }

        public Queue<string> PDFMessageQueue { get; set; }

        public string recommendationString = "לדעתנו המוצרים הבאים יעניינו אותך ";
        GoodModel goodModel = new GoodModel();
        public ObservableCollection<RecommendedGoodsVM> Goods { get; set; }

        public RecommendationVM()
        {
            
            RecommendationsINPDF = new PDFCreationCMD();
            //CreatePDFDays = new CreatePDFCommand();
            RecommendationsINPDF.GeneratePdfEvent += CreatePDFStores_function;
            //CreatePDFDays.GeneratePdfEvent += CreatePDFDays_function;
            getCollection();
            PopUpEnabled = false;
            PDFMessageQueue = new Queue<string>();
        }

        public void CreatePDF()
        {
            goodModel.CreateRecommendations();
            PDFMessageQueue.Enqueue("Recommendations saved");
            PDFMessageQueue.Enqueue("path: " + AppDomain.CurrentDomain.BaseDirectory + "Recommendations.pdf");
        }


        private void getCollection()
        {
            Goods = new ObservableCollection<RecommendedGoodsVM>();
            foreach (var item in goodModel.GetRecommendations())
            {
                Goods.Add(new RecommendedGoodsVM(new Good(item), goodModel));
            }
        }
    }
}
