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
    /// Container for the parameters to the CreateEvaluationForm operation. Creates an evaluation
    /// form in the specified Connect Customer instance. The form can be used to define questions
    /// related to agent performance, and create sections to organize such questions. Question
    /// and section identifiers cannot be duplicated within the same evaluation form.
    /// </summary>
    public partial class CreateEvaluationFormRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AIVersion. 
        /// <para>
        /// The AI version to use for the evaluation form. This specifies which AI model version
        /// is used for automated evaluations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AIVersion { get; set; }

        /// <summary>
        /// Checks to see if the AIVersion property is set.
        /// </summary>
        internal bool IsSetAIVersion() => this.AIVersion != null;

        /// <summary>
        /// Gets and sets the property AsDraft. 
        /// <para>
        /// A boolean flag indicating whether to create evaluation form in draft state.
        /// </para>
        /// </summary>
        public bool? AsDraft { get; set; }

        /// <summary>
        /// Checks to see if the AsDraft property is set.
        /// </summary>
        internal bool IsSetAsDraft() => this.AsDraft.HasValue;

        /// <summary>
        /// Gets and sets the property AutoEvaluationConfiguration. 
        /// <para>
        /// Configuration information about automated evaluations.
        /// </para>
        /// </summary>
        public EvaluationFormAutoEvaluationConfiguration AutoEvaluationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoEvaluationConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoEvaluationConfiguration() => this.AutoEvaluationConfiguration != null;

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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the evaluation form.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property Items. 
        /// <para>
        /// Items that are part of the evaluation form. The total number of sections and questions
        /// must not exceed 100 each. Questions must be contained in a section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<EvaluationFormItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationFormItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LanguageConfiguration. 
        /// <para>
        /// Configuration for language settings of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormLanguageConfiguration LanguageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LanguageConfiguration property is set.
        /// </summary>
        internal bool IsSetLanguageConfiguration() => this.LanguageConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReviewConfiguration. 
        /// <para>
        /// Configuration information about evaluation reviews.
        /// </para>
        /// </summary>
        public EvaluationReviewConfiguration ReviewConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReviewConfiguration property is set.
        /// </summary>
        internal bool IsSetReviewConfiguration() => this.ReviewConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScoringStrategy. 
        /// <para>
        /// A scoring strategy of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormScoringStrategy ScoringStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ScoringStrategy property is set.
        /// </summary>
        internal bool IsSetScoringStrategy() => this.ScoringStrategy != null;

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
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Configuration that specifies the target for the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormTargetConfiguration TargetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConfiguration() => this.TargetConfiguration != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
