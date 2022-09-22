using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoComponent dc = new DemoComponent();
            Console.Write("");
            //dc.sqlDataAdapter1.Fill(dc.stockDataset1);
            //dc.stockDataset1.WriteXml("C:\\Users\\B.Arunkumar\\source\\repos\\SoleraFiles\\product.xml");
            //dc.stockDataset1.WriteXmlSchema("C:\\Users\\B.Arunkumar\\source\\repos\\SoleraFiles\\product123.xsd");
            //Console.WriteLine("Data exported to xml");
            dc.stockDataset1.ReadXmlSchema("C:\\Users\\B.Arunkumar\\source\\repos\\SoleraFiles\\product123.xsd");
            dc.stockDataset1.ReadXml("\\Users\\B.Arunkumar\\source\\repos\\SoleraFiles\\product.xml");

            Console.WriteLine("Data Read from xml");

            //ProductDBManager pm = new ProductDBManager();
            //bool sts = true;
            //while (sts)
            //{
            //    int ch = pm.Menu();
            //    switch (ch)
            //    {
            //        case 1:pm.AddProduct();
            //            break;
            //        case 2:pm.EditProduct();
            //            break;
            //        case 3:pm.RemoveProduct();
            //            break;
            //        case 4:pm.FindProduct();
            //            break;
            //        case 5:pm.ListProduct();
            //            break;
            //        case 6:sts = false;
            //            break;
            //        default:Console.WriteLine("Enter valid choice");
            //            break;
            //    }
            //}
        }
    }
}
