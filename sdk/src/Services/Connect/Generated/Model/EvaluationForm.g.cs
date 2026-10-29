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
    /// Information about the evaluation form.
    /// </summary>
    public partial class EvaluationForm
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
        /// Gets and sets the property AutoEvaluationConfiguration. 
        /// <para>
        /// The automatic evaluation configuration of an evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormAutoEvaluationConfiguration AutoEvaluationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoEvaluationConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoEvaluationConfiguration() => this.AutoEvaluationConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who created the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the evaluation form was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

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
        /// Gets and sets the property EvaluationFormArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the evaluation form resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluationFormArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormArn property is set.
        /// </summary>
        internal bool IsSetEvaluationFormArn() => this.EvaluationFormArn != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EvaluationFormId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormId property is set.
        /// </summary>
        internal bool IsSetEvaluationFormId() => this.EvaluationFormId != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormVersion. 
        /// <para>
        /// A version of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EvaluationFormVersion { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormVersion property is set.
        /// </summary>
        internal bool IsSetEvaluationFormVersion() => this.EvaluationFormVersion.HasValue;

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
        /// Configuration for language settings of this evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormLanguageConfiguration LanguageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LanguageConfiguration property is set.
        /// </summary>
        internal bool IsSetLanguageConfiguration() => this.LanguageConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp for when the evaluation form was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastValidationTime. 
        /// <para>
        /// The timestamp when the most recent validation was started for this evaluation form.
        /// </para>
        /// </summary>
        public DateTime? LastValidationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastValidationTime property is set.
        /// </summary>
        internal bool IsSetLastValidationTime() => this.LastValidationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestValidationStatus. 
        /// <para>
        /// The status of the most recent validation run for this evaluation form. Valid values:
        /// <c>IN_PROGRESS</c>, <c>COMPLETED</c>, <c>FAILED</c>.
        /// </para>
        /// </summary>
        public EvaluationFormValidationStatus LatestValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LatestValidationStatus property is set.
        /// </summary>
        internal bool IsSetLatestValidationStatus() => this.LatestValidationStatus != null;

        /// <summary>
        /// Gets and sets the property Locked. 
        /// <para>
        /// The flag indicating whether the evaluation form is locked for changes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Checks to see if the Locked property is set.
        /// </summary>
        internal bool IsSetLocked() => this.Locked.HasValue;

        /// <summary>
        /// Gets and sets the property ReviewConfiguration. 
        /// <para>
        /// Configuration for evaluation review settings of this evaluation form.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationFormVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// Configuration that specifies the target for this evaluation form.
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
