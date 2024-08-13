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
    /// Container for the parameters to the UpdateFirewallRuleGroupAssociation operation.
    /// Changes the association of a <a>FirewallRuleGroup</a> with a VPC. The association
    /// enables DNS filtering for the VPC.
    /// </summary>
    public partial class UpdateFirewallRuleGroupAssociationRequest : AmazonRoute53ResolverRequest
    {
        private string _firewallRuleGroupAssociationId;
        private MutationProtectionStatus _mutationProtection;
        private string _name;
        private int? _priority;

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupAssociationId. 
        /// <para>
        /// The identifier of the <a>FirewallRuleGroupAssociation</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FirewallRuleGroupAssociationId
        {
            get { return this._firewallRuleGroupAssociationId; }
            set { this._firewallRuleGroupAssociationId = value; }
        }

        // Check to see if FirewallRuleGroupAssociationId property is set
        internal bool IsSetFirewallRuleGroupAssociationId()
        {
            return this._firewallRuleGroupAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property MutationProtection. 
        /// <para>
        /// If enabled, this setting disallows modification or removal of the association, to
        /// help prevent against accidentally altering DNS firewall protections. 
        /// </para>
        /// </summary>
        public MutationProtectionStatus MutationProtection
        {
            get { return this._mutationProtection; }
            set { this._mutationProtection = value; }
        }

        // Check to see if MutationProtection property is set
        internal bool IsSetMutationProtection()
        {
            return this._mutationProtection != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule group association.
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
        /// The setting that determines the processing order of the rule group among the rule
        /// groups that you associate with the specified VPC. DNS Firewall filters VPC traffic
        /// starting from the rule group with the lowest numeric priority setting. 
        /// </para>
        ///  
        /// <para>
        /// You must specify a unique priority for each rule group that you associate with a single
        /// VPC. To make it easier to insert rule groups later, leave space between the numbers,
        /// for example, use 100, 200, and so on. You can change the priority setting for a rule
        /// group association after you create it.
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