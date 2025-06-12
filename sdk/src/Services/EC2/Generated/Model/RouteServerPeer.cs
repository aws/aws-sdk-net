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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private RouteServerBfdStatus _bfdStatus;
        private RouteServerBgpOptions _bgpOptions;
        private RouteServerBgpStatus _bgpStatus;
        private string _endpointEniAddress;
        private string _endpointEniId;
        private string _failureReason;
        private string _peerAddress;
        private string _routeServerEndpointId;
        private string _routeServerId;
        private string _routeServerPeerId;
        private RouteServerPeerState _state;
        private string _subnetId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property BfdStatus. 
        /// <para>
        /// The current status of the BFD session with this peer.
        /// </para>
        /// </summary>
        public RouteServerBfdStatus BfdStatus
        {
            get { return this._bfdStatus; }
            set { this._bfdStatus = value; }
        }

        // Check to see if BfdStatus property is set
        internal bool IsSetBfdStatus()
        {
            return this._bfdStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BgpOptions. 
        /// <para>
        /// The BGP configuration options for this peer, including ASN (Autonomous System Number)
        /// and BFD (Bidrectional Forwarding Detection) settings.
        /// </para>
        /// </summary>
        public RouteServerBgpOptions BgpOptions
        {
            get { return this._bgpOptions; }
            set { this._bgpOptions = value; }
        }

        // Check to see if BgpOptions property is set
        internal bool IsSetBgpOptions()
        {
            return this._bgpOptions != null;
        }

        /// <summary>
        /// Gets and sets the property BgpStatus. 
        /// <para>
        /// The current status of the BGP session with this peer.
        /// </para>
        /// </summary>
        public RouteServerBgpStatus BgpStatus
        {
            get { return this._bgpStatus; }
            set { this._bgpStatus = value; }
        }

        // Check to see if BgpStatus property is set
        internal bool IsSetBgpStatus()
        {
            return this._bgpStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointEniAddress. 
        /// <para>
        /// The IP address of the Elastic network interface for the route server endpoint.
        /// </para>
        /// </summary>
        public string EndpointEniAddress
        {
            get { return this._endpointEniAddress; }
            set { this._endpointEniAddress = value; }
        }

        // Check to see if EndpointEniAddress property is set
        internal bool IsSetEndpointEniAddress()
        {
            return this._endpointEniAddress != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointEniId. 
        /// <para>
        /// The ID of the Elastic network interface for the route server endpoint.
        /// </para>
        /// </summary>
        public string EndpointEniId
        {
            get { return this._endpointEniId; }
            set { this._endpointEniId = value; }
        }

        // Check to see if EndpointEniId property is set
        internal bool IsSetEndpointEniId()
        {
            return this._endpointEniId != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for any failure in peer creation or operation.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The IPv4 address of the peer device.
        /// </para>
        /// </summary>
        public string PeerAddress
        {
            get { return this._peerAddress; }
            set { this._peerAddress = value; }
        }

        // Check to see if PeerAddress property is set
        internal bool IsSetPeerAddress()
        {
            return this._peerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property RouteServerEndpointId. 
        /// <para>
        /// The ID of the route server endpoint associated with this peer.
        /// </para>
        /// </summary>
        public string RouteServerEndpointId
        {
            get { return this._routeServerEndpointId; }
            set { this._routeServerEndpointId = value; }
        }

        // Check to see if RouteServerEndpointId property is set
        internal bool IsSetRouteServerEndpointId()
        {
            return this._routeServerEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the route server associated with this peer.
        /// </para>
        /// </summary>
        public string RouteServerId
        {
            get { return this._routeServerId; }
            set { this._routeServerId = value; }
        }

        // Check to see if RouteServerId property is set
        internal bool IsSetRouteServerId()
        {
            return this._routeServerId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteServerPeerId. 
        /// <para>
        /// The unique identifier of the route server peer.
        /// </para>
        /// </summary>
        public string RouteServerPeerId
        {
            get { return this._routeServerPeerId; }
            set { this._routeServerPeerId = value; }
        }

        // Check to see if RouteServerPeerId property is set
        internal bool IsSetRouteServerPeerId()
        {
            return this._routeServerPeerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route server peer.
        /// </para>
        /// </summary>
        public RouteServerPeerState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet containing the route server peer.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the route server peer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC containing the route server peer.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}