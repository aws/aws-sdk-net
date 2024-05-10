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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// A query used for retrieving network health data.
    /// </summary>
    public partial class DataQuery
    {
        private string _destination;
        private string _id;
        private MetricType _metric;
        private PeriodType _period;
        private string _source;
        private StatisticType _statistic;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Region or Availability Zone that's the target for the data query. For example,
        /// <c>eu-north-1</c>.
        /// </para>
        /// </summary>
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A user-defined ID associated with a data query that's returned in the <c>dataResponse</c>
        /// identifying the query. For example, if you set the Id to <c>MyQuery01</c>in the query,
        /// the <c>dataResponse</c> identifies the query as <c>MyQuery01</c>.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The metric, <c>aggregation-latency</c>, indicating that network latency is aggregated
        /// for the query. This is the only supported metric.
        /// </para>
        /// </summary>
        public MetricType Metric
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
        /// Gets and sets the property Period. 
        /// <para>
        /// The aggregation period used for the data query.
        /// </para>
        /// </summary>
        public PeriodType Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Region or Availability Zone that's the source for the data query. For example,
        /// <c>us-east-1</c>.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The metric data aggregation period, <c>p50</c>, between the specified <c>startDate</c>
        /// and <c>endDate</c>. For example, a metric of <c>five_minutes</c> is the median of
        /// all the data points gathered within those five minutes. <c>p50</c> is the only supported
        /// metric.
        /// </para>
        /// </summary>
        public StatisticType Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

    }
}