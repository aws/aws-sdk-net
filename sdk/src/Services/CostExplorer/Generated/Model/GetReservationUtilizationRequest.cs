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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetReservationUtilization operation.
    /// Retrieves the reservation utilization for your account. Management account in an organization
    /// have access to member accounts. You can filter data by dimensions in a time period.
    /// You can use <code>GetDimensionValues</code> to determine the possible dimension values.
    /// Currently, you can group only by <code>SUBSCRIPTION_ID</code>.
    /// </summary>
    public partial class GetReservationUtilizationRequest : AmazonCostExplorerRequest
    {
        private Expression _filter;
        private Granularity _granularity;
        private List<GroupDefinition> _groupBy = new List<GroupDefinition>();
        private int? _maxResults;
        private string _nextPageToken;
        private SortDefinition _sortBy;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters utilization data by dimensions. You can filter by the following dimensions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AZ
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CACHE_ENGINE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DEPLOYMENT_OPTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_TYPE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LINKED_ACCOUNT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPERATING_SYSTEM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SCOPE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TENANCY
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <code>GetReservationUtilization</code> uses the same <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object as the other operations, but only <code>AND</code> is supported among each
        /// dimension, and nesting is supported up to only one level deep. If there are multiple
        /// values for a dimension, they are OR'd together.
        /// </para>
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// If <code>GroupBy</code> is set, <code>Granularity</code> can't be set. If <code>Granularity</code>
        /// isn't set, the response object doesn't include <code>Granularity</code>, either <code>MONTHLY</code>
        /// or <code>DAILY</code>. If both <code>GroupBy</code> and <code>Granularity</code> aren't
        /// set, <code>GetReservationUtilization</code> defaults to <code>DAILY</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>GetReservationUtilization</code> operation supports only <code>DAILY</code>
        /// and <code>MONTHLY</code> granularities.
        /// </para>
        /// </summary>
        public Granularity Granularity
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
        /// Groups only by <code>SUBSCRIPTION_ID</code>. Metadata is included.
        /// </para>
        /// </summary>
        public List<GroupDefinition> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && this._groupBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you returned for this request. If more objects
        /// are available, in the response, AWS provides a NextPageToken value that you can use
        /// in a subsequent call to get the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. AWS provides the token when the response
        /// from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value by which you want to sort the data.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported for <code>Key</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>UtilizationPercentage</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UtilizationPercentageInUnits</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PurchasedHours</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PurchasedUnits</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TotalActualHours</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TotalActualUnits</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UnusedHours</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UnusedUnits</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OnDemandCostOfRIHoursUsed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NetRISavings</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TotalPotentialRISavings</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AmortizedUpfrontFee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AmortizedRecurringFee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TotalAmortizedFee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RICostForUnusedHours</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RealizedSavings</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UnrealizedSavings</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Supported values for <code>SortOrder</code> are <code>ASCENDING</code> or <code>DESCENDING</code>.
        /// </para>
        /// </summary>
        public SortDefinition SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// Sets the start and end dates for retrieving RI utilization. The start date is inclusive,
        /// but the end date is exclusive. For example, if <code>start</code> is <code>2017-01-01</code>
        /// and <code>end</code> is <code>2017-05-01</code>, then the cost and usage data is retrieved
        /// from <code>2017-01-01</code> up to and including <code>2017-04-30</code> but not including
        /// <code>2017-05-01</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval TimePeriod
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