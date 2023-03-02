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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeFleetMetric operation.
    /// </summary>
    public partial class DescribeFleetMetricResponse : AmazonWebServiceResponse
    {
        private string _aggregationField;
        private AggregationType _aggregationType;
        private DateTime? _creationDate;
        private string _description;
        private string _indexName;
        private DateTime? _lastModifiedDate;
        private string _metricArn;
        private string _metricName;
        private int? _period;
        private string _queryString;
        private string _queryVersion;
        private FleetMetricUnit _unit;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AggregationField. 
        /// <para>
        /// The field to aggregate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string AggregationField
        {
            get { return this._aggregationField; }
            set { this._aggregationField = value; }
        }

        // Check to see if AggregationField property is set
        internal bool IsSetAggregationField()
        {
            return this._aggregationField != null;
        }

        /// <summary>
        /// Gets and sets the property AggregationType. 
        /// <para>
        /// The type of the aggregation query.
        /// </para>
        /// </summary>
        public AggregationType AggregationType
        {
            get { return this._aggregationType; }
            set { this._aggregationType = value; }
        }

        // Check to see if AggregationType property is set
        internal bool IsSetAggregationType()
        {
            return this._aggregationType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the fleet metric is created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The fleet metric description.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to search.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the fleet metric is last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricArn. 
        /// <para>
        /// The ARN of the fleet metric to describe.
        /// </para>
        /// </summary>
        public string MetricArn
        {
            get { return this._metricArn; }
            set { this._metricArn = value; }
        }

        // Check to see if MetricArn property is set
        internal bool IsSetMetricArn()
        {
            return this._metricArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the fleet metric to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string MetricName
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
        /// The time in seconds between fleet metric emissions. Range [60(1 min), 86400(1 day)]
        /// and must be multiple of 60.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=86400)]
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The search query string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property QueryVersion. 
        /// <para>
        /// The query version.
        /// </para>
        /// </summary>
        public string QueryVersion
        {
            get { return this._queryVersion; }
            set { this._queryVersion = value; }
        }

        // Check to see if QueryVersion property is set
        internal bool IsSetQueryVersion()
        {
            return this._queryVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Used to support unit transformation such as milliseconds to seconds. The unit must
        /// be supported by <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_MetricDatum.html">CW
        /// metric</a>.
        /// </para>
        /// </summary>
        public FleetMetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the fleet metric.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}