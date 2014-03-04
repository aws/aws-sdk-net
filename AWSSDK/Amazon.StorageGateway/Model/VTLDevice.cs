/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para> Represents a device object associated with a gateway-VTL. </para>
    /// </summary>
    public partial class VTLDevice
    {
        
        private string vTLDeviceARN;
        private string vTLDeviceType;
        private string vTLDeviceVendor;
        private string vTLDeviceProductIdentifier;
        private DeviceiSCSIAttributes deviceiSCSIAttributes;

        /// <summary>
        /// Specifies the unique Amazon Resource Name (ARN) of the device (tape drive or media changer).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VTLDeviceARN
        {
            get { return this.vTLDeviceARN; }
            set { this.vTLDeviceARN = value; }
        }

        /// <summary>
        /// Sets the VTLDeviceARN property
        /// </summary>
        /// <param name="vTLDeviceARN">The value to set for the VTLDeviceARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VTLDevice WithVTLDeviceARN(string vTLDeviceARN)
        {
            this.vTLDeviceARN = vTLDeviceARN;
            return this;
        }
            

        // Check to see if VTLDeviceARN property is set
        internal bool IsSetVTLDeviceARN()
        {
            return this.vTLDeviceARN != null;
        }
        public string VTLDeviceType
        {
            get { return this.vTLDeviceType; }
            set { this.vTLDeviceType = value; }
        }

        /// <summary>
        /// Sets the VTLDeviceType property
        /// </summary>
        /// <param name="vTLDeviceType">The value to set for the VTLDeviceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VTLDevice WithVTLDeviceType(string vTLDeviceType)
        {
            this.vTLDeviceType = vTLDeviceType;
            return this;
        }
            

        // Check to see if VTLDeviceType property is set
        internal bool IsSetVTLDeviceType()
        {
            return this.vTLDeviceType != null;
        }
        public string VTLDeviceVendor
        {
            get { return this.vTLDeviceVendor; }
            set { this.vTLDeviceVendor = value; }
        }

        /// <summary>
        /// Sets the VTLDeviceVendor property
        /// </summary>
        /// <param name="vTLDeviceVendor">The value to set for the VTLDeviceVendor property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VTLDevice WithVTLDeviceVendor(string vTLDeviceVendor)
        {
            this.vTLDeviceVendor = vTLDeviceVendor;
            return this;
        }
            

        // Check to see if VTLDeviceVendor property is set
        internal bool IsSetVTLDeviceVendor()
        {
            return this.vTLDeviceVendor != null;
        }
        public string VTLDeviceProductIdentifier
        {
            get { return this.vTLDeviceProductIdentifier; }
            set { this.vTLDeviceProductIdentifier = value; }
        }

        /// <summary>
        /// Sets the VTLDeviceProductIdentifier property
        /// </summary>
        /// <param name="vTLDeviceProductIdentifier">The value to set for the VTLDeviceProductIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VTLDevice WithVTLDeviceProductIdentifier(string vTLDeviceProductIdentifier)
        {
            this.vTLDeviceProductIdentifier = vTLDeviceProductIdentifier;
            return this;
        }
            

        // Check to see if VTLDeviceProductIdentifier property is set
        internal bool IsSetVTLDeviceProductIdentifier()
        {
            return this.vTLDeviceProductIdentifier != null;
        }

        /// <summary>
        /// A list of iSCSI information about a VTL device.
        ///  
        /// </summary>
        public DeviceiSCSIAttributes DeviceiSCSIAttributes
        {
            get { return this.deviceiSCSIAttributes; }
            set { this.deviceiSCSIAttributes = value; }
        }

        /// <summary>
        /// Sets the DeviceiSCSIAttributes property
        /// </summary>
        /// <param name="deviceiSCSIAttributes">The value to set for the DeviceiSCSIAttributes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VTLDevice WithDeviceiSCSIAttributes(DeviceiSCSIAttributes deviceiSCSIAttributes)
        {
            this.deviceiSCSIAttributes = deviceiSCSIAttributes;
            return this;
        }
            

        // Check to see if DeviceiSCSIAttributes property is set
        internal bool IsSetDeviceiSCSIAttributes()
        {
            return this.deviceiSCSIAttributes != null;
        }
    }
}
