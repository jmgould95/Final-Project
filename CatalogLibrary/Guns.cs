﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
/// <summary>
/// Jimmy Gould
/// Final Project
/// 12/05/2016
/// This class library does all the SQL commands for Guns
/// </summary>
namespace CatalogLibrary
{
    public class Guns
    {
        public string LastStatus;
        //Use the following for testing within Visual Studio
        private const string dbGun = "Data Source = C:/Users/Jimmy/Documents/Advanced Visual Basic/FinalProject_JimmyGould/CatalogLibrary/GunDB.db; Version = 3";

        //Use the following for deployment.
        //private const string dbEMPLOYEES = "Data Source = CSIndustries.db; Version = 3";

        SQLiteConnection connection = new SQLiteConnection(dbGun);
        SQLiteDataAdapter dataAdapter;
        SQLiteCommand command;

        DataSet ds = new DataSet();
        String sql;

        //This is never Used
        public DataSet ExecuteQuery(string sql)
        {
            ds.Clear();
            DateTime time = DateTime.Now;
            //sql = "INSERT INTO Gun (Make, Model, Type, SerialNumber, DatePurchased, AmmoId) Values(" +
            //        "'test',' test  ',' Pistol','12346','11/29/2016'," + 1 + ")";
            try
            {
                connection.Open();
                dataAdapter = new SQLiteDataAdapter(sql, connection);
                dataAdapter.Fill(ds);
                connection.Close();
                LastStatus = "Succeed";
            }
            catch (Exception ex)
            {
                ds = null;
                LastStatus = "Fail";
            }

            return ds;
        }

        //Finds Gun By name
        public DataView FindByName(string pMake)
        {
            connection.Open();
            DataSet dataSet = new DataSet();
            DateTime time = DateTime.Now;
            sql = "Select gunId, Make, Model, GunType, Caliber, SerialNumber, PurchaseDate From Gun AS G  Join Ammo As A ON G.AmmoId=A.Id Where G.Make ='" + pMake + "'";
            //sql = "Select * from Gun Where Make = '" + pMake + "'";
            try
            {
                dataAdapter = new SQLiteDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet);
                connection.Close();
                LastStatus = "Succeed";
            }
            catch (Exception ex)
            {
                ds = null;
                LastStatus = "Fail";
            }
            
            return dataSet.Tables[0].DefaultView;
        }

        //finds compatable Guns by searching ammo id
        public DataView FindCompatableGuns(int pAmmoId)
        {
            connection.Open();
            DataSet dataSet = new DataSet();
            DateTime time = DateTime.Now;
            sql = "Select gunId, Make, Model, GunType, Caliber, SerialNumber, PurchaseDate From Gun AS G  Join Ammo As A ON G.AmmoId=A.Id Where G.AmmoId =" + pAmmoId + "";
            //sql = "Select * from Gun Where Make = '" + pMake + "'";
            try
            {
                dataAdapter = new SQLiteDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet);
                connection.Close();
                LastStatus = "Succeed";
            }
            catch (Exception ex)
            {
                ds = null;
                LastStatus = "Fail";
            }

