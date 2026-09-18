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
    /// A profile template question.
    /// </summary>
    public partial class ProfileTemplateQuestion
    {
        /// <summary>
        /// Gets and sets the property MaxSelectedChoices. 
        /// <para>
        /// The maximum number of choices selected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxSelectedChoices { get; set; }

        /// <summary>
        /// Checks to see if the MaxSelectedChoices property is set.
        /// </summary>
        internal bool IsSetMaxSelectedChoices() => this.MaxSelectedChoices.HasValue;

        /// <summary>
        /// Gets and sets the property MinSelectedChoices. 
        /// <para>
        /// The minimum number of choices selected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MinSelectedChoices { get; set; }

        /// <summary>
        /// Checks to see if the MinSelectedChoices property is set.
        /// </summary>
        internal bool IsSetMinSelectedChoices() => this.MinSelectedChoices.HasValue;

        /// <summary>
        /// Gets and sets the property QuestionChoices. 
        /// <para>
        /// The question choices.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProfileTemplateChoice> QuestionChoices { get; set; } = AWSConfigs.InitializeCollections ? new List<ProfileTemplateChoice>() : null;

        /// <summary>
        /// Checks to see if the QuestionChoices property is set.
        /// </summary>
        internal bool IsSetQuestionChoices() => this.QuestionChoices != null && (this.QuestionChoices.Count > 0 || !AWSConfigs.InitializeCollections);

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
    }
}
