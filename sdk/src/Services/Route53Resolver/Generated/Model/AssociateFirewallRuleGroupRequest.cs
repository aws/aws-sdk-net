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
    /// Container for the parameters to the AssociateFirewallRuleGroup operation.
    /// Associates a <a>FirewallRuleGroup</a> with a VPC, to provide DNS filtering for the
    /// VPC.
    /// </summary>
    public partial class AssociateFirewallRuleGroupRequest : AmazonRoute53ResolverRequest
    {
        private string _creatorRequestId;
        private string _firewallRuleGroupId;
        private MutationProtectionStatus _mutationProtection;
        private string _name;
        private int? _priority;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed requests to be
        /// retried without the risk of running the operation twice. <c>CreatorRequestId</c> can
        /// be any unique string, for example, a date/time stamp. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group. 
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
        /// Gets and sets the property MutationProtection. 
        /// <para>
        /// If enabled, this setting disallows modification or removal of the association, to
        /// help prevent against accidentally altering DNS firewall protections. When you create
        /// the association, the default setting is <c>DISABLED</c>. 
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
        /// A name that lets you identify the association, to manage and use it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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
        /// for example, use 101, 200, and so on. You can change the priority setting for a rule
        /// group association after you create it.
        /// </para>
        ///  
        /// <para>
        /// The allowed values for <c>Priority</c> are between 100 and 9900.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag keys and values that you want to associate with the rule group association.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the VPC that you want to associate with the rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}