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

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkspaceAuthentication operation. Use this
    /// operation to define the identity provider (IdP) that this workspace authenticates
    /// users from, using SAML. You can also map SAML assertion attributes to workspace user
    /// information and define which groups in the assertion attribute are to have the <c>Admin</c>
    /// and <c>Editor</c> roles in the workspace. <note> <para> Changes to the authentication
    /// method for a workspace may take a few minutes to take effect. </para> </note>
    /// </summary>
    public partial class UpdateWorkspaceAuthenticationRequest : AmazonManagedGrafanaRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationProviders. 
        /// <para>
        /// Specifies whether this workspace uses SAML 2.0, IAM Identity Center, or both to authenticate
        /// users for using the Grafana console within a workspace. For more information, see
        /// <a href="https://docs.aws.amazon.com/grafana/latest/userguide/authentication-in-AMG.html">User
        /// authentication in Amazon Managed Grafana</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AuthenticationProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthenticationProviders property is set.
        /// </summary>
        internal bool IsSetAuthenticationProviders() => this.AuthenticationProviders != null && (this.AuthenticationProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SamlConfiguration. 
        /// <para>
        /// If the workspace uses SAML, use this structure to map SAML assertion attributes to
        /// workspace user information and define which groups in the assertion attribute are
        /// to have the <c>Admin</c> and <c>Editor</c> roles in the workspace.
        /// </para>
        /// </summary>
        public SamlConfiguration SamlConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SamlConfiguration property is set.
        /// </summary>
        internal bool IsSetSamlConfiguration() => this.SamlConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to update the authentication for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
