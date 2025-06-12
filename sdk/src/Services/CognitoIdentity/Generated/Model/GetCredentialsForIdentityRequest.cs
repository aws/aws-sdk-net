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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
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
namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the GetCredentialsForIdentity operation.
    /// Returns credentials for the provided identity ID. Any provided logins will be validated
    /// against supported login providers. If the token is for <c>cognito-identity.amazonaws.com</c>,
    /// it will be passed through to Security Token Service with the appropriate role for
    /// the token.
    /// 
    ///  
    /// <para>
    /// This is a public API. You do not need any credentials to call this API.
    /// </para>
    /// </summary>
    public partial class GetCredentialsForIdentityRequest : AmazonCognitoIdentityRequest
    {
        private string _customRoleArn;
        private string _identityId;
        private Dictionary<string, string> _logins = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CustomRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to be assumed when multiple roles were
        /// received in the token from the identity provider. For example, a SAML-based identity
        /// provider. This parameter is optional for identity providers that do not support role
        /// customization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomRoleArn
        {
            get { return this._customRoleArn; }
            set { this._customRoleArn = value; }
        }

        // Check to see if CustomRoleArn property is set
        internal bool IsSetCustomRoleArn()
        {
            return this._customRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// A unique identifier in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string IdentityId
        {
            get { return this._identityId; }
            set { this._identityId = value; }
        }

        // Check to see if IdentityId property is set
        internal bool IsSetIdentityId()
        {
            return this._identityId != null;
        }

        /// <summary>
        /// Gets and sets the property Logins. 
        /// <para>
        /// A set of optional name-value pairs that map provider names to provider tokens. The
        /// name-value pair will follow the syntax "provider_name": "provider_user_identifier".
        /// </para>
        ///  
        /// <para>
        /// Logins should not be specified when trying to get credentials for an unauthenticated
        /// identity.
        /// </para>
        ///  
        /// <para>
        /// The Logins parameter is required when using identities associated with external identity
        /// providers such as Facebook. For examples of <c>Logins</c> maps, see the code examples
        /// in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/external-identity-providers.html">External
        /// Identity Providers</a> section of the Amazon Cognito Developer Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public Dictionary<string, string> Logins
        {
            get { return this._logins; }
            set { this._logins = value; }
        }

        // Check to see if Logins property is set
        internal bool IsSetLogins()
        {
            return this._logins != null && (this._logins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}