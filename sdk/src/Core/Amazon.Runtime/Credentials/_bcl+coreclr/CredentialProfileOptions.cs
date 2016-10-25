/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Runtime
{
    /// <summary>
    /// The options that are available for creating AWSCredentials with the AWSCredentialsFactory.
    /// The type of AWSCredentials that are created depends on which Options are set.
    ///
    /// Below are the different types of credentials returned, along with the options that are used to obtain them.
    /// ([] denotes options that are not required)
    ///
    /// BasicAWSCredentials         AccessKey SecretKey
    /// SessionAWSCredentials       AccessKey SecretKey Token
    /// AssmeRoleAWSCredentials     SourceProfile RoleArn [ExternalID] [MfaSerial]
#if BCL
    /// FederatedAWSCredentials     EndpointName RoleArn [UserIdentity]
#endif
    /// </summary>
    public class CredentialProfileOptions
    {
        /// <summary>
        /// The access key to be used in the AWSCredentials.
        /// </summary>
        public string AccessKey { get; set; }
#if BCL
        /// <summary>
        /// The endpoint name to be used for SAML AWSCredentials.
        /// </summary>
        public string EndpointName { get; set; }
#endif
        /// <summary>
        /// The external id to use in assume role AWSCredentials.
        /// </summary>
        public string ExternalID { get; set; }
        /// <summary>
        /// The serial number of the MFA to use in assume role AWSCredentials.
        /// </summary>
        public string MfaSerial { get; set; }
        /// <summary>
#if BCL
        /// The role ARN to use when creating assume role or SAML AWSCredentials.
#else
        /// The role ARN to use when creating assume role AWSCredentials.
#endif
        /// </summary>
        public string RoleArn { get; set; }
        /// <summary>
        /// The secret key to use when creating AWSCredentials.
        /// </summary>
        public string SecretKey { get; set; }
        /// <summary>
        /// When this CredentialProfileOptions object references another CredentialProfile,
        /// the name of the referenced CredentialProfile.
        /// </summary>
        public string SourceProfile { get; set; }
        /// <summary>
        /// The session token to be used to create AWSCredentials.
        /// </summary>
        public string Token { get; set; }
#if BCL
        /// <summary>
        /// The user identity to use when creating SAML AWSCredentials.
        /// </summary>
        public string UserIdentity { get; set; }
#endif

        public override string ToString()
        {
            return
                "[AccessKey=" + AccessKey + ", " +
#if BCL
                "EndpointName=" + EndpointName + ", " +
#endif
                "ExternalID=" + ExternalID + ", " +
                "MfaSerial=" + MfaSerial + ", " +
                "RoleArn=" + RoleArn + ", " +
                "SecretKey=XXXXX, " +
                "SourceProfile=" + SourceProfile + ", " +
                "Token=" + Token +
#if BCL
                ", " + "UserIdentity=" + UserIdentity +
#endif
                "]";
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            var po = obj as CredentialProfileOptions;
            if (po == null)
                return false;

#if BCL
            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey,  EndpointName, ExternalID, MfaSerial, RoleArn, SecretKey, SourceProfile, Token, UserIdentity},
                new object[] { po.AccessKey, po.EndpointName, po.ExternalID, po.MfaSerial, po.RoleArn, po.SecretKey, po.SourceProfile, po.Token, po.UserIdentity });
#else
            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey, ExternalID, MfaSerial, RoleArn, SecretKey, SourceProfile, Token},
                new object[] { po.AccessKey, po.ExternalID, po.MfaSerial, po.RoleArn, po.SecretKey, po.SourceProfile, po.Token });
#endif
        }

        public override int GetHashCode()
        {
#if BCL
            return Hashing.Hash(AccessKey, EndpointName, ExternalID, MfaSerial, RoleArn, SecretKey, SourceProfile, Token, UserIdentity);
#else
            return Hashing.Hash(AccessKey, ExternalID, MfaSerial, RoleArn, SecretKey, SourceProfile, Token);
#endif
        }
    }
}
