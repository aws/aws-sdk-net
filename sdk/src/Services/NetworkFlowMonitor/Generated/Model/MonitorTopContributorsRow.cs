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
    /// A set of information for a top contributor network flow in a monitor. In a monitor,
    /// Network Flow Monitor returns information about the network flows for top contributors
    /// for each metric. Top contributors are network flows with the top values for each metric
    /// type.
    /// </summary>
    public partial class MonitorTopContributorsRow
    {
        private DestinationCategory _destinationCategory;
        private string _dnatIp;
        private KubernetesMetadata _kubernetesMetadata;
        private string _localAz;
        private string _localInstanceArn;
        private string _localInstanceId;
        private string _localIp;
        private string _localRegion;
        private string _localSubnetArn;
        private string _localSubnetId;
        private string _localVpcArn;
        private string _localVpcId;
        private string _remoteAz;
        private string _remoteInstanceArn;
        private string _remoteInstanceId;
        private string _remoteIp;
        private string _remoteRegion;
        private string _remoteSubnetArn;
        private string _remoteSubnetId;
        private string _remoteVpcArn;
        private string _remoteVpcId;
        private string _snatIp;
        private int? _targetPort;
        private List<TraversedComponent> _traversedConstructs = AWSConfigs.InitializeCollections ? new List<TraversedComponent>() : null;
        private long? _value;

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
        public DestinationCategory DestinationCategory
        {
            get { return this._destinationCategory; }
            set { this._destinationCategory = value; }
        }

        // Check to see if DestinationCategory property is set
        internal bool IsSetDestinationCategory()
        {
            return this._destinationCategory != null;
        }

        /// <summary>
        /// Gets and sets the property DnatIp. 
        /// <para>
        /// The destination network address translation (DNAT) IP address for a top contributor
        /// network flow.
        /// </para>
        /// </summary>
        public string DnatIp
        {
            get { return this._dnatIp; }
            set { this._dnatIp = value; }
        }

        // Check to see if DnatIp property is set
        internal bool IsSetDnatIp()
        {
            return this._dnatIp != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesMetadata. 
        /// <para>
        /// Meta data about Kubernetes resources.
        /// </para>
        /// </summary>
        public KubernetesMetadata KubernetesMetadata
        {
            get { return this._kubernetesMetadata; }
            set { this._kubernetesMetadata = value; }
        }

        // Check to see if KubernetesMetadata property is set
        internal bool IsSetKubernetesMetadata()
        {
            return this._kubernetesMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property LocalAz. 
        /// <para>
        /// The Availability Zone for the local resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string LocalAz
        {
            get { return this._localAz; }
            set { this._localAz = value; }
        }

        // Check to see if LocalAz property is set
        internal bool IsSetLocalAz()
        {
            return this._localAz != null;
        }

        /// <summary>
        /// Gets and sets the property LocalInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local resource.
        /// </para>
        /// </summary>
        public string LocalInstanceArn
        {
            get { return this._localInstanceArn; }
            set { this._localInstanceArn = value; }
        }

        // Check to see if LocalInstanceArn property is set
        internal bool IsSetLocalInstanceArn()
        {
            return this._localInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalInstanceId. 
        /// <para>
        /// The instance identifier for the local resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string LocalInstanceId
        {
            get { return this._localInstanceId; }
            set { this._localInstanceId = value; }
        }

        // Check to see if LocalInstanceId property is set
        internal bool IsSetLocalInstanceId()
        {
            return this._localInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalIp. 
        /// <para>
        /// The IP address of the local resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string LocalIp
        {
            get { return this._localIp; }
            set { this._localIp = value; }
        }

        // Check to see if LocalIp property is set
        internal bool IsSetLocalIp()
        {
            return this._localIp != null;
        }

        /// <summary>
        /// Gets and sets the property LocalRegion. 
        /// <para>
        /// The Amazon Web Services Region for the local resource for a top contributor network
        /// flow.
        /// </para>
        /// </summary>
        public string LocalRegion
        {
            get { return this._localRegion; }
            set { this._localRegion = value; }
        }

        // Check to see if LocalRegion property is set
        internal bool IsSetLocalRegion()
        {
            return this._localRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LocalSubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local subnet.
        /// </para>
        /// </summary>
        public string LocalSubnetArn
        {
            get { return this._localSubnetArn; }
            set { this._localSubnetArn = value; }
        }

        // Check to see if LocalSubnetArn property is set
        internal bool IsSetLocalSubnetArn()
        {
            return this._localSubnetArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalSubnetId. 
        /// <para>
        /// The subnet ID for the local resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string LocalSubnetId
        {
            get { return this._localSubnetId; }
            set { this._localSubnetId = value; }
        }

        // Check to see if LocalSubnetId property is set
        internal bool IsSetLocalSubnetId()
        {
            return this._localSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalVpcArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local VPC.
        /// </para>
        /// </summary>
        public string LocalVpcArn
        {
            get { return this._localVpcArn; }
            set { this._localVpcArn = value; }
        }

        // Check to see if LocalVpcArn property is set
        internal bool IsSetLocalVpcArn()
        {
            return this._localVpcArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalVpcId. 
        /// <para>
        /// The VPC ID for a top contributor network flow for the local resource.
        /// </para>
        /// </summary>
        public string LocalVpcId
        {
            get { return this._localVpcId; }
            set { this._localVpcId = value; }
        }

        // Check to see if LocalVpcId property is set
        internal bool IsSetLocalVpcId()
        {
            return this._localVpcId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteAz. 
        /// <para>
        /// The Availability Zone for the remote resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string RemoteAz
        {
            get { return this._remoteAz; }
            set { this._remoteAz = value; }
        }

        // Check to see if RemoteAz property is set
        internal bool IsSetRemoteAz()
        {
            return this._remoteAz != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a remote resource.
        /// </para>
        /// </summary>
        public string RemoteInstanceArn
        {
            get { return this._remoteInstanceArn; }
            set { this._remoteInstanceArn = value; }
        }

        // Check to see if RemoteInstanceArn property is set
        internal bool IsSetRemoteInstanceArn()
        {
            return this._remoteInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteInstanceId. 
        /// <para>
        /// The instance identifier for the remote resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string RemoteInstanceId
        {
            get { return this._remoteInstanceId; }
            set { this._remoteInstanceId = value; }
        }

        // Check to see if RemoteInstanceId property is set
        internal bool IsSetRemoteInstanceId()
        {
            return this._remoteInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteIp. 
        /// <para>
        /// The IP address of the remote resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string RemoteIp
        {
            get { return this._remoteIp; }
            set { this._remoteIp = value; }
        }

        // Check to see if RemoteIp property is set
        internal bool IsSetRemoteIp()
        {
            return this._remoteIp != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteRegion. 
        /// <para>
        /// The Amazon Web Services Region for the remote resource for a top contributor network
        /// flow.
        /// </para>
        /// </summary>
        public string RemoteRegion
        {
            get { return this._remoteRegion; }
            set { this._remoteRegion = value; }
        }

        // Check to see if RemoteRegion property is set
        internal bool IsSetRemoteRegion()
        {
            return this._remoteRegion != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteSubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a remote subnet.
        /// </para>
        /// </summary>
        public string RemoteSubnetArn
        {
            get { return this._remoteSubnetArn; }
            set { this._remoteSubnetArn = value; }
        }

        // Check to see if RemoteSubnetArn property is set
        internal bool IsSetRemoteSubnetArn()
        {
            return this._remoteSubnetArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteSubnetId. 
        /// <para>
        /// The subnet ID for the remote resource for a top contributor network flow.
        /// </para>
        /// </summary>
        public string RemoteSubnetId
        {
            get { return this._remoteSubnetId; }
            set { this._remoteSubnetId = value; }
        }

        // Check to see if RemoteSubnetId property is set
        internal bool IsSetRemoteSubnetId()
        {
            return this._remoteSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteVpcArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a remote VPC.
        /// </para>
        /// </summary>
        public string RemoteVpcArn
        {
            get { return this._remoteVpcArn; }
            set { this._remoteVpcArn = value; }
        }

        // Check to see if RemoteVpcArn property is set
        internal bool IsSetRemoteVpcArn()
        {
            return this._remoteVpcArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteVpcId. 
        /// <para>
        /// The VPC ID for a top contributor network flow for the remote resource.
        /// </para>
        /// </summary>
        public string RemoteVpcId
        {
            get { return this._remoteVpcId; }
            set { this._remoteVpcId = value; }
        }

        // Check to see if RemoteVpcId property is set
        internal bool IsSetRemoteVpcId()
        {
            return this._remoteVpcId != null;
        }

        /// <summary>
        /// Gets and sets the property SnatIp. 
        /// <para>
        /// The secure network address translation (SNAT) IP address for a top contributor network
        /// flow.
        /// </para>
        /// </summary>
        public string SnatIp
        {
            get { return this._snatIp; }
            set { this._snatIp = value; }
        }

        // Check to see if SnatIp property is set
        internal bool IsSetSnatIp()
        {
            return this._snatIp != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPort. 
        /// <para>
        /// The target port.
        /// </para>
        /// </summary>
        public int? TargetPort
        {
            get { return this._targetPort; }
            set { this._targetPort = value; }
        }

        // Check to see if TargetPort property is set
        internal bool IsSetTargetPort()
        {
            return this._targetPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TraversedConstructs. 
        /// <para>
        /// The constructs traversed by a network flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TraversedComponent> TraversedConstructs
        {
            get { return this._traversedConstructs; }
            set { this._traversedConstructs = value; }
        }

        // Check to see if TraversedConstructs property is set
        internal bool IsSetTraversedConstructs()
        {
            return this._traversedConstructs != null && (this._traversedConstructs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the metric for a top contributor network flow.
        /// </para>
        /// </summary>
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}