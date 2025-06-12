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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
        private ReviewTemplateAnswerStatus _answerStatus;
        private List<ChoiceAnswer> _choiceAnswers = AWSConfigs.InitializeCollections ? new List<ChoiceAnswer>() : null;
        private List<Choice> _choices = AWSConfigs.InitializeCollections ? new List<Choice>() : null;
        private string _helpfulResourceDisplayText;
        private string _helpfulResourceUrl;
        private string _improvementPlanUrl;
        private bool? _isApplicable;
        private string _notes;
        private string _pillarId;
        private string _questionDescription;
        private string _questionId;
        private string _questionTitle;
        private AnswerReason _reason;
        private List<string> _selectedChoices = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AnswerStatus. 
        /// <para>
        /// The status of whether or not this question has been answered.
        /// </para>
        /// </summary>
        public ReviewTemplateAnswerStatus AnswerStatus
        {
            get { return this._answerStatus; }
            set { this._answerStatus = value; }
        }

        // Check to see if AnswerStatus property is set
        internal bool IsSetAnswerStatus()
        {
            return this._answerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ChoiceAnswers. 
        /// <para>
        /// A list of selected choices to a question in your review template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChoiceAnswer> ChoiceAnswers
        {
            get { return this._choiceAnswers; }
            set { this._choiceAnswers = value; }
        }

        // Check to see if ChoiceAnswers property is set
        internal bool IsSetChoiceAnswers()
        {
            return this._choiceAnswers != null && (this._choiceAnswers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Choices.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Choice> Choices
        {
            get { return this._choices; }
            set { this._choices = value; }
        }

        // Check to see if Choices property is set
        internal bool IsSetChoices()
        {
            return this._choices != null && (this._choices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1, Max=64)]
        public string HelpfulResourceDisplayText
        {
            get { return this._helpfulResourceDisplayText; }
            set { this._helpfulResourceDisplayText = value; }
        }

        // Check to see if HelpfulResourceDisplayText property is set
        internal bool IsSetHelpfulResourceDisplayText()
        {
            return this._helpfulResourceDisplayText != null;
        }

        /// <summary>
        /// Gets and sets the property HelpfulResourceUrl.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string HelpfulResourceUrl
        {
            get { return this._helpfulResourceUrl; }
            set { this._helpfulResourceUrl = value; }
        }

        // Check to see if HelpfulResourceUrl property is set
        internal bool IsSetHelpfulResourceUrl()
        {
            return this._helpfulResourceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ImprovementPlanUrl.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ImprovementPlanUrl
        {
            get { return this._improvementPlanUrl; }
            set { this._improvementPlanUrl = value; }
        }

        // Check to see if ImprovementPlanUrl property is set
        internal bool IsSetImprovementPlanUrl()
        {
            return this._improvementPlanUrl != null;
        }

        /// <summary>
        /// Gets and sets the property IsApplicable.
        /// </summary>
        public bool? IsApplicable
        {
            get { return this._isApplicable; }
            set { this._isApplicable = value; }
        }

        // Check to see if IsApplicable property is set
        internal bool IsSetIsApplicable()
        {
            return this._isApplicable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Notes.
        /// </summary>
        [AWSProperty(Max=2084)]
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null;
        }

        /// <summary>
        /// Gets and sets the property PillarId.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PillarId
        {
            get { return this._pillarId; }
            set { this._pillarId = value; }
        }

        // Check to see if PillarId property is set
        internal bool IsSetPillarId()
        {
            return this._pillarId != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionDescription.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string QuestionDescription
        {
            get { return this._questionDescription; }
            set { this._questionDescription = value; }
        }

        // Check to see if QuestionDescription property is set
        internal bool IsSetQuestionDescription()
        {
            return this._questionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionId.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string QuestionId
        {
            get { return this._questionId; }
            set { this._questionId = value; }
        }

        // Check to see if QuestionId property is set
        internal bool IsSetQuestionId()
        {
            return this._questionId != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionTitle.
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string QuestionTitle
        {
            get { return this._questionTitle; }
            set { this._questionTitle = value; }
        }

        // Check to see if QuestionTitle property is set
        internal bool IsSetQuestionTitle()
        {
            return this._questionTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason why the question is not applicable to your review template.
        /// </para>
        /// </summary>
        public AnswerReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedChoices.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelectedChoices
        {
            get { return this._selectedChoices; }
            set { this._selectedChoices = value; }
        }

        // Check to see if SelectedChoices property is set
        internal bool IsSetSelectedChoices()
        {
            return this._selectedChoices != null && (this._selectedChoices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}