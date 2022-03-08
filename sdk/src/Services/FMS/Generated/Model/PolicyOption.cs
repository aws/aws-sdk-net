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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Contains the Network Firewall firewall policy options to configure a centralized deployment
    /// model.
    /// </summary>
    public partial class PolicyOption
    {
        private NetworkFirewallPolicy _networkFirewallPolicy;

        /// <summary>
        /// Gets and sets the property NetworkFirewallPolicy. 
        /// <para>
        /// Defines the deployment model to use for the firewall policy.
        /// </para>
        /// </summary>
        public NetworkFirewallPolicy NetworkFirewallPolicy
        {
            get { return this._networkFirewallPolicy; }
            set { this._networkFirewallPolicy = value; }
        }

        // Check to see if NetworkFirewallPolicy property is set
        internal bool IsSetNetworkFirewallPolicy()
        {
            return this._networkFirewallPolicy != null;
        }

    }
}