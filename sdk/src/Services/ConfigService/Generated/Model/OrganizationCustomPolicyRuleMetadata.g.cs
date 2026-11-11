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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// An object that specifies metadata for your organization's Config Custom Policy rule.
    /// The metadata includes the runtime system in use, which accounts have debug logging
    /// enabled, and other custom rule metadata, such as resource type, resource ID of Amazon
    /// Web Services resource, and organization trigger types that initiate Config to evaluate
    /// Amazon Web Services resources against a rule.
    /// </summary>
    public partial class OrganizationCustomPolicyRuleMetadata
    {
        /// <summary>
        /// Gets and sets the property DebugLogDeliveryAccounts. 
        /// <para>
        /// A list of accounts that you can enable debug logging for your organization Config
        /// Custom Policy rule. List is null when debug logging is enabled for all accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<string> DebugLogDeliveryAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DebugLogDeliveryAccounts property is set.
        /// </summary>
        internal bool IsSetDebugLogDeliveryAccounts() => this.DebugLogDeliveryAccounts != null && (this.DebugLogDeliveryAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you provide for your organization Config Custom Policy rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InputParameters. 
        /// <para>
        /// A string, in JSON format, that is passed to your organization Config Custom Policy
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string InputParameters { get; set; }

        /// <summary>
        /// Checks to see if the InputParameters property is set.
        /// </summary>
        internal bool IsSetInputParameters() => this.InputParameters != null;

        /// <summary>
        /// Gets and sets the property MaximumExecutionFrequency. 
        /// <para>
        /// The maximum frequency with which Config runs evaluations for a rule. Your Config Custom
        /// Policy rule is triggered when Config delivers the configuration snapshot. For more
        /// information, see <a>ConfigSnapshotDeliveryProperties</a>.
        /// </para>
        /// </summary>
        public MaximumExecutionFrequency MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// Checks to see if the MaximumExecutionFrequency property is set.
        /// </summary>
        internal bool IsSetMaximumExecutionFrequency() => this.MaximumExecutionFrequency != null;

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleTriggerTypes. 
        /// <para>
        /// The type of notification that initiates Config to run an evaluation for a rule. For
        /// Config Custom Policy rules, Config supports change-initiated notification types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ConfigurationItemChangeNotification</c> - Initiates an evaluation when Config
        /// delivers a configuration item as a result of a resource change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OversizedConfigurationItemChangeNotification</c> - Initiates an evaluation when
        /// Config delivers an oversized configuration item. Config may generate this notification
        /// type when a resource changes and the notification exceeds the maximum size allowed
        /// by Amazon SNS.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationConfigRuleTriggerTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationConfigRuleTriggerTypes property is set.
        /// </summary>
        internal bool IsSetOrganizationConfigRuleTriggerTypes() => this.OrganizationConfigRuleTriggerTypes != null && (this.OrganizationConfigRuleTriggerTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyRuntime. 
        /// <para>
        /// The runtime system for your organization Config Custom Policy rules. Guard is a policy-as-code
        /// language that allows you to write policies that are enforced by Config Custom Policy
        /// rules. For more information about Guard, see the <a href="https://github.com/aws-cloudformation/cloudformation-guard">Guard
        /// GitHub Repository</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PolicyRuntime { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRuntime property is set.
        /// </summary>
        internal bool IsSetPolicyRuntime() => this.PolicyRuntime != null;

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The policy definition containing the logic for your organization Config Custom Policy
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string PolicyText { get; set; }

        /// <summary>
        /// Checks to see if the PolicyText property is set.
        /// </summary>
        internal bool IsSetPolicyText() => this.PolicyText != null;

        /// <summary>
        /// Gets and sets the property ResourceIdScope. 
        /// <para>
        /// The ID of the Amazon Web Services resource that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 768)]
        public string ResourceIdScope { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdScope property is set.
        /// </summary>
        internal bool IsSetResourceIdScope() => this.ResourceIdScope != null;

        /// <summary>
        /// Gets and sets the property ResourceTypesScope. 
        /// <para>
        /// The type of the Amazon Web Services resource that was evaluated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> ResourceTypesScope { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypesScope property is set.
        /// </summary>
        internal bool IsSetResourceTypesScope() => this.ResourceTypesScope != null && (this.ResourceTypesScope.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagKeyScope. 
        /// <para>
        /// One part of a key-value pair that make up a tag. A key is a general label that acts
        /// like a category for more specific tag values.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// Checks to see if the TagKeyScope property is set.
        /// </summary>
        internal bool IsSetTagKeyScope() => this.TagKeyScope != null;

        /// <summary>
        /// Gets and sets the property TagValueScope. 
        /// <para>
        /// The optional part of a key-value pair that make up a tag. A value acts as a descriptor
        /// within a tag category (key).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TagValueScope { get; set; }

        /// <summary>
        /// Checks to see if the TagValueScope property is set.
        /// </summary>
        internal bool IsSetTagValueScope() => this.TagValueScope != null;
    }
}
