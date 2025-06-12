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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetBucketMetricData operation.
    /// Returns the data points of a specific metric for an Amazon Lightsail bucket.
    /// 
    ///  
    /// <para>
    /// Metrics report the utilization of a bucket. View and collect metric data regularly
    /// to monitor the number of objects stored in a bucket (including object versions) and
    /// the storage space used by those objects.
    /// </para>
    /// </summary>
    public partial class GetBucketMetricDataRequest : AmazonLightsailRequest
    {
        private string _bucketName;
        private DateTime? _endTime;
        private BucketMetricName _metricName;
        private int? _period;
        private DateTime? _startTime;
        private List<string> _statistics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MetricUnit _unit;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to get metric data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=54)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp indicating the latest data to be returned.
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric for which you want to return information.
        /// </para>
        ///  
        /// <para>
        /// Valid bucket metric names are listed below, along with the most useful statistics
        /// to include in your request, and the published unit value.
        /// </para>
        ///  <note> 
        /// <para>
        /// These bucket metrics are reported once per day.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <b> <c>BucketSizeBytes</c> </b> - The amount of data in bytes stored in a bucket.
        /// This value is calculated by summing the size of all objects in the bucket (including
        /// object versions), including the size of all parts for all incomplete multipart uploads
        /// to the bucket.
        /// </para>
        ///  
        /// <para>
        /// Statistics: The most useful statistic is <c>Maximum</c>.
        /// </para>
        ///  
        /// <para>
        /// Unit: The published unit is <c>Bytes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>NumberOfObjects</c> </b> - The total number of objects stored in a bucket.
        /// This value is calculated by counting all objects in the bucket (including object versions)
        /// and the total number of parts for all incomplete multipart uploads to the bucket.
        /// </para>
        ///  
        /// <para>
        /// Statistics: The most useful statistic is <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        /// Unit: The published unit is <c>Count</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public BucketMetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points.
        /// </para>
        ///  <note> 
        /// <para>
        /// Bucket storage metrics are reported once per day. Therefore, you should specify a
        /// period of 86400 seconds, which is the number of seconds in a day.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=86400)]
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp indicating the earliest data to be returned.
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

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistic for the metric.
        /// </para>
        ///  
        /// <para>
        /// The following statistics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Minimum</c> - The lowest value observed during the specified period. Use this
        /// value to determine low volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Maximum</c> - The highest value observed during the specified period. Use this
        /// value to determine high volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sum</c> - The sum of all values submitted for the matching metric. You can use
        /// this statistic to determine the total volume of a metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Average</c> - The value of <c>Sum</c> / <c>SampleCount</c> during the specified
        /// period. By comparing this statistic with the <c>Minimum</c> and <c>Maximum</c> values,
        /// you can determine the full scope of a metric and how close the average use is to the
        /// <c>Minimum</c> and <c>Maximum</c> values. This comparison helps you to know when to
        /// increase or decrease your resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SampleCount</c> - The count, or number, of data points used for the statistical
        /// calculation.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && (this._statistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for the metric data request.
        /// </para>
        ///  
        /// <para>
        /// Valid units depend on the metric data being requested. For the valid units with each
        /// available metric, see the <c>metricName</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}