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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// VPN connection options.
    /// </summary>
    public partial class AwsEc2VpnConnectionOptionsDetails
    {
        private bool? _staticRoutesOnly;
        private List<AwsEc2VpnConnectionOptionsTunnelOptionsDetails> _tunnelOptions = AWSConfigs.InitializeCollections ? new List<AwsEc2VpnConnectionOptionsTunnelOptionsDetails>() : null;

        /// <summary>
        /// Gets and sets the property StaticRoutesOnly. 
        /// <para>
        /// Whether the VPN connection uses static routes only.
        /// </para>
        /// </summary>
        public bool? StaticRoutesOnly
        {
            get { return this._staticRoutesOnly; }
            set { this._staticRoutesOnly = value; }
        }

        // Check to see if StaticRoutesOnly property is set
        internal bool IsSetStaticRoutesOnly()
        {
            return this._staticRoutesOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TunnelOptions. 
        /// <para>
        /// The VPN tunnel options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2VpnConnectionOptionsTunnelOptionsDetails> TunnelOptions
        {
            get { return this._tunnelOptions; }
            set { this._tunnelOptions = value; }
        }

        // Check to see if TunnelOptions property is set
        internal bool IsSetTunnelOptions()
        {
            return this._tunnelOptions != null && (this._tunnelOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}