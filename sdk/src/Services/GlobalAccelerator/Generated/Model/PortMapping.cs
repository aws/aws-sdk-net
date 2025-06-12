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
    /// Returns the ports and associated IP addresses and ports of Amazon EC2 instances in
    /// your virtual private cloud (VPC) subnets. Custom routing is a port mapping protocol
    /// in Global Accelerator that statically associates port ranges with VPC subnets, which
    /// allows Global Accelerator to route to specific instances and ports within one or more
    /// subnets.
    /// </summary>
    public partial class PortMapping
    {
        private int? _acceleratorPort;
        private SocketAddress _destinationSocketAddress;
        private CustomRoutingDestinationTrafficState _destinationTrafficState;
        private string _endpointGroupArn;
        private string _endpointId;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AcceleratorPort. 
        /// <para>
        /// The accelerator port.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? AcceleratorPort
        {
            get { return this._acceleratorPort; }
            set { this._acceleratorPort = value; }
        }

        // Check to see if AcceleratorPort property is set
        internal bool IsSetAcceleratorPort()
        {
            return this._acceleratorPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationSocketAddress. 
        /// <para>
        /// The EC2 instance IP address and port number in the virtual private cloud (VPC) subnet.
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
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The IP address of the VPC subnet (the subnet ID).
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
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols supported by the endpoint group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}