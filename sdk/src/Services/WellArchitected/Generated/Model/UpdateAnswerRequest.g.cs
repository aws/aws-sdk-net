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
    /// Container for the parameters to the UpdateAnswer operation. Update the answer to a
    /// specific question in a workload review.
    /// </summary>
    public partial class UpdateAnswerRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property ChoiceUpdates. 
        /// <para>
        /// A list of choices to update on a question in your workload. The String key corresponds
        /// to the choice ID to be updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ChoiceUpdate> ChoiceUpdates { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ChoiceUpdate>() : null;

        /// <summary>
        /// Checks to see if the ChoiceUpdates property is set.
        /// </summary>
        internal bool IsSetChoiceUpdates() => this.ChoiceUpdates != null && (this.ChoiceUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsApplicable.
        /// </summary>
        public bool? IsApplicable { get; set; }

        /// <summary>
        /// Checks to see if the IsApplicable property is set.
        /// </summary>
        internal bool IsSetIsApplicable() => this.IsApplicable.HasValue;

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string LensAlias { get; set; }

        /// <summary>
        /// Checks to see if the LensAlias property is set.
        /// </summary>
        internal bool IsSetLensAlias() => this.LensAlias != null;

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
        /// Gets and sets the property QuestionId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string QuestionId { get; set; }

        /// <summary>
        /// Checks to see if the QuestionId property is set.
        /// </summary>
        internal bool IsSetQuestionId() => this.QuestionId != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason why a question is not applicable to your workload.
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

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;
    }
}
