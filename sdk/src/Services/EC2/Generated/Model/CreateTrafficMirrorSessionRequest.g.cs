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
    /// Container for the parameters to the CreateTrafficMirrorSession operation. Creates
    /// a Traffic Mirror session. <para> A Traffic Mirror session actively copies packets
    /// from a Traffic Mirror source to a Traffic Mirror target. Create a filter, and then
    /// assign it to the session to define a subset of the traffic to mirror, for example
    /// all TCP traffic. </para> <para> The Traffic Mirror source and the Traffic Mirror target
    /// (monitoring appliances) can be in the same VPC, or in a different VPC connected via
    /// VPC peering or a transit gateway. </para> <para> By default, no traffic is mirrored.
    /// Use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTrafficMirrorFilter.html">CreateTrafficMirrorFilter</a>
    /// to create filter rules that specify the traffic to mirror. </para>
    /// </summary>
    public partial class CreateTrafficMirrorSessionRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Traffic Mirror session.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the source network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

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
        public int? PacketLength { get; set; }

        /// <summary>
        /// Checks to see if the PacketLength property is set.
        /// </summary>
        internal bool IsSetPacketLength() => this.PacketLength.HasValue;

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
        [AWSProperty(Required = true)]
        public int? SessionNumber { get; set; }

        /// <summary>
        /// Checks to see if the SessionNumber property is set.
        /// </summary>
        internal bool IsSetSessionNumber() => this.SessionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to a Traffic Mirror session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// The ID of the Traffic Mirror filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficMirrorFilterId property is set.
        /// </summary>
        internal bool IsSetTrafficMirrorFilterId() => this.TrafficMirrorFilterId != null;

        /// <summary>
        /// Gets and sets the property TrafficMirrorTargetId. 
        /// <para>
        /// The ID of the Traffic Mirror target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficMirrorTargetId property is set.
        /// </summary>
        internal bool IsSetTrafficMirrorTargetId() => this.TrafficMirrorTargetId != null;

        /// <summary>
        /// Gets and sets the property VirtualNetworkId. 
        /// <para>
        /// The VXLAN ID for the Traffic Mirror session. For more information about the VXLAN
        /// protocol, see <a href="https://datatracker.ietf.org/doc/html/rfc7348">RFC 7348</a>.
        /// If you do not specify a <c>VirtualNetworkId</c>, an account-wide unique ID is chosen
        /// at random.
        /// </para>
        /// </summary>
        public int? VirtualNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualNetworkId property is set.
        /// </summary>
        internal bool IsSetVirtualNetworkId() => this.VirtualNetworkId.HasValue;
    }
}
