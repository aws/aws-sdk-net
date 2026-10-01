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
    /// This is the response object from the UpdateMonitor operation.
    /// </summary>
    public partial class UpdateMonitorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the monitor was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LocalResources. 
        /// <para>
        /// The local resources to monitor. A local resource in a workload is the location of
        /// hosts where the Network Flow Monitor agent is installed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<MonitorLocalResource> LocalResources { get; set; } = AWSConfigs.InitializeCollections ? new List<MonitorLocalResource>() : null;

        /// <summary>
        /// Checks to see if the LocalResources property is set.
        /// </summary>
        internal bool IsSetLocalResources() => this.LocalResources != null && (this.LocalResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The last date and time that the monitor was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 512)]
        public string MonitorArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitorArn property is set.
        /// </summary>
        internal bool IsSetMonitorArn() => this.MonitorArn != null;

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
        /// Gets and sets the property MonitorStatus. 
        /// <para>
        /// The status of a monitor. The status can be one of the following
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>: The monitor is in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The monitor is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c>: The monitor is inactive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: Monitor creation failed due to an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: The monitor is in the process of being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitorStatus MonitorStatus { get; set; }

        /// <summary>
        /// Checks to see if the MonitorStatus property is set.
        /// </summary>
        internal bool IsSetMonitorStatus() => this.MonitorStatus != null;

        /// <summary>
        /// Gets and sets the property RemoteResources. 
        /// <para>
        /// The remote resources updated for a monitor, as an array of resources with identifiers
        /// and types.
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
        [AWSProperty(Required = true)]
        public List<MonitorRemoteResource> RemoteResources { get; set; } = AWSConfigs.InitializeCollections ? new List<MonitorRemoteResource>() : null;

        /// <summary>
        /// Checks to see if the RemoteResources property is set.
        /// </summary>
        internal bool IsSetRemoteResources() => this.RemoteResources != null && (this.RemoteResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for a monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
