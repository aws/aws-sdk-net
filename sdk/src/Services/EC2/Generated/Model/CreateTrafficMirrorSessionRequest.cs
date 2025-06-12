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
    /// Container for the parameters to the CreateTrafficMirrorSession operation.
    /// Creates a Traffic Mirror session.
    /// 
    ///  
    /// <para>
    /// A Traffic Mirror session actively copies packets from a Traffic Mirror source to a
    /// Traffic Mirror target. Create a filter, and then assign it to the session to define
    /// a subset of the traffic to mirror, for example all TCP traffic.
    /// </para>
    ///  
    /// <para>
    /// The Traffic Mirror source and the Traffic Mirror target (monitoring appliances) can
    /// be in the same VPC, or in a different VPC connected via VPC peering or a transit gateway.
    /// 
    /// </para>
    ///  
    /// <para>
    /// By default, no traffic is mirrored. Use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTrafficMirrorFilter.html">CreateTrafficMirrorFilter</a>
    /// to create filter rules that specify the traffic to mirror.
    /// </para>
    /// </summary>
    public partial class CreateTrafficMirrorSessionRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private bool? _dryRun;
        private string _networkInterfaceId;
        private int? _packetLength;
        private int? _sessionNumber;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _trafficMirrorFilterId;
        private string _trafficMirrorTargetId;
        private int? _virtualNetworkId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Traffic Mirror session.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
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
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the source network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property PacketLength. 
        /// <para>
        /// The number of bytes in each packet to mirror. These are bytes after the VXLAN header.
        /// Do not specify this parameter when you want to mirror the entire packet. To mirror
        /// a subset of the packet, set this to the length (in bytes) that you want to mirror.
        /// For example, if you set this value to 100, then the first 100 bytes that meet the
        /// filter criteria are copied to the target.
        /// </para>
        ///  
        /// <para>
        /// If you do not want to mirror the entire packet, use the <c>PacketLength</c> parameter
        /// to specify the number of bytes in each packet to mirror.
        /// </para>
        ///  
        /// <para>
        /// For sessions with Network Load Balancer (NLB) Traffic Mirror targets the default <c>PacketLength</c>
        /// will be set to 8500. Valid values are 1-8500. Setting a <c>PacketLength</c> greater
        /// than 8500 will result in an error response.
        /// </para>
        /// </summary>
        public int? PacketLength
        {
            get { return this._packetLength; }
            set { this._packetLength = value; }
        }

        // Check to see if PacketLength property is set
        internal bool IsSetPacketLength()
        {
            return this._packetLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionNumber. 
        /// <para>
        /// The session number determines the order in which sessions are evaluated when an interface
        /// is used by multiple sessions. The first session with a matching filter is the one
        /// that mirrors the packets.
        /// </para>
        ///  
        /// <para>
        /// Valid values are 1-32766.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SessionNumber
        {
            get { return this._sessionNumber; }
            set { this._sessionNumber = value; }
        }

        // Check to see if SessionNumber property is set
        internal bool IsSetSessionNumber()
        {
            return this._sessionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to a Traffic Mirror session.
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

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// The ID of the Traffic Mirror filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrafficMirrorFilterId
        {
            get { return this._trafficMirrorFilterId; }
            set { this._trafficMirrorFilterId = value; }
        }

        // Check to see if TrafficMirrorFilterId property is set
        internal bool IsSetTrafficMirrorFilterId()
        {
            return this._trafficMirrorFilterId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorTargetId. 
        /// <para>
        /// The ID of the Traffic Mirror target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrafficMirrorTargetId
        {
            get { return this._trafficMirrorTargetId; }
            set { this._trafficMirrorTargetId = value; }
        }

        // Check to see if TrafficMirrorTargetId property is set
        internal bool IsSetTrafficMirrorTargetId()
        {
            return this._trafficMirrorTargetId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualNetworkId. 
        /// <para>
        /// The VXLAN ID for the Traffic Mirror session. For more information about the VXLAN
        /// protocol, see <a href="https://datatracker.ietf.org/doc/html/rfc7348">RFC 7348</a>.
        /// If you do not specify a <c>VirtualNetworkId</c>, an account-wide unique ID is chosen
        /// at random.
        /// </para>
        /// </summary>
        public int? VirtualNetworkId
        {
            get { return this._virtualNetworkId; }
            set { this._virtualNetworkId = value; }
        }

        // Check to see if VirtualNetworkId property is set
        internal bool IsSetVirtualNetworkId()
        {
            return this._virtualNetworkId.HasValue; 
        }

    }
}