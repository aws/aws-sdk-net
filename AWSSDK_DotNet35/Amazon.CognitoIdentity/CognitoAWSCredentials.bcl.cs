using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

using Amazon.CognitoIdentity.Model;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Temporary, short-lived session credentials that are automatically retrieved from
    /// Amazon Cognito Identity Service and AWS Security Token Service.
    /// Depending on configured Logins, credentials may be authenticated or unauthenticated.
    /// </summary>
    public partial class CognitoAWSCredentials : RefreshingAWSCredentials
    {
        private Credentials GetStsCredentials(AssumeRoleWithWebIdentityRequest assumeRequest)
        {
            var assumeResult = sts.AssumeRoleWithWebIdentity(assumeRequest);
            var credentials = assumeResult.Credentials;
            return credentials;
        }

        private GetOpenIdTokenResponse GetOpenId(GetOpenIdTokenRequest getTokenRequest)
        {
            var getTokenResult = cib.GetOpenIdToken(getTokenRequest);
            return getTokenResult;
        }
    }
}