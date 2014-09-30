using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;

using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// Assumed role credentials retrieved and automatically refreshed from
    /// an instance of IAmazonSecurityTokenService.
    /// </summary>
    public partial class STSAssumeRoleAWSCredentials : RefreshingAWSCredentials, IDisposable
    {
        private Credentials GetServiceCredentials()
        {
            Credentials credentials;

            if (_assumeRequest != null)
                credentials = Amazon.Runtime.Internal.Util.AsyncHelpers.RunSync<AssumeRoleResponse>(() => _stsClient.AssumeRoleAsync(_assumeRequest)).Credentials;
            else
                credentials = Amazon.Runtime.Internal.Util.AsyncHelpers.RunSync<AssumeRoleWithSAMLResponse>(() => _stsClient.AssumeRoleWithSAMLAsync(_assumeSamlRequest)).Credentials;

            return credentials;
        }
    }
}
