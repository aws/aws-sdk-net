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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// This is the response object from the ListFirewallRules operation.
    /// </summary>
    public partial class ListFirewallRulesResponse : AmazonWebServiceResponse
    {
        private List<FirewallRule> _firewallRules = new List<FirewallRule>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FirewallRules. 
        /// <para>
        /// A list of the rules that you have defined. 
        /// </para>
        ///  
        /// <para>
        /// This might be a parital list of the firewall rules that you've defined. For information,
        /// see <code>MaxResults</code>. 
        /// </para>
        /// </summary>
        public List<FirewallRule> FirewallRules
        {
            get { return this._firewallRules; }
            set { this._firewallRules = value; }
        }

        // Check to see if FirewallRules property is set
        internal bool IsSetFirewallRules()
        {
            return this._firewallRules != null && this._firewallRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If objects are still available for retrieval, Resolver returns this token in the response.
        /// To retrieve the next batch of objects, provide this token in your next request.
        /// </para>
        /// </summary>
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

    }
}