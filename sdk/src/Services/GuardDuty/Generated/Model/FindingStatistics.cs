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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private Dictionary<string, int> _countBySeverity = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private List<AccountStatistics> _groupedByAccount = AWSConfigs.InitializeCollections ? new List<AccountStatistics>() : null;
        private List<DateStatistics> _groupedByDate = AWSConfigs.InitializeCollections ? new List<DateStatistics>() : null;
        private List<FindingTypeStatistics> _groupedByFindingType = AWSConfigs.InitializeCollections ? new List<FindingTypeStatistics>() : null;
        private List<ResourceStatistics> _groupedByResource = AWSConfigs.InitializeCollections ? new List<ResourceStatistics>() : null;
        private List<SeverityStatistics> _groupedBySeverity = AWSConfigs.InitializeCollections ? new List<SeverityStatistics>() : null;

        /// <summary>
        /// Gets and sets the property CountBySeverity. 
        /// <para>
        /// Represents a list of map of severity to count statistics for a set of findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This parameter is deprecated. Please set GroupBy to 'SEVERITY' to return GroupedBySeverity instead.")]
        public Dictionary<string, int> CountBySeverity
        {
            get { return this._countBySeverity; }
            set { this._countBySeverity = value; }
        }

        // Check to see if CountBySeverity property is set
        internal bool IsSetCountBySeverity()
        {
            return this._countBySeverity != null && (this._countBySeverity.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupedByAccount. 
        /// <para>
        /// Represents a list of map of accounts with a findings count associated with each account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccountStatistics> GroupedByAccount
        {
            get { return this._groupedByAccount; }
            set { this._groupedByAccount = value; }
        }

        // Check to see if GroupedByAccount property is set
        internal bool IsSetGroupedByAccount()
        {
            return this._groupedByAccount != null && (this._groupedByAccount.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupedByDate. 
        /// <para>
        /// Represents a list of map of dates with a count of total findings generated on each
        /// date per severity level.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateStatistics> GroupedByDate
        {
            get { return this._groupedByDate; }
            set { this._groupedByDate = value; }
        }

        // Check to see if GroupedByDate property is set
        internal bool IsSetGroupedByDate()
        {
            return this._groupedByDate != null && (this._groupedByDate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FindingTypeStatistics> GroupedByFindingType
        {
            get { return this._groupedByFindingType; }
            set { this._groupedByFindingType = value; }
        }

        // Check to see if GroupedByFindingType property is set
        internal bool IsSetGroupedByFindingType()
        {
            return this._groupedByFindingType != null && (this._groupedByFindingType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupedByResource. 
        /// <para>
        /// Represents a list of map of top resources with a count of total findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceStatistics> GroupedByResource
        {
            get { return this._groupedByResource; }
            set { this._groupedByResource = value; }
        }

        // Check to see if GroupedByResource property is set
        internal bool IsSetGroupedByResource()
        {
            return this._groupedByResource != null && (this._groupedByResource.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupedBySeverity. 
        /// <para>
        /// Represents a list of map of total findings for each severity level.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SeverityStatistics> GroupedBySeverity
        {
            get { return this._groupedBySeverity; }
            set { this._groupedBySeverity = value; }
        }

        // Check to see if GroupedBySeverity property is set
        internal bool IsSetGroupedBySeverity()
        {
            return this._groupedBySeverity != null && (this._groupedBySeverity.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}