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
    /// This is the response object from the ListThirdPartyFirewallFirewallPolicies operation.
    /// </summary>
    public partial class ListThirdPartyFirewallFirewallPoliciesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ThirdPartyFirewallFirewallPolicy> _thirdPartyFirewallFirewallPolicies = new List<ThirdPartyFirewallFirewallPolicy>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The value that you will use for <code>NextToken</code> in the next <code>ListThirdPartyFirewallFirewallPolicies</code>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ThirdPartyFirewallFirewallPolicies. 
        /// <para>
        /// A list that contains one <code>ThirdPartyFirewallFirewallPolicies</code> element for
        /// each third-party firewall policies that the specified third-party firewall vendor
        /// is associated with. Each <code>ThirdPartyFirewallFirewallPolicies</code> element contains
        /// the firewall policy name and ID.
        /// </para>
        /// </summary>
        public List<ThirdPartyFirewallFirewallPolicy> ThirdPartyFirewallFirewallPolicies
        {
            get { return this._thirdPartyFirewallFirewallPolicies; }
            set { this._thirdPartyFirewallFirewallPolicies = value; }
        }

        // Check to see if ThirdPartyFirewallFirewallPolicies property is set
        internal bool IsSetThirdPartyFirewallFirewallPolicies()
        {
            return this._thirdPartyFirewallFirewallPolicies != null && this._thirdPartyFirewallFirewallPolicies.Count > 0; 
        }

    }
}