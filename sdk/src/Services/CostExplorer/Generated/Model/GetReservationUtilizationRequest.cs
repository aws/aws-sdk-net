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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetReservationUtilization operation.
    /// Retrieves the reservation utilization for your account. Management account in an organization
    /// have access to member accounts. You can filter data by dimensions in a time period.
    /// You can use <c>GetDimensionValues</c> to determine the possible dimension values.
    /// Currently, you can group only by <c>SUBSCRIPTION_ID</c>.
    /// </summary>
    public partial class GetReservationUtilizationRequest : AmazonCostExplorerRequest
    {
        private Expression _filter;
        private Granularity _granularity;
        private List<GroupDefinition> _groupBy = AWSConfigs.InitializeCollections ? new List<GroupDefinition>() : null;
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
        ///  <note> 
        /// <para>
        /// If not specified, the <c>SERVICE</c> filter defaults to Amazon Elastic Compute Cloud
        /// - Compute. Supported values for <c>SERVICE</c> are Amazon Elastic Compute Cloud -
        /// Compute, Amazon Relational Database Service, Amazon ElastiCache, Amazon Redshift,
        /// and Amazon Elasticsearch Service. The value for the <c>SERVICE</c> filter should not
        /// exceed "1".
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// SCOPE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TENANCY
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>GetReservationUtilization</c> uses the same <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object as the other operations, but only <c>AND</c> is supported among each dimension,
        /// and nesting is supported up to only one level deep. If there are multiple values for
        /// a dimension, they are OR'd together.
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
        /// If <c>GroupBy</c> is set, <c>Granularity</c> can't be set. If <c>Granularity</c> isn't
        /// set, the response object doesn't include <c>Granularity</c>, either <c>MONTHLY</c>
        /// or <c>DAILY</c>. If both <c>GroupBy</c> and <c>Granularity</c> aren't set, <c>GetReservationUtilization</c>
        /// defaults to <c>DAILY</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>GetReservationUtilization</c> operation supports only <c>DAILY</c> and <c>MONTHLY</c>
        /// granularities.
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
        /// Groups only by <c>SUBSCRIPTION_ID</c>. Metadata is included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupDefinition> GroupBy
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
        /// The maximum number of objects that you returned for this request. If more objects
        /// are available, in the response, Amazon Web Services provides a NextPageToken value
        /// that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
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
        /// The value that you want to sort the data by.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported for <c>Key</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UtilizationPercentage</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UtilizationPercentageInUnits</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PurchasedHours</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PurchasedUnits</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalActualHours</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalActualUnits</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UnusedHours</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UnusedUnits</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OnDemandCostOfRIHoursUsed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetRISavings</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalPotentialRISavings</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AmortizedUpfrontFee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AmortizedRecurringFee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalAmortizedFee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RICostForUnusedHours</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RealizedSavings</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UnrealizedSavings</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The supported values for <c>SortOrder</c> are <c>ASCENDING</c> and <c>DESCENDING</c>.
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
        /// Sets the start and end dates for retrieving Reserved Instance (RI) utilization. The
        /// start date is inclusive, but the end date is exclusive. For example, if <c>start</c>
        /// is <c>2017-01-01</c> and <c>end</c> is <c>2017-05-01</c>, then the cost and usage
        /// data is retrieved from <c>2017-01-01</c> up to and including <c>2017-04-30</c> but
        /// not including <c>2017-05-01</c>. 
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