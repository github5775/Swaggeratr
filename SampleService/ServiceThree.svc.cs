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
    [Swaggerator.Attributes.Swaggerated("/tertiary", "Endpoint w/o interface")]
    //WCF Test Client for testing this service, please select ServiceThree.svc or ServiceThree.svc.cs at the Solution Explorer and start debugging.
    public class ServiceThree : IDisposable
    {
       
        [WebGet(UriTemplate = "/work", ResponseFormat = WebMessageFormat.Json)]
        public string DoWork()
        {
            return DateTime.Now.ToString();
        }

        public void Dispose()
        {
            //
        }

    }
}
