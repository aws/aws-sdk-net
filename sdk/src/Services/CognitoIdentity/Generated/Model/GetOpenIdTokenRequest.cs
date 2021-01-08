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
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the GetOpenIdToken operation.
    /// Gets an OpenID token, using a known Cognito ID. This known Cognito ID is returned
    /// by <a>GetId</a>. You can optionally add additional logins for the identity. Supplying
    /// multiple logins creates an implicit link.
    /// 
    ///  
    /// <para>
    /// The OpenId token is valid for 10 minutes.
    /// </para>
    ///  
    /// <para>
    /// This is a public API. You do not need any credentials to call this API.
    /// </para>
    /// </summary>
    public partial class GetOpenIdTokenRequest : AmazonCognitoIdentityRequest
    {
        private string _identityId;
        private Dictionary<string, string> _logins = new Dictionary<string, string>();

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
        /// A set of optional name-value pairs that map provider names to provider tokens. When
        /// using graph.facebook.com and www.amazon.com, supply the access_token returned from
        /// the provider's authflow. For accounts.google.com, an Amazon Cognito user pool provider,
        /// or any other OpenId Connect provider, always include the <code>id_token</code>.
        /// </para>
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
            return this._logins != null && this._logins.Count > 0; 
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}