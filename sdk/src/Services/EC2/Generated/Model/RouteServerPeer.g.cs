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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a BGP peer configuration for a route server endpoint.
    /// 
    ///  
    /// <para>
    /// A route server peer is a session between a route server endpoint and the device deployed
    /// in Amazon Web Services (such as a firewall appliance or other network security function
    /// running on an EC2 instance). The device must meet these requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Have an elastic network interface in the VPC
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Support BGP (Border Gateway Protocol)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Can initiate BGP sessions
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RouteServerPeer
    {
        /// <summary>
        /// Gets and sets the property BfdStatus. 
        /// <para>
        /// The current status of the BFD session with this peer.
        /// </para>
        /// </summary>
        public RouteServerBfdStatus BfdStatus { get; set; }

        /// <summary>
        /// Checks to see if the BfdStatus property is set.
        /// </summary>
        internal bool IsSetBfdStatus() => this.BfdStatus != null;

        /// <summary>
        /// Gets and sets the property BgpOptions. 
        /// <para>
        /// The BGP configuration options for this peer, including ASN (Autonomous System Number)
        /// and BFD (Bidrectional Forwarding Detection) settings.
        /// </para>
        /// </summary>
        public RouteServerBgpOptions BgpOptions { get; set; }

        /// <summary>
        /// Checks to see if the BgpOptions property is set.
        /// </summary>
        internal bool IsSetBgpOptions() => this.BgpOptions != null;

        /// <summary>
        /// Gets and sets the property BgpStatus. 
        /// <para>
        /// The current status of the BGP session with this peer.
        /// </para>
        /// </summary>
        public RouteServerBgpStatus BgpStatus { get; set; }

        /// <summary>
        /// Checks to see if the BgpStatus property is set.
        /// </summary>
        internal bool IsSetBgpStatus() => this.BgpStatus != null;

        /// <summary>
        /// Gets and sets the property EndpointEniAddress. 
        /// <para>
        /// The IP address of the Elastic network interface for the route server endpoint.
        /// </para>
        /// </summary>
        public string EndpointEniAddress { get; set; }

        /// <summary>
        /// Checks to see if the EndpointEniAddress property is set.
        /// </summary>
        internal bool IsSetEndpointEniAddress() => this.EndpointEniAddress != null;

        /// <summary>
        /// Gets and sets the property EndpointEniId. 
        /// <para>
        /// The ID of the Elastic network interface for the route server endpoint.
        /// </para>
        /// </summary>
        public string EndpointEniId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointEniId property is set.
        /// </summary>
        internal bool IsSetEndpointEniId() => this.EndpointEniId != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for any failure in peer creation or operation.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The IPv4 address of the peer device.
        /// </para>
        /// </summary>
        public string PeerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerAddress property is set.
        /// </summary>
        internal bool IsSetPeerAddress() => this.PeerAddress != null;

        /// <summary>
        /// Gets and sets the property RouteServerEndpointId. 
        /// <para>
        /// The ID of the route server endpoint associated with this peer.
        /// </para>
        /// </summary>
        public string RouteServerEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerEndpointId property is set.
        /// </summary>
        internal bool IsSetRouteServerEndpointId() => this.RouteServerEndpointId != null;

        /// <summary>
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the route server associated with this peer.
        /// </para>
        /// </summary>
        public string RouteServerId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerId property is set.
        /// </summary>
        internal bool IsSetRouteServerId() => this.RouteServerId != null;

        /// <summary>
        /// Gets and sets the property RouteServerPeerId. 
        /// <para>
        /// The unique identifier of the route server peer.
        /// </para>
        /// </summary>
        public string RouteServerPeerId { get; set; }

        /// <summary>
        /// Checks to see if the RouteServerPeerId property is set.
        /// </summary>
        internal bool IsSetRouteServerPeerId() => this.RouteServerPeerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route server peer.
        /// </para>
        /// </summary>
        public RouteServerPeerState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet containing the route server peer.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the route server peer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC containing the route server peer.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
