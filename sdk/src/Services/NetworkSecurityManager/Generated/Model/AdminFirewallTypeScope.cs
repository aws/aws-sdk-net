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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Defines the firewall types that an administrator can create and manage.
    /// </summary>
    public partial class AdminFirewallTypeScope
    {
        private bool? _allFirewallTypesEnabled;
        private List<string> _firewallTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllFirewallTypesEnabled. 
        /// <para>
        /// Specifies whether the administrator can manage all firewall types, except for third-party
        /// firewall types.
        /// </para>
        /// </summary>
        public bool? AllFirewallTypesEnabled
        {
            get { return this._allFirewallTypesEnabled; }
            set { this._allFirewallTypesEnabled = value; }
        }

        // Check to see if AllFirewallTypesEnabled property is set
        internal bool IsSetAllFirewallTypesEnabled()
        {
            return this._allFirewallTypesEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirewallTypes. 
        /// <para>
        /// The list of firewall types that the administrator can manage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> FirewallTypes
        {
            get { return this._firewallTypes; }
            set { this._firewallTypes = value; }
        }

        // Check to see if FirewallTypes property is set
        internal bool IsSetFirewallTypes()
        {
            return this._firewallTypes != null && (this._firewallTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}