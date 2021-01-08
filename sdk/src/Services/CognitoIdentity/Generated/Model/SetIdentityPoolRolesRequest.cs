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

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the SetIdentityPoolRoles operation.
    /// Sets the roles for an identity pool. These roles are used when making calls to <a>GetCredentialsForIdentity</a>
    /// action.
    /// 
    ///  
    /// <para>
    /// You must use AWS Developer credentials to call this API.
    /// </para>
    /// </summary>
    public partial class SetIdentityPoolRolesRequest : AmazonCognitoIdentityRequest
    {
        private string _identityPoolId;
        private Dictionary<string, RoleMapping> _roleMappings = new Dictionary<string, RoleMapping>();
        private Dictionary<string, string> _roles = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleMappings. 
        /// <para>
        /// How users for a specific identity provider are to mapped to roles. This is a string
        /// to <a>RoleMapping</a> object map. The string identifies the identity provider, for
        /// example, "graph.facebook.com" or "cognito-idp-east-1.amazonaws.com/us-east-1_abcdefghi:app_client_id".
        /// </para>
        ///  
        /// <para>
        /// Up to 25 rules can be specified per identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public Dictionary<string, RoleMapping> RoleMappings
        {
            get { return this._roleMappings; }
            set { this._roleMappings = value; }
        }

        // Check to see if RoleMappings property is set
        internal bool IsSetRoleMappings()
        {
            return this._roleMappings != null && this._roleMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        /// The map of roles associated with this pool. For a given role, the key will be either
        /// "authenticated" or "unauthenticated" and the value will be the Role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2)]
        public Dictionary<string, string> Roles
        {
            get { return this._roles; }
            set { this._roles = value; }
        }

        // Check to see if Roles property is set
        internal bool IsSetRoles()
        {
            return this._roles != null && this._roles.Count > 0; 
        }

    }
}