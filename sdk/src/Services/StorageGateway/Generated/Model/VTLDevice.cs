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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
        private DeviceiSCSIAttributes _deviceiSCSIAttributes;
        private string _vtlDeviceARN;
        private string _vtlDeviceProductIdentifier;
        private string _vtlDeviceType;
        private string _vtlDeviceVendor;

        /// <summary>
        /// Gets and sets the property DeviceiSCSIAttributes. 
        /// <para>
        /// A list of iSCSI information about a VTL device.
        /// </para>
        /// </summary>
        public DeviceiSCSIAttributes DeviceiSCSIAttributes
        {
            get { return this._deviceiSCSIAttributes; }
            set { this._deviceiSCSIAttributes = value; }
        }

        // Check to see if DeviceiSCSIAttributes property is set
        internal bool IsSetDeviceiSCSIAttributes()
        {
            return this._deviceiSCSIAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property VTLDeviceARN. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) of the device (tape drive or media
        /// changer).
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string VTLDeviceARN
        {
            get { return this._vtlDeviceARN; }
            set { this._vtlDeviceARN = value; }
        }

        // Check to see if VTLDeviceARN property is set
        internal bool IsSetVTLDeviceARN()
        {
            return this._vtlDeviceARN != null;
        }

        /// <summary>
        /// Gets and sets the property VTLDeviceProductIdentifier. 
        /// <para>
        /// Specifies the model number of device that the VTL device emulates.
        /// </para>
        /// </summary>
        public string VTLDeviceProductIdentifier
        {
            get { return this._vtlDeviceProductIdentifier; }
            set { this._vtlDeviceProductIdentifier = value; }
        }

        // Check to see if VTLDeviceProductIdentifier property is set
        internal bool IsSetVTLDeviceProductIdentifier()
        {
            return this._vtlDeviceProductIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property VTLDeviceType. 
        /// <para>
        /// Specifies the type of device that the VTL device emulates.
        /// </para>
        /// </summary>
        public string VTLDeviceType
        {
            get { return this._vtlDeviceType; }
            set { this._vtlDeviceType = value; }
        }

        // Check to see if VTLDeviceType property is set
        internal bool IsSetVTLDeviceType()
        {
            return this._vtlDeviceType != null;
        }

        /// <summary>
        /// Gets and sets the property VTLDeviceVendor. 
        /// <para>
        /// Specifies the vendor of the device that the VTL device object emulates.
        /// </para>
        /// </summary>
        public string VTLDeviceVendor
        {
            get { return this._vtlDeviceVendor; }
            set { this._vtlDeviceVendor = value; }
        }

        // Check to see if VTLDeviceVendor property is set
        internal bool IsSetVTLDeviceVendor()
        {
            return this._vtlDeviceVendor != null;
        }

    }
}