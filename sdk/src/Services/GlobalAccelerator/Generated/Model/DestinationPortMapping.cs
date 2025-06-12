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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
        private string _acceleratorArn;
        private List<SocketAddress> _acceleratorSocketAddresses = AWSConfigs.InitializeCollections ? new List<SocketAddress>() : null;
        private SocketAddress _destinationSocketAddress;
        private CustomRoutingDestinationTrafficState _destinationTrafficState;
        private string _endpointGroupArn;
        private string _endpointGroupRegion;
        private string _endpointId;
        private IpAddressType _ipAddressType;

        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom routing accelerator that you have port
        /// mappings for.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string AcceleratorArn
        {
            get { return this._acceleratorArn; }
            set { this._acceleratorArn = value; }
        }

        // Check to see if AcceleratorArn property is set
        internal bool IsSetAcceleratorArn()
        {
            return this._acceleratorArn != null;
        }

        /// <summary>
        /// Gets and sets the property AcceleratorSocketAddresses. 
        /// <para>
        /// The IP address/port combinations (sockets) that map to a given destination socket
        /// address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SocketAddress> AcceleratorSocketAddresses
        {
            get { return this._acceleratorSocketAddresses; }
            set { this._acceleratorSocketAddresses = value; }
        }

        // Check to see if AcceleratorSocketAddresses property is set
        internal bool IsSetAcceleratorSocketAddresses()
        {
            return this._acceleratorSocketAddresses != null && (this._acceleratorSocketAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationSocketAddress. 
        /// <para>
        /// The endpoint IP address/port combination for traffic received on the accelerator socket
        /// address.
        /// </para>
        /// </summary>
        public SocketAddress DestinationSocketAddress
        {
            get { return this._destinationSocketAddress; }
            set { this._destinationSocketAddress = value; }
        }

        // Check to see if DestinationSocketAddress property is set
        internal bool IsSetDestinationSocketAddress()
        {
            return this._destinationSocketAddress != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTrafficState. 
        /// <para>
        /// Indicates whether or not a port mapping destination can receive traffic. The value
        /// is either ALLOW, if traffic is allowed to the destination, or DENY, if traffic is
        /// not allowed to the destination.
        /// </para>
        /// </summary>
        public CustomRoutingDestinationTrafficState DestinationTrafficState
        {
            get { return this._destinationTrafficState; }
            set { this._destinationTrafficState = value; }
        }

        // Check to see if DestinationTrafficState property is set
        internal bool IsSetDestinationTrafficState()
        {
            return this._destinationTrafficState != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EndpointGroupArn
        {
            get { return this._endpointGroupArn; }
            set { this._endpointGroupArn = value; }
        }

        // Check to see if EndpointGroupArn property is set
        internal bool IsSetEndpointGroupArn()
        {
            return this._endpointGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupRegion. 
        /// <para>
        /// The Amazon Web Services Region for the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EndpointGroupRegion
        {
            get { return this._endpointGroupRegion; }
            set { this._endpointGroupRegion = value; }
        }

        // Check to see if EndpointGroupRegion property is set
        internal bool IsSetEndpointGroupRegion()
        {
            return this._endpointGroupRegion != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID for the virtual private cloud (VPC) subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type that an accelerator supports. For a custom routing accelerator,
        /// the value must be IPV4.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

    }
}