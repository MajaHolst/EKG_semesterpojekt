using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class DataBase
    {
        private SqlConnection connection= new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EKGDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private SqlDataReader reader;
        private SqlCommand command;
        private const string DBAccess="EKGDB";

        public DataBase(){}

        public List<EKGData> GetEGKData(string id)
        {
            command = new SqlCommand("select * from dbo.PhysionNet");
            List<EKGData> ekgData = new List<EKGData>();
            connection.Open();
            command = new SqlCommand("select * from dbo.PhysionNet where PNID=" + id);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ekgData.Add(new EKGData((double)reader["PNData"]));
            }
            connection.Close();
            return ekgData;
        }
    }
}
