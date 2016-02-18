using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace InformationService
{

    [ServiceContract]
    public interface IInformationService
    {

        [OperationContract]
        DataSet GetDemographicsUsingDBWithConfig();

        [OperationContract]
        DataSet GetDemographicsUsingDBWithOutConfig();
    }
}
