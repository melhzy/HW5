using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using DataAccessLayer;
using ModelsLayer;

namespace InformationService
{

    public class InformationService : IInformationService
    {
        public DataSet GetDemographicsUsingDBWithConfig()
        {
            return DataAccessInformation.GetEmpInfoUsingDBWithConfig();
        }

        public DataSet GetDemographicsUsingDBWithOutConfig()
        {
            return DataAccessInformation.GetEmpInfoUsingDBWithOutConfig();
        }
    }
}
