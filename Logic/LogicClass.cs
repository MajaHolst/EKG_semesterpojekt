using System;
using System.Collections.Generic;
using Data_tier;
using Logic;


namespace Logic
{
    public class LogicClass
    {
        private EKGData _ekgData = new EKGData();

        public List<EKGData> getEKGData()
        {
            return _ekgData.GetEKGData();
        }

        // ændret til database

        //private EKGData _dataObject;


        //public LogicClass()
        //{
        //    _dataObject = new EKGData();
        //}

        //public List<EKGData> GetDataBases(int id)
        //{
        //    return _dataObject.GetEKGData();
        //}
    }
}
