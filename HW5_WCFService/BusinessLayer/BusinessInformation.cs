using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelsLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BusinessInformation
    {
        public static List<ModelsInformation> GetEmpData()
        {
            ModelsInformation EmpInfo = new ModelsInformation();
            var EmpInfoList = new List<ModelsInformation>();

            DataSet dsGetEmpInfo = new DataSet();

            var webService = new InformationService.InformationServiceClient();

            //dsGetEmpInfo = DataAccessInformation.GetEmpInfoUsingDBWithOutConfig();
            //dsGetEmpInfo = DataAccessInformation.GetEmpInfoUsingDBWithConfig();
            
            //using web service to get db data;
            //dsGetEmpInfo = webService.GetDemographicsUsingDBWithOutConfig();
            dsGetEmpInfo = webService.GetDemographicsUsingDBWithConfig();

            if (dsGetEmpInfo.Tables.Count>0)
            {
                EmpInfoList = dsGetEmpInfo.Tables[0].AsEnumerable().Select(m => new ModelsInformation
                {
                    FirstName=Convert.ToString(m["FirstName"]),
                    LastName=Convert.ToString(m["LastName"]),
                    Sex=Convert.ToString(m["Sex"]),
                    Address=Convert.ToString(m["Address"])
                }
                    
                    ).ToList();
            }

            return EmpInfoList;
        }
    }
}
