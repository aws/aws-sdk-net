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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The status of the firewall endpoint and firewall policy configuration for a single
    /// VPC subnet. This is part of the <a>FirewallStatus</a>. 
    /// 
    ///  
    /// <para>
    /// For each VPC subnet that you associate with a firewall, Network Firewall does the
    /// following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Instantiates a firewall endpoint in the subnet, ready to take traffic.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configures the endpoint with the current firewall policy settings, to provide the
    /// filtering behavior for the endpoint.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you update a firewall, for example to add a subnet association or change a rule
    /// group in the firewall policy, the affected sync states reflect out-of-sync or not
    /// ready status until the changes are complete. 
    /// </para>
    /// </summary>
    public partial class SyncState
    {
        private Attachment _attachment;
        private Dictionary<string, PerObjectStatus> _config = AWSConfigs.InitializeCollections ? new Dictionary<string, PerObjectStatus>() : null;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// The configuration and status for a single firewall subnet. For each configured subnet,
        /// Network Firewall creates the attachment by instantiating the firewall endpoint in
        /// the subnet so that it's ready to take traffic. 
        /// </para>
        /// </summary>
        public Attachment Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// The configuration status of the firewall endpoint in a single VPC subnet. Network
        /// Firewall provides each endpoint with the rules that are configured in the firewall
        /// policy. Each time you add a subnet or modify the associated firewall policy, Network
        /// Firewall synchronizes the rules in the endpoint, so it can properly filter network
        /// traffic. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PerObjectStatus> Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null && (this._config.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}