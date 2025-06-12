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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
    /// Container for the parameters to the DescribeDimensionKeys operation.
    /// For a specific time period, retrieve the top <c>N</c> dimension keys for a metric.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// Each response element returns a maximum of 500 bytes. For larger elements, such as
    /// SQL statements, only the first 500 bytes are returned.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeDimensionKeysRequest : AmazonPIRequest
    {
        private List<string> _additionalMetrics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _endTime;
        private Dictionary<string, string> _filter = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DimensionGroup _groupBy;
        private string _identifier;
        private int? _maxResults;
        private string _metric;
        private string _nextToken;
        private DimensionGroup _partitionBy;
        private int? _periodInSeconds;
        private ServiceType _serviceType;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AdditionalMetrics. 
        /// <para>
        /// Additional metrics for the top <c>N</c> dimension keys. If the specified dimension
        /// group in the <c>GroupBy</c> parameter is <c>db.sql_tokenized</c>, you can specify
        /// per-SQL metrics to get the values for the top <c>N</c> SQL digests. The response syntax
        /// is as follows: <c>"AdditionalMetrics" : { "<i>string</i>" : "<i>string</i>" }</c>.
        /// </para>
        ///  
        /// <para>
        /// The only supported statistic function is <c>.avg</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public List<string> AdditionalMetrics
        {
            get { return this._additionalMetrics; }
            set { this._additionalMetrics = value; }
        }

        // Check to see if AdditionalMetrics property is set
        internal bool IsSetAdditionalMetrics()
        {
            return this._additionalMetrics != null && (this._additionalMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time specifying the end of the requested time series data. The value
        /// specified is <i>exclusive</i>, which means that data points less than (but not equal
        /// to) <c>EndTime</c> are returned.
        /// </para>
        ///  
        /// <para>
        /// The value for <c>EndTime</c> must be later than the value for <c>StartTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters to apply in the request. Restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any number of filters by the same dimension, as specified in the <c>GroupBy</c> or
        /// <c>Partition</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A single filter for any other dimension in this dimension group.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>db.sql.db_id</c> filter isn't available for RDS for SQL Server DB instances.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && (this._filter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// A specification for how to aggregate the data points from a query result. You must
        /// specify a valid dimension group. Performance Insights returns all dimensions within
        /// this group, unless you provide the names of specific dimensions within this group.
        /// You can also request that Performance Insights return a limited number of values for
        /// a dimension. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DimensionGroup GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An immutable, Amazon Web Services Region-unique identifier for a data source. Performance
        /// Insights gathers metrics from this data source.
        /// </para>
        ///  
        /// <para>
        /// To use an Amazon RDS instance as a data source, you specify its <c>DbiResourceId</c>
        /// value. For example, specify <c>db-FAIHNTYBKTGAUSUZQYPDS2GW4A</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in the response. If more items exist than the
        /// specified <c>MaxRecords</c> value, a pagination token is included in the response
        /// so that the remaining results can be retrieved. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
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
        /// Gets and sets the property Metric. 
        /// <para>
        /// The name of a Performance Insights metric to be measured.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Metric</c> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db.load.avg</c> - A scaled representation of the number of active sessions for
        /// the database engine. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sampledload.avg</c> - The raw number of active sessions for the database engine.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the number of active sessions is less than an internal Performance Insights threshold,
        /// <c>db.load.avg</c> and <c>db.sampledload.avg</c> are the same value. If the number
        /// of active sessions is greater than the internal threshold, Performance Insights samples
        /// the active sessions, with <c>db.load.avg</c> showing the scaled values, <c>db.sampledload.avg</c>
        /// showing the raw values, and <c>db.sampledload.avg</c> less than <c>db.load.avg</c>.
        /// For most use cases, you can query <c>db.load.avg</c> only. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the token, up to the value specified
        /// by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property PartitionBy. 
        /// <para>
        /// For each dimension specified in <c>GroupBy</c>, specify a secondary dimension to further
        /// subdivide the partition keys in the response. 
        /// </para>
        /// </summary>
        public DimensionGroup PartitionBy
        {
            get { return this._partitionBy; }
            set { this._partitionBy = value; }
        }

        // Check to see if PartitionBy property is set
        internal bool IsSetPartitionBy()
        {
            return this._partitionBy != null;
        }

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
        /// If you don't specify <c>PeriodInSeconds</c>, then Performance Insights chooses a value
        /// for you, with a goal of returning roughly 100-200 data points in the response. 
        /// </para>
        /// </summary>
        public int? PeriodInSeconds
        {
            get { return this._periodInSeconds; }
            set { this._periodInSeconds = value; }
        }

        // Check to see if PeriodInSeconds property is set
        internal bool IsSetPeriodInSeconds()
        {
            return this._periodInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The Amazon Web Services service for which Performance Insights will return metrics.
        /// Valid values are as follows:
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
        [AWSProperty(Required=true)]
        public ServiceType ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time specifying the beginning of the requested time series data. You
        /// must specify a <c>StartTime</c> within the past 7 days. The value specified is <i>inclusive</i>,
        /// which means that data points equal to or greater than <c>StartTime</c> are returned.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The value for <c>StartTime</c> must be earlier than the value for <c>EndTime</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}