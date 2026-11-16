using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SageMakerInferenceRouterRuntime;
using Amazon.SageMakerInferenceRouterRuntime.Model;

namespace AWSSDKDocSamples.Amazon.SageMakerInferenceRouterRuntime.Generated
{
    class SageMakerInferenceRouterRuntimeSamples : ISample
    {
        public void SageMakerInferenceRouterRuntimeInvokeInferenceRouter()
        {
            #region InvokeInferenceRouter-1

            var client = new AmazonSageMakerInferenceRouterRuntimeClient();
            var response = client.InvokeInferenceRouter(new InvokeInferenceRouterRequest
            {
                Body = new MemoryStream({"instances": [[1.0, 2.0, 5.0]]}),
                ContentType = "application/json",
                InferenceRouterName = "my-router",
                RoutingTargetName = "my-target"
            });

            string contentType = response.ContentType;
            string routingReason = response.RoutingReason;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
