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
using Amazon.Runtime.Internal.UserAgent;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;

namespace Amazon.Runtime
{
    /// <summary>
    /// Session credentials consisting of AccessKey, SecretKey and Token
    /// </summary>
    public class SessionAWSCredentials : AWSCredentials
    {
        #region Public constructors

        /// <summary>
        /// Constructs a SessionAWSCredentials object for the specified accessKey, secretKey.
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token"></param>
        public SessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token) : this(awsAccessKeyId, awsSecretAccessKey, token, null)
        {
        }

        /// <summary>
        /// Constructs a SessionAWSCredentials object for the specified accessKey, secretKey, and account id.
        /// When the account id is set and the service supports account id based endpoints, AWS will send the request 
        /// using the account-based endpoint rather than the regional endpount. 
        /// Account-based endpoints take the form https://<paramref name="accountId"/>.ddb.region.amazonaws.com
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token"></param>
        /// <param name="accountId">The account id for the credentials. The account id is your 12 digit account number with no hyphens. For example: 123456789012.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, string accountId)
        {
            if (string.IsNullOrEmpty(awsAccessKeyId)) throw new ArgumentNullException("awsAccessKeyId");
            if (string.IsNullOrEmpty(awsSecretAccessKey)) throw new ArgumentNullException("awsSecretAccessKey");
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException("token");
            _lastCredentials = new ImmutableCredentials(awsAccessKeyId, awsSecretAccessKey, token, accountId);
            FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_STS_SESSION_TOKEN);
        }

        #endregion

        #region Credentials data

        private ImmutableCredentials _lastCredentials;

        #endregion

        #region Abstract class overrides

        /// <summary>
        /// Returns an instance of ImmutableCredentials for this instance
        /// </summary>
        /// <returns></returns>
        public override ImmutableCredentials GetCredentials()
        {
            return _lastCredentials;
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            var sac = obj as SessionAWSCredentials;
            if (sac == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { _lastCredentials },
                new object[] { sac._lastCredentials });
        }

        public override int GetHashCode()
        {
            return Hashing.Hash(_lastCredentials);
        }
    }
}
