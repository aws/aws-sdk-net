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
    /// Container for the parameters to the GetResourceMetrics operation.
    /// Retrieve Performance Insights metrics for a set of data sources, over a time period.
    /// You can provide specific dimension groups and dimensions, and provide aggregation
    /// and filtering criteria for each group.
    /// </summary>
    public partial class GetResourceMetricsRequest : AmazonPIRequest
    {
        private DateTime? _endTime;
        private string _identifier;
        private int? _maxResults;
        private List<MetricQuery> _metricQueries = new List<MetricQuery>();
        private string _nextToken;
        private int? _periodInSeconds;
        private ServiceType _serviceType;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time specifiying the end of the requested time series data. The value
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
        /// Gets and sets the property MetricQueries. 
        /// <para>
        /// An array of one or more queries to perform. Each query must specify a Performance
        /// Insights metric, and can optionally specify aggregation and filtering criteria.
        /// </para>
        /// </summary>
        public List<MetricQuery> MetricQueries
        {
            get { return this._metricQueries; }
            set { this._metricQueries = value; }
        }

        // Check to see if MetricQueries property is set
        internal bool IsSetMetricQueries()
        {
            return this._metricQueries != null && this._metricQueries.Count > 0; 
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