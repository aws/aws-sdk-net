using System;
using System.Collections.Generic;
using System.Text;
using Amazon.Runtime.Internal.UserAgent;

namespace Amazon.Runtime
{
    public static class PaginatorUtils
    {
        public static void SetUserAgentAdditionOnRequest(AmazonWebServiceRequest request)
        {
            request.UserAgentDetails.AddFeature(UserAgentFeatureId.PAGINATOR);
        }
    }
}
