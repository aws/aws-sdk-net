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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScope operation.
    /// Update a scope to add or remove resources that you want to be available for Network
    /// Flow Monitor to generate metrics for, when you have active agents on those resources
    /// sending metrics reports to the Network Flow Monitor backend.
    /// </summary>
    public partial class UpdateScopeRequest : AmazonNetworkFlowMonitorRequest
    {
        private List<TargetResource> _resourcesToAdd = AWSConfigs.InitializeCollections ? new List<TargetResource>() : null;
        private List<TargetResource> _resourcesToDelete = AWSConfigs.InitializeCollections ? new List<TargetResource>() : null;
        private string _scopeId;

        /// <summary>
        /// Gets and sets the property ResourcesToAdd. 
        /// <para>
        /// A list of resources to add to a scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=99)]
        public List<TargetResource> ResourcesToAdd
        {
            get { return this._resourcesToAdd; }
            set { this._resourcesToAdd = value; }
        }

        // Check to see if ResourcesToAdd property is set
        internal bool IsSetResourcesToAdd()
        {
            return this._resourcesToAdd != null && (this._resourcesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourcesToDelete. 
        /// <para>
        /// A list of resources to delete from a scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=99)]
        public List<TargetResource> ResourcesToDelete
        {
            get { return this._resourcesToDelete; }
            set { this._resourcesToDelete = value; }
        }

        // Check to see if ResourcesToDelete property is set
        internal bool IsSetResourcesToDelete()
        {
            return this._resourcesToDelete != null && (this._resourcesToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScopeId. 
        /// <para>
        /// The identifier for the scope that includes the resources you want to get data results
        /// for. A scope ID is an internally-generated identifier that includes all the resources
        /// for a specific root account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScopeId
        {
            get { return this._scopeId; }
            set { this._scopeId = value; }
        }

        // Check to see if ScopeId property is set
        internal bool IsSetScopeId()
        {
            return this._scopeId != null;
        }

    }
}