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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The high-level properties of a firewall policy. This, along with the <a>FirewallPolicy</a>,
    /// define the policy. You can retrieve all objects for a firewall policy by calling <a>DescribeFirewallPolicy</a>.
    /// </summary>
    public partial class FirewallPolicyResponse
    {
        /// <summary>
        /// Gets and sets the property ConsumedStatefulDomainCapacity. 
        /// <para>
        /// The total number of domain name specifications across all domain list rule groups
        /// in the firewall policy that use the <c>stateful-domain-rulegroup</c> resource type.
        /// </para>
        /// </summary>
        public int? ConsumedStatefulDomainCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedStatefulDomainCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedStatefulDomainCapacity() => this.ConsumedStatefulDomainCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumedStatefulRuleCapacity. 
        /// <para>
        /// The number of capacity units currently consumed by the policy's stateful rules.
        /// </para>
        /// </summary>
        public int? ConsumedStatefulRuleCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedStatefulRuleCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedStatefulRuleCapacity() => this.ConsumedStatefulRuleCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumedStatelessRuleCapacity. 
        /// <para>
        /// The number of capacity units currently consumed by the policy's stateless rules.
        /// </para>
        /// </summary>
        public int? ConsumedStatelessRuleCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedStatelessRuleCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedStatelessRuleCapacity() => this.ConsumedStatelessRuleCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains the Amazon Web Services KMS encryption configuration
        /// settings for your firewall policy.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Any configuration errors that apply to the firewall policy. Network Firewall detects
        /// these errors asynchronously, after you create or update the policy, so an error can
        /// appear after the request that caused it has already succeeded. Each entry describes
        /// the problem and how to resolve it, and Network Firewall clears it automatically after
        /// you resolve the problem.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<FirewallPolicyError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<FirewallPolicyError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// If this response is for a create request that had <c>DryRun</c> set to <c>TRUE</c>,
        /// then this ARN is a placeholder that isn't attached to a valid resource.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FirewallPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyArn property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyArn() => this.FirewallPolicyArn != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyId. 
        /// <para>
        /// The unique identifier for the firewall policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string FirewallPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyId property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyId() => this.FirewallPolicyId != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyName. 
        /// <para>
        /// The descriptive name of the firewall policy. You can't change the name of a firewall
        /// policy after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string FirewallPolicyName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyName property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyName() => this.FirewallPolicyName != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyStatus. 
        /// <para>
        /// The current status of the firewall policy. You can retrieve this for a firewall policy
        /// by calling <a>DescribeFirewallPolicy</a> and providing the firewall policy's name
        /// or ARN.
        /// </para>
        /// </summary>
        public ResourceStatus FirewallPolicyStatus { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyStatus property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyStatus() => this.FirewallPolicyStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the firewall policy was changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssociations. 
        /// <para>
        /// The number of firewalls that are associated with this firewall policy.
        /// </para>
        /// </summary>
        public int? NumberOfAssociations { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociations property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociations() => this.NumberOfAssociations.HasValue;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional detail about the firewall policy's current status, when applicable. For
        /// example, while an Amazon Route 53 Resolver DNS Firewall rule group change is in progress,
        /// the status is <c>UPDATING</c> and this message is "A DNS Firewall rule group change
        /// is in progress."
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
