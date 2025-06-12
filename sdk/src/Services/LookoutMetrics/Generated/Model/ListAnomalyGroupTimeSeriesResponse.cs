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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// This is the response object from the ListAnomalyGroupTimeSeries operation.
    /// </summary>
    public partial class ListAnomalyGroupTimeSeriesResponse : AmazonWebServiceResponse
    {
        private string _anomalyGroupId;
        private string _metricName;
        private string _nextToken;
        private List<TimeSeries> _timeSeriesList = AWSConfigs.InitializeCollections ? new List<TimeSeries>() : null;
        private List<string> _timestampList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AnomalyGroupId. 
        /// <para>
        /// The ID of the anomaly group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string AnomalyGroupId
        {
            get { return this._anomalyGroupId; }
            set { this._anomalyGroupId = value; }
        }

        // Check to see if AnomalyGroupId property is set
        internal bool IsSetAnomalyGroupId()
        {
            return this._anomalyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the measure field.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// The pagination token that's included if more results are available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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
        /// Gets and sets the property TimeSeriesList. 
        /// <para>
        /// A list of anomalous metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TimeSeries> TimeSeriesList
        {
            get { return this._timeSeriesList; }
            set { this._timeSeriesList = value; }
        }

        // Check to see if TimeSeriesList property is set
        internal bool IsSetTimeSeriesList()
        {
            return this._timeSeriesList != null && (this._timeSeriesList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimestampList. 
        /// <para>
        /// Timestamps for the anomalous metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TimestampList
        {
            get { return this._timestampList; }
            set { this._timestampList = value; }
        }

        // Check to see if TimestampList property is set
        internal bool IsSetTimestampList()
        {
            return this._timestampList != null && (this._timestampList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}