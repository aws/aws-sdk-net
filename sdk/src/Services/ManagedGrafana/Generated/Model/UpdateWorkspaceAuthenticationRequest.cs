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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkspaceAuthentication operation.
    /// Use this operation to define the identity provider (IdP) that this workspace authenticates
    /// users from, using SAML. You can also map SAML assertion attributes to workspace user
    /// information and define which groups in the assertion attribute are to have the <code>Admin</code>
    /// and <code>Editor</code> roles in the workspace.
    /// </summary>
    public partial class UpdateWorkspaceAuthenticationRequest : AmazonManagedGrafanaRequest
    {
        private List<string> _authenticationProviders = new List<string>();
        private SamlConfiguration _samlConfiguration;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property AuthenticationProviders. 
        /// <para>
        /// Specifies whether this workspace uses SAML 2.0, IAM Identity Center (successor to
        /// Single Sign-On), or both to authenticate users for using the Grafana console within
        /// a workspace. For more information, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/authentication-in-AMG.html">User
        /// authentication in Amazon Managed Grafana</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AuthenticationProviders
        {
            get { return this._authenticationProviders; }
            set { this._authenticationProviders = value; }
        }

        // Check to see if AuthenticationProviders property is set
        internal bool IsSetAuthenticationProviders()
        {
            return this._authenticationProviders != null && this._authenticationProviders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SamlConfiguration. 
        /// <para>
        /// If the workspace uses SAML, use this structure to map SAML assertion attributes to
        /// workspace user information and define which groups in the assertion attribute are
        /// to have the <code>Admin</code> and <code>Editor</code> roles in the workspace.
        /// </para>
        /// </summary>
        public SamlConfiguration SamlConfiguration
        {
            get { return this._samlConfiguration; }
            set { this._samlConfiguration = value; }
        }

        // Check to see if SamlConfiguration property is set
        internal bool IsSetSamlConfiguration()
        {
            return this._samlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to update the authentication for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}