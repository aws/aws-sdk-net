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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property FirewallRuleGroupAssociationId. 
        /// <para>
        /// The identifier of the <a>FirewallRuleGroupAssociation</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FirewallRuleGroupAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRuleGroupAssociationId property is set.
        /// </summary>
        internal bool IsSetFirewallRuleGroupAssociationId() => this.FirewallRuleGroupAssociationId != null;

        /// <summary>
        /// Gets and sets the property MutationProtection. 
        /// <para>
        /// If enabled, this setting disallows modification or removal of the association, to
        /// help prevent against accidentally altering DNS firewall protections. 
        /// </para>
        /// </summary>
        public MutationProtectionStatus MutationProtection { get; set; }

        /// <summary>
        /// Checks to see if the MutationProtection property is set.
        /// </summary>
        internal bool IsSetMutationProtection() => this.MutationProtection != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule group association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;
    }
}
