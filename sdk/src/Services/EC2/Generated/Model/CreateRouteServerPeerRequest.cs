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
    /// Container for the parameters to the CreateRouteServerPeer operation.
    /// Creates a new BGP peer for a specified route server endpoint.
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
    /// <para>
    /// For more information see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/dynamic-routing-route-server.html">Dynamic
    /// routing in your VPC with VPC Route Server</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateRouteServerPeerRequest : AmazonEC2Request
    {
        private RouteServerBgpOptionsRequest _bgpOptions;
        private bool? _dryRun;
        private string _peerAddress;
        private string _routeServerEndpointId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property BgpOptions. 
        /// <para>
        /// The BGP options for the peer, including ASN (Autonomous System Number) and BFD (Bidrectional
        /// Forwarding Detection) settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteServerBgpOptionsRequest BgpOptions
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The IPv4 address of the peer device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the route server endpoint for which to create a peer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the route server peer during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}