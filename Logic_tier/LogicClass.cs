using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_tier;

namespace Logic_tier
{
    public class LogicClass
    {
        private EKGData _EKGData = new EKGData();
        public List<EKGData> getEKGData1()
        {
            return _EKGData.getEKGData();// tilføjet 
        } 
    }
}
