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
    /// Describes why a firewall is out of sync. Exactly one of <c>missingFirewall</c> or
    /// <c>invalidFirewall</c> is set.
    /// </summary>
    public partial class FirewallSyncReason
    {
        private InvalidFirewallReasons _invalidFirewall;
        private string _missingFirewall;

        /// <summary>
        /// Gets and sets the property InvalidFirewall. 
        /// <para>
        /// Details about a firewall whose configuration does not match the intended configuration.
        /// </para>
        /// </summary>
        public InvalidFirewallReasons InvalidFirewall
        {
            get { return this._invalidFirewall; }
            set { this._invalidFirewall = value; }
        }

        // Check to see if InvalidFirewall property is set
        internal bool IsSetInvalidFirewall()
        {
            return this._invalidFirewall != null;
        }

        /// <summary>
        /// Gets and sets the property MissingFirewall. 
        /// <para>
        /// Indicates that an expected firewall is missing. The value describes the missing firewall.
        /// </para>
        /// </summary>
        public string MissingFirewall
        {
            get { return this._missingFirewall; }
            set { this._missingFirewall = value; }
        }

        // Check to see if MissingFirewall property is set
        internal bool IsSetMissingFirewall()
        {
            return this._missingFirewall != null;
        }

    }
}