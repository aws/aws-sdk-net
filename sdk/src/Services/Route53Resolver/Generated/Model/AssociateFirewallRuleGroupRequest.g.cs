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
    /// Container for the parameters to the AssociateFirewallRuleGroup operation. Associates
    /// a <a>FirewallRuleGroup</a> with a VPC, to provide DNS filtering for the VPC. <para>
    /// If the rule group contains any rule configured with the <c>PartnerThreatProtection</c>
    /// rule type, the calling account must hold an active Amazon Web Services Marketplace
    /// subscription to the named partner. If the subscription is missing, the association
    /// request is rejected. </para>
    /// </summary>
    public partial class AssociateFirewallRuleGroupRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed requests to be
        /// retried without the risk of running the operation twice. <c>CreatorRequestId</c> can
        /// be any unique string, for example, a date/time stamp. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string FirewallRuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallRuleGroupId property is set.
        /// </summary>
        internal bool IsSetFirewallRuleGroupId() => this.FirewallRuleGroupId != null;

        /// <summary>
        /// Gets and sets the property MutationProtection. 
        /// <para>
        /// If enabled, this setting disallows modification or removal of the association, to
        /// help prevent against accidentally altering DNS firewall protections. When you create
        /// the association, the default setting is <c>DISABLED</c>. 
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
        /// A name that lets you identify the association, to manage and use it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
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
        /// for example, use 101, 200, and so on. You can change the priority setting for a rule
        /// group association after you create it.
        /// </para>
        ///  
        /// <para>
        /// The allowed values for <c>Priority</c> are between 100 and 9900.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag keys and values that you want to associate with the rule group association.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the VPC that you want to associate with the rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
