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

namespace Amazon.PI.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceMetrics operation. Retrieve Performance
    /// Insights metrics for a set of data sources over a time period. You can provide specific
    /// dimension groups and dimensions, and provide filtering criteria for each group. You
    /// must specify an aggregate function for each metric. <note> <para> Each response element
    /// returns a maximum of 500 bytes. For larger elements, such as SQL statements, only
    /// the first 500 bytes are returned. </para> </note>
    /// </summary>
    public partial class GetResourceMetricsRequest : AmazonPIRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time specifying the end of the requested time series query range. The
        /// value specified is <i>exclusive</i>. Thus, the command returns data points less than
        /// (but not equal to) <c>EndTime</c>.
        /// </para>
        ///  
        /// <para>
        /// The value for <c>EndTime</c> must be later than the value for <c>StartTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An immutable identifier for a data source that is unique for an Amazon Web Services
        /// Region. Performance Insights gathers metrics from this data source. In the console,
        /// the identifier is shown as <i>ResourceID</i>. When you call <c>DescribeDBInstances</c>,
        /// the identifier is returned as <c>DbiResourceId</c>.
        /// </para>
        ///  
        /// <para>
        /// To use a DB instance as a data source, specify its <c>DbiResourceId</c> value. For
        /// example, specify <c>db-ABCDEFGHIJKLMNOPQRSTU1VW2X</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MetricQueries. 
        /// <para>
        /// An array of one or more queries to perform. Each query must specify a Performance
        /// Insights metric and specify an aggregate function, and you can provide filtering criteria.
        /// You must append the aggregate function to the metric. For example, to find the average
        /// for the metric <c>db.load</c> you must use <c>db.load.avg</c>. Valid values for aggregate
        /// functions include <c>.avg</c>, <c>.min</c>, <c>.max</c>, and <c>.sum</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 15)]
        public List<MetricQuery> MetricQueries { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricQuery>() : null;

        /// <summary>
        /// Checks to see if the MetricQueries property is set.
        /// </summary>
        internal bool IsSetMetricQueries() => this.MetricQueries != null && (this.MetricQueries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the token, up to the value specified
        /// by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PeriodAlignment. 
        /// <para>
        /// The returned timestamp which is the start or end time of the time periods. The default
        /// value is <c>END_TIME</c>.
        /// </para>
        /// </summary>
        public PeriodAlignment PeriodAlignment { get; set; }

        /// <summary>
        /// Checks to see if the PeriodAlignment property is set.
        /// </summary>
        internal bool IsSetPeriodAlignment() => this.PeriodAlignment != null;

        /// <summary>
        /// Gets and sets the property PeriodInSeconds. 
        /// <para>
        /// The granularity, in seconds, of the data points returned from Performance Insights.
        /// A period can be as short as one second, or as long as one day (86400 seconds). Valid
        /// values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>1</c> (one second)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>60</c> (one minute)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>300</c> (five minutes)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>3600</c> (one hour)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>86400</c> (twenty-four hours)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify <c>PeriodInSeconds</c>, then Performance Insights will choose
        /// a value for you, with a goal of returning roughly 100-200 data points in the response.
        /// </para>
        /// </summary>
        public int? PeriodInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the PeriodInSeconds property is set.
        /// </summary>
        internal bool IsSetPeriodInSeconds() => this.PeriodInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The Amazon Web Services service for which Performance Insights returns metrics. Valid
        /// values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RDS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DOCDB</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceType ServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time specifying the beginning of the requested time series query range.
        /// You can't specify a <c>StartTime</c> that is earlier than 7 days ago. By default,
        /// Performance Insights has 7 days of retention, but you can extend this range up to
        /// 2 years. The value specified is <i>inclusive</i>. Thus, the command returns data points
        /// equal to or greater than <c>StartTime</c>.
        /// </para>
        ///  
        /// <para>
        /// The value for <c>StartTime</c> must be earlier than the value for <c>EndTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
