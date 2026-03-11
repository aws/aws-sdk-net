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
    /// authenticating through AWS Signin.
    /// </summary>
    public class LoginImmutableCredentials : ImmutableCredentials
    {
        /// <summary>
        /// The expiry time of the credentials, obtained from the AWS Signin service.
        /// </summary>
        public DateTime? ExpiresAt { get; private set; }

        /// <summary>
        /// Constructs an instance with supplied keys, token, and expiration.
        /// </summary>
        /// <param name="awsAccessKeyId">The AccessKey for the credentials.</param>
        /// <param name="awsSecretAccessKey">The SecretKey for the credentials.</param>
        /// <param name="sessionToken">The security token for the credentials.</param>
        /// <param name="expiresAt">The expiration time for the credentials.</param>
        public LoginImmutableCredentials(
            string awsAccessKeyId, string awsSecretAccessKey,
            string sessionToken, DateTime? expiresAt) : this(awsAccessKeyId, awsSecretAccessKey, sessionToken, expiresAt, null)
        {
        }

        /// <summary>
        /// Constructs an instance with supplied keys, token, expiration, and account id.
        /// </summary>
        /// <param name="awsAccessKeyId">The AccessKey for the credentials.</param>
        /// <param name="awsSecretAccessKey">The SecretKey for the credentials.</param>
        /// <param name="sessionToken">The security token for the credentials.</param>
        /// <param name="expiresAt">The expiration time for the credentials.</param>
        /// <param name="accountId">The 12-digit number that uniquely identifies an AWS account.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public LoginImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string sessionToken, DateTime? expiresAt, string accountId) : base(awsAccessKeyId, awsSecretAccessKey, sessionToken, accountId)
        {
            if (string.IsNullOrEmpty(sessionToken)) throw new ArgumentNullException(nameof(sessionToken));
            ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Get a copy of this LoginImmutableCredentials object.
        /// </summary>
        /// <returns>A copy of this object as ImmutableCredentials object.</returns>
        public override ImmutableCredentials Copy()
        {
            return new LoginImmutableCredentials(AccessKey, SecretKey, Token, ExpiresAt, AccountId);
        }

        public override int GetHashCode()
        {
            return Hashing.Hash(AccessKey, SecretKey, Token, ExpiresAt, AccountId);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            LoginImmutableCredentials awsLoginImmutableCredentials = obj as LoginImmutableCredentials;
            if (awsLoginImmutableCredentials == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey, SecretKey, Token, ExpiresAt, AccountId },
                new object[] { awsLoginImmutableCredentials.AccessKey, awsLoginImmutableCredentials.SecretKey, awsLoginImmutableCredentials.Token, ExpiresAt, AccountId });
        }
    }
}
