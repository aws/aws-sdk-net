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
    /// Describes the data that identifies an Amazon FPGA image (AFI) on the PCI bus.
    /// </summary>
    public partial class PciId
    {
        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property SubsystemId. 
        /// <para>
        /// The ID of the subsystem.
        /// </para>
        /// </summary>
        public string SubsystemId { get; set; }

        /// <summary>
        /// Checks to see if the SubsystemId property is set.
        /// </summary>
        internal bool IsSetSubsystemId() => this.SubsystemId != null;

        /// <summary>
        /// Gets and sets the property SubsystemVendorId. 
        /// <para>
        /// The ID of the vendor for the subsystem.
        /// </para>
        /// </summary>
        public string SubsystemVendorId { get; set; }

        /// <summary>
        /// Checks to see if the SubsystemVendorId property is set.
        /// </summary>
        internal bool IsSetSubsystemVendorId() => this.SubsystemVendorId != null;

        /// <summary>
        /// Gets and sets the property VendorId. 
        /// <para>
        /// The ID of the vendor.
        /// </para>
        /// </summary>
        public string VendorId { get; set; }

        /// <summary>
        /// Checks to see if the VendorId property is set.
        /// </summary>
        internal bool IsSetVendorId() => this.VendorId != null;
    }
}
