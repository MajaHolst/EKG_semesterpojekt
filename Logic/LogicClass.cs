using System;
using System.Collections.Generic;
using Data_tier;
using Logic;


namespace Logic
{
    public class LogicClass
    {
        //private EKGData _ekgData = new EKGData();

        //public List<EKGData> getEKGData()
        //{
        //    return _ekgData.getEKGData();
        //}

        // ændret til database

        private DataBase _dataObject;
        

        public LogicClass()
        {
            _dataObject = new DataBase();
        }

        public List<EKGData> GetDataBases(int id)
        {
            return _dataObject.GetEkgData(id);
        }
    }
}
