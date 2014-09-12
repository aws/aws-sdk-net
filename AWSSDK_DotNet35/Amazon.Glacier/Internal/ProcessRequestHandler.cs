using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Glacier.Internal
{
    public class ProcessRequestHandler : GenericHandler
    {
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            if (request.ResourcePath != null)
            {
                if (request.ResourcePath.StartsWith("//", StringComparison.Ordinal))
                {
                    request.ResourcePath = "/-" + request.ResourcePath.Substring(1);
                }
            }
            request.Headers["x-amz-glacier-version"] = "2012-06-01";
        }
    }
}
