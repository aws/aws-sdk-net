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
    /// Immutable representation of AWS credentials obtained as a result of
    /// authenticating through AWS SSO.
    /// </summary>
    public class SSOImmutableCredentials : ImmutableCredentials
    {
        /// <summary>
        /// The expiry time of the credentials, obtained from the AWS SSO service.
        /// </summary>
        public DateTime Expiration { get; private set; }

        /// <summary>
        /// Constructs an instance with supplied keys, token, and expiration.
        /// </summary>
        /// <param name="awsAccessKeyId">The AccessKey for the credentials.</param>
        /// <param name="awsSecretAccessKey">The SecretKey for the credentials.</param>
        /// <param name="token">The security token for the credentials.</param>
        /// <param name="expiration">The expiration time for the credentials.</param>
        public SSOImmutableCredentials(
            string awsAccessKeyId, string awsSecretAccessKey,
            string token, DateTime expiration) : this(awsAccessKeyId, awsSecretAccessKey, token, expiration, null)
        {
        }

        /// <summary>
        /// Constructs an instance with supplied keys, token, expiration, and account id.
        /// When the account id is set and the service supports account id based endpoints, 
        /// AWS will send the request using the account-based endpoint rather than the regional endpount. 
        /// Account-based endpoints take the form https://<paramref name="accountId"/>.ddb.region.amazonaws.com
        /// </summary>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="token"></param>
        /// <param name="expiration"></param>
        /// <param name="accountId">The account id for the credentials. The account id is your 12 digit account number with no hyphens. For example: 123456789012.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SSOImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, DateTime expiration, string accountId) : base(awsAccessKeyId, awsSecretAccessKey, token, accountId)
        {
            if (string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));
            Expiration = expiration;
        }

        /// <summary>
        /// Get a copy of this SSOImmutableCredentials object.
        /// </summary>
        /// <returns>A copy of this object.</returns>
        public new SSOImmutableCredentials Copy()
        {
            return new SSOImmutableCredentials(AccessKey, SecretKey, Token, Expiration, AccountId);
        }

        public override int GetHashCode()
        {
            return Hashing.Hash(AccessKey, SecretKey, Token, Expiration, AccountId);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            SSOImmutableCredentials ssoImmutableCredentials = obj as SSOImmutableCredentials;
            if (ssoImmutableCredentials == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey, SecretKey, Token, Expiration, AccountId },
                new object[] { ssoImmutableCredentials.AccessKey, ssoImmutableCredentials.SecretKey, ssoImmutableCredentials.Token, Expiration, AccountId });
        }
    }
}
