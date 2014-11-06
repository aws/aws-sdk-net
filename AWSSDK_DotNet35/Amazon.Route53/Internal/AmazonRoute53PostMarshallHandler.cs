using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Route53.Internal
{
    public class AmazonRoute53PostMarshallHandler : GenericHandler
    {
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            ProcessRequestHandlers(executionContext);
        }

        /// <summary>
        /// Remove duplicates in resource path which can happen if the exact return values from the CreateHostedZone
        /// operation are used.
        /// </summary>
        /// <param name="executionContext">Execution context.</param>
        private static void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;

            if (request.ResourcePath.Contains("/hostedzone//hostedzone/"))
            {
                request.ResourcePath = request.ResourcePath.Replace("/hostedzone//hostedzone/", "/hostedzone/");
            }
            if (request.ResourcePath.Contains("/change//change/"))
            {
                request.ResourcePath = request.ResourcePath.Replace("/change//change/", "/change/");
            }
            if (request.ResourcePath.Contains("/delegationset//delegationset/"))
            {
                request.ResourcePath = request.ResourcePath.Replace("/delegationset//delegationset/", "/delegationset/");
            }
        }
    }
}
