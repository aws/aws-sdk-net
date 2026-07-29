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
 * Do not modify this file. This file is generated from the sustainability-2018-05-10.normal.json service model.
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
namespace Amazon.Sustainability.Model
{
    /// <summary>
    /// Container for the parameters to the GetEstimatedWaterAllocation operation.
    /// Returns estimated water allocation values based on customer grouping and filtering
    /// parameters. We recommend using pagination to ensure that the operation returns quickly
    /// and successfully.
    /// </summary>
    public partial class GetEstimatedWaterAllocationRequest : AmazonSustainabilityRequest
    {
        private List<string> _allocationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FilterExpression _filterBy;
        private TimeGranularity _granularity;
        private List<string> _groupBy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private TimePeriod _timePeriod;

        /// <summary>
        /// Gets and sets the property AllocationTypes. 
        /// <para>
        /// The allocation types to include in the results. If absent, returns <c>TOTAL_WATER_WITHDRAWALS</c>
        /// allocation types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllocationTypes
        {
            get { return this._allocationTypes; }
            set { this._allocationTypes = value; }
        }

        // Check to see if AllocationTypes property is set
        internal bool IsSetAllocationTypes()
        {
            return this._allocationTypes != null && (this._allocationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterBy. 
        /// <para>
        ///  The criteria for filtering estimated water allocation. To determine which dimensions
        /// are available to be filtered by, you can first call <a>GetEstimatedWaterAllocationDimensionValues</a>
        /// 
        /// </para>
        /// </summary>
        public FilterExpression FilterBy
        {
            get { return this._filterBy; }
            set { this._filterBy = value; }
        }

        // Check to see if FilterBy property is set
        internal bool IsSetFilterBy()
        {
            return this._filterBy != null;
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The time granularity for the results. Only <c>YEARLY_CALENDAR</c> time granularity
        /// is currently supported for water allocation. Defaults to <c>YEARLY_CALENDAR</c> if
        /// absent.
        /// </para>
        ///  
        /// <para>
        ///  If requesting partial time periods, data will be returned based on the smallest supported
        /// granularity. For example, requesting <c>2025-04-01T00:00:00Z</c> to <c>2026-04-01T00:00:00Z</c>
        /// with <c>YEARLY_CALENDAR</c> will return all the data for 2026 only. 
        /// </para>
        /// </summary>
        public TimeGranularity Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The dimensions available for grouping estimated water allocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && (this._groupBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Default is 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token specifying which page of results to return in the response. If
        /// no token is provided, the default page is the first page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property TimePeriod. 
        /// <para>
        ///  The date range for fetching estimated water allocation. The range must include the
        /// start date of a year for that year's data to be included in the response. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimePeriod TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}