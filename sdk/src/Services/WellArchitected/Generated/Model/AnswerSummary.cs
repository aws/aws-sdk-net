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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// An answer summary of a lens review in a workload.
    /// </summary>
    public partial class AnswerSummary
    {
        private List<ChoiceAnswerSummary> _choiceAnswerSummaries = AWSConfigs.InitializeCollections ? new List<ChoiceAnswerSummary>() : null;
        private List<Choice> _choices = AWSConfigs.InitializeCollections ? new List<Choice>() : null;
        private bool? _isApplicable;
        private JiraConfiguration _jiraConfiguration;
        private string _pillarId;
        private string _questionId;
        private string _questionTitle;
        private QuestionType _questionType;
        private AnswerReason _reason;
        private Risk _risk;
        private List<string> _selectedChoices = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ChoiceAnswerSummaries. 
        /// <para>
        /// A list of selected choices to a question in your workload.
        /// </para>
        /// </summary>
        public List<ChoiceAnswerSummary> ChoiceAnswerSummaries
        {
            get { return this._choiceAnswerSummaries; }
            set { this._choiceAnswerSummaries = value; }
        }

        // Check to see if ChoiceAnswerSummaries property is set
        internal bool IsSetChoiceAnswerSummaries()
        {
            return this._choiceAnswerSummaries != null && (this._choiceAnswerSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Choices.
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
        /// Gets and sets the property IsApplicable.
        /// </summary>
        public bool IsApplicable
        {
            get { return this._isApplicable.GetValueOrDefault(); }
            set { this._isApplicable = value; }
        }

        // Check to see if IsApplicable property is set
        internal bool IsSetIsApplicable()
        {
            return this._isApplicable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Configuration of the Jira integration.
        /// </para>
        /// </summary>
        public JiraConfiguration JiraConfiguration
        {
            get { return this._jiraConfiguration; }
            set { this._jiraConfiguration = value; }
        }

        // Check to see if JiraConfiguration property is set
        internal bool IsSetJiraConfiguration()
        {
            return this._jiraConfiguration != null;
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
        /// Gets and sets the property QuestionType. 
        /// <para>
        /// The type of the question.
        /// </para>
        /// </summary>
        public QuestionType QuestionType
        {
            get { return this._questionType; }
            set { this._questionType = value; }
        }

        // Check to see if QuestionType property is set
        internal bool IsSetQuestionType()
        {
            return this._questionType != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason why a choice is non-applicable to a question in your workload.
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
        /// Gets and sets the property Risk.
        /// </summary>
        public Risk Risk
        {
            get { return this._risk; }
            set { this._risk = value; }
        }

        // Check to see if Risk property is set
        internal bool IsSetRisk()
        {
            return this._risk != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedChoices.
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