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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the DescribeFirewallPolicy operation.
    /// </summary>
    public partial class DescribeFirewallPolicyResponse : AmazonWebServiceResponse
    {
        private FirewallPolicy _firewallPolicy;
        private FirewallPolicyResponse _firewallPolicyResponse;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property FirewallPolicy. 
        /// <para>
        /// The policy for the specified firewall policy. 
        /// </para>
        /// </summary>
        public FirewallPolicy FirewallPolicy
        {
            get { return this._firewallPolicy; }
            set { this._firewallPolicy = value; }
        }

        // Check to see if FirewallPolicy property is set
        internal bool IsSetFirewallPolicy()
        {
            return this._firewallPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyResponse. 
        /// <para>
        /// The high-level properties of a firewall policy. This, along with the <a>FirewallPolicy</a>,
        /// define the policy. You can retrieve all objects for a firewall policy by calling <a>DescribeFirewallPolicy</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FirewallPolicyResponse FirewallPolicyResponse
        {
            get { return this._firewallPolicyResponse; }
            set { this._firewallPolicyResponse = value; }
        }

        // Check to see if FirewallPolicyResponse property is set
        internal bool IsSetFirewallPolicyResponse()
        {
            return this._firewallPolicyResponse != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the firewall policy. The token marks the state of the policy resource
        /// at the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the policy, you provide the token in your request. Network Firewall
        /// uses the token to ensure that the policy hasn't changed since you last retrieved it.
        /// If it has changed, the operation fails with an <code>InvalidTokenException</code>.
        /// If this happens, retrieve the firewall policy again to get a current copy of it with
        /// current token. Reapply your changes as needed, then try the operation again using
        /// the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}