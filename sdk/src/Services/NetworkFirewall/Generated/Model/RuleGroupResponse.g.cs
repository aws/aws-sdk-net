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
    /// The high-level properties of a rule group. This, along with the <a>RuleGroup</a>,
    /// define the rule group. You can retrieve all objects for a rule group by calling <a>DescribeRuleGroup</a>.
    /// </summary>
    public partial class RuleGroupResponse
    {
        /// <summary>
        /// Gets and sets the property AnalysisResults. 
        /// <para>
        /// The list of analysis results for <c>AnalyzeRuleGroup</c>. If you set <c>AnalyzeRuleGroup</c>
        /// to <c>TRUE</c> in <a>CreateRuleGroup</a>, <a>UpdateRuleGroup</a>, or <a>DescribeRuleGroup</a>,
        /// Network Firewall analyzes the rule group and identifies the rules that might adversely
        /// effect your firewall's functionality. For example, if Network Firewall detects a rule
        /// that's routing traffic asymmetrically, which impacts the service's ability to properly
        /// process traffic, the service includes the rule in the list of analysis results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalysisResult> AnalysisResults { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisResult>() : null;

        /// <summary>
        /// Checks to see if the AnalysisResults property is set.
        /// </summary>
        internal bool IsSetAnalysisResults() => this.AnalysisResults != null && (this.AnalysisResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The maximum operating resources that this rule group can use. Rule group capacity
        /// is fixed at creation. When you update a rule group, you are limited to this capacity.
        /// When you reference a rule group from a firewall policy, Network Firewall reserves
        /// this capacity for the rule group. 
        /// </para>
        ///  
        /// <para>
        /// You can retrieve the capacity that would be required for a rule group before you create
        /// the rule group by calling <a>CreateRuleGroup</a> with <c>DryRun</c> set to <c>TRUE</c>.
        /// 
        /// </para>
        /// </summary>
        public int? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// The number of capacity units currently consumed by the rule group rules. 
        /// </para>
        /// </summary>
        public int? ConsumedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedCapacity() => this.ConsumedCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule group. 
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
        /// settings for your rule group.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the rule group was changed.
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
        /// The number of firewall policies that use this rule group.
        /// </para>
        /// </summary>
        public int? NumberOfAssociations { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociations property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociations() => this.NumberOfAssociations.HasValue;

        /// <summary>
        /// Gets and sets the property RuleGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule group.
        /// </para>
        ///  <note> 
        /// <para>
        /// If this response is for a create request that had <c>DryRun</c> set to <c>TRUE</c>,
        /// then this ARN is a placeholder that isn't attached to a valid resource.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string RuleGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupArn property is set.
        /// </summary>
        internal bool IsSetRuleGroupArn() => this.RuleGroupArn != null;

        /// <summary>
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// The unique identifier for the rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string RuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupId property is set.
        /// </summary>
        internal bool IsSetRuleGroupId() => this.RuleGroupId != null;

        /// <summary>
        /// Gets and sets the property RuleGroupName. 
        /// <para>
        /// The descriptive name of the rule group. You can't change the name of a rule group
        /// after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupName property is set.
        /// </summary>
        internal bool IsSetRuleGroupName() => this.RuleGroupName != null;

        /// <summary>
        /// Gets and sets the property RuleGroupStatus. 
        /// <para>
        /// Detailed information about the current status of a rule group. 
        /// </para>
        /// </summary>
        public ResourceStatus RuleGroupStatus { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupStatus property is set.
        /// </summary>
        internal bool IsSetRuleGroupStatus() => this.RuleGroupStatus != null;

        /// <summary>
        /// Gets and sets the property SnsTopic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service SNS topic
        /// that's used to record changes to the managed rule group. You can subscribe to the
        /// SNS topic to receive notifications when the managed rule group is modified, such as
        /// for new versions and for version expiration. For more information, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/welcome.html">Amazon
        /// Simple Notification Service Developer Guide.</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SnsTopic { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopic property is set.
        /// </summary>
        internal bool IsSetSnsTopic() => this.SnsTopic != null;

        /// <summary>
        /// Gets and sets the property SourceMetadata. 
        /// <para>
        /// A complex type that contains metadata about the rule group that your own rule group
        /// is copied from. You can use the metadata to track the version updates made to the
        /// originating rule group.
        /// </para>
        /// </summary>
        public SourceMetadata SourceMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SourceMetadata property is set.
        /// </summary>
        internal bool IsSetSourceMetadata() => this.SourceMetadata != null;

        /// <summary>
        /// Gets and sets the property SummaryConfiguration. 
        /// <para>
        /// A complex type containing the currently selected rule option fields that will be displayed
        /// for rule summarization returned by <a>DescribeRuleGroupSummary</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>RuleOptions</c> specified in <a>SummaryConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Rule metadata organization preferences
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SummaryConfiguration SummaryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SummaryConfiguration property is set.
        /// </summary>
        internal bool IsSetSummaryConfiguration() => this.SummaryConfiguration != null;

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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the rule group is stateless or stateful. If the rule group is stateless,
        /// it contains stateless rules. If it is stateful, it contains stateful rules. 
        /// </para>
        /// </summary>
        public RuleGroupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
