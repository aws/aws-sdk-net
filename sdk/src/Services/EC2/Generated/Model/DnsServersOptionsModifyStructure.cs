/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the DNS server to be used.
    /// </summary>
    public partial class DnsServersOptionsModifyStructure
    {
        private List<string> _customDnsServers = new List<string>();
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property CustomDnsServers. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the DNS servers to be used. You can specify
        /// up to two DNS servers. Ensure that the DNS servers can be reached by the clients.
        /// The specified values overwrite the existing values.
        /// </para>
        /// </summary>
        public List<string> CustomDnsServers
        {
            get { return this._customDnsServers; }
            set { this._customDnsServers = value; }
        }

        // Check to see if CustomDnsServers property is set
        internal bool IsSetCustomDnsServers()
        {
            return this._customDnsServers != null && this._customDnsServers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether DNS servers should be used. Specify <code>False</code> to delete
        /// the existing DNS servers.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}