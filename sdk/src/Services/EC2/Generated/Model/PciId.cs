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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _deviceId;
        private string _subsystemId;
        private string _subsystemVendorId;
        private string _vendorId;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The ID of the device.
        /// </para>
        /// </summary>
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property SubsystemId. 
        /// <para>
        /// The ID of the subsystem.
        /// </para>
        /// </summary>
        public string SubsystemId
        {
            get { return this._subsystemId; }
            set { this._subsystemId = value; }
        }

        // Check to see if SubsystemId property is set
        internal bool IsSetSubsystemId()
        {
            return this._subsystemId != null;
        }

        /// <summary>
        /// Gets and sets the property SubsystemVendorId. 
        /// <para>
        /// The ID of the vendor for the subsystem.
        /// </para>
        /// </summary>
        public string SubsystemVendorId
        {
            get { return this._subsystemVendorId; }
            set { this._subsystemVendorId = value; }
        }

        // Check to see if SubsystemVendorId property is set
        internal bool IsSetSubsystemVendorId()
        {
            return this._subsystemVendorId != null;
        }

        /// <summary>
        /// Gets and sets the property VendorId. 
        /// <para>
        /// The ID of the vendor.
        /// </para>
        /// </summary>
        public string VendorId
        {
            get { return this._vendorId; }
            set { this._vendorId = value; }
        }

        // Check to see if VendorId property is set
        internal bool IsSetVendorId()
        {
            return this._vendorId != null;
        }

    }
}