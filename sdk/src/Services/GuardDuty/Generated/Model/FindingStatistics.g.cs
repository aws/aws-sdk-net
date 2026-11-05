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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about finding statistics.
    /// </summary>
    public partial class FindingStatistics
    {
        /// <summary>
        /// Gets and sets the property CountBySeverity. 
        /// <para>
        /// Represents a list of map of severity to count statistics for a set of findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This parameter is deprecated. Please set GroupBy to 'SEVERITY' to return GroupedBySeverity instead.")]
        public Dictionary<string, int> CountBySeverity { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the CountBySeverity property is set.
        /// </summary>
        internal bool IsSetCountBySeverity() => this.CountBySeverity != null && (this.CountBySeverity.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupedByAccount. 
        /// <para>
        /// Represents a list of map of accounts with a findings count associated with each account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccountStatistics> GroupedByAccount { get; set; } = AWSConfigs.InitializeCollections ? new List<AccountStatistics>() : null;

        /// <summary>
        /// Checks to see if the GroupedByAccount property is set.
        /// </summary>
        internal bool IsSetGroupedByAccount() => this.GroupedByAccount != null && (this.GroupedByAccount.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupedByDate. 
        /// <para>
        /// Represents a list of map of dates with a count of total findings generated on each
        /// date per severity level.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateStatistics> GroupedByDate { get; set; } = AWSConfigs.InitializeCollections ? new List<DateStatistics>() : null;

        /// <summary>
        /// Checks to see if the GroupedByDate property is set.
        /// </summary>
        internal bool IsSetGroupedByDate() => this.GroupedByDate != null && (this.GroupedByDate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupedByFindingType. 
        /// <para>
        /// Represents a list of map of finding types with a count of total findings generated
        /// for each type. 
        /// </para>
        ///  
        /// <para>
        /// Based on the <c>orderBy</c> parameter, this request returns either the most occurring
        /// finding types or the least occurring finding types. If the <c>orderBy</c> parameter
        /// is <c>ASC</c>, this will represent the least occurring finding types in your account;
        /// otherwise, this will represent the most occurring finding types. The default value
        /// of <c>orderBy</c> is <c>DESC</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FindingTypeStatistics> GroupedByFindingType { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingTypeStatistics>() : null;

        /// <summary>
        /// Checks to see if the GroupedByFindingType property is set.
        /// </summary>
        internal bool IsSetGroupedByFindingType() => this.GroupedByFindingType != null && (this.GroupedByFindingType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupedByResource. 
        /// <para>
        /// Represents a list of map of top resources with a count of total findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceStatistics> GroupedByResource { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceStatistics>() : null;

        /// <summary>
        /// Checks to see if the GroupedByResource property is set.
        /// </summary>
        internal bool IsSetGroupedByResource() => this.GroupedByResource != null && (this.GroupedByResource.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupedBySeverity. 
        /// <para>
        /// Represents a list of map of total findings for each severity level.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SeverityStatistics> GroupedBySeverity { get; set; } = AWSConfigs.InitializeCollections ? new List<SeverityStatistics>() : null;

        /// <summary>
        /// Checks to see if the GroupedBySeverity property is set.
        /// </summary>
        internal bool IsSetGroupedBySeverity() => this.GroupedBySeverity != null && (this.GroupedBySeverity.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
