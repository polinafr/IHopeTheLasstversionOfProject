
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace BL
{
    //how to save graph to pdf
    //predictions: apriory
    public class BLimp : IBL
    {
        public Dictionary<int, Good> GetBoughtGoodsQuantity()
        {
            throw new NotImplementedException();
        }

        public Dictionary<float, Good> GetGoodsRatio()
        {
            throw new NotImplementedException();
        }

        public List<List<Good>> getRecommendations(List<Good> currentBucketsGoods)
        {
            throw new NotImplementedException();
        }

        private List<List<Good>> apriori (List<Good> currentBucket)
        {

        }

        public bool saveToPDF(Dictionary<Good, float> statistics, GraphType type)
        {
            
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Arial", 20, XFontStyle.Bold);
            graph.DrawString("This is my first PDF document", font, XBrushes.Black,
                new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            pdf.Save("C:\\firstpage.pdf");
            return true;


        }
    }
    }

