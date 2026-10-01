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
    /// A lens review of a question.
    /// </summary>
    public partial class LensReview
    {
        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Jira configuration status of the Lens review.
        /// </para>
        /// </summary>
        public JiraSelectedQuestionConfiguration JiraConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the JiraConfiguration property is set.
        /// </summary>
        internal bool IsSetJiraConfiguration() => this.JiraConfiguration != null;

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LensAlias { get; set; }

        /// <summary>
        /// Checks to see if the LensAlias property is set.
        /// </summary>
        internal bool IsSetLensAlias() => this.LensAlias != null;

        /// <summary>
        /// Gets and sets the property LensArn. 
        /// <para>
        /// The ARN for the lens.
        /// </para>
        /// </summary>
        public string LensArn { get; set; }

        /// <summary>
        /// Checks to see if the LensArn property is set.
        /// </summary>
        internal bool IsSetLensArn() => this.LensArn != null;

        /// <summary>
        /// Gets and sets the property LensName.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LensName { get; set; }

        /// <summary>
        /// Checks to see if the LensName property is set.
        /// </summary>
        internal bool IsSetLensName() => this.LensName != null;

        /// <summary>
        /// Gets and sets the property LensStatus. 
        /// <para>
        /// The status of the lens.
        /// </para>
        /// </summary>
        public LensStatus LensStatus { get; set; }

        /// <summary>
        /// Checks to see if the LensStatus property is set.
        /// </summary>
        internal bool IsSetLensStatus() => this.LensStatus != null;

        /// <summary>
        /// Gets and sets the property LensVersion. 
        /// <para>
        /// The version of the lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string LensVersion { get; set; }

        /// <summary>
        /// Checks to see if the LensVersion property is set.
        /// </summary>
        internal bool IsSetLensVersion() => this.LensVersion != null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        /// Gets and sets the property PillarReviewSummaries.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PillarReviewSummary> PillarReviewSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<PillarReviewSummary>() : null;

        /// <summary>
        /// Checks to see if the PillarReviewSummaries property is set.
        /// </summary>
        internal bool IsSetPillarReviewSummaries() => this.PillarReviewSummaries != null && (this.PillarReviewSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrioritizedRiskCounts.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> PrioritizedRiskCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the PrioritizedRiskCounts property is set.
        /// </summary>
        internal bool IsSetPrioritizedRiskCounts() => this.PrioritizedRiskCounts != null && (this.PrioritizedRiskCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// The profiles associated with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<WorkloadProfile> Profiles { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkloadProfile>() : null;

        /// <summary>
        /// Checks to see if the Profiles property is set.
        /// </summary>
        internal bool IsSetProfiles() => this.Profiles != null && (this.Profiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RiskCounts.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> RiskCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the RiskCounts property is set.
        /// </summary>
        internal bool IsSetRiskCounts() => this.RiskCounts != null && (this.RiskCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the lens review was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
