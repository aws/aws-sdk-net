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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// An answer of the question.
    /// </summary>
    public partial class ReviewTemplateAnswer
    {
        /// <summary>
        /// Gets and sets the property AnswerStatus. 
        /// <para>
        /// The status of whether or not this question has been answered.
        /// </para>
        /// </summary>
        public ReviewTemplateAnswerStatus AnswerStatus { get; set; }

        /// <summary>
        /// Checks to see if the AnswerStatus property is set.
        /// </summary>
        internal bool IsSetAnswerStatus() => this.AnswerStatus != null;

        /// <summary>
        /// Gets and sets the property ChoiceAnswers. 
        /// <para>
        /// A list of selected choices to a question in your review template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChoiceAnswer> ChoiceAnswers { get; set; } = AWSConfigs.InitializeCollections ? new List<ChoiceAnswer>() : null;

        /// <summary>
        /// Checks to see if the ChoiceAnswers property is set.
        /// </summary>
        internal bool IsSetChoiceAnswers() => this.ChoiceAnswers != null && (this.ChoiceAnswers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Choices.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Choice> Choices { get; set; } = AWSConfigs.InitializeCollections ? new List<Choice>() : null;

        /// <summary>
        /// Checks to see if the Choices property is set.
        /// </summary>
        internal bool IsSetChoices() => this.Choices != null && (this.Choices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HelpfulResourceDisplayText. 
        /// <para>
        /// The helpful resource text to be displayed for a custom lens.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field does not apply to Amazon Web Services official lenses.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string HelpfulResourceDisplayText { get; set; }

        /// <summary>
        /// Checks to see if the HelpfulResourceDisplayText property is set.
        /// </summary>
        internal bool IsSetHelpfulResourceDisplayText() => this.HelpfulResourceDisplayText != null;

        /// <summary>
        /// Gets and sets the property HelpfulResourceUrl.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string HelpfulResourceUrl { get; set; }

        /// <summary>
        /// Checks to see if the HelpfulResourceUrl property is set.
        /// </summary>
        internal bool IsSetHelpfulResourceUrl() => this.HelpfulResourceUrl != null;

        /// <summary>
        /// Gets and sets the property ImprovementPlanUrl.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ImprovementPlanUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImprovementPlanUrl property is set.
        /// </summary>
        internal bool IsSetImprovementPlanUrl() => this.ImprovementPlanUrl != null;

        /// <summary>
        /// Gets and sets the property IsApplicable.
        /// </summary>
        public bool? IsApplicable { get; set; }

        /// <summary>
        /// Checks to see if the IsApplicable property is set.
        /// </summary>
        internal bool IsSetIsApplicable() => this.IsApplicable.HasValue;

        /// <summary>
        /// Gets and sets the property Notes.
        /// </summary>
        [AWSProperty(Max = 2084)]
        public string Notes { get; set; }

        /// <summary>
        /// Checks to see if the Notes property is set.
        /// </summary>
        internal bool IsSetNotes() => this.Notes != null;

        /// <summary>
        /// Gets and sets the property PillarId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PillarId { get; set; }

        /// <summary>
        /// Checks to see if the PillarId property is set.
        /// </summary>
        internal bool IsSetPillarId() => this.PillarId != null;

        /// <summary>
        /// Gets and sets the property QuestionDescription.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string QuestionDescription { get; set; }

        /// <summary>
        /// Checks to see if the QuestionDescription property is set.
        /// </summary>
        internal bool IsSetQuestionDescription() => this.QuestionDescription != null;

        /// <summary>
        /// Gets and sets the property QuestionId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string QuestionId { get; set; }

        /// <summary>
        /// Checks to see if the QuestionId property is set.
        /// </summary>
        internal bool IsSetQuestionId() => this.QuestionId != null;

        /// <summary>
        /// Gets and sets the property QuestionTitle.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string QuestionTitle { get; set; }

        /// <summary>
        /// Checks to see if the QuestionTitle property is set.
        /// </summary>
        internal bool IsSetQuestionTitle() => this.QuestionTitle != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason why the question is not applicable to your review template.
        /// </para>
        /// </summary>
        public AnswerReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property SelectedChoices.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelectedChoices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SelectedChoices property is set.
        /// </summary>
        internal bool IsSetSelectedChoices() => this.SelectedChoices != null && (this.SelectedChoices.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
