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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// This structure defines which groups defined in the SAML assertion attribute are to
    /// be mapped to the Grafana <c>Admin</c> and <c>Editor</c> roles in the workspace. SAML
    /// authenticated users not part of <c>Admin</c> or <c>Editor</c> role groups have <c>Viewer</c>
    /// permission over the workspace.
    /// </summary>
    public partial class RoleValues
    {
        private List<string> _admin = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _editor = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Admin. 
        /// <para>
        /// A list of groups from the SAML assertion attribute to grant the Grafana <c>Admin</c>
        /// role to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> Admin
        {
            get { return this._admin; }
            set { this._admin = value; }
        }

        // Check to see if Admin property is set
        internal bool IsSetAdmin()
        {
            return this._admin != null && (this._admin.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Editor. 
        /// <para>
        /// A list of groups from the SAML assertion attribute to grant the Grafana <c>Editor</c>
        /// role to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> Editor
        {
            get { return this._editor; }
            set { this._editor = value; }
        }

        // Check to see if Editor property is set
        internal bool IsSetEditor()
        {
            return this._editor != null && (this._editor.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}