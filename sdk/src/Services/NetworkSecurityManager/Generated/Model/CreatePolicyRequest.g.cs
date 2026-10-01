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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePolicy operation. Creates a policy. A policy
    /// combines templates and rules with enforcement settings for a firewall type, such as
    /// AWS WAF or AWS Shield Advanced. Use <c>isPublished</c> to create the policy in published
    /// (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
    /// </summary>
    public partial class CreatePolicyRequest : AmazonNetworkSecurityManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatedTemplateAndRuleList. 
        /// <para>
        /// The templates and rules to associate with the policy. For AWS WAF policies, specify
        /// 1 to 100 templates or rules, of which at most 2 can be templates. For AWS Shield Advanced
        /// policies, this list must be empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<TemplateOrRuleReference> AssociatedTemplateAndRuleList { get; set; } = AWSConfigs.InitializeCollections ? new List<TemplateOrRuleReference>() : null;

        /// <summary>
        /// Checks to see if the AssociatedTemplateAndRuleList property is set.
        /// </summary>
        internal bool IsSetAssociatedTemplateAndRuleList() => this.AssociatedTemplateAndRuleList != null && (this.AssociatedTemplateAndRuleList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure that the operation completes
        /// no more than one time. If you retry a request with the same client token and the same
        /// parameters, the service returns the result of the original successful request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property FirewallType. 
        /// <para>
        /// The firewall type associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyFirewallType FirewallType { get; set; }

        /// <summary>
        /// Checks to see if the FirewallType property is set.
        /// </summary>
        internal bool IsSetFirewallType() => this.FirewallType != null;

        /// <summary>
        /// Gets and sets the property IsPublished. 
        /// <para>
        /// Specifies whether to publish the resource. When <c>true</c>, the resource is saved
        /// in published (<c>ACTIVE</c>) state. When <c>false</c>, it is saved as a draft (<c>DRAFT</c>).
        /// Default: <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Checks to see if the IsPublished property is set.
        /// </summary>
        internal bool IsSetIsPublished() => this.IsPublished.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyConfiguration. 
        /// <para>
        /// The configuration settings that control the policy's behavior, including remediation
        /// and firewall-type-specific settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyConfiguration PolicyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PolicyConfiguration property is set.
        /// </summary>
        internal bool IsSetPolicyConfiguration() => this.PolicyConfiguration != null;

        /// <summary>
        /// Gets and sets the property PolicyDescription. 
        /// <para>
        /// A description of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDescription property is set.
        /// </summary>
        internal bool IsSetPolicyDescription() => this.PolicyDescription != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the resource. A lower number indicates a higher priority.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the resource when it is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
