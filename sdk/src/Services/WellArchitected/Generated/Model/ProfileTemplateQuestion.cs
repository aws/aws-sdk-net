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
    /// A profile template question.
    /// </summary>
    public partial class ProfileTemplateQuestion
    {
        private int? _maxSelectedChoices;
        private int? _minSelectedChoices;
        private List<ProfileTemplateChoice> _questionChoices = AWSConfigs.InitializeCollections ? new List<ProfileTemplateChoice>() : null;
        private string _questionDescription;
        private string _questionId;
        private string _questionTitle;

        /// <summary>
        /// Gets and sets the property MaxSelectedChoices. 
        /// <para>
        /// The maximum number of choices selected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MaxSelectedChoices
        {
            get { return this._maxSelectedChoices; }
            set { this._maxSelectedChoices = value; }
        }

        // Check to see if MaxSelectedChoices property is set
        internal bool IsSetMaxSelectedChoices()
        {
            return this._maxSelectedChoices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSelectedChoices. 
        /// <para>
        /// The minimum number of choices selected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MinSelectedChoices
        {
            get { return this._minSelectedChoices; }
            set { this._minSelectedChoices = value; }
        }

        // Check to see if MinSelectedChoices property is set
        internal bool IsSetMinSelectedChoices()
        {
            return this._minSelectedChoices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuestionChoices. 
        /// <para>
        /// The question choices.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProfileTemplateChoice> QuestionChoices
        {
            get { return this._questionChoices; }
            set { this._questionChoices = value; }
        }

        // Check to see if QuestionChoices property is set
        internal bool IsSetQuestionChoices()
        {
            return this._questionChoices != null && (this._questionChoices.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}