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

namespace Amazon.Runtime.CredentialManagement
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
    /// FederatedAWSCredentials     EndpointName RoleArn [UserIdentity]
#if !BCL35
    /// SSO                         SsoAccountId SsoRegion SsoRoleName SsoStartUrl SsoSession
#endif
    /// </summary>
    public class CredentialProfileOptions
    {
        /// <summary>
        /// The access key to be used in the AWSCredentials.
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// The source of credentials to be used to obtain AWSCredentials.
        /// </summary>
        public string CredentialSource { get; set; }
        /// <summary>
        /// The endpoint name to be used for federated AWSCredentials.
        /// </summary>
        public string EndpointName { get; set; }
        /// <summary>
        /// The external id to use in assume role AWSCredentials.
        /// </summary>
        public string ExternalID { get; set; }
        /// <summary>
        /// The serial number of the MFA to use in assume role AWSCredentials.
        /// </summary>
        public string MfaSerial { get; set; }
        /// <summary>The role ARN to use when creating assume role or federated AWSCredentials.</summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// An identifier for the assumed role session.
        /// </summary>
        public string RoleSessionName { get; set; }

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
        /// <summary>
        /// The user identity to use when creating federated AWSCredentials.
        /// If not set, the user identity that the code is running under will be used.
        /// </summary>
        public string UserIdentity { get; set; }
        /// <summary>
        /// Contains the executable information to be used by the process credential retriever
        /// to either fetch Basic or Session credentials
        /// </summary>
        public string CredentialProcess { get; set; }

        /// <summary>
        /// Absolute path to the file on disk containing an OIDC token.
        /// </summary>
        public string WebIdentityTokenFile { get; set; }
        /// <summary>
        /// The name of the section which contains the custom endpoints for a service or services.
        /// For example: 
        /// [profile foo]
        /// services = bar
        /// [services bar]
        /// s3 = 
        ///   endpoint_url = https://custom-endpoint-s3:80
        /// ec2 = 
        ///   endpoint_url = https://custome-endpoint_ec2:80
        /// This will tell the SDK to look for custom endpoints in "bar" for the profile "foo.
        /// A single Services section can contain configurations for multiple services.
        /// </summary>
        public string Services { get; set; }
        /// <summary>
        /// The global endpoint to use for a profile. Service specific endpoints will always override this value.
        /// </summary>
        public string EndpointUrl { get; set; }

#if !BCL35
        /// <summary>
        /// The AWS account ID that temporary AWS credentials will be resolved for using AWS SSO.
        /// </summary>
        public string SsoAccountId { get; set; }

        /// <summary>
        /// The AWS region where the SSO directory for <see cref="SsoStartUrl"/> is hosted.
        /// </summary>
        public string SsoRegion { get; set; }

        /// <summary>
        /// The corresponding IAM role in the AWS account that temporary AWS credentials will be resolved for using AWS SSO.
        /// </summary>
        public string SsoRoleName { get; set; }

        /// <summary>
        /// Name of the Sso Session section used to retrieve <see cref="SsoRegion"/> and
        /// <see cref="SsoStartUrl"/>.
        /// </summary>
        public string SsoSession { get; set; }

        /// <summary>
        /// The main URL for users to login to their SSO directory.
        /// Provided by the SSO service via the web console.
        /// </summary>
        public string SsoStartUrl { get; set; }
#endif
        /// <summary>
        /// Return true the properties are all null or empty, false otherwise.
        /// </summary>
        internal bool IsEmpty
        {
            get
            {
                return
                    string.IsNullOrEmpty(EndpointName) &&
                    string.IsNullOrEmpty(UserIdentity) &&
                    string.IsNullOrEmpty(AccessKey) &&
                    string.IsNullOrEmpty(ExternalID) &&
                    string.IsNullOrEmpty(MfaSerial) &&
                    string.IsNullOrEmpty(RoleArn) &&
                    string.IsNullOrEmpty(RoleSessionName) &&
                    string.IsNullOrEmpty(SecretKey) &&
                    string.IsNullOrEmpty(SourceProfile) &&
                    string.IsNullOrEmpty(Token) &&
                    string.IsNullOrEmpty(CredentialProcess) &&
                    string.IsNullOrEmpty(Services) &&
                    string.IsNullOrEmpty(EndpointUrl) &&
#if !BCL35
                    string.IsNullOrEmpty(SsoAccountId) &&
                    string.IsNullOrEmpty(SsoRegion) &&
                    string.IsNullOrEmpty(SsoRoleName) &&
                    string.IsNullOrEmpty(SsoStartUrl) &&
                    string.IsNullOrEmpty(SsoSession) &&
#endif
                    string.IsNullOrEmpty(WebIdentityTokenFile);
            }
        }
        public override string ToString()
        {
            return
                "[AccessKey=" + AccessKey + ", " +
                "EndpointName=" + EndpointName + ", " +
                "ExternalID=" + ExternalID + ", " +
                "MfaSerial=" + MfaSerial + ", " +
                "RoleArn=" + RoleArn + ", " +
                "RoleSessionName=" + RoleSessionName + ", " +
                "SecretKey=XXXXX, " +
                "SourceProfile=" + SourceProfile + ", " +
                "EndpointUrl=" + EndpointUrl + ", " +
                "Services=" + Services + ", " +
                "Token=" + Token +
                ", " + "UserIdentity=" + UserIdentity +
                ", " + "CredentialProcess=" + CredentialProcess +
                ", " + "WebIdentityTokenFile=" + WebIdentityTokenFile +
#if !BCL35
                ", " + "SsoAccountId=" + SsoAccountId +
                ", " + "SsoRegion=" + SsoRegion +
                ", " + "SsoRoleName=" + SsoRoleName +
                ", " + "SsoStartUrl=" + SsoStartUrl +
                ", " + "SsoSession=" + SsoSession +
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

#if !BCL35
            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey, EndpointName, ExternalID, MfaSerial, RoleArn, RoleSessionName, SecretKey, SourceProfile, Token, UserIdentity, CredentialProcess, WebIdentityTokenFile, SsoAccountId, SsoRegion, SsoRoleName, SsoStartUrl, SsoSession, Services, EndpointUrl },
                new object[] { po.AccessKey, po.EndpointName, po.ExternalID, po.MfaSerial, po.RoleArn, po.RoleSessionName, po.SecretKey, po.SourceProfile, po.Token, po.UserIdentity, po.CredentialProcess, po.WebIdentityTokenFile, po.SsoAccountId, po.SsoRegion, po.SsoRoleName, po.SsoStartUrl, po.SsoSession, po.Services, po.EndpointUrl });
#else
            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey, EndpointName, ExternalID, MfaSerial, RoleArn, RoleSessionName, SecretKey, SourceProfile, Token, UserIdentity, CredentialProcess, WebIdentityTokenFile },
                new object[] { po.AccessKey, po.EndpointName, po.ExternalID, po.MfaSerial, po.RoleArn, po.RoleSessionName, po.SecretKey, po.SourceProfile, po.Token, po.UserIdentity, po.CredentialProcess, po.WebIdentityTokenFile });
#endif
        }

        public override int GetHashCode()
        {
#if !BCL35
            return Hashing.Hash(AccessKey, EndpointName, ExternalID, MfaSerial, RoleArn, RoleSessionName, SecretKey, SourceProfile, Token, UserIdentity, CredentialProcess, WebIdentityTokenFile, SsoAccountId, SsoRegion, SsoRoleName, SsoStartUrl, SsoSession, Services, EndpointUrl);
#else
            return Hashing.Hash(AccessKey, EndpointName, ExternalID, MfaSerial, RoleArn, RoleSessionName, SecretKey, SourceProfile, Token, UserIdentity, CredentialProcess, WebIdentityTokenFile);
#endif
        }
    }
}
