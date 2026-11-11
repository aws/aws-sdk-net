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
    /// Container for the parameters to the GetVpnConnectionDeviceSampleConfiguration operation.
    /// Download an Amazon Web Services-provided sample configuration file to be used with
    /// the customer gateway device specified for your Site-to-Site VPN connection.
    /// </summary>
    public partial class GetVpnConnectionDeviceSampleConfigurationRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InternetKeyExchangeVersion. 
        /// <para>
        /// The IKE version to be used in the sample configuration file for your customer gateway
        /// device. You can specify one of the following versions: <c>ikev1</c> or <c>ikev2</c>.
        /// </para>
        /// </summary>
        public string InternetKeyExchangeVersion { get; set; }

        /// <summary>
        /// Checks to see if the InternetKeyExchangeVersion property is set.
        /// </summary>
        internal bool IsSetInternetKeyExchangeVersion() => this.InternetKeyExchangeVersion != null;

        /// <summary>
        /// Gets and sets the property SampleType. 
        /// <para>
        /// The type of sample configuration to generate. Valid values are "compatibility" (includes
        /// IKEv1) or "recommended" (throws UnsupportedOperationException for IKEv1).
        /// </para>
        /// </summary>
        public string SampleType { get; set; }

        /// <summary>
        /// Checks to see if the SampleType property is set.
        /// </summary>
        internal bool IsSetSampleType() => this.SampleType != null;

        /// <summary>
        /// Gets and sets the property VpnConnectionDeviceTypeId. 
        /// <para>
        /// Device identifier provided by the <c>GetVpnConnectionDeviceTypes</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpnConnectionDeviceTypeId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConnectionDeviceTypeId property is set.
        /// </summary>
        internal bool IsSetVpnConnectionDeviceTypeId() => this.VpnConnectionDeviceTypeId != null;

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The <c>VpnConnectionId</c> specifies the Site-to-Site VPN connection used for the
        /// sample configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConnectionId property is set.
        /// </summary>
        internal bool IsSetVpnConnectionId() => this.VpnConnectionId != null;
    }
}
