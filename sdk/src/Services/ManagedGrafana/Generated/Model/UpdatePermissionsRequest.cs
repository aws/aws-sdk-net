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
    /// Container for the parameters to the UpdatePermissions operation.
    /// Updates which users in a workspace have the Grafana <c>Admin</c> or <c>Editor</c>
    /// roles.
    /// </summary>
    public partial class UpdatePermissionsRequest : AmazonManagedGrafanaRequest
    {
        private List<UpdateInstruction> _updateInstructionBatch = AWSConfigs.InitializeCollections ? new List<UpdateInstruction>() : null;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property UpdateInstructionBatch. 
        /// <para>
        /// An array of structures that contain the permission updates to make.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<UpdateInstruction> UpdateInstructionBatch
        {
            get { return this._updateInstructionBatch; }
            set { this._updateInstructionBatch = value; }
        }

        // Check to see if UpdateInstructionBatch property is set
        internal bool IsSetUpdateInstructionBatch()
        {
            return this._updateInstructionBatch != null && (this._updateInstructionBatch.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to update.
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