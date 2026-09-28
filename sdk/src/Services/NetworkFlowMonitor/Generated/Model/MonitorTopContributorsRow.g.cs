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
    /// A set of information for a top contributor network flow in a monitor. In a monitor,
    /// Network Flow Monitor returns information about the network flows for top contributors
    /// for each metric. Top contributors are network flows with the top values for each metric
    /// type.
    /// </summary>
    public partial class MonitorTopContributorsRow
    {
        /// <summary>
        /// Gets and sets the property DestinationCategory. 
        /// <para>
        /// The destination category for a top contributors row. Destination categories can be
        /// one of the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INTRA_AZ</c>: Top contributor network flows within a single Availability Zone
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTER_AZ</c>: Top contributor network flows between Availability Zones
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTER_REGION</c>: Top contributor network flows between Regions (to the edge of
        /// another Region)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTER_VPC</c>: Top contributor network flows between VPCs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SERVICES</c>: Top contributor network flows to or from Amazon Web Services
        /// services
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNCLASSIFIED</c>: Top contributor network flows that do not have a bucket classification
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DestinationCategory DestinationCategory { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCategory property is set.
        /// </summary>
        internal bool IsSetDestinationCategory() => this.DestinationCategory != null;

        /// <summary>
        /// Gets and sets the property DnatIp. 
        /// <para>
        /// The destination network address translation (DNAT) IP address for a top contributor
        /// network flow.
        /// </para>
        /// </summary>
        public string DnatIp { get; set; }

        /// <summary>
        /// Checks to see if the DnatIp property is set.
        /// </summary>
        internal bool IsSetDnatIp() => this.DnatIp != null;

        /// <summary>
        /// Gets and sets the property KubernetesMetadata. 
        /// <para>
        /// Meta data about Kubernetes resources.
        /// </para>
        /// </summary>
        public KubernetesMetadata KubernetesMetadata { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesMetadata property is set.
        /// </summary>
        internal bool IsSetKubernetesMetadata() => this.KubernetesMetadata != null;

        /// <summary>
        /// Gets and sets the property LocalAz. 
        /// <para>
        /// The Availability Zone for the local resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string LocalAz { get; set; }

        /// <summary>
        /// Checks to see if the LocalAz property is set.
        /// </summary>
        internal bool IsSetLocalAz() => this.LocalAz != null;

        /// <summary>
        /// Gets and sets the property LocalInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local resource.
        /// </para>
        /// </summary>
        public string LocalInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the LocalInstanceArn property is set.
        /// </summary>
        internal bool IsSetLocalInstanceArn() => this.LocalInstanceArn != null;

        /// <summary>
        /// Gets and sets the property LocalInstanceId. 
        /// <para>
        /// The instance identifier for the local resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string LocalInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the LocalInstanceId property is set.
        /// </summary>
        internal bool IsSetLocalInstanceId() => this.LocalInstanceId != null;

        /// <summary>
        /// Gets and sets the property LocalIp. 
        /// <para>
        /// The IP address of the local resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string LocalIp { get; set; }

        /// <summary>
        /// Checks to see if the LocalIp property is set.
        /// </summary>
        internal bool IsSetLocalIp() => this.LocalIp != null;

        /// <summary>
        /// Gets and sets the property LocalRegion. 
        /// <para>
        /// The Amazon Web Services Region for the local resource for a top contributor network
        /// flow.
        /// </para>
        /// </summary>
        public string LocalRegion { get; set; }

        /// <summary>
        /// Checks to see if the LocalRegion property is set.
        /// </summary>
        internal bool IsSetLocalRegion() => this.LocalRegion != null;

        /// <summary>
        /// Gets and sets the property LocalSubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local subnet.
        /// </para>
        /// </summary>
        public string LocalSubnetArn { get; set; }

        /// <summary>
        /// Checks to see if the LocalSubnetArn property is set.
        /// </summary>
        internal bool IsSetLocalSubnetArn() => this.LocalSubnetArn != null;

        /// <summary>
        /// Gets and sets the property LocalSubnetId. 
        /// <para>
        /// The subnet ID for the local resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string LocalSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the LocalSubnetId property is set.
        /// </summary>
        internal bool IsSetLocalSubnetId() => this.LocalSubnetId != null;

        /// <summary>
        /// Gets and sets the property LocalVpcArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local VPC.
        /// </para>
        /// </summary>
        public string LocalVpcArn { get; set; }

        /// <summary>
        /// Checks to see if the LocalVpcArn property is set.
        /// </summary>
        internal bool IsSetLocalVpcArn() => this.LocalVpcArn != null;

        /// <summary>
        /// Gets and sets the property LocalVpcId. 
        /// <para>
        /// The VPC ID for a top contributor network flow for the local resource.
        /// </para>
        /// </summary>
        public string LocalVpcId { get; set; }

        /// <summary>
        /// Checks to see if the LocalVpcId property is set.
        /// </summary>
        internal bool IsSetLocalVpcId() => this.LocalVpcId != null;

        /// <summary>
        /// Gets and sets the property RemoteAz. 
        /// <para>
        /// The Availability Zone for the remote resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string RemoteAz { get; set; }

        /// <summary>
        /// Checks to see if the RemoteAz property is set.
        /// </summary>
        internal bool IsSetRemoteAz() => this.RemoteAz != null;

        /// <summary>
        /// Gets and sets the property RemoteInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a remote resource.
        /// </para>
        /// </summary>
        public string RemoteInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the RemoteInstanceArn property is set.
        /// </summary>
        internal bool IsSetRemoteInstanceArn() => this.RemoteInstanceArn != null;

        /// <summary>
        /// Gets and sets the property RemoteInstanceId. 
        /// <para>
        /// The instance identifier for the remote resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string RemoteInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the RemoteInstanceId property is set.
        /// </summary>
        internal bool IsSetRemoteInstanceId() => this.RemoteInstanceId != null;

        /// <summary>
        /// Gets and sets the property RemoteIp. 
        /// <para>
        /// The IP address of the remote resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string RemoteIp { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIp property is set.
        /// </summary>
        internal bool IsSetRemoteIp() => this.RemoteIp != null;

        /// <summary>
        /// Gets and sets the property RemoteRegion. 
        /// <para>
        /// The Amazon Web Services Region for the remote resource for a top contributor network
        /// flow.
        /// </para>
        /// </summary>
        public string RemoteRegion { get; set; }

        /// <summary>
        /// Checks to see if the RemoteRegion property is set.
        /// </summary>
        internal bool IsSetRemoteRegion() => this.RemoteRegion != null;

        /// <summary>
        /// Gets and sets the property RemoteSubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a remote subnet.
        /// </para>
        /// </summary>
        public string RemoteSubnetArn { get; set; }

        /// <summary>
        /// Checks to see if the RemoteSubnetArn property is set.
        /// </summary>
        internal bool IsSetRemoteSubnetArn() => this.RemoteSubnetArn != null;

        /// <summary>
        /// Gets and sets the property RemoteSubnetId. 
        /// <para>
        /// The subnet ID for the remote resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string RemoteSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the RemoteSubnetId property is set.
        /// </summary>
        internal bool IsSetRemoteSubnetId() => this.RemoteSubnetId != null;

        /// <summary>
        /// Gets and sets the property RemoteVpcArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a remote VPC.
        /// </para>
        /// </summary>
        public string RemoteVpcArn { get; set; }

        /// <summary>
        /// Checks to see if the RemoteVpcArn property is set.
        /// </summary>
        internal bool IsSetRemoteVpcArn() => this.RemoteVpcArn != null;

        /// <summary>
        /// Gets and sets the property RemoteVpcId. 
        /// <para>
        /// The VPC ID for a top contributor network flow for the remote resource.
        /// </para>
        /// </summary>
        public string RemoteVpcId { get; set; }

        /// <summary>
        /// Checks to see if the RemoteVpcId property is set.
        /// </summary>
        internal bool IsSetRemoteVpcId() => this.RemoteVpcId != null;

        /// <summary>
        /// Gets and sets the property SnatIp. 
        /// <para>
        /// The secure network address translation (SNAT) IP address for a top contributor network
        /// flow.
        /// </para>
        /// </summary>
        public string SnatIp { get; set; }

        /// <summary>
        /// Checks to see if the SnatIp property is set.
        /// </summary>
        internal bool IsSetSnatIp() => this.SnatIp != null;

        /// <summary>
        /// Gets and sets the property TargetPort. 
        /// <para>
        /// The target port.
        /// </para>
        /// </summary>
        public int? TargetPort { get; set; }

        /// <summary>
        /// Checks to see if the TargetPort property is set.
        /// </summary>
        internal bool IsSetTargetPort() => this.TargetPort.HasValue;

        /// <summary>
        /// Gets and sets the property TraversedConstructs. 
        /// <para>
        /// The constructs traversed by a network flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TraversedComponent> TraversedConstructs { get; set; } = AWSConfigs.InitializeCollections ? new List<TraversedComponent>() : null;

        /// <summary>
        /// Checks to see if the TraversedConstructs property is set.
        /// </summary>
        internal bool IsSetTraversedConstructs() => this.TraversedConstructs != null && (this.TraversedConstructs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the metric for a top contributor network flow.
        /// </para>
        /// </summary>
        public long? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
