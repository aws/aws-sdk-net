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
    /// A review template.
    /// </summary>
    public partial class ReviewTemplate
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The review template description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Lenses. 
        /// <para>
        /// The lenses applied to the review template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Lenses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Lenses property is set.
        /// </summary>
        internal bool IsSetLenses() => this.Lenses != null && (this.Lenses.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Owner.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property QuestionCounts. 
        /// <para>
        /// A count of how many total questions are answered and unanswered in the review template.
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

        /// <summary>
        /// Gets and sets the property ShareInvitationId. 
        /// <para>
        /// The ID assigned to the template share invitation.
        /// </para>
        /// </summary>
        public string ShareInvitationId { get; set; }

        /// <summary>
        /// Checks to see if the ShareInvitationId property is set.
        /// </summary>
        internal bool IsSetShareInvitationId() => this.ShareInvitationId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the review template.
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
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The review template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 250)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the review template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The latest status of a review template.
        /// </para>
        /// </summary>
        public ReviewTemplateUpdateStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the review template was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
