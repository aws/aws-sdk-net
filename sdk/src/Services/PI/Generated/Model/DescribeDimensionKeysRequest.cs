/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDimensionKeys operation.
    /// For a specific time period, retrieve the top <code>N</code> dimension keys for a metric.
    /// </summary>
    public partial class DescribeDimensionKeysRequest : AmazonPIRequest
    {
        private DateTime? _endTime;
        private Dictionary<string, string> _filter = new Dictionary<string, string>();
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time specifying the end of the requested time series data. The value
        /// specified is <i>exclusive</i> - data points less than (but not equal to) <code>EndTime</code>
        /// will be returned.
        /// </para>
        ///  
        /// <para>
        /// The value for <code>EndTime</code> must be later than the value for <code>StartTime</code>.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
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
        /// Any number of filters by the same dimension, as specified in the <code>GroupBy</code>
        /// or <code>Partition</code> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A single filter for any other dimension in this dimension group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// A specification for how to aggregate the data points from a query result. You must
        /// specify a valid dimension group. Performance Insights will return all of the dimensions
        /// within that group, unless you provide the names of specific dimensions within that
        /// group. You can also request that Performance Insights return a limited number of values
        /// for a dimension.
        /// </para>
        /// </summary>
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
        /// An immutable, AWS Region-unique identifier for a data source. Performance Insights
        /// gathers metrics from this data source.
        /// </para>
        ///  
        /// <para>
        /// To use an Amazon RDS instance as a data source, you specify its <code>DbiResourceId</code>
        /// value - for example: <code>db-FAIHNTYBKTGAUSUZQYPDS2GW4A</code> 
        /// </para>
        /// </summary>
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
        /// specified <code>MaxRecords</code> value, a pagination token is included in the response
        /// so that the remaining results can be retrieved. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Metric. 
        /// <para>
        /// The name of a Performance Insights metric to be measured.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Metric</code> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db.load.avg</code> - a scaled representation of the number of active sessions
        /// for the database engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sampledload.avg</code> - the raw number of active sessions for the database
        /// engine.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// by <code>MaxRecords</code>.
        /// </para>
        /// </summary>
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
        /// For each dimension specified in <code>GroupBy</code>, specify a secondary dimension
        /// to further subdivide the partition keys in the response.
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
        ///  <code>1</code> (one second)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>60</code> (one minute)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>300</code> (five minutes)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>3600</code> (one hour)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>86400</code> (twenty-four hours)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify <code>PeriodInSeconds</code>, then Performance Insights will
        /// choose a value for you, with a goal of returning roughly 100-200 data points in the
        /// response.
        /// </para>
        /// </summary>
        public int PeriodInSeconds
        {
            get { return this._periodInSeconds.GetValueOrDefault(); }
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
        /// The AWS service for which Performance Insights will return metrics. The only valid
        /// value for <i>ServiceType</i> is: <code>RDS</code> 
        /// </para>
        /// </summary>
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
        /// can't specify a <code>StartTime</code> that's earlier than 7 days ago. The value specified
        /// is <i>inclusive</i> - data points equal to or greater than <code>StartTime</code>
        /// will be returned.
        /// </para>
        ///  
        /// <para>
        /// The value for <code>StartTime</code> must be earlier than the value for <code>EndTime</code>.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}