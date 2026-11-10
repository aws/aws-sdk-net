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
    /// The high-level properties of a Next Generation policy. This includes the policy's
    /// identity, status, consumed capacity, and association count. Network Firewall returns
    /// this object in response to the Next Generation policy operations. To retrieve the
    /// policy's rule groups and settings, use the <c>FirewallPolicyV2</c> object.
    /// </summary>
    public partial class FirewallPolicyV2Response
    {
        /// <summary>
        /// Gets and sets the property ConsumedFirewallRuleCapacity. 
        /// <para>
        /// The number of firewall engine rule capacity units that the policy's firewall section
        /// currently consumes.
        /// </para>
        /// </summary>
        public int? ConsumedFirewallRuleCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedFirewallRuleCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedFirewallRuleCapacity() => this.ConsumedFirewallRuleCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumedIpsDomainCapacity. 
        /// <para>
        /// The number of IPS domain list capacity units that the policy's IPS section currently
        /// consumes.
        /// </para>
        /// </summary>
        public int? ConsumedIpsDomainCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedIpsDomainCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedIpsDomainCapacity() => this.ConsumedIpsDomainCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumedIpsRuleCapacity. 
        /// <para>
        /// The number of IPS engine rule capacity units that the policy's IPS section currently
        /// consumes.
        /// </para>
        /// </summary>
        public int? ConsumedIpsRuleCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedIpsRuleCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedIpsRuleCapacity() => this.ConsumedIpsRuleCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the Next Generation policy.
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
        /// settings for your Next Generation policy.
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
        /// Any configuration errors that apply to the Next Generation policy. Network Firewall
        /// detects these errors asynchronously, after you create or update the policy, so an
        /// error can appear after the request that caused it has already succeeded. Each entry
        /// describes the problem and how to resolve it, and Network Firewall clears it automatically
        /// after you resolve the problem.
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
        /// Gets and sets the property FirewallPolicyV2Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Next Generation policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FirewallPolicyV2Arn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyV2Arn property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyV2Arn() => this.FirewallPolicyV2Arn != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyV2Id. 
        /// <para>
        /// The unique identifier of the Next Generation policy. Network Firewall assigns this
        /// identifier when you create the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string FirewallPolicyV2Id { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyV2Id property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyV2Id() => this.FirewallPolicyV2Id != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyV2Name. 
        /// <para>
        /// The descriptive name of the Next Generation policy. You can't change the name of a
        /// firewall policy after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string FirewallPolicyV2Name { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyV2Name property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyV2Name() => this.FirewallPolicyV2Name != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyV2Status. 
        /// <para>
        /// The current status of the Next Generation policy. A policy must be in the <c>ACTIVE</c>
        /// state before you can use it in a firewall.
        /// </para>
        /// </summary>
        public ResourceStatus FirewallPolicyV2Status { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyV2Status property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyV2Status() => this.FirewallPolicyV2Status != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the Next Generation policy was changed.
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
        /// The number of firewalls that are associated with the Next Generation policy.
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
        /// Additional information about the current status of the Next Generation policy.
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
        /// The key-value tag pairs that are associated with the Next Generation policy.
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
