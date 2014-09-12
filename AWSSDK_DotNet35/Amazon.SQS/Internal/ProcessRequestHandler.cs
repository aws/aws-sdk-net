using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.SQS.Model;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Internal
{
    public class ProcessRequestHandler : GenericHandler
    {
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            if (request.Parameters.ContainsKey("QueueUrl"))
            {
                string queueUrl = request.Parameters["QueueUrl"];
                Uri uri = new Uri(queueUrl);
                request.Parameters.Remove("QueueUrl");
                request.ResourcePath = uri.AbsolutePath;
            }
        }
    }
}
