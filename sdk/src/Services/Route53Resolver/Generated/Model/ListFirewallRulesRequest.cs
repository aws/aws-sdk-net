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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the ListFirewallRules operation.
    /// Retrieves the firewall rules that you have defined for the specified firewall rule
    /// group. DNS Firewall uses the rules in a rule group to filter DNS network traffic for
    /// a VPC. 
    /// 
    ///  
    /// <para>
    /// A single call might return only a partial list of the rules. For information, see
    /// <c>MaxResults</c>. 
    /// </para>
    /// </summary>
    public partial class ListFirewallRulesRequest : AmazonRoute53ResolverRequest
    {
        private Action _action;
        private string _firewallRuleGroupId;
        private int? _maxResults;
        private string _nextToken;
        private int? _priority;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Optional additional filter for the rules to retrieve.
        /// </para>
        ///  
        /// <para>
        /// The action that DNS Firewall should take on a DNS query when it matches one of the
        /// domains in the rule's domain list, or a threat in a DNS Firewall Advanced rule:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW</c> - Permit the request to go through. Not availabe for DNS Firewall Advanced
        /// rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALERT</c> - Permit the request to go through but send an alert to the logs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BLOCK</c> - Disallow the request. If this is specified, additional handling details
        /// are provided in the rule's <c>BlockResponse</c> setting. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group that you want to retrieve the rules
        /// for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FirewallRuleGroupId
        {
            get { return this._firewallRuleGroupId; }
            set { this._firewallRuleGroupId = value; }
        }

        // Check to see if FirewallRuleGroupId property is set
        internal bool IsSetFirewallRuleGroupId()
        {
            return this._firewallRuleGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you want Resolver to return for this request. If
        /// more objects are available, in the response, Resolver provides a <c>NextToken</c>
        /// value that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <c>MaxResults</c>, Resolver returns up to 100 objects.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For the first call to this list request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// When you request a list of objects, Resolver returns at most the number of objects
        /// specified in <c>MaxResults</c>. If more objects are available for retrieval, Resolver
        /// returns a <c>NextToken</c> value in the response. To retrieve the next batch of objects,
        /// use the token that was returned for the prior request in your next request.
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

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Optional additional filter for the rules to retrieve.
        /// </para>
        ///  
        /// <para>
        /// The setting that determines the processing order of the rules in a rule group. DNS
        /// Firewall processes the rules in a rule group by order of priority, starting from the
        /// lowest setting.
        /// </para>
        /// </summary>
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

    }
}