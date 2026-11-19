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
    /// Counts describing the coverage of a completed Organizational Report. Includes the
    /// number of accounts in scope, how many had a profile, how many failed, and aggregated
    /// recommendation counts by pillar and priority. Returned only by GetAgentOrganizationalReport
    /// after the report reaches COMPLETED status. Not returned on the list response.
    /// </summary>
    public partial class CoverageSummary
    {
        /// <summary>
        /// Gets and sets the property AccountsWithProfile. 
        /// <para>
        /// Number of in-scope accounts that had an Agent Profile and were successfully processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? AccountsWithProfile { get; set; }

        /// <summary>
        /// Checks to see if the AccountsWithProfile property is set.
        /// </summary>
        internal bool IsSetAccountsWithProfile() => this.AccountsWithProfile.HasValue;

        /// <summary>
        /// Gets and sets the property AccountsWithoutProfile. 
        /// <para>
        /// Number of in-scope accounts that had no Agent Profile at the time of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? AccountsWithoutProfile { get; set; }

        /// <summary>
        /// Checks to see if the AccountsWithoutProfile property is set.
        /// </summary>
        internal bool IsSetAccountsWithoutProfile() => this.AccountsWithoutProfile.HasValue;

        /// <summary>
        /// Gets and sets the property FailedAccountCount. 
        /// <para>
        /// Number of in-scope accounts that errored during processing. Equal to the length of
        /// failedAccounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FailedAccountCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedAccountCount property is set.
        /// </summary>
        internal bool IsSetFailedAccountCount() => this.FailedAccountCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedAccounts. 
        /// <para>
        /// Accounts that errored during processing and the reason they failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1000)]
        public List<FailedAccount> FailedAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<FailedAccount>() : null;

        /// <summary>
        /// Checks to see if the FailedAccounts property is set.
        /// </summary>
        internal bool IsSetFailedAccounts() => this.FailedAccounts != null && (this.FailedAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailedOrganizationalUnits. 
        /// <para>
        /// Organizational units named in the report's filters that could not be expanded into
        /// their member accounts, along with the reason each failed. A failed OU means the report
        /// is missing whatever accounts it contained. Absent or empty when every requested OU
        /// expanded successfully.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1000)]
        public List<FailedOrganizationalUnit> FailedOrganizationalUnits { get; set; } = AWSConfigs.InitializeCollections ? new List<FailedOrganizationalUnit>() : null;

        /// <summary>
        /// Checks to see if the FailedOrganizationalUnits property is set.
        /// </summary>
        internal bool IsSetFailedOrganizationalUnits() => this.FailedOrganizationalUnits != null && (this.FailedOrganizationalUnits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendationCountByPillar. 
        /// <para>
        /// Recommendation count grouped by Well-Architected pillar. Each entry pairs a Pillar
        /// enum value with a non-negative long. The counts sum to totalRecommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<PillarCount> RecommendationCountByPillar { get; set; } = AWSConfigs.InitializeCollections ? new List<PillarCount>() : null;

        /// <summary>
        /// Checks to see if the RecommendationCountByPillar property is set.
        /// </summary>
        internal bool IsSetRecommendationCountByPillar() => this.RecommendationCountByPillar != null && (this.RecommendationCountByPillar.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendationCountByPriority. 
        /// <para>
        /// Recommendation count grouped by Priority. Each entry pairs a Priority enum value with
        /// a non-negative long. The counts sum to totalRecommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<PriorityCount> RecommendationCountByPriority { get; set; } = AWSConfigs.InitializeCollections ? new List<PriorityCount>() : null;

        /// <summary>
        /// Checks to see if the RecommendationCountByPriority property is set.
        /// </summary>
        internal bool IsSetRecommendationCountByPriority() => this.RecommendationCountByPriority != null && (this.RecommendationCountByPriority.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalAccountsInScope. 
        /// <para>
        /// Total number of accounts that were in scope for the report after applying all filters
        /// and AWS Organizations membership validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TotalAccountsInScope { get; set; }

        /// <summary>
        /// Checks to see if the TotalAccountsInScope property is set.
        /// </summary>
        internal bool IsSetTotalAccountsInScope() => this.TotalAccountsInScope.HasValue;

        /// <summary>
        /// Gets and sets the property TotalProfiles. 
        /// <para>
        /// Total number of Agent Profiles contributing to the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TotalProfiles { get; set; }

        /// <summary>
        /// Checks to see if the TotalProfiles property is set.
        /// </summary>
        internal bool IsSetTotalProfiles() => this.TotalProfiles.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRecommendations. 
        /// <para>
        /// Total number of recommendations included in the report across all profiles and all
        /// pillars.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TotalRecommendations { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecommendations property is set.
        /// </summary>
        internal bool IsSetTotalRecommendations() => this.TotalRecommendations.HasValue;
    }
}
