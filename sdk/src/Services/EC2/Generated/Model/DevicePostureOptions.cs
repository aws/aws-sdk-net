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
    /// Describes the device posture options for a Client VPN endpoint. Device posture options
    /// specify the device trust providers that the endpoint uses to evaluate the security
    /// posture of connecting devices.
    /// </summary>
    public partial class DevicePostureOptions
    {
        private bool? _enabled;
        private List<ClientVpnTrustProviderRequest> _trustProviders = AWSConfigs.InitializeCollections ? new List<ClientVpnTrustProviderRequest>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether device posture evaluation is enabled for the Client VPN endpoint.
        /// Specify <c>false</c> to disable device posture, which clears the configured device
        /// trust providers.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrustProviders. 
        /// <para>
        /// The device trust providers to configure for the Client VPN endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClientVpnTrustProviderRequest> TrustProviders
        {
            get { return this._trustProviders; }
            set { this._trustProviders = value; }
        }

        // Check to see if TrustProviders property is set
        internal bool IsSetTrustProviders()
        {
            return this._trustProviders != null && (this._trustProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}