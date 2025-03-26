using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.UserAgent;

namespace Amazon.Runtime
{
    public static class PaginatorUtils
    {
        public static void SetUserAgentAdditionOnRequest(AmazonWebServiceRequest request)
        {
            ((IAmazonWebServiceRequest)request).UserAgentDetails.AddFeature(UserAgentFeatureId.PAGINATOR);
        }
    }
}
