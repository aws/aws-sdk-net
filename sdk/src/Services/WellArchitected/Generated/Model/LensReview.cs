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
    /// A lens review of a question.
    /// </summary>
    public partial class LensReview
    {
        private JiraSelectedQuestionConfiguration _jiraConfiguration;
        private string _lensAlias;
        private string _lensArn;
        private string _lensName;
        private LensStatus _lensStatus;
        private string _lensVersion;
        private string _nextToken;
        private string _notes;
        private List<PillarReviewSummary> _pillarReviewSummaries = AWSConfigs.InitializeCollections ? new List<PillarReviewSummary>() : null;
        private Dictionary<string, int> _prioritizedRiskCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private List<WorkloadProfile> _profiles = AWSConfigs.InitializeCollections ? new List<WorkloadProfile>() : null;
        private Dictionary<string, int> _riskCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Jira configuration status of the Lens review.
        /// </para>
        /// </summary>
        public JiraSelectedQuestionConfiguration JiraConfiguration
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
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property LensArn. 
        /// <para>
        /// The ARN for the lens.
        /// </para>
        /// </summary>
        public string LensArn
        {
            get { return this._lensArn; }
            set { this._lensArn = value; }
        }

        // Check to see if LensArn property is set
        internal bool IsSetLensArn()
        {
            return this._lensArn != null;
        }

        /// <summary>
        /// Gets and sets the property LensName.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LensName
        {
            get { return this._lensName; }
            set { this._lensName = value; }
        }

        // Check to see if LensName property is set
        internal bool IsSetLensName()
        {
            return this._lensName != null;
        }

        /// <summary>
        /// Gets and sets the property LensStatus. 
        /// <para>
        /// The status of the lens.
        /// </para>
        /// </summary>
        public LensStatus LensStatus
        {
            get { return this._lensStatus; }
            set { this._lensStatus = value; }
        }

        // Check to see if LensStatus property is set
        internal bool IsSetLensStatus()
        {
            return this._lensStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LensVersion. 
        /// <para>
        /// The version of the lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string LensVersion
        {
            get { return this._lensVersion; }
            set { this._lensVersion = value; }
        }

        // Check to see if LensVersion property is set
        internal bool IsSetLensVersion()
        {
            return this._lensVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
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
        /// Gets and sets the property PillarReviewSummaries.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PillarReviewSummary> PillarReviewSummaries
        {
            get { return this._pillarReviewSummaries; }
            set { this._pillarReviewSummaries = value; }
        }

        // Check to see if PillarReviewSummaries property is set
        internal bool IsSetPillarReviewSummaries()
        {
            return this._pillarReviewSummaries != null && (this._pillarReviewSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrioritizedRiskCounts.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> PrioritizedRiskCounts
        {
            get { return this._prioritizedRiskCounts; }
            set { this._prioritizedRiskCounts = value; }
        }

        // Check to see if PrioritizedRiskCounts property is set
        internal bool IsSetPrioritizedRiskCounts()
        {
            return this._prioritizedRiskCounts != null && (this._prioritizedRiskCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// The profiles associated with the workload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<WorkloadProfile> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }

        // Check to see if Profiles property is set
        internal bool IsSetProfiles()
        {
            return this._profiles != null && (this._profiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RiskCounts.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> RiskCounts
        {
            get { return this._riskCounts; }
            set { this._riskCounts = value; }
        }

        // Check to see if RiskCounts property is set
        internal bool IsSetRiskCounts()
        {
            return this._riskCounts != null && (this._riskCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt.
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}