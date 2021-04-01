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
    /// Container for the parameters to the UpdateFirewallRule operation.
    /// Updates the specified firewall rule.
    /// </summary>
    public partial class UpdateFirewallRuleRequest : AmazonRoute53ResolverRequest
    {
        private Action _action;
        private BlockOverrideDnsType _blockOverrideDnsType;
        private string _blockOverrideDomain;
        private int? _blockOverrideTtl;
        private BlockResponse _blockResponse;
        private string _firewallDomainListId;
        private string _firewallRuleGroupId;
        private string _name;
        private int? _priority;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that DNS Firewall should take on a DNS query when it matches one of the
        /// domains in the rule's domain list:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALLOW</code> - Permit the request to go through.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALERT</code> - Permit the request to go through but send an alert to the logs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BLOCK</code> - Disallow the request. This option requires additional details
        /// in the rule's <code>BlockResponse</code>. 
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
        /// Gets and sets the property BlockOverrideDnsType. 
        /// <para>
        /// The DNS record's type. This determines the format of the record value that you provided
        /// in <code>BlockOverrideDomain</code>. Used for the rule action <code>BLOCK</code> with
        /// a <code>BlockResponse</code> setting of <code>OVERRIDE</code>.
        /// </para>
        /// </summary>
        public BlockOverrideDnsType BlockOverrideDnsType
        {
            get { return this._blockOverrideDnsType; }
            set { this._blockOverrideDnsType = value; }
        }

        // Check to see if BlockOverrideDnsType property is set
        internal bool IsSetBlockOverrideDnsType()
        {
            return this._blockOverrideDnsType != null;
        }

        /// <summary>
        /// Gets and sets the property BlockOverrideDomain. 
        /// <para>
        /// The custom DNS record to send back in response to the query. Used for the rule action
        /// <code>BLOCK</code> with a <code>BlockResponse</code> setting of <code>OVERRIDE</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string BlockOverrideDomain
        {
            get { return this._blockOverrideDomain; }
            set { this._blockOverrideDomain = value; }
        }

        // Check to see if BlockOverrideDomain property is set
        internal bool IsSetBlockOverrideDomain()
        {
            return this._blockOverrideDomain != null;
        }

        /// <summary>
        /// Gets and sets the property BlockOverrideTtl. 
        /// <para>
        /// The recommended amount of time, in seconds, for the DNS resolver or web browser to
        /// cache the provided override record. Used for the rule action <code>BLOCK</code> with
        /// a <code>BlockResponse</code> setting of <code>OVERRIDE</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=604800)]
        public int BlockOverrideTtl
        {
            get { return this._blockOverrideTtl.GetValueOrDefault(); }
            set { this._blockOverrideTtl = value; }
        }

        // Check to see if BlockOverrideTtl property is set
        internal bool IsSetBlockOverrideTtl()
        {
            return this._blockOverrideTtl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlockResponse. 
        /// <para>
        /// The way that you want DNS Firewall to block the request. Used for the rule action
        /// setting <code>BLOCK</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NODATA</code> - Respond indicating that the query was successful, but no response
        /// is available for it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NXDOMAIN</code> - Respond indicating that the domain name that's in the query
        /// doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OVERRIDE</code> - Provide a custom override in the response. This option requires
        /// custom handling details in the rule's <code>BlockOverride*</code> settings. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BlockResponse BlockResponse
        {
            get { return this._blockResponse; }
            set { this._blockResponse = value; }
        }

        // Check to see if BlockResponse property is set
        internal bool IsSetBlockResponse()
        {
            return this._blockResponse != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the domain list to use in the rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FirewallDomainListId
        {
            get { return this._firewallDomainListId; }
            set { this._firewallDomainListId = value; }
        }

        // Check to see if FirewallDomainListId property is set
        internal bool IsSetFirewallDomainListId()
        {
            return this._firewallDomainListId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group for the rule. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The setting that determines the processing order of the rule in the rule group. DNS
        /// Firewall processes the rules in a rule group by order of priority, starting from the
        /// lowest setting.
        /// </para>
        ///  
        /// <para>
        /// You must specify a unique priority for each rule in a rule group. To make it easier
        /// to insert rules later, leave space between the numbers, for example, use 100, 200,
        /// and so on. You can change the priority setting for the rules in a rule group at any
        /// time.
        /// </para>
        /// </summary>
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

    }
}