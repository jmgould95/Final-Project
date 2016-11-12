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
            MMake = pMake;
            MModel = pModel;
            MSerialNum = pSerialNum;
            MType = pType;
            MPurchaseDate = pPurchaseDate;
            MAmmoID = pAmmoID;

        }

        public string MMake
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

        public string MModel
        {
            get
            {
                return mModel;
            }

            set
            {
                mModel = value;
            }
        }

        public string MType
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

        public DateTime MPurchaseDate
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

        public string MSerialNum
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

        public int MAmmoID
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
