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
    /// Container for the parameters to the GetVpnConnectionDeviceSampleConfiguration operation.
    /// Download an Amazon Web Services-provided sample configuration file to be used with
    /// the customer gateway device specified for your Site-to-Site VPN connection.
    /// </summary>
    public partial class GetVpnConnectionDeviceSampleConfigurationRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _internetKeyExchangeVersion;
        private string _sampleType;
        private string _vpnConnectionDeviceTypeId;
        private string _vpnConnectionId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InternetKeyExchangeVersion. 
        /// <para>
        /// The IKE version to be used in the sample configuration file for your customer gateway
        /// device. You can specify one of the following versions: <c>ikev1</c> or <c>ikev2</c>.
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
        /// Gets and sets the property SampleType. 
        /// <para>
        /// The type of sample configuration to generate. Valid values are "compatibility" (includes
        /// IKEv1) or "recommended" (throws UnsupportedOperationException for IKEv1).
        /// </para>
        /// </summary>
        public string SampleType
        {
            get { return this._sampleType; }
            set { this._sampleType = value; }
        }

        // Check to see if SampleType property is set
        internal bool IsSetSampleType()
        {
            return this._sampleType != null;
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionDeviceTypeId. 
        /// <para>
        /// Device identifier provided by the <c>GetVpnConnectionDeviceTypes</c> API.
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
        /// The <c>VpnConnectionId</c> specifies the Site-to-Site VPN connection used for the
        /// sample configuration.
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