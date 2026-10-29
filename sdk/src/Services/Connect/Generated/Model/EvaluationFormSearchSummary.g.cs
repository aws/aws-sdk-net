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
    /// Information about the returned evaluation forms.
    /// </summary>
    public partial class EvaluationFormSearchSummary
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
        /// Gets and sets the property ActiveVersion. 
        /// <para>
        /// Active version of the evaluation form.
        /// </para>
        /// </summary>
        public int? ActiveVersion { get; set; }

        /// <summary>
        /// Checks to see if the ActiveVersion property is set.
        /// </summary>
        internal bool IsSetActiveVersion() => this.ActiveVersion.HasValue;

        /// <summary>
        /// Gets and sets the property AutoEvaluationEnabled. 
        /// <para>
        /// Whether automated evaluation is enabled.
        /// </para>
        /// </summary>
        public bool? AutoEvaluationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoEvaluationEnabled property is set.
        /// </summary>
        internal bool IsSetAutoEvaluationEnabled() => this.AutoEvaluationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ContactInteractionType. 
        /// <para>
        /// The contact interaction type for this evaluation form.
        /// </para>
        /// </summary>
        public ContactInteractionType ContactInteractionType { get; set; }

        /// <summary>
        /// Checks to see if the ContactInteractionType property is set.
        /// </summary>
        internal bool IsSetContactInteractionType() => this.ContactInteractionType != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created the evaluation form.
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
        /// When the evaluation form was created.
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
        /// Gets and sets the property EvaluationFormLanguage. 
        /// <para>
        /// The language of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormLanguageCode EvaluationFormLanguage { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormLanguage property is set.
        /// </summary>
        internal bool IsSetEvaluationFormLanguage() => this.EvaluationFormLanguage != null;

        /// <summary>
        /// Gets and sets the property LastActivatedBy. 
        /// <para>
        /// The ID of user who last activated evaluation form.
        /// </para>
        /// </summary>
        public string LastActivatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastActivatedBy property is set.
        /// </summary>
        internal bool IsSetLastActivatedBy() => this.LastActivatedBy != null;

        /// <summary>
        /// Gets and sets the property LastActivatedTime. 
        /// <para>
        /// When the evaluation format was last activated.
        /// </para>
        /// </summary>
        public DateTime? LastActivatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastActivatedTime property is set.
        /// </summary>
        internal bool IsSetLastActivatedTime() => this.LastActivatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who changed the evaluation form.
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
        /// When the evaluation form was last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// Latest version of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? LatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersion property is set.
        /// </summary>
        internal bool IsSetLatestVersion() => this.LatestVersion.HasValue;

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
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the evaluation form.
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
