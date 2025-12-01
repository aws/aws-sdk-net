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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Updates to RBAC role mappings for an Argo CD capability. You can add, update, or remove
    /// role mappings in a single operation.
    /// </summary>
    public partial class UpdateRoleMappings
    {
        private List<ArgoCdRoleMapping> _addOrUpdateRoleMappings = AWSConfigs.InitializeCollections ? new List<ArgoCdRoleMapping>() : null;
        private List<ArgoCdRoleMapping> _removeRoleMappings = AWSConfigs.InitializeCollections ? new List<ArgoCdRoleMapping>() : null;

        /// <summary>
        /// Gets and sets the property AddOrUpdateRoleMappings. 
        /// <para>
        /// A list of role mappings to add or update. If a mapping for the specified role already
        /// exists, it will be updated with the new identities. If it doesn't exist, a new mapping
        /// will be created.
        /// </para>
        /// </summary>
        public List<ArgoCdRoleMapping> AddOrUpdateRoleMappings
        {
            get { return this._addOrUpdateRoleMappings; }
            set { this._addOrUpdateRoleMappings = value; }
        }

        // Check to see if AddOrUpdateRoleMappings property is set
        internal bool IsSetAddOrUpdateRoleMappings()
        {
            return this._addOrUpdateRoleMappings != null && (this._addOrUpdateRoleMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoveRoleMappings. 
        /// <para>
        /// A list of role mappings to remove from the RBAC configuration. Each mapping specifies
        /// an Argo CD role (<c>ADMIN</c>, <c>EDITOR</c>, or <c>VIEWER</c>) and the identities
        /// to remove from that role.
        /// </para>
        /// </summary>
        public List<ArgoCdRoleMapping> RemoveRoleMappings
        {
            get { return this._removeRoleMappings; }
            set { this._removeRoleMappings = value; }
        }

        // Check to see if RemoveRoleMappings property is set
        internal bool IsSetRemoveRoleMappings()
        {
            return this._removeRoleMappings != null && (this._removeRoleMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}