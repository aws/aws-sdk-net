/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Represents a device object associated with a gateway-VTL.
    /// </summary>
    public partial class VTLDevice
    {
        private DeviceiSCSIAttributes _deviceiSCSIAttributes;
        private string _vTLDeviceARN;
        private string _vTLDeviceProductIdentifier;
        private string _vTLDeviceType;
        private string _vTLDeviceVendor;

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
        public string VTLDeviceARN
        {
            get { return this._vTLDeviceARN; }
            set { this._vTLDeviceARN = value; }
        }

        // Check to see if VTLDeviceARN property is set
        internal bool IsSetVTLDeviceARN()
        {
            return this._vTLDeviceARN != null;
        }

        /// <summary>
        /// Gets and sets the property VTLDeviceProductIdentifier.
        /// </summary>
        public string VTLDeviceProductIdentifier
        {
            get { return this._vTLDeviceProductIdentifier; }
            set { this._vTLDeviceProductIdentifier = value; }
        }

        // Check to see if VTLDeviceProductIdentifier property is set
        internal bool IsSetVTLDeviceProductIdentifier()
        {
            return this._vTLDeviceProductIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property VTLDeviceType.
        /// </summary>
        public string VTLDeviceType
        {
            get { return this._vTLDeviceType; }
            set { this._vTLDeviceType = value; }
        }

        // Check to see if VTLDeviceType property is set
        internal bool IsSetVTLDeviceType()
        {
            return this._vTLDeviceType != null;
        }

        /// <summary>
        /// Gets and sets the property VTLDeviceVendor.
        /// </summary>
        public string VTLDeviceVendor
        {
            get { return this._vTLDeviceVendor; }
            set { this._vTLDeviceVendor = value; }
        }

        // Check to see if VTLDeviceVendor property is set
        internal bool IsSetVTLDeviceVendor()
        {
            return this._vTLDeviceVendor != null;
        }

    }
}