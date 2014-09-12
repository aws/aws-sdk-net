using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util;

namespace Amazon.S3.Encryption.Internal
{
    /// <summary>
    /// Adds the crypto token to the user agent
    /// </summary>
    public class UserAgentHandler : GenericHandler
    {
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            string currentUserAgent = request.Headers[AWSSDKUtils.UserAgentHeader];
            request.Headers[AWSSDKUtils.UserAgentHeader] = currentUserAgent + " S3Crypto";
        }
    }
}
