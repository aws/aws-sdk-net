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
        private List<Choice> _choices = new List<Choice>();
        private bool? _isApplicable;
        private string _pillarId;
        private string _questionId;
        private string _questionTitle;
        private Risk _risk;
        private List<string> _selectedChoices = new List<string>();

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
            return this._choices != null && this._choices.Count > 0; 
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
            return this._selectedChoices != null && this._selectedChoices.Count > 0; 
        }

    }
}