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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Represents a node and its specifications in an in-vehicle communication network. All
    /// signal decoders must be associated with a network node. 
    /// 
    ///  
    /// <para>
    ///  To return this information about all the network interfaces specified in a decoder
    /// manifest, use the API operation.
    /// </para>
    /// </summary>
    public partial class NetworkInterface
    {
        /// <summary>
        /// Gets and sets the property CanInterface. 
        /// <para>
        /// Information about a network interface specified by the Controller Area Network (CAN)
        /// protocol.
        /// </para>
        /// </summary>
        public CanInterface CanInterface { get; set; }

        /// <summary>
        /// Checks to see if the CanInterface property is set.
        /// </summary>
        internal bool IsSetCanInterface() => this.CanInterface != null;

        /// <summary>
        /// Gets and sets the property CustomDecodingInterface. 
        /// <para>
        /// Information about a <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/APIReference/API_CustomDecodingInterface.html">custom
        /// network interface</a>.
        /// </para>
        /// </summary>
        public CustomDecodingInterface CustomDecodingInterface { get; set; }

        /// <summary>
        /// Checks to see if the CustomDecodingInterface property is set.
        /// </summary>
        internal bool IsSetCustomDecodingInterface() => this.CustomDecodingInterface != null;

        /// <summary>
        /// Gets and sets the property InterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string InterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceId property is set.
        /// </summary>
        internal bool IsSetInterfaceId() => this.InterfaceId != null;

        /// <summary>
        /// Gets and sets the property ObdInterface. 
        /// <para>
        /// Information about a network interface specified by the on-board diagnostic (OBD) II
        /// protocol.
        /// </para>
        /// </summary>
        public ObdInterface ObdInterface { get; set; }

        /// <summary>
        /// Checks to see if the ObdInterface property is set.
        /// </summary>
        internal bool IsSetObdInterface() => this.ObdInterface != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The network protocol for the vehicle. For example, <c>CAN_SIGNAL</c> specifies a protocol
        /// that defines how data is communicated between electronic control units (ECUs). <c>OBD_SIGNAL</c>
        /// specifies a protocol that defines how self-diagnostic data is communicated between
        /// ECUs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NetworkInterfaceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VehicleMiddleware. 
        /// <para>
        /// The vehicle middleware defined as a type of network interface. Examples of vehicle
        /// middleware include <c>ROS2</c> and <c>SOME/IP</c>.
        /// </para>
        /// </summary>
        public VehicleMiddleware VehicleMiddleware { get; set; }

        /// <summary>
        /// Checks to see if the VehicleMiddleware property is set.
        /// </summary>
        internal bool IsSetVehicleMiddleware() => this.VehicleMiddleware != null;
    }
}
