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
    /// Defines the accounts, organizational units, and firewall types that an administrator
    /// can manage.
    /// </summary>
    public partial class AdminScope
    {
        private AdminFirewallTypeScope _firewallTypeScope;
        private AdminScopeFilter _scopeFilter;

        /// <summary>
        /// Gets and sets the property FirewallTypeScope. 
        /// <para>
        /// The firewall types that the administrator can create and manage.
        /// </para>
        /// </summary>
        public AdminFirewallTypeScope FirewallTypeScope
        {
            get { return this._firewallTypeScope; }
            set { this._firewallTypeScope = value; }
        }

        // Check to see if FirewallTypeScope property is set
        internal bool IsSetFirewallTypeScope()
        {
            return this._firewallTypeScope != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeFilter. 
        /// <para>
        /// The filter that determines which accounts and organizational units are in the administrator's
        /// scope.
        /// </para>
        /// </summary>
        public AdminScopeFilter ScopeFilter
        {
            get { return this._scopeFilter; }
            set { this._scopeFilter = value; }
        }

        // Check to see if ScopeFilter property is set
        internal bool IsSetScopeFilter()
        {
            return this._scopeFilter != null;
        }

    }
}