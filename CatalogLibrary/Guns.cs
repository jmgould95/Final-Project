using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

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
        public DataView DisplayTable()
        {
            connection.Open();
            DataSet dataSet = new DataSet();

            //sql = "Select * From Gun ORDER BY Make";
            //"From Gun Inner Join Ammo ON Gun.AmmoId=Ammo.Id";
            try
            {
                sql = "Select Make, Model, GunType, Caliber, SerialNumber, PurchaseDate From Gun AS G Join Ammo As A ON G.AmmoId=A.Id";
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
