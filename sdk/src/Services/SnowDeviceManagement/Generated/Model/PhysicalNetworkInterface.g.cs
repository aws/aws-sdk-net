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

namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// The details about the physical network interface for the device.
    /// </summary>
    public partial class PhysicalNetworkInterface
    {
        /// <summary>
        /// Gets and sets the property DefaultGateway. 
        /// <para>
        /// The default gateway of the device.
        /// </para>
        /// </summary>
        public string DefaultGateway { get; set; }

        /// <summary>
        /// Checks to see if the DefaultGateway property is set.
        /// </summary>
        internal bool IsSetDefaultGateway() => this.DefaultGateway != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the device.
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property IpAddressAssignment. 
        /// <para>
        /// A value that describes whether the IP address is dynamic or persistent.
        /// </para>
        /// </summary>
        public IpAddressAssignment IpAddressAssignment { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressAssignment property is set.
        /// </summary>
        internal bool IsSetIpAddressAssignment() => this.IpAddressAssignment != null;

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The MAC address of the device.
        /// </para>
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// Checks to see if the MacAddress property is set.
        /// </summary>
        internal bool IsSetMacAddress() => this.MacAddress != null;

        /// <summary>
        /// Gets and sets the property Netmask. 
        /// <para>
        /// The netmask used to divide the IP address into subnets.
        /// </para>
        /// </summary>
        public string Netmask { get; set; }

        /// <summary>
        /// Checks to see if the Netmask property is set.
        /// </summary>
        internal bool IsSetNetmask() => this.Netmask != null;

        /// <summary>
        /// Gets and sets the property PhysicalConnectorType. 
        /// <para>
        /// The physical connector type.
        /// </para>
        /// </summary>
        public PhysicalConnectorType PhysicalConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalConnectorType property is set.
        /// </summary>
        internal bool IsSetPhysicalConnectorType() => this.PhysicalConnectorType != null;

        /// <summary>
        /// Gets and sets the property PhysicalNetworkInterfaceId. 
        /// <para>
        /// The physical network interface ID.
        /// </para>
        /// </summary>
        public string PhysicalNetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalNetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetPhysicalNetworkInterfaceId() => this.PhysicalNetworkInterfaceId != null;
    }
}
