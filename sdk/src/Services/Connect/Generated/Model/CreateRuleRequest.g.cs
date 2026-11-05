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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRule operation. Creates a rule for the specified
    /// Connect Customer instance. <para> Use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/connect-rules-language.html">Rules
    /// Function language</a> to code conditions for the rule. </para>
    /// </summary>
    public partial class CreateRuleRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of actions to be run when the rule is triggered.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RuleAction> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleAction>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The conditions of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Function { get; set; }

        /// <summary>
        /// Checks to see if the Function property is set.
        /// </summary>
        internal bool IsSetFunction() => this.Function != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PreEvaluationFilters. 
        /// <para>
        /// The pre-evaluation filters for the rule, that restrict the rule to be applied to only
        /// certain resources based on the resource's attributes, such as tags assigned to a contact.
        /// The pre-evaluation filters are applied even before rule conditions are evaluated and
        /// are used to enforce tag-based-access-control while applying rules.
        /// </para>
        /// </summary>
        public PreEvaluationFilters PreEvaluationFilters { get; set; }

        /// <summary>
        /// Checks to see if the PreEvaluationFilters property is set.
        /// </summary>
        internal bool IsSetPreEvaluationFilters() => this.PreEvaluationFilters != null;

        /// <summary>
        /// Gets and sets the property PublishStatus. 
        /// <para>
        /// The publish status of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RulePublishStatus PublishStatus { get; set; }

        /// <summary>
        /// Checks to see if the PublishStatus property is set.
        /// </summary>
        internal bool IsSetPublishStatus() => this.PublishStatus != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggerEventSource. 
        /// <para>
        /// The event source to trigger the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleTriggerEventSource TriggerEventSource { get; set; }

        /// <summary>
        /// Checks to see if the TriggerEventSource property is set.
        /// </summary>
        internal bool IsSetTriggerEventSource() => this.TriggerEventSource != null;
    }
}
