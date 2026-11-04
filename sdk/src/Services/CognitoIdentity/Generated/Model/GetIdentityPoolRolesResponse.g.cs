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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetIdentityPoolRoles operation.
    /// </summary>
    public partial class GetIdentityPoolRolesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property RoleMappings. 
        /// <para>
        /// How users for a specific identity provider are to mapped to roles. This is a String-to-<a>RoleMapping</a>
        /// object map. The string identifies the identity provider, for example, <c>graph.facebook.com</c>
        /// or <c>cognito-idp.us-east-1.amazonaws.com/us-east-1_abcdefghi:app_client_id</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, RoleMapping> RoleMappings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, RoleMapping>() : null;

        /// <summary>
        /// Checks to see if the RoleMappings property is set.
        /// </summary>
        internal bool IsSetRoleMappings() => this.RoleMappings != null && (this.RoleMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        /// The map of roles associated with this pool. Currently only authenticated and unauthenticated
        /// roles are supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public Dictionary<string, string> Roles { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Roles property is set.
        /// </summary>
        internal bool IsSetRoles() => this.Roles != null && (this.Roles.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
