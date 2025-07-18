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
    /// The response to a <c>DataQuery</c>.
    /// </summary>
    public partial class DataResponse
    {
        private string _destination;
        private string _id;
        private MetricType _metric;
        private List<MetricPoint> _metricPoints = AWSConfigs.InitializeCollections ? new List<MetricPoint>() : null;
        private PeriodType _period;
        private string _source;
        private StatisticType _statistic;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Region or Availability Zone that's the destination for the data query. For example,
        /// <c>eu-west-1</c>.
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
        /// The ID passed in the <c>DataQuery</c>.
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
        /// The metric used for the network performance request.
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
        /// Gets and sets the property MetricPoints. 
        /// <para>
        /// A list of <c>MetricPoint</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricPoint> MetricPoints
        {
            get { return this._metricPoints; }
            set { this._metricPoints = value; }
        }

        // Check to see if MetricPoints property is set
        internal bool IsSetMetricPoints()
        {
            return this._metricPoints != null && (this._metricPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period used for the network performance request.
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
        /// The statistic used for the network performance request.
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