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
    /// List of customer gateway devices that have a sample configuration file available for
    /// use. You can also see the list of device types with sample configuration files available
    /// under <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/your-cgw.html">Your customer
    /// gateway device</a> in the <i>Amazon Web Services Site-to-Site VPN User Guide</i>.
    /// </summary>
    public partial class VpnConnectionDeviceType
    {
        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// Customer gateway device platform.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Software. 
        /// <para>
        /// Customer gateway device software version.
        /// </para>
        /// </summary>
        public string Software { get; set; }

        /// <summary>
        /// Checks to see if the Software property is set.
        /// </summary>
        internal bool IsSetSoftware() => this.Software != null;

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// Customer gateway device vendor.
        /// </para>
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// Checks to see if the Vendor property is set.
        /// </summary>
        internal bool IsSetVendor() => this.Vendor != null;

        /// <summary>
        /// Gets and sets the property VpnConnectionDeviceTypeId. 
        /// <para>
        /// Customer gateway device identifier.
        /// </para>
        /// </summary>
        public string VpnConnectionDeviceTypeId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConnectionDeviceTypeId property is set.
        /// </summary>
        internal bool IsSetVpnConnectionDeviceTypeId() => this.VpnConnectionDeviceTypeId != null;
    }
}
