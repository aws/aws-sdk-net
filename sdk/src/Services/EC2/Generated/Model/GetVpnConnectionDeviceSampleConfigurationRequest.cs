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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetVpnConnectionDeviceSampleConfiguration operation.
    /// Download an AWS-provided sample configuration file to be used with the customer gateway
    /// device specified for your Site-to-Site VPN connection.
    /// </summary>
    public partial class GetVpnConnectionDeviceSampleConfigurationRequest : AmazonEC2Request
    {
        private string _internetKeyExchangeVersion;
        private string _vpnConnectionDeviceTypeId;
        private string _vpnConnectionId;

        /// <summary>
        /// Gets and sets the property InternetKeyExchangeVersion. 
        /// <para>
        /// The IKE version to be used in the sample configuration file for your customer gateway
        /// device. You can specify one of the following versions: <code>ikev1</code> or <code>ikev2</code>.
        /// </para>
        /// </summary>
        public string InternetKeyExchangeVersion
        {
            get { return this._internetKeyExchangeVersion; }
            set { this._internetKeyExchangeVersion = value; }
        }

        // Check to see if InternetKeyExchangeVersion property is set
        internal bool IsSetInternetKeyExchangeVersion()
        {
            return this._internetKeyExchangeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionDeviceTypeId. 
        /// <para>
        /// Device identifier provided by the <code>GetVpnConnectionDeviceTypes</code> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpnConnectionDeviceTypeId
        {
            get { return this._vpnConnectionDeviceTypeId; }
            set { this._vpnConnectionDeviceTypeId = value; }
        }

        // Check to see if VpnConnectionDeviceTypeId property is set
        internal bool IsSetVpnConnectionDeviceTypeId()
        {
            return this._vpnConnectionDeviceTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The <code>VpnConnectionId</code> specifies the Site-to-Site VPN connection used for
        /// the sample configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpnConnectionId
        {
            get { return this._vpnConnectionId; }
            set { this._vpnConnectionId = value; }
        }

        // Check to see if VpnConnectionId property is set
        internal bool IsSetVpnConnectionId()
        {
            return this._vpnConnectionId != null;
        }

    }
}