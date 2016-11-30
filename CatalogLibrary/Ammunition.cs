using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogLibrary
{
   public class Ammunition
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
            //sql = "INSERT INTO Ammo (Brand, Grain, Caliber, PurchaseDate, Quantity, Type) Values(" +
            //        "'test',"+ 40 +",'50','11/29/2016'," + 25 + ",'fmj')";
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

        public DataView DisplayTable()
        {
            connection.Open();
            DataSet dataSet = new DataSet();

            sql = "Select Caliber From Ammo Order by Id";
            //"From Gun Inner Join Ammo ON Gun.AmmoId=Ammo.Id";
            //sql = "Select Make, Model, Type, Caliber, SerialNumber, PurchaseDate From Gun AS G Join Ammo As A ON G.AmmoId=A.Id";
            dataAdapter = new SQLiteDataAdapter(sql, connection);
            dataAdapter.Fill(dataSet);
            connection.Close();
            return dataSet.Tables[0].DefaultView;
        }
        


        //    private string mBrand;
        //    private int mGrain;
        //    private string mCaliber;
        //    private DateTime mPurchaseDate;
        //    private int mQuantity;
        //    private string mType;

        //    public Ammunition(string pBrand, string pCaliber, int pGrain, DateTime pPurchased, int pQuantity, string pType)
        //    {
        //       mBrand = pBrand;
        //        mGrain = pGrain;
        //        mCaliber = pCaliber;
        //        mPurchaseDate = pPurchased;
        //        mQuantity = pQuantity;
        //        mType = pType;
        //    }
        //    public string Brand
        //    {
        //        get
        //        {
        //            return mBrand;
        //        }

        //        set
        //        {
        //            mBrand = value;
        //        }
        //    }

        //    public int Grain
        //    {
        //        get
        //        {
        //            return mGrain;
        //        }

        //        set
        //        {
        //            mGrain = value;
        //        }
        //    }

        //    public string Caliber
        //    {
        //        get
        //        {
        //            return mCaliber;
        //        }

        //        set
        //        {
        //            mCaliber = value;
        //        }
        //    }

        //    public DateTime PurchaseDate
        //    {
        //        get
        //        {
        //            return mPurchaseDate;
        //        }

        //        set
        //        {
        //            mPurchaseDate = value;
        //        }
        //    }

        //    public int Quantity
        //    {
        //        get
        //        {
        //            return mQuantity;
        //        }

        //        set
        //        {
        //            mQuantity = value;
        //        }
        //    }

        //    public string Type
        //    {
        //        get
        //        {
        //            return mType;
        //        }

        //        set
        //        {
        //            mType = value;
        //        }
        //    }
    }
}