            return dataSet.Tables[0].DefaultView;
        }

        //gets the total guns that have the same ammo Id and returns the count as a string
        public string TotalCompatableGuns(int pAmmoId)
        {
            int Total;
            connection.Open();
            DataSet dataSet = new DataSet();

            sql = "Select Count(AmmoId)Id From Gun Where AmmoId =" + pAmmoId + "";
            command = connection.CreateCommand();
            command.CommandText = sql;


            //object caliber =  command.ExecuteScalarAsync;
            // int test = int.Parse(caliber);

            Total = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return Total.ToString();
        }

        //Adds a gun to the database
        public DataSet AddGun(string pMake, string pModel, string pType, string pPurchaseDate, string pSerialNum, int pAmmoId)
        {
            ds.Clear();
            DateTime time = DateTime.Now;
            sql = "INSERT INTO Gun (Make, Model, GunType, SerialNumber, DatePurchased, AmmoId) Values(" +
                    "'"+pMake+"','"+pModel+  "','"+ pType+"','"+pSerialNum+"','"+pPurchaseDate+"'," + pAmmoId + ")";
            try
            {
                connection.Open();
                dataAdapter = new SQLiteDataAdapter(sql, connection);
                dataAdapter.Fill(ds);
                connection.Close();
                LastStatus = "Succeed";
            }
            catch (Exception ex)
            {
                ds = null;
                LastStatus = "Fail";
            }

            return ds;
        }

        //updates the gun table
        public DataSet UpdateGun(string pMake, string pModel, string pType, string pPurchaseDate, string pSerialNum, int pAmmoId, int pId)
        {
            ds.Clear();
            DateTime time = DateTime.Now;
            //sql = "Update Gun Set(Make, Model, GunType, SerialNumber, DatePurchased, AmmoId) Values(" +
            //        "'" + pMake + "','" + pModel + "','" + pType + "','" + pSerialNum + "','" + pPurchaseDate + "'," + pAmmoId + ") Where Id = "+pId;
            sql = "Update Gun Set Make ='" + pMake + "', Model='"+pModel+ "', GunType ='" + pType+ 
                "', SerialNumber ='" + pSerialNum+ "', DatePurchased = '"+pPurchaseDate+ "', AmmoId ="+pAmmoId+" Where gunId =" + pId+"";
            try
            {
                connection.Open();
                dataAdapter = new SQLiteDataAdapter(sql, connection);
                dataAdapter.Fill(ds);
                connection.Close();
                LastStatus = "Succeed";
            }
            catch (Exception ex)
            {
                ds = null;
                LastStatus = "Fail";
            }

            return ds;
        }

        

        //this returns the ammo Id as an Int
        public int AmmoId(string pCaliber)
        {
            int caliber;
            connection.Open();
            DataSet dataSet = new DataSet();

            sql = "Select Id From Ammo Where Caliber ='"+pCaliber+"'";
            command = connection.CreateCommand();
            command.CommandText = sql;


           //object caliber =  command.ExecuteScalarAsync;
           // int test = int.Parse(caliber);

            caliber= Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return caliber;
        }

        //displays the gun table with an inner join to show the caliber
        public DataView DisplayTable()
        {
            connection.Open();
            DataSet dataSet = new DataSet();

            //sql = "Select * From Gun ORDER BY Make";
            //"From Gun Inner Join Ammo ON Gun.AmmoId=Ammo.Id";
            try
            {
                sql = "Select gunId, Make, Model, GunType, Caliber, SerialNumber, PurchaseDate From Gun AS G Join Ammo As A ON G.AmmoId=A.Id";
                dataAdapter = new SQLiteDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet);
                connection.Close();
                return dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        //deletes gun form the gun table
        public bool DeleteGun(int pId)
        {
            ds.Clear();
            sql = "Delete from Gun Where gunId =" + pId + "";
            try
            {
                connection.Open();
                dataAdapter = new SQLiteDataAdapter(sql, connection);
                dataAdapter.Fill(ds);
                connection.Close();
                LastStatus = "Succeed";
            }
            catch (Exception ex)
            {
                ds = null;
                LastStatus = "Fail";

                return false;
            }

            return true;
        }

        //private string mMake;
        //private string mModel;
        //private string mType;
        //private string mSerialNum;
        //private int mAmmoID;
        //private DateTime mPurchaseDate;


        //public Gun(string pMake, string pModel, string pSerialNum, string pType, DateTime pPurchaseDate, int pAmmoID)
        //{
        //    mMake = pMake;
        //   mModel = pModel;
        //    mSerialNum = pSerialNum;
        //    mType = pType;
        //    mPurchaseDate = pPurchaseDate;
        //    mAmmoID = pAmmoID;

        //}

        //public string Make
        //{
        //    get
        //    {
        //        return mMake;
        //    }

        //    set
        //    {
        //        mMake = value;
        //    }
        //}

        //public string Model
        //{
        //    get
        //    {
        //        return Model;
        //    }

        //    set
        //    {
        //        mModel = value;
        //    }
        //}

        //public string Type
        //{
        //    get
        //    {
        //        return mType;
        //    }

        //    set
        //    {
        //        mType = value;
        //    }
        //}

        //public DateTime PurchaseDate
        //{
        //    get
        //    {
        //        return mPurchaseDate;
        //    }

        //    set
        //    {
        //        mPurchaseDate = value;
        //    }
        //}

        //public string SerialNum
        //{
        //    get
        //    {
        //        return mSerialNum;
        //    }

        //    set
        //    {
        //        mSerialNum = value;
        //    }
        //}

        //public int AmmoID
        //{
        //    get
        //    {
        //        return mAmmoID;
        //    }

        //    set
        //    {
        //        mAmmoID = value;
        //    }
        //}
    }
}
