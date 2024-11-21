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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
        private CanInterface _canInterface;
        private CustomDecodingInterface _customDecodingInterface;
        private string _interfaceId;
        private ObdInterface _obdInterface;
        private NetworkInterfaceType _type;
        private VehicleMiddleware _vehicleMiddleware;

        /// <summary>
        /// Gets and sets the property CanInterface. 
        /// <para>
        /// Information about a network interface specified by the Controller Area Network (CAN)
        /// protocol.
        /// </para>
        /// </summary>
        public CanInterface CanInterface
        {
            get { return this._canInterface; }
            set { this._canInterface = value; }
        }

        // Check to see if CanInterface property is set
        internal bool IsSetCanInterface()
        {
            return this._canInterface != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDecodingInterface. 
        /// <para>
        /// Information about a <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/APIReference/API_CustomDecodingInterface.html">custom
        /// network interface</a>.
        /// </para>
        /// </summary>
        public CustomDecodingInterface CustomDecodingInterface
        {
            get { return this._customDecodingInterface; }
            set { this._customDecodingInterface = value; }
        }

        // Check to see if CustomDecodingInterface property is set
        internal bool IsSetCustomDecodingInterface()
        {
            return this._customDecodingInterface != null;
        }

        /// <summary>
        /// Gets and sets the property InterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string InterfaceId
        {
            get { return this._interfaceId; }
            set { this._interfaceId = value; }
        }

        // Check to see if InterfaceId property is set
        internal bool IsSetInterfaceId()
        {
            return this._interfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property ObdInterface. 
        /// <para>
        /// Information about a network interface specified by the on-board diagnostic (OBD) II
        /// protocol.
        /// </para>
        /// </summary>
        public ObdInterface ObdInterface
        {
            get { return this._obdInterface; }
            set { this._obdInterface = value; }
        }

        // Check to see if ObdInterface property is set
        internal bool IsSetObdInterface()
        {
            return this._obdInterface != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The network protocol for the vehicle. For example, <c>CAN_SIGNAL</c> specifies a protocol
        /// that defines how data is communicated between electronic control units (ECUs). <c>OBD_SIGNAL</c>
        /// specifies a protocol that defines how self-diagnostic data is communicated between
        /// ECUs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkInterfaceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VehicleMiddleware. 
        /// <para>
        /// The vehicle middleware defined as a type of network interface. Examples of vehicle
        /// middleware include <c>ROS2</c> and <c>SOME/IP</c>.
        /// </para>
        /// </summary>
        public VehicleMiddleware VehicleMiddleware
        {
            get { return this._vehicleMiddleware; }
            set { this._vehicleMiddleware = value; }
        }

        // Check to see if VehicleMiddleware property is set
        internal bool IsSetVehicleMiddleware()
        {
            return this._vehicleMiddleware != null;
        }

    }
}