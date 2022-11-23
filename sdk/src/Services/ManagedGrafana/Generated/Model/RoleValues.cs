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
    /// This structure defines which groups defined in the SAML assertion attribute are to
    /// be mapped to the Grafana <code>Admin</code> and <code>Editor</code> roles in the workspace.
    /// SAML authenticated users not part of <code>Admin</code> or <code>Editor</code> role
    /// groups have <code>Viewer</code> permission over the workspace.
    /// </summary>
    public partial class RoleValues
    {
        private List<string> _admin = new List<string>();
        private List<string> _editor = new List<string>();

        /// <summary>
        /// Gets and sets the property Admin. 
        /// <para>
        /// A list of groups from the SAML assertion attribute to grant the Grafana <code>Admin</code>
        /// role to.
        /// </para>
        /// </summary>
        public List<string> Admin
        {
            get { return this._admin; }
            set { this._admin = value; }
        }

        // Check to see if Admin property is set
        internal bool IsSetAdmin()
        {
            return this._admin != null && this._admin.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Editor. 
        /// <para>
        /// A list of groups from the SAML assertion attribute to grant the Grafana <code>Editor</code>
        /// role to.
        /// </para>
        /// </summary>
        public List<string> Editor
        {
            get { return this._editor; }
            set { this._editor = value; }
        }

        // Check to see if Editor property is set
        internal bool IsSetEditor()
        {
            return this._editor != null && this._editor.Count > 0; 
        }

    }
}