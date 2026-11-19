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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetReservationCoverage operation. Retrieves the
    /// reservation coverage for your account, which you can use to see how much of your Amazon
    /// Elastic Compute Cloud, Amazon Relational Database Service, Amazon ElastiCache, Amazon
    /// MemoryDB, Amazon Redshift, Amazon Elasticsearch Service, or Amazon OpenSearch Service
    /// usage is covered by a reservation. An organization's management account can see the
    /// coverage of the associated member accounts. This supports dimensions, cost categories,
    /// and nested expressions. For any time period, you can filter data about reservation
    /// usage by the following dimensions: <ul> <li> <para> AZ </para> </li> <li> <para> CACHE_ENGINE
    /// </para> </li> <li> <para> DATABASE_ENGINE </para> </li> <li> <para> DEPLOYMENT_OPTION
    /// </para> </li> <li> <para> INSTANCE_TYPE </para> </li> <li> <para> INSTANCE_TYPE_FAMILY
    /// </para> </li> <li> <para> LINKED_ACCOUNT </para> </li> <li> <para> PLATFORM </para>
    /// </li> <li> <para> REGION </para> </li> <li> <para> SERVICE </para> </li> <li> <para>
    /// TAG </para> </li> <li> <para> TENANCY </para> </li> </ul> <para> The dimensions that
    /// you can use depend on the service in the <c>SERVICE</c> filter. For details, see <c>Filter</c>.
    /// </para> <para> To determine valid values for a dimension, use the <c>GetDimensionValues</c>
    /// operation. </para>
    /// </summary>
    public partial class GetReservationCoverageRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters coverage data by dimensions. You can filter by the following dimensions:
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
        /// DATABASE_ENGINE
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
        /// INSTANCE_TYPE_FAMILY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LINKED_ACCOUNT
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
        /// Supported values for <c>SERVICE</c> are Amazon Elastic Compute Cloud - Compute, Amazon
        /// Relational Database Service, Amazon ElastiCache, Amazon MemoryDB, Amazon Redshift,
        /// Amazon Elasticsearch Service, and Amazon OpenSearch Service. You can specify up to
        /// two <c>SERVICE</c> values.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// TAG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TENANCY
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The dimensions that you can use depend on the service in the <c>SERVICE</c> filter.
        /// <c>CACHE_ENGINE</c> applies only to Amazon ElastiCache and Amazon MemoryDB. <c>DATABASE_ENGINE</c>
        /// and <c>DEPLOYMENT_OPTION</c> apply only to Amazon Relational Database Service. <c>INSTANCE_TYPE_FAMILY</c>,
        /// <c>PLATFORM</c>, and <c>TENANCY</c> apply only to Amazon Elastic Compute Cloud - Compute.
        /// If you specify two <c>SERVICE</c> values, use only dimensions that both services support.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetReservationCoverage</c> uses the same <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_Expression.html">Expression</a>
        /// object as the other operations, but only <c>AND</c> is supported among each dimension.
        /// You can nest only one level deep. If there are multiple values for a dimension, they
        /// are OR'd together.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide a <c>SERVICE</c> filter, Cost Explorer defaults to EC2.
        /// </para>
        ///  
        /// <para>
        /// Cost category is also supported.
        /// </para>
        /// </summary>
        public Expression Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// The granularity of the Amazon Web Services cost data for the reservation. Valid values
        /// are <c>MONTHLY</c> and <c>DAILY</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>GroupBy</c> is set, <c>Granularity</c> can't be set. If <c>Granularity</c> isn't
        /// set, the response object doesn't include <c>Granularity</c>, either <c>MONTHLY</c>
        /// or <c>DAILY</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>GetReservationCoverage</c> operation supports only <c>DAILY</c> and <c>MONTHLY</c>
        /// granularities.
        /// </para>
        /// </summary>
        public Granularity Granularity { get; set; }

        /// <summary>
        /// Checks to see if the Granularity property is set.
        /// </summary>
        internal bool IsSetGranularity() => this.Granularity != null;

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// You can group the data by the following attributes. The attributes that you can use
        /// depend on the service in the <c>SERVICE</c> filter. If you don't provide a <c>SERVICE</c>
        /// filter, Cost Explorer uses Amazon Elastic Compute Cloud - Compute.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Elastic Compute Cloud - Compute: <c>AZ</c>, <c>INSTANCE_TYPE</c>, <c>INSTANCE_TYPE_FAMILY</c>,
        /// <c>LINKED_ACCOUNT</c>, <c>PLATFORM</c>, <c>REGION</c>, and <c>TENANCY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Relational Database Service: <c>AZ</c>, <c>DATABASE_ENGINE</c>, <c>DEPLOYMENT_OPTION</c>,
        /// <c>INSTANCE_TYPE</c>, <c>LINKED_ACCOUNT</c>, and <c>REGION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ElastiCache and Amazon MemoryDB: <c>AZ</c>, <c>CACHE_ENGINE</c>, <c>INSTANCE_TYPE</c>,
        /// <c>LINKED_ACCOUNT</c>, and <c>REGION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Redshift, Amazon Elasticsearch Service, and Amazon OpenSearch Service: <c>AZ</c>,
        /// <c>INSTANCE_TYPE</c>, <c>LINKED_ACCOUNT</c>, and <c>REGION</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify two <c>SERVICE</c> values, use only attributes that both services support.
        /// You can specify up to four attributes, and only the <c>DIMENSION</c> type is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupDefinition> GroupBy { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupDefinition>() : null;

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null && (this.GroupBy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you returned for this request. If more objects
        /// are available, in the response, Amazon Web Services provides a NextPageToken value
        /// that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The measurement that you want your reservation coverage reported in.
        /// </para>
        ///  
        /// <para>
        /// Valid values are <c>Hour</c>, <c>Unit</c>, and <c>Cost</c>. You can use multiple values
        /// in a request. <c>Hour</c> returns <c>CoverageHours</c>, <c>Unit</c> returns <c>CoverageNormalizedUnits</c>,
        /// and <c>Cost</c> returns <c>CoverageCost</c>. <c>Unit</c> is supported only for Amazon
        /// Elastic Compute Cloud - Compute. If you don't specify <c>Metrics</c>, the response
        /// includes only <c>CoverageHours</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value by which you want to sort the data.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported for <c>Key</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OnDemandCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CoverageHoursPercentage</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OnDemandHours</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReservedHours</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalRunningHours</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CoverageNormalizedUnitsPercentage</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OnDemandNormalizedUnits</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReservedNormalizedUnits</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TotalRunningNormalizedUnits</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Time</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Supported values for <c>SortOrder</c> are <c>ASCENDING</c> or <c>DESCENDING</c>.
        /// </para>
        /// </summary>
        public SortDefinition SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The start and end dates of the period that you want to retrieve data about reservation
        /// coverage for. You can retrieve data for a maximum of 13 months: the last 12 months
        /// and the current month. The start date is inclusive, but the end date is exclusive.
        /// For example, if <c>start</c> is <c>2017-01-01</c> and <c>end</c> is <c>2017-05-01</c>,
        /// then the cost and usage data is retrieved from <c>2017-01-01</c> up to and including
        /// <c>2017-04-30</c> but not including <c>2017-05-01</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateInterval TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;
    }
}
