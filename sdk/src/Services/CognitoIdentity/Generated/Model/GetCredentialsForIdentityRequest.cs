/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the GetCredentialsForIdentity operation.
    /// Returns credentials for the provided identity ID. Any provided logins will be validated
    /// against supported login providers. If the token is for cognito-identity.amazonaws.com,
    /// it will be passed through to AWS Security Token Service with the appropriate role
    /// for the token.
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
        private Dictionary<string, string> _logins = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CustomRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to be assumed when multiple roles were
        /// received in the token from the identity provider. For example, a SAML-based identity
        /// provider. This parameter is optional for identity providers that do not support role
        /// customization.
        /// </para>
        /// </summary>
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
        /// A set of optional name-value pairs that map provider names to provider tokens.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Logins
        {
            get { return this._logins; }
            set { this._logins = value; }
        }

        // Check to see if Logins property is set
        internal bool IsSetLogins()
        {
            return this._logins != null && this._logins.Count > 0; 
        }

    }
}