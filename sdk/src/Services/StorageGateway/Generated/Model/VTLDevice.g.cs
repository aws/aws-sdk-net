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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Represents a device object associated with a tape gateway.
    /// </summary>
    public partial class VTLDevice
    {
        /// <summary>
        /// Gets and sets the property DeviceiSCSIAttributes. 
        /// <para>
        /// A list of iSCSI information about a VTL device.
        /// </para>
        /// </summary>
        public DeviceiSCSIAttributes DeviceiSCSIAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DeviceiSCSIAttributes property is set.
        /// </summary>
        internal bool IsSetDeviceiSCSIAttributes() => this.DeviceiSCSIAttributes != null;

        /// <summary>
        /// Gets and sets the property VTLDeviceARN. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) of the device (tape drive or media
        /// changer).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string VTLDeviceARN { get; set; }

        /// <summary>
        /// Checks to see if the VTLDeviceARN property is set.
        /// </summary>
        internal bool IsSetVTLDeviceARN() => this.VTLDeviceARN != null;

        /// <summary>
        /// Gets and sets the property VTLDeviceProductIdentifier. 
        /// <para>
        /// Specifies the model number of device that the VTL device emulates.
        /// </para>
        /// </summary>
        public string VTLDeviceProductIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VTLDeviceProductIdentifier property is set.
        /// </summary>
        internal bool IsSetVTLDeviceProductIdentifier() => this.VTLDeviceProductIdentifier != null;

        /// <summary>
        /// Gets and sets the property VTLDeviceType. 
        /// <para>
        /// Specifies the type of device that the VTL device emulates.
        /// </para>
        /// </summary>
        public string VTLDeviceType { get; set; }

        /// <summary>
        /// Checks to see if the VTLDeviceType property is set.
        /// </summary>
        internal bool IsSetVTLDeviceType() => this.VTLDeviceType != null;

        /// <summary>
        /// Gets and sets the property VTLDeviceVendor. 
        /// <para>
        /// Specifies the vendor of the device that the VTL device object emulates.
        /// </para>
        /// </summary>
        public string VTLDeviceVendor { get; set; }

        /// <summary>
        /// Checks to see if the VTLDeviceVendor property is set.
        /// </summary>
        internal bool IsSetVTLDeviceVendor() => this.VTLDeviceVendor != null;
    }
}
