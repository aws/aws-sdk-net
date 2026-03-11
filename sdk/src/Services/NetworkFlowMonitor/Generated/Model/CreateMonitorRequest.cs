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
    /// Container for the parameters to the CreateMonitor operation.
    /// Create a monitor for specific network flows between local and remote resources, so
    /// that you can monitor network performance for one or several of your workloads. For
    /// each monitor, Network Flow Monitor publishes detailed end-to-end performance metrics
    /// and a network health indicator (NHI) that informs you whether there were Amazon Web
    /// Services network issues for one or more of the network flows tracked by a monitor,
    /// during a time period that you choose.
    /// </summary>
    public partial class CreateMonitorRequest : AmazonNetworkFlowMonitorRequest
    {
        private string _clientToken;
        private List<MonitorLocalResource> _localResources = AWSConfigs.InitializeCollections ? new List<MonitorLocalResource>() : null;
        private string _monitorName;
        private List<MonitorRemoteResource> _remoteResources = AWSConfigs.InitializeCollections ? new List<MonitorRemoteResource>() : null;
        private string _scopeArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property LocalResources. 
        /// <para>
        /// The local resources to monitor. A local resource in a workload is the location of
        /// the host, or hosts, where the Network Flow Monitor agent is installed. For example,
        /// if a workload consists of an interaction between a web service and a backend database
        /// (for example, Amazon Dynamo DB), the subnet with the EC2 instance that hosts the web
        /// service, which also runs the agent, is the local resource.
        /// </para>
        ///  
        /// <para>
        /// Be aware that all local resources must belong to the current Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<MonitorLocalResource> LocalResources
        {
            get { return this._localResources; }
            set { this._localResources = value; }
        }

        // Check to see if LocalResources property is set
        internal bool IsSetLocalResources()
        {
            return this._localResources != null && (this._localResources.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property RemoteResources. 
        /// <para>
        /// The remote resources to monitor. A remote resource is the other endpoint in the bi-directional
        /// flow of a workload, with a local resource. For example, Amazon Dynamo DB can be a
        /// remote resource.
        /// </para>
        ///  
        /// <para>
        /// When you specify remote resources, be aware that specific combinations of resources
        /// are allowed and others are not, including the following constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All remote resources that you specify must all belong to a single Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify Amazon Web Services services as remote resources, any other remote
        /// resources that you specify must be in the current Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you specify a remote resource for another Region, you can only specify the <c>Region</c>
        /// resource type. You cannot specify a subnet, VPC, or Availability Zone in another Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you leave the <c>RemoteResources</c> parameter empty, the monitor will include
        /// all network flows that terminate in the current Region.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MonitorRemoteResource> RemoteResources
        {
            get { return this._remoteResources; }
            set { this._remoteResources = value; }
        }

        // Check to see if RemoteResources property is set
        internal bool IsSetRemoteResources()
        {
            return this._remoteResources != null && (this._remoteResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScopeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scope for the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ScopeArn
        {
            get { return this._scopeArn; }
            set { this._scopeArn = value; }
        }

        // Check to see if ScopeArn property is set
        internal bool IsSetScopeArn()
        {
            return this._scopeArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for a monitor. You can add a maximum of 200 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}