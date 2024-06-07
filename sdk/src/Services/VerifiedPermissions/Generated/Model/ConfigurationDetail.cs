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

/*
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains configuration information about an identity source.
    /// 
    ///  
    /// <para>
    /// This data type is a response parameter to the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_GetIdentitySource.html">GetIdentitySource</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class ConfigurationDetail
    {
        private CognitoUserPoolConfigurationDetail _cognitoUserPoolConfiguration;
        private OpenIdConnectConfigurationDetail _openIdConnectConfiguration;

        /// <summary>
        /// Gets and sets the property CognitoUserPoolConfiguration. 
        /// <para>
        /// Contains configuration details of a Amazon Cognito user pool that Verified Permissions
        /// can use as a source of authenticated identities as entities. It specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of a Amazon Cognito user pool, the policy store entity that
        /// you want to assign to user groups, and one or more application client IDs.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"configuration":{"cognitoUserPoolConfiguration":{"userPoolArn":"arn:aws:cognito-idp:us-east-1:123456789012:userpool/us-east-1_1a2b3c4d5","clientIds":
        /// ["a1b2c3d4e5f6g7h8i9j0kalbmc"],"groupConfiguration": {"groupEntityType": "MyCorp::Group"}}}</c>
        /// 
        /// </para>
        /// </summary>
        public CognitoUserPoolConfigurationDetail CognitoUserPoolConfiguration
        {
            get { return this._cognitoUserPoolConfiguration; }
            set { this._cognitoUserPoolConfiguration = value; }
        }

        // Check to see if CognitoUserPoolConfiguration property is set
        internal bool IsSetCognitoUserPoolConfiguration()
        {
            return this._cognitoUserPoolConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIdConnectConfiguration. 
        /// <para>
        /// Contains configuration details of an OpenID Connect (OIDC) identity provider, or identity
        /// source, that Verified Permissions can use to generate entities from authenticated
        /// identities. It specifies the issuer URL, token type that you want to use, and policy
        /// store entity details.
        /// </para>
        ///  
        /// <para>
        /// Example:<c>"configuration":{"openIdConnectConfiguration":{"issuer":"https://auth.example.com","tokenSelection":{"accessTokenOnly":{"audiences":["https://myapp.example.com","https://myapp2.example.com"],"principalIdClaim":"sub"}},"entityIdPrefix":"MyOIDCProvider","groupConfiguration":{"groupClaim":"groups","groupEntityType":"MyCorp::UserGroup"}}}</c>
        /// 
        /// </para>
        /// </summary>
        public OpenIdConnectConfigurationDetail OpenIdConnectConfiguration
        {
            get { return this._openIdConnectConfiguration; }
            set { this._openIdConnectConfiguration = value; }
        }

        // Check to see if OpenIdConnectConfiguration property is set
        internal bool IsSetOpenIdConnectConfiguration()
        {
            return this._openIdConnectConfiguration != null;
        }

    }
}