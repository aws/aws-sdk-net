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

namespace Amazon.NetworkMonitor.Model
{
    /// <summary>
    /// This is the response object from the CreateProbe operation.
    /// </summary>
    public partial class CreateProbeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// Indicates whether the IP address is <c>IPV4</c> or <c>IPV6</c>.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily { get; set; }

        /// <summary>
        /// Checks to see if the AddressFamily property is set.
        /// </summary>
        internal bool IsSetAddressFamily() => this.AddressFamily != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time and date that the probe was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination IP address for the monitor. This must be either an IPv4 or IPv6 address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The port associated with the <c>destination</c>. This is required only if the <c>protocol</c>
        /// is <c>TCP</c> and must be a number between <c>1</c> and <c>65536</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The time and date when the probe was last modified. 
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PacketSize. 
        /// <para>
        /// The size of the packets sent between the source and destination. This must be a number
        /// between <c>56</c> and <c>8500</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 56, Max = 8500)]
        public int? PacketSize { get; set; }

        /// <summary>
        /// Checks to see if the PacketSize property is set.
        /// </summary>
        internal bool IsSetPacketSize() => this.PacketSize.HasValue;

        /// <summary>
        /// Gets and sets the property ProbeArn. 
        /// <para>
        /// The ARN of the probe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProbeArn { get; set; }

        /// <summary>
        /// Checks to see if the ProbeArn property is set.
        /// </summary>
        internal bool IsSetProbeArn() => this.ProbeArn != null;

        /// <summary>
        /// Gets and sets the property ProbeId. 
        /// <para>
        /// The ID of the probe for which details are returned.
        /// </para>
        /// </summary>
        public string ProbeId { get; set; }

        /// <summary>
        /// Checks to see if the ProbeId property is set.
        /// </summary>
        internal bool IsSetProbeId() => this.ProbeId != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for the network traffic between the <c>source</c> and <c>destination</c>.
        /// This must be either <c>TCP</c> or <c>ICMP</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the probe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the probe.
        /// </para>
        /// </summary>
        public ProbeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value pairs assigned to the probe.
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

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the source VPC or subnet.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
