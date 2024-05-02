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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListMetricValues operation.
    /// Lists the values reported for an IoT Device Defender metric (device-side metric, cloud-side
    /// metric, or custom metric) by the given thing during the specified time period.
    /// </summary>
    public partial class ListMetricValuesRequest : AmazonIoTRequest
    {
        private string _dimensionName;
        private DimensionValueOperator _dimensionValueOperator;
        private DateTime? _endTime;
        private int? _maxResults;
        private string _metricName;
        private string _nextToken;
        private DateTime? _startTime;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property DimensionName. 
        /// <para>
        /// The dimension name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DimensionName
        {
            get { return this._dimensionName; }
            set { this._dimensionName = value; }
        }

        // Check to see if DimensionName property is set
        internal bool IsSetDimensionName()
        {
            return this._dimensionName != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionValueOperator. 
        /// <para>
        /// The dimension value operator.
        /// </para>
        /// </summary>
        public DimensionValueOperator DimensionValueOperator
        {
            get { return this._dimensionValueOperator; }
            set { this._dimensionValueOperator = value; }
        }

        // Check to see if DimensionValueOperator property is set
        internal bool IsSetDimensionValueOperator()
        {
            return this._dimensionValueOperator != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period for which metric values are returned.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the security profile metric for which values are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time period for which metric values are returned.
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
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing for which security profile metric values are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}