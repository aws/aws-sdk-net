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
    /// Container for the parameters to the UpdateAnswer operation.
    /// Update the answer to a specific question in a workload review.
    /// </summary>
    public partial class UpdateAnswerRequest : AmazonWellArchitectedRequest
    {
        private Dictionary<string, ChoiceUpdate> _choiceUpdates = AWSConfigs.InitializeCollections ? new Dictionary<string, ChoiceUpdate>() : null;
        private bool? _isApplicable;
        private string _lensAlias;
        private string _notes;
        private string _questionId;
        private AnswerReason _reason;
        private List<string> _selectedChoices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property ChoiceUpdates. 
        /// <para>
        /// A list of choices to update on a question in your workload. The String key corresponds
        /// to the choice ID to be updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ChoiceUpdate> ChoiceUpdates
        {
            get { return this._choiceUpdates; }
            set { this._choiceUpdates = value; }
        }

        // Check to see if ChoiceUpdates property is set
        internal bool IsSetChoiceUpdates()
        {
            return this._choiceUpdates != null && (this._choiceUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string LensAlias
        {
            get { return this._lensAlias; }
            set { this._lensAlias = value; }
        }

        // Check to see if LensAlias property is set
        internal bool IsSetLensAlias()
        {
            return this._lensAlias != null;
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
        /// Gets and sets the property QuestionId.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason why a question is not applicable to your workload.
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

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

    }
}