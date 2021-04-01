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
    /// This is the response object from the ListFirewallRuleGroupAssociations operation.
    /// </summary>
    public partial class ListFirewallRuleGroupAssociationsResponse : AmazonWebServiceResponse
    {
        private List<FirewallRuleGroupAssociation> _firewallRuleGroupAssociations = new List<FirewallRuleGroupAssociation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupAssociations. 
        /// <para>
        /// A list of your firewall rule group associations.
        /// </para>
        ///  
        /// <para>
        /// This might be a partial list of the associations that you have defined. For information,
        /// see <code>MaxResults</code>. 
        /// </para>
        /// </summary>
        public List<FirewallRuleGroupAssociation> FirewallRuleGroupAssociations
        {
            get { return this._firewallRuleGroupAssociations; }
            set { this._firewallRuleGroupAssociations = value; }
        }

        // Check to see if FirewallRuleGroupAssociations property is set
        internal bool IsSetFirewallRuleGroupAssociations()
        {
            return this._firewallRuleGroupAssociations != null && this._firewallRuleGroupAssociations.Count > 0; 
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