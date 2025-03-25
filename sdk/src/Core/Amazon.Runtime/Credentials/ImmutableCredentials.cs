/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;

namespace Amazon.Runtime
{
    /// <summary>
    /// Immutable representation of AWS credentials.
    /// </summary>
    public class ImmutableCredentials
    {
        #region Properties

        /// <summary>
        /// Gets the AccessKey property for the current credentials.
        /// </summary>
        public string AccessKey { get; private set; }

        /// <summary>
        /// Gets the SecretKey property for the current credentials.
        /// </summary>
        public string SecretKey { get; private set; }

        /// <summary>
        /// Gets the Token property for the current credentials.
        /// </summary>
        public string Token { get; private set; }


        /// <summary>
        /// Gets the UseToken property for the current credentials.
        /// Specifies if Token property is non-empty.
        /// </summary>
        public bool UseToken { get { return !string.IsNullOrEmpty(Token); } }

        /// <summary>
        /// Gets the AccountId property for the current credentials.
        /// The account id is your 12 digit account number with no hypens. For example: 123456789012.
        /// When the account id is set and the service supports account id based endpoints, AWS will send the request 
        /// using the account-based endpoint rather than the regional endpount. 
        /// Account-based endpoints take the form https://accountid.ddb.region.amazonaws.com
        /// </summary>
        public string AccountId { get; private set; }
        #endregion


        #region Constructors

        /// <summary>
        /// Constructs an ImmutableCredentials object with supplied accessKey, secretKey.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token">Optional. Can be set to null or empty for non-session credentials.</param>
        public ImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId)) throw new ArgumentNullException("awsAccessKeyId");
            if (string.IsNullOrEmpty(awsSecretAccessKey)) throw new ArgumentNullException("awsSecretAccessKey");

            AccessKey = awsAccessKeyId;
            SecretKey = awsSecretAccessKey;

            Token = token ?? string.Empty;
            
        }

        /// <summary>
        /// Constructs an ImmutableCredentials object with supplied accessKey, secretKey, and aws account id.
        /// When the account id is set and the service supports account id based endpoints, AWS will send the request 
        /// using the account-based endpoint rather than the regional endpount. 
        /// Account-based endpoints take the form https://<paramref name="accountId"/>.ddb.region.amazonaws.com
        /// </summary>
        /// <param name="awsAccessKeyId">The access key for the credentials.</param>
        /// <param name="awsSecretAccessKey">The secret access key for the credentials.</param>
        /// <param name="token">Optional. Can be set to null or empty for non-session credentials.</param>
        /// <param name="accountId">Optional. If <see cref="AccountIdEndpointMode"/> is set to preferred or required, the account id will be used in endpoint resolution.
        /// The account id is your 12 digit account number with no hyphens. For example: 123456789012.</param>
        public ImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, string accountId) : this(awsAccessKeyId, awsSecretAccessKey, token)
        {
            AccountId = accountId;
        }

        private ImmutableCredentials() { }

        #endregion


        #region Public methods

        /// <summary>
        /// Returns a copy of the current credentials.
        /// </summary>
        /// <returns></returns>
        public virtual ImmutableCredentials Copy()
        {
            ImmutableCredentials credentials = new ImmutableCredentials
            {
                AccessKey = this.AccessKey,
                SecretKey = this.SecretKey,
                Token = this.Token,
                AccountId = this.AccountId
            };
            return credentials;
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return Hashing.Hash(AccessKey, SecretKey, Token);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            ImmutableCredentials ic = obj as ImmutableCredentials;
            if (ic == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey, SecretKey, Token },
                new object[] { ic.AccessKey, ic.SecretKey, ic.Token });
        }

        #endregion
    }

}
