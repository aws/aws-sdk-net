using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MWAA;
using Amazon.MWAA.Model;

namespace AWSSDKDocSamples.Amazon.MWAA.Generated
{
    class MWAASamples : ISample
    {
        public void MWAAInvokeRestApi()
        {
            #region InvokeRestApi-1

            var client = new AmazonMWAAClient();
            var response = client.InvokeRestApi(new InvokeRestApiRequest
            {
                Method = "GET",
                Name = "MyEnvironment",
                Path = "/variables"
            });

            global::Amazon.Runtime.Documents.Document restApiResponse = response.RestApiResponse;
            int? restApiStatusCode = response.RestApiStatusCode;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
