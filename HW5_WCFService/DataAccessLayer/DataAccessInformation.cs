using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace DataAccessLayer
{
    public class DataAccessInformation
    {
        public static DataSet GetEmpInfoUsingDBWithConfig()
        {

            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;
            DataTable dt = new DataTable();
            DataSet dsGetEmpInfo = new DataSet();

            //string cs = ConfigurationManager.ConnectionStrings["DemographicsConnection"].ConnectionString;

            var num = ConfigurationManager.ConnectionStrings.Count;

            var cs = ConfigurationManager.ConnectionStrings["EmpInfoConnection"].ConnectionString;
            
            cnn = new SqlConnection(cs);
            sql = "Select * from IndividualDemographics";

            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetEmpInfo.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetEmpInfo;
        }

        public static DataSet GetEmpInfoUsingDBWithOutConfig()
        {
            string connetionString = null;

            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;
            DataTable dt = new DataTable();
            DataSet dsGetEmpList = new DataSet();

            connetionString = "Data Source=MELSACERINNJ;Initial Catalog=employee;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);

            sql = "Select * from IndividualDemographics";

            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetEmpList.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetEmpList;
        }
    }
}
