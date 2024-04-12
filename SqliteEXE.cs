using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace WindowsFormsApp1
{
    public class SqliteEXE
    {
        public static String Path = "";

        public static string CreateDB(string Name)
        {
            //添加数据库
            Path = "./" + Name + ".db";
            SQLiteConnection.CreateFile(Path);
            CreateTable(true, Path);
            return Path;


        }

        public static void SetPath(string Name)
        {
            Path = "./" + Name + ".db";
        }

        public static void CreateTable(bool default1, string Path)
        {
            //添加数据表和初始类
            if (default1)
            {
                SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);

                try
                {
                    if (SqliteConnect.State != System.Data.ConnectionState.Open)
                    {
                        SqliteConnect.Open();
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.Connection = SqliteConnect;
                        cmd.CommandText = "Create Table Product (ProductID INTEGER PRIMARY KEY, ProductName varchar(200))";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "Create Table ProductDetail (ID INTEGER PRIMARY KEY, ProductID int, Sell float, Mark varchar(200), Supplier varchar(200))";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "Create Table Cart (CartID INTEGER PRIMARY KEY, ProductDetailID int)";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "Create Table Record (RecordID INTEGER PRIMARY KEY, ProductDetailID int, Name varchar(200),Phone1 varchar(200), Phone2 varchar(200), Country varchar(200), Address varchar(200), Payment float )";
                        cmd.ExecuteNonQuery();
                        SqliteConnect.Close();
                        SQLiteProductInsert("Mobile Phone");
                        SQLiteProductInsert("Computer");
                        SQLiteProductInsert("Tablet");
                        SQLiteProductInsert("Battery Pack");
                        SQLiteProductInsert("Desktop");
                        SQLiteProductDetailInsert(1, 1000, "备注1", "ASUS");
                        SQLiteProductDetailInsert(2, 1100, "备注2", "ASUS");
                        SQLiteProductDetailInsert(3, 1200, "备注3", "ASUS");
                        SQLiteProductDetailInsert(4, 1300, "备注4", "ASUS");
                        SQLiteProductDetailInsert(5, 1400, "备注5", "ASUS");
                        SQLiteProductDetailInsert(1, 1500, "备注1", "LG");
                        SQLiteProductDetailInsert(2, 1600, "备注2", "LG");
                        SQLiteProductDetailInsert(3, 1700, "备注3", "LG");
                        SQLiteProductDetailInsert(4, 1800, "备注4", "LG");
                        SQLiteProductDetailInsert(5, 1900, "备注5", "LG");
                        SQLiteProductDetailInsert(1, 2000, "备注1", "Samsung");
                        SQLiteProductDetailInsert(2, 2100, "备注2", "Samsung");
                        SQLiteProductDetailInsert(3, 2200, "备注3", "Samsung");
                        SQLiteProductDetailInsert(4, 2300, "备注4", "Samsung");
                        SQLiteProductDetailInsert(5, 2400, "备注5", "Samsung");




                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("创建初始表失败，请检测数据库");


                }


            }
        }

        public static void SQLiteProductInsert(string ProductName)
        //添加类
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);
            try
            {
                if (SqliteConnect.State != System.Data.ConnectionState.Open)
                {
                    string sql1 = "insert into Product(ProductName) values('" + ProductName + "')";
                    SqliteConnect.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = SqliteConnect;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    SqliteConnect.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("创建初始表失败，请检测数据库");


            }
        }

        public static void InsertIntoCart(int ProductDetailID)
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);
            try
            {
                if (SqliteConnect.State != System.Data.ConnectionState.Open)
                {
                    string sql1 = "insert into Cart (ProductDetailID) values(" + ProductDetailID + ")";
                    SqliteConnect.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = SqliteConnect;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    SqliteConnect.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("创建初始表失败，请检测数据库");


            }
        }


        public static void SQLiteProductDetailInsert(int id, float Sell, string Mark, string Supplier)
        //添加类
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);
            try
            {
                if (SqliteConnect.State != System.Data.ConnectionState.Open)
                {
                    string sql1 = "insert into ProductDetail (ProductID, Sell, Mark, Supplier) values(" + id + ", " + Sell + ",'" + Mark + "','" + Supplier + "')";
                    SqliteConnect.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = SqliteConnect;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    SqliteConnect.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("创建初始表失败，请检测数据库");


            }
        }

        public static void Clear_Cart()
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + SqliteEXE.Path);
            try
            {
                string sql1 = "delete from Cart";
                SqliteConnect.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = SqliteConnect;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
                SqliteConnect.Close();
                Form1.Sell = 0;
                Form1.CartCount = 0;


            }
            catch (Exception ex)
            {
                throw new Exception("清空购物车失败，请检测数据库");


            }
        }

        public static void DeleteIntoCart(int ID)
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);
            try
            {
                if (SqliteConnect.State != System.Data.ConnectionState.Open)
                {
                    string sql1 = "delete from Cart where CartID = " + ID;
                    SqliteConnect.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = SqliteConnect;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    SqliteConnect.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("购物车移去失败，请检测数据库");


            }
        }

        public static void DeleteIntoProduct(int ID)
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);
            try
            {
                if (SqliteConnect.State != System.Data.ConnectionState.Open)
                {
                    string sql1 = "delete from ProductDetail where ID = " + ID;
                    SqliteConnect.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = SqliteConnect;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    SqliteConnect.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("购物车移去失败，请检测数据库");


            }
        }

        public static void InsertIntoProduct(string product2)
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);
            try
            {
                if (SqliteConnect.State != System.Data.ConnectionState.Open)
                {
                    string sql1 = "insert into Product(ProductName) Values('" + product2 + "')";
                    SqliteConnect.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = SqliteConnect;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    SqliteConnect.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("商品分类添加失败，请检测数据库");


            }
        }

        public static void InsertIntoProductDetail(string product, string supplier, string price, string mark)
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);
            try
            {
                if (SqliteConnect.State != System.Data.ConnectionState.Open)
                {
                    string sql1 = $@" insert into ProductDetail(ProductID, Sell, Mark, Supplier) Values( (select productID from product where ProductName = '" + product + "' Limit 1), " + price
                        + ",'" + mark + "','" + supplier + "')";
                    SqliteConnect.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = SqliteConnect;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    SqliteConnect.Close();
                    MessageBox.Show("添加商品成功");

                }
            }
            catch (Exception ex)
            {
                throw new Exception("商品分类添加失败，请检测数据库");


            }
        }

        public static void insertintoRecord(string id1, string name, string phone1, string phone2, string Address, string country)
        {
            SQLiteConnection SqliteConnect = new SQLiteConnection("data source=" + Path);
            try
            {
                if (SqliteConnect.State != System.Data.ConnectionState.Open)
                {
                    string sql1 = $@" insert into Record(ProductDetailID,Name, Phone1,Phone2, Country, Address, Payment) Values(" + id1 + " , '" + name + "', '" + phone1
                        + "','" + phone2 + "','" + country + "','" + Address + "'," + Form1.Sell + ")";
                    SqliteConnect.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = SqliteConnect;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    SqliteConnect.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("记录添加失败，请检测数据库");


            }
        }
    }
}



