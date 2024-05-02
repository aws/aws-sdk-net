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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Contains the settings to configure a network ACL policy, a Network Firewall firewall
    /// policy deployment model, or a third-party firewall policy.
    /// </summary>
    public partial class PolicyOption
    {
        private NetworkAclCommonPolicy _networkAclCommonPolicy;
        private NetworkFirewallPolicy _networkFirewallPolicy;
        private ThirdPartyFirewallPolicy _thirdPartyFirewallPolicy;

        /// <summary>
        /// Gets and sets the property NetworkAclCommonPolicy. 
        /// <para>
        /// Defines a Firewall Manager network ACL policy. 
        /// </para>
        /// </summary>
        public NetworkAclCommonPolicy NetworkAclCommonPolicy
        {
            get { return this._networkAclCommonPolicy; }
            set { this._networkAclCommonPolicy = value; }
        }

        // Check to see if NetworkAclCommonPolicy property is set
        internal bool IsSetNetworkAclCommonPolicy()
        {
            return this._networkAclCommonPolicy != null;
        }

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

        /// <summary>
        /// Gets and sets the property ThirdPartyFirewallPolicy. 
        /// <para>
        /// Defines the policy options for a third-party firewall policy.
        /// </para>
        /// </summary>
        public ThirdPartyFirewallPolicy ThirdPartyFirewallPolicy
        {
            get { return this._thirdPartyFirewallPolicy; }
            set { this._thirdPartyFirewallPolicy = value; }
        }

        // Check to see if ThirdPartyFirewallPolicy property is set
        internal bool IsSetThirdPartyFirewallPolicy()
        {
            return this._thirdPartyFirewallPolicy != null;
        }

    }
}