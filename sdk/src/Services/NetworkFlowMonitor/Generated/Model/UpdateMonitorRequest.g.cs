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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMonitor operation. Update a monitor to add
    /// or remove local or remote resources.
    /// </summary>
    public partial class UpdateMonitorRequest : AmazonNetworkFlowMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive string of up to 64 ASCII characters that you specify to make
        /// an idempotent API request. Don't reuse the same client token for other API requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property LocalResourcesToAdd. 
        /// <para>
        /// Additional local resources to specify network flows for a monitor, as an array of
        /// resources with identifiers and types. A local resource in a workload is the location
        /// of hosts where the Network Flow Monitor agent is installed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorLocalResource> LocalResourcesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<MonitorLocalResource>() : null;

        /// <summary>
        /// Checks to see if the LocalResourcesToAdd property is set.
        /// </summary>
        internal bool IsSetLocalResourcesToAdd() => this.LocalResourcesToAdd != null && (this.LocalResourcesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LocalResourcesToRemove. 
        /// <para>
        /// The local resources to remove, as an array of resources with identifiers and types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorLocalResource> LocalResourcesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<MonitorLocalResource>() : null;

        /// <summary>
        /// Checks to see if the LocalResourcesToRemove property is set.
        /// </summary>
        internal bool IsSetLocalResourcesToRemove() => this.LocalResourcesToRemove != null && (this.LocalResourcesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MonitorName { get; set; }

        /// <summary>
        /// Checks to see if the MonitorName property is set.
        /// </summary>
        internal bool IsSetMonitorName() => this.MonitorName != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorRemoteResource> RemoteResourcesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<MonitorRemoteResource>() : null;

        /// <summary>
        /// Checks to see if the RemoteResourcesToAdd property is set.
        /// </summary>
        internal bool IsSetRemoteResourcesToAdd() => this.RemoteResourcesToAdd != null && (this.RemoteResourcesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorRemoteResource> RemoteResourcesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<MonitorRemoteResource>() : null;

        /// <summary>
        /// Checks to see if the RemoteResourcesToRemove property is set.
        /// </summary>
        internal bool IsSetRemoteResourcesToRemove() => this.RemoteResourcesToRemove != null && (this.RemoteResourcesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
