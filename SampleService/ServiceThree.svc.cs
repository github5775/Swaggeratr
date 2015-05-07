using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceThree" in code, svc and config file together.
    // NOTE: In order to launch
    [ServiceContract]
    [Swaggerator.Attributes.Swaggerated("/tertiary", "Endpoint w/o interface")]
    //WCF Test Client for testing this service, please select ServiceThree.svc or ServiceThree.svc.cs at the Solution Explorer and start debugging.
    public class ServiceThree : IDisposable
    {

        [WebGet(UriTemplate = "/work", ResponseFormat = WebMessageFormat.Json)]
        public string DoWork()
        {
            return Environment.MachineName + ": " + DateTime.Now.ToString();
        }

        [WebGet(UriTemplate = "/work2?what={workId}", ResponseFormat = WebMessageFormat.Json)]
        public string DoWork2(int workId)
        {
            return Environment.MachineName + "(" + workId.ToString() + "): " + DateTime.Now.ToString();
        }

        [WebGet(UriTemplate = "/work3?whatnow={date}", ResponseFormat = WebMessageFormat.Json)]
        public string DoWork3(DateTime date)
        {
            return Environment.MachineName + "(" + date.ToString() + "): " + date.DayOfWeek;
        }

        public void Dispose()
        {
            //
        }

    }
}
