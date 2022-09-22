using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace productDemo
{
    class ProductDBManager
    {
        DemoComponent dc = null;
        public ProductDBManager()
        {
            dc = new DemoComponent();
            dc.sqlDataAdapter1.Fill(dc.stockDataset1);
        }
        public int Menu()
        {
            Console.WriteLine("1.New Product");
            Console.WriteLine("2.Edit Product");
            Console.WriteLine("3.Delete Product");
            Console.WriteLine("4.Find Product");
            Console.WriteLine("5.List Product");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Please enter your choice:");
            int ch = int.Parse(Console.ReadLine());
            return ch;
        }
        public void AddProduct()
        {
            int pid;
            string pname;
            float price;
            int qty;
            Console.WriteLine("Enter product id\t:\t");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Name\t:\t");
            pname = Console.ReadLine();
            Console.WriteLine("Enter product price\t:\t");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter avaliable quantity\t:\t");
            qty = int.Parse(Console.ReadLine());

            DataRow dr = dc.stockDataset1.Tables[0].NewRow();
            dr[0] = pid;
            dr[1] = pname;
            dr[2] = price;
            dr[3] = qty;
            dc.stockDataset1.Tables[0].Rows.Add(dr);
            dc.sqlDataAdapter1.Update(dc.stockDataset1);
            Console.WriteLine("Record inserted succesfully");

        }

        public void EditProduct()
        {
            int pid;
            string pname;
            float price;
            int qty;

            Console.WriteLine("Enter product id\t:\t");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Name\t:\t");
            pname = Console.ReadLine();
            Console.WriteLine("Enter product price\t:\t");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter avaliable quantity\t:\t");
            qty = int.Parse(Console.ReadLine());

            DataRow dr = dc.stockDataset1.Tables[0].Rows.Find(pid);
            if (dr != null)
            {
                dr[1] = pname;
                dr[2] = price;
                dr[3] = qty;
                dc.sqlDataAdapter1.Update(dc.stockDataset1);
                Console.WriteLine("Record updated succesfully");
            }
            else
            {
                Console.WriteLine("Record not found to update");
            }
         
        }
        public void RemoveProduct()
        {
            int pid;
            Console.WriteLine("Enter product id\t:\t");
            pid = int.Parse(Console.ReadLine());
           
            DataRow dr = dc.stockDataset1.Tables[0].Rows.Find(pid);
            if (dr != null){
                dr.Delete();
                dc.sqlDataAdapter1.Update(dc.stockDataset1);
                Console.WriteLine("Record Deeleted succesfully");
            }
            else
            {
                Console.WriteLine("Record not found to delete");
            }

        }
        public void FindProduct()
        {
            int pid;
            Console.WriteLine("Enter product id\t:\t");
            pid = int.Parse(Console.ReadLine());

            DataRow dr = dc.stockDataset1.Tables[0].Rows.Find(pid);
            if (dr != null)
            {
                Console.WriteLine("ID\tNAME\tPRICE\tQUANTITY");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}");
                Console.WriteLine("----------------------------------------------------");
                dc.sqlDataAdapter1.Update(dc.stockDataset1);
                Console.WriteLine("Record found succesfully");

            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }
        public void ListProduct()
        {
            if (dc.stockDataset1.Tables[0].Rows.Count>0)
            {
                Console.WriteLine("ID\tNAME\tPRICE\tQUANTITY");
                Console.WriteLine("----------------------------------------------------");
                foreach(DataRow dr in dc.stockDataset1.Tables[0].Rows)
                Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}");
                Console.WriteLine("----------------------------------------------------");
                dc.sqlDataAdapter1.Update(dc.stockDataset1);
                Console.WriteLine("Records retrived succesfully");
            }
            else
            {
                Console.WriteLine("no product data is present");
            }

        }
    }
}
