
using DAL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using BL.Apriory;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace BL
{
    //how to save graph to pdf
    //predictions: apriory
    public class BLimp : IBL
    {
        IDAL myDAL;
        public Dictionary<Good, int> GetBoughtGoodsQuantity()
        {
            List<Good> allGoods = getListOfGoods();
            Dictionary<Good, int> statistics = new Dictionary<Good, int>();
            foreach (Good good in allGoods)
            {
                statistics.Add(good, 0);
            }
            List<Bucket> allBuckets = new List<Bucket>();
            foreach(Bucket bucket in allBuckets)
            {
                foreach(Good good in bucket.Goods)
                {
                    statistics[good] += 1;
                }
            }
            return statistics;
        }

        public Dictionary<Good, float> GetGoodsRatio()
        {
            Dictionary<Good, int> statistics = GetBoughtGoodsQuantity();
            // get total quantity of bought goods
            float sum = 0;
            foreach(KeyValuePair<Good, int> pair in statistics)
            {
                sum += pair.Value;
            }
            Dictionary<Good, float> ratio = new Dictionary<Good, float>();
            foreach (KeyValuePair<Good, int> pair in statistics)
            {
                ratio.Add(pair.Key, pair.Value / sum);
            }
            return ratio;
        }

        public List<List<Good>> getRecommendations(List<Good> currentBucketsGoods)
        {
            throw new NotImplementedException();
        }

        private List<List<Good>> apriori (List<Good> currentBucket)
        {
            throw new NotImplementedException();
        }

        public bool saveToPDF(Dictionary<Good, float> statistics, GraphType type)
        {

            PdfPTable table = new PdfPTable(2);

            PdfPCell cell = new PdfPCell(new Phrase("Item Name"));

            cell.Colspan = 1;

            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right

            table.AddCell(cell);
            PdfPCell cell2 = new PdfPCell(new Phrase("Best Day"));

            cell2.Colspan = 1;

            cell2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right

            table.AddCell(cell2);
            foreach (var tuple in tuples)
            {
                int quantity = 0;
                int maxQuantity = 0;
                DayOfWeek dayOfWeek = new DayOfWeek();
                /*foreach (DayOfWeek day in days)
                {
                    List<Item> items = idal.getAllItems(y => y.Date_of_purchase.DayOfWeek == day && y.SerialKey == tuple.Item1);
                    foreach (var item in items)
                    {
                        quantity += item.Quantity;
                    }
                    if (quantity > maxQuantity)
                    {
                        maxQuantity = quantity;
                        dayOfWeek = day;
                    }
                }*/
                table.AddCell(tuple.Item2);
                table.AddCell(dayOfWeek.ToString());

            }
            Document doc = new Document(PageSize.A4, 7f, 5f, 5f, 0f);
            doc.AddTitle("Machine Learning results");
            PdfWriter.GetInstance(doc, new FileStream(AppDomain.CurrentDomain.BaseDirectory + "Recommended Days.pdf", FileMode.Create));
            doc.Open();
            //     Paragraph p1 = new Paragraph(text);
            //   doc.Add(p1);

            doc.Add(table);
            Font x = FontFactory.GetFont("nina fett");

            x.Size = 19;

            x.SetStyle("Italic");

            x.SetColor(0, 42, 255);


            Paragraph c2 = new Paragraph(@"Based on our recommendations for which products to buy on which  day", x);
            c2.IndentationLeft = 30;
            doc.Add(c2);


            doc.Close();


        }
        public void Initialize()
        {
            //Firebase Connection
        }

        public List<Good> getListOfGoods(Func<Good, bool> condition)
        {
            List<Good> allGoods = getListOfGoods();
            return allGoods.Where(condition).ToList();
        }

        public List<Good> getListOfGoods()
        {
            return myDAL.getAllGoods();
        }

        public List<Bucket> getListOfBuckets(Func<Bucket, bool> condition)
        {
            List<Bucket> allBuckets = getListOfBuckets();
            return allBuckets.Where(condition).ToList();
        }

        public List<Bucket> getListOfBuckets()
        {
            return myDAL.getAllBuckets();
        }


        public void CreateRecommendationsPDF()
        {
            throw new NotImplementedException();
        }

        public bool UpdateGood(Good good)
        {
            try
            {
                myDAL.UpdateGood(good);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public BLimp()
        {
            myDAL = new DALimp();
        }

        void IBL.AddGood(Good good) {
            myDAL.AddGood(good);
        }

        
    }
    }

