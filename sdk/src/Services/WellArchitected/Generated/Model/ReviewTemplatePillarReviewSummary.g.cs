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
    /// Summary of a review template.
    /// </summary>
    public partial class ReviewTemplatePillarReviewSummary
    {
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
        /// Gets and sets the property PillarName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PillarName { get; set; }

        /// <summary>
        /// Checks to see if the PillarName property is set.
        /// </summary>
        internal bool IsSetPillarName() => this.PillarName != null;

        /// <summary>
        /// Gets and sets the property QuestionCounts. 
        /// <para>
        /// A count of how many questions are answered and unanswered in the requested pillar
        /// of the lens review.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> QuestionCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the QuestionCounts property is set.
        /// </summary>
        internal bool IsSetQuestionCounts() => this.QuestionCounts != null && (this.QuestionCounts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
