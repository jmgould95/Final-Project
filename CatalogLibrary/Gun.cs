using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogLibrary
{
    public class Gun
    {
        private string mMake;
        private string mModel;
        private string mType;
        private string mSerialNum;
        private int mAmmoID;
        private DateTime mPurchaseDate;


        public Gun(string pMake, string pModel, string pSerialNum, string pType, DateTime pPurchaseDate, int pAmmoID)
        {
            mMake = pMake;
           mModel = pModel;
            mSerialNum = pSerialNum;
            mType = pType;
            mPurchaseDate = pPurchaseDate;
            mAmmoID = pAmmoID;

        }

        public string Make
        {
            get
            {
                return mMake;
            }

            set
            {
                mMake = value;
            }
        }

        public string Model
        {
            get
            {
                return Model;
            }

            set
            {
                mModel = value;
            }
        }

        public string Type
        {
            get
            {
                return mType;
            }

            set
            {
                mType = value;
            }
        }

        public DateTime PurchaseDate
        {
            get
            {
                return mPurchaseDate;
            }

            set
            {
                mPurchaseDate = value;
            }
        }

        public string SerialNum
        {
            get
            {
                return mSerialNum;
            }

            set
            {
                mSerialNum = value;
            }
        }

        public int AmmoID
        {
            get
            {
                return mAmmoID;
            }

            set
            {
                mAmmoID = value;
            }
        }
    }
}
