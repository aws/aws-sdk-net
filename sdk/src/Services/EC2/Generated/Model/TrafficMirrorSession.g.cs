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
    /// Describes a Traffic Mirror session.
    /// </summary>
    public partial class TrafficMirrorSession
    {
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
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the Traffic Mirror session's network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the account that owns the Traffic Mirror session.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PacketLength. 
        /// <para>
        /// The number of bytes in each packet to mirror. These are the bytes after the VXLAN
        /// header. To mirror a subset, set this to the length (in bytes) to mirror. For example,
        /// if you set this value to 100, then the first 100 bytes that meet the filter criteria
        /// are copied to the target. Do not specify this parameter when you want to mirror the
        /// entire packet
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
        public int? SessionNumber { get; set; }

        /// <summary>
        /// Checks to see if the SessionNumber property is set.
        /// </summary>
        internal bool IsSetSessionNumber() => this.SessionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Traffic Mirror session.
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
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// The ID of the Traffic Mirror filter.
        /// </para>
        /// </summary>
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficMirrorFilterId property is set.
        /// </summary>
        internal bool IsSetTrafficMirrorFilterId() => this.TrafficMirrorFilterId != null;

        /// <summary>
        /// Gets and sets the property TrafficMirrorSessionId. 
        /// <para>
        /// The ID for the Traffic Mirror session.
        /// </para>
        /// </summary>
        public string TrafficMirrorSessionId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficMirrorSessionId property is set.
        /// </summary>
        internal bool IsSetTrafficMirrorSessionId() => this.TrafficMirrorSessionId != null;

        /// <summary>
        /// Gets and sets the property TrafficMirrorTargetId. 
        /// <para>
        /// The ID of the Traffic Mirror target.
        /// </para>
        /// </summary>
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficMirrorTargetId property is set.
        /// </summary>
        internal bool IsSetTrafficMirrorTargetId() => this.TrafficMirrorTargetId != null;

        /// <summary>
        /// Gets and sets the property VirtualNetworkId. 
        /// <para>
        /// The virtual network ID associated with the Traffic Mirror session.
        /// </para>
        /// </summary>
        public int? VirtualNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualNetworkId property is set.
        /// </summary>
        internal bool IsSetVirtualNetworkId() => this.VirtualNetworkId.HasValue;
    }
}
