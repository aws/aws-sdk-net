﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// Credentials that are retrieved by invoking AWS Security Token Service
    /// AssumeRole or AssumeRoleWithSAML action.
    /// </summary>
    [Obsolete("This class has been replaced by Amazon.Runtime.AssumeRoleAWSCredentials and Amazon.Runtime.StoredProfileFederatedCredentials, and will be removed in a future version.", false)]
    public partial class STSAssumeRoleAWSCredentials : RefreshingAWSCredentials
    {
#if !UNITY
        private IAmazonSecurityTokenService _stsClient;
#else
        private AmazonSecurityTokenServiceClient _stsClient;
#endif
        private AssumeRoleRequest _assumeRequest;
        private AssumeRoleWithSAMLRequest _assumeSamlRequest;
        private bool _isDisposed = false;
        private static TimeSpan _defaultPreemptExpiryTime = TimeSpan.FromMinutes(5);

        /// <summary>
        /// Instantiates STSAssumeRoleAWSCredentials which automatically assumes a specified role.
        /// The credentials are refreshed before expiration.
        /// </summary>
        /// <param name="sts">
        /// Instance of IAmazonSecurityTokenService that will be used to make the AssumeRole service call.
        /// </param>
        /// <param name="assumeRoleRequest">Configuration for the role to assume.</param>
        public STSAssumeRoleAWSCredentials(IAmazonSecurityTokenService sts, AssumeRoleRequest assumeRoleRequest)
        {
            if (sts == null) throw new ArgumentNullException("sts");
            if (assumeRoleRequest == null) throw new ArgumentNullException("assumeRoleRequest");
#if !UNITY
            _stsClient = sts;
#else
            _stsClient = (AmazonSecurityTokenServiceClient)sts;
#endif
            _assumeRequest = assumeRoleRequest;
            PreemptExpiryTime = _defaultPreemptExpiryTime;
        }

        /// <summary>
        /// Instantiates STSAssumeRoleAWSCredentials which automatically assumes a specified SAML role.
        /// The credentials are refreshed before expiration.
        /// </summary>
        /// <param name="assumeRoleWithSamlRequest">Configuration for the SAML role to assume.</param>
        public STSAssumeRoleAWSCredentials(AssumeRoleWithSAMLRequest assumeRoleWithSamlRequest)
        {
            if (assumeRoleWithSamlRequest == null) throw new ArgumentNullException("assumeRoleWithSamlRequest");

            _stsClient = new AmazonSecurityTokenServiceClient(new AnonymousAWSCredentials());
            _assumeSamlRequest = assumeRoleWithSamlRequest;
            PreemptExpiryTime = _defaultPreemptExpiryTime;
        }

        /// <summary>
        /// Generate new credentials.
        /// </summary>
        /// <returns></returns>
        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            Credentials credentials = GetServiceCredentials();
            return new CredentialsRefreshState
            {
                Expiration = credentials.Expiration,
                Credentials = credentials.GetCredentials()
            };
        }

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected override void Dispose(bool disposing)
        {
            if (!this._isDisposed)
            {
                if (disposing && _stsClient != null)
                {
                    _stsClient.Dispose();
                    _stsClient = null;
                }
                this._isDisposed = true;

                base.Dispose(disposing);
            }
        }

        #endregion
    }
}
