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
    /// Container for the parameters to the UpdateMonitor operation.
    /// Update a monitor to add or remove local or remote resources.
    /// </summary>
    public partial class UpdateMonitorRequest : AmazonNetworkFlowMonitorRequest
    {
        private string _clientToken;
        private List<MonitorLocalResource> _localResourcesToAdd = AWSConfigs.InitializeCollections ? new List<MonitorLocalResource>() : null;
        private List<MonitorLocalResource> _localResourcesToRemove = AWSConfigs.InitializeCollections ? new List<MonitorLocalResource>() : null;
        private string _monitorName;
        private List<MonitorRemoteResource> _remoteResourcesToAdd = AWSConfigs.InitializeCollections ? new List<MonitorRemoteResource>() : null;
        private List<MonitorRemoteResource> _remoteResourcesToRemove = AWSConfigs.InitializeCollections ? new List<MonitorRemoteResource>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive string of up to 64 ASCII characters that you specify to make
        /// an idempotent API request. Don't reuse the same client token for other API requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property LocalResourcesToAdd. 
        /// <para>
        /// Additional local resources to specify network flows for a monitor, as an array of
        /// resources with identifiers and types. A local resource in a workload is the location
        /// of hosts where the Network Flow Monitor agent is installed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorLocalResource> LocalResourcesToAdd
        {
            get { return this._localResourcesToAdd; }
            set { this._localResourcesToAdd = value; }
        }

        // Check to see if LocalResourcesToAdd property is set
        internal bool IsSetLocalResourcesToAdd()
        {
            return this._localResourcesToAdd != null && (this._localResourcesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocalResourcesToRemove. 
        /// <para>
        /// The local resources to remove, as an array of resources with identifiers and types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorLocalResource> LocalResourcesToRemove
        {
            get { return this._localResourcesToRemove; }
            set { this._localResourcesToRemove = value; }
        }

        // Check to see if LocalResourcesToRemove property is set
        internal bool IsSetLocalResourcesToRemove()
        {
            return this._localResourcesToRemove != null && (this._localResourcesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteResourcesToAdd. 
        /// <para>
        /// The remote resources to add, as an array of resources with identifiers and types.
        /// </para>
        ///  
        /// <para>
        /// A remote resource is the other endpoint in the flow of a workload, with a local resource.
        /// For example, Amazon Dynamo DB can be a remote resource. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorRemoteResource> RemoteResourcesToAdd
        {
            get { return this._remoteResourcesToAdd; }
            set { this._remoteResourcesToAdd = value; }
        }

        // Check to see if RemoteResourcesToAdd property is set
        internal bool IsSetRemoteResourcesToAdd()
        {
            return this._remoteResourcesToAdd != null && (this._remoteResourcesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoteResourcesToRemove. 
        /// <para>
        /// The remote resources to remove, as an array of resources with identifiers and types.
        /// </para>
        ///  
        /// <para>
        /// A remote resource is the other endpoint specified for the network flow of a workload,
        /// with a local resource. For example, Amazon Dynamo DB can be a remote resource. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorRemoteResource> RemoteResourcesToRemove
        {
            get { return this._remoteResourcesToRemove; }
            set { this._remoteResourcesToRemove = value; }
        }

        // Check to see if RemoteResourcesToRemove property is set
        internal bool IsSetRemoteResourcesToRemove()
        {
            return this._remoteResourcesToRemove != null && (this._remoteResourcesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}