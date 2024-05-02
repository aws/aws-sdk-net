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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
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
namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// The details about the physical network interface for the device.
    /// </summary>
    public partial class PhysicalNetworkInterface
    {
        private string _defaultGateway;
        private string _ipAddress;
        private IpAddressAssignment _ipAddressAssignment;
        private string _macAddress;
        private string _netmask;
        private PhysicalConnectorType _physicalConnectorType;
        private string _physicalNetworkInterfaceId;

        /// <summary>
        /// Gets and sets the property DefaultGateway. 
        /// <para>
        /// The default gateway of the device.
        /// </para>
        /// </summary>
        public string DefaultGateway
        {
            get { return this._defaultGateway; }
            set { this._defaultGateway = value; }
        }

        // Check to see if DefaultGateway property is set
        internal bool IsSetDefaultGateway()
        {
            return this._defaultGateway != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the device.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressAssignment. 
        /// <para>
        /// A value that describes whether the IP address is dynamic or persistent.
        /// </para>
        /// </summary>
        public IpAddressAssignment IpAddressAssignment
        {
            get { return this._ipAddressAssignment; }
            set { this._ipAddressAssignment = value; }
        }

        // Check to see if IpAddressAssignment property is set
        internal bool IsSetIpAddressAssignment()
        {
            return this._ipAddressAssignment != null;
        }

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The MAC address of the device.
        /// </para>
        /// </summary>
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this._macAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Netmask. 
        /// <para>
        /// The netmask used to divide the IP address into subnets.
        /// </para>
        /// </summary>
        public string Netmask
        {
            get { return this._netmask; }
            set { this._netmask = value; }
        }

        // Check to see if Netmask property is set
        internal bool IsSetNetmask()
        {
            return this._netmask != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalConnectorType. 
        /// <para>
        /// The physical connector type.
        /// </para>
        /// </summary>
        public PhysicalConnectorType PhysicalConnectorType
        {
            get { return this._physicalConnectorType; }
            set { this._physicalConnectorType = value; }
        }

        // Check to see if PhysicalConnectorType property is set
        internal bool IsSetPhysicalConnectorType()
        {
            return this._physicalConnectorType != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalNetworkInterfaceId. 
        /// <para>
        /// The physical network interface ID.
        /// </para>
        /// </summary>
        public string PhysicalNetworkInterfaceId
        {
            get { return this._physicalNetworkInterfaceId; }
            set { this._physicalNetworkInterfaceId = value; }
        }

        // Check to see if PhysicalNetworkInterfaceId property is set
        internal bool IsSetPhysicalNetworkInterfaceId()
        {
            return this._physicalNetworkInterfaceId != null;
        }

    }
}