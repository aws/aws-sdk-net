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
    /// Filters narrowing the scope of an Organizational Report. Every member is optional.
    /// An absent or empty member places no constraint on that dimension. When the entire
    /// structure is absent, the report covers every account and every recommendation in the
    /// organization.
    /// </summary>
    public partial class OrganizationalReportFilters
    {
        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// AWS account IDs to include in the report. Absent or empty means all accounts in the
        /// organization are in scope. Each supplied account is validated against AWS Organizations
        /// membership. Accounts that do not belong to the caller's organization are excluded
        /// and recorded on the report's coverage summary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10000)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAtRange. 
        /// <para>
        /// Inclusive window on recommendation creation time. Absent means no lower or upper bound
        /// on createdAt.
        /// </para>
        /// </summary>
        public TimeWindow CreatedAtRange { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAtRange property is set.
        /// </summary>
        internal bool IsSetCreatedAtRange() => this.CreatedAtRange != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// AWS Organizational Unit IDs whose member accounts are included in the report. Absent
        /// or empty means no OU-based scoping is applied. Account and OU filters combine as a
        /// union.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10000)]
        public List<string> OrganizationalUnitIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitIds property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitIds() => this.OrganizationalUnitIds != null && (this.OrganizationalUnitIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Pillars. 
        /// <para>
        /// Well-Architected pillars to include. Absent or empty means all pillars.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> Pillars { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Pillars property is set.
        /// </summary>
        internal bool IsSetPillars() => this.Pillars != null && (this.Pillars.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Priorities. 
        /// <para>
        /// Recommendation priorities (HIGH, MEDIUM, LOW) to include. Absent or empty means all
        /// priorities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> Priorities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Priorities property is set.
        /// </summary>
        internal bool IsSetPriorities() => this.Priorities != null && (this.Priorities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecommendationTypes. 
        /// <para>
        /// Recommendation types (RESOURCE, ARCHITECTURE, APPLICATION) to include. Absent or empty
        /// means all types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> RecommendationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendationTypes property is set.
        /// </summary>
        internal bool IsSetRecommendationTypes() => this.RecommendationTypes != null && (this.RecommendationTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// Recommendation statuses (ACTIVE, SUPPRESSED, COMPLETED) to include. Absent or empty
        /// means all statuses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> Statuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Statuses property is set.
        /// </summary>
        internal bool IsSetStatuses() => this.Statuses != null && (this.Statuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAtRange. 
        /// <para>
        /// Inclusive window on recommendation last-updated time. Absent means no lower or upper
        /// bound on updatedAt.
        /// </para>
        /// </summary>
        public TimeWindow UpdatedAtRange { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAtRange property is set.
        /// </summary>
        internal bool IsSetUpdatedAtRange() => this.UpdatedAtRange != null;
    }
}
