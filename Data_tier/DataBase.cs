using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_tier
{
    public class DataBase
    {
        private SqlDataReader reader;
        private SqlCommand command;
        private SqlConnection Connection
        {
            get
            {
                var con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EKGDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                return con;
            }
        }

        public DataBase()
        {
        }

        //public List<EKGData> GetEKGData1()
        //{
        //    command = new SqlCommand("select * from dbo.PhysionNet");
        //    List<EKGData> ekgData = new List<EKGData>();
        //    Connection.Open();
        //    command = new SqlCommand("select * from dbo.PhysionNet where PNID='");
        //    reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        ekgData.Add(new EKGData((double)reader["PNData"]));
        //    }
        //    Connection.Close();
        //    return ekgData;
        //}

        public List<EKGData> GetEkgData(int id)
        {
            List<EKGData> ekgList = new List<EKGData>();

            string selectString = "select*from dbo.PhysioNet where PNID='" + 1 + "'";

            using (SqlCommand command = new SqlCommand(selectString, Connection))
            {
                reader = command.ExecuteReader();
            }
            while (reader.Read())
            {
                //ekgList.Add(new EKGData(Convert.(reader["PNData"])));
            }

            return ekgList;
        }
    }
}
