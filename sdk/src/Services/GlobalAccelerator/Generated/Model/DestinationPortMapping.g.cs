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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// The port mappings for a specified endpoint IP address (destination).
    /// </summary>
    public partial class DestinationPortMapping
    {
        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom routing accelerator that you have port
        /// mappings for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string AcceleratorArn { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorArn property is set.
        /// </summary>
        internal bool IsSetAcceleratorArn() => this.AcceleratorArn != null;

        /// <summary>
        /// Gets and sets the property AcceleratorSocketAddresses. 
        /// <para>
        /// The IP address/port combinations (sockets) that map to a given destination socket
        /// address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SocketAddress> AcceleratorSocketAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<SocketAddress>() : null;

        /// <summary>
        /// Checks to see if the AcceleratorSocketAddresses property is set.
        /// </summary>
        internal bool IsSetAcceleratorSocketAddresses() => this.AcceleratorSocketAddresses != null && (this.AcceleratorSocketAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DestinationSocketAddress. 
        /// <para>
        /// The endpoint IP address/port combination for traffic received on the accelerator socket
        /// address.
        /// </para>
        /// </summary>
        public SocketAddress DestinationSocketAddress { get; set; }

        /// <summary>
        /// Checks to see if the DestinationSocketAddress property is set.
        /// </summary>
        internal bool IsSetDestinationSocketAddress() => this.DestinationSocketAddress != null;

        /// <summary>
        /// Gets and sets the property DestinationTrafficState. 
        /// <para>
        /// Indicates whether or not a port mapping destination can receive traffic. The value
        /// is either ALLOW, if traffic is allowed to the destination, or DENY, if traffic is
        /// not allowed to the destination.
        /// </para>
        /// </summary>
        public CustomRoutingDestinationTrafficState DestinationTrafficState { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTrafficState property is set.
        /// </summary>
        internal bool IsSetDestinationTrafficState() => this.DestinationTrafficState != null;

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EndpointGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointGroupArn property is set.
        /// </summary>
        internal bool IsSetEndpointGroupArn() => this.EndpointGroupArn != null;

        /// <summary>
        /// Gets and sets the property EndpointGroupRegion. 
        /// <para>
        /// The Amazon Web Services Region for the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// Checks to see if the EndpointGroupRegion property is set.
        /// </summary>
        internal bool IsSetEndpointGroupRegion() => this.EndpointGroupRegion != null;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID for the virtual private cloud (VPC) subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type that an accelerator supports. For a custom routing accelerator,
        /// the value must be IPV4.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;
    }
}
