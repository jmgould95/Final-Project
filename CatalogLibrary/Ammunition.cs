using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogLibrary
{
    class Ammunition
    {
        private string mBrand;
        private int mGrain;
        private string mCaliber;
        private DateTime mPurchaseDate;
        private int mQuantity;
        private int mGunID;

        public Ammunition(string pBrand, string pCaliber, int pGrain, DateTime pPurchased, int pQuantity, int pGunID)
        {
           mBrand = pBrand;
            mGrain = pGrain;
            mCaliber = pCaliber;
            mPurchaseDate = pPurchased;
            mQuantity = pQuantity;
            mGunID = pGunID;
        }
        public string Brand
        {
            get
            {
                return mBrand;
            }

            set
            {
                mBrand = value;
            }
        }

        public int Grain
        {
            get
            {
                return mGrain;
            }

            set
            {
                mGrain = value;
            }
        }

        public string Caliber
        {
            get
            {
                return mCaliber;
            }

            set
            {
                mCaliber = value;
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

        public int Quantity
        {
            get
            {
                return mQuantity;
            }

            set
            {
                mQuantity = value;
            }
        }

        public int GunID
        {
            get
            {
                return mGunID;
            }

            set
            {
                mGunID = value;
            }
        }
    }
}
