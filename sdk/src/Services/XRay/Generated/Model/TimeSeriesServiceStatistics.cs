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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// A list of TimeSeriesStatistic structures.
    /// </summary>
    public partial class TimeSeriesServiceStatistics
    {
        private EdgeStatistics _edgeSummaryStatistics;
        private List<HistogramEntry> _responseTimeHistogram = AWSConfigs.InitializeCollections ? new List<HistogramEntry>() : null;
        private ForecastStatistics _serviceForecastStatistics;
        private ServiceStatistics _serviceSummaryStatistics;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property EdgeSummaryStatistics.
        /// </summary>
        public EdgeStatistics EdgeSummaryStatistics
        {
            get { return this._edgeSummaryStatistics; }
            set { this._edgeSummaryStatistics = value; }
        }

        // Check to see if EdgeSummaryStatistics property is set
        internal bool IsSetEdgeSummaryStatistics()
        {
            return this._edgeSummaryStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseTimeHistogram. 
        /// <para>
        /// The response time histogram for the selected entities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HistogramEntry> ResponseTimeHistogram
        {
            get { return this._responseTimeHistogram; }
            set { this._responseTimeHistogram = value; }
        }

        // Check to see if ResponseTimeHistogram property is set
        internal bool IsSetResponseTimeHistogram()
        {
            return this._responseTimeHistogram != null && (this._responseTimeHistogram.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceForecastStatistics. 
        /// <para>
        /// The forecasted high and low fault count values.
        /// </para>
        /// </summary>
        public ForecastStatistics ServiceForecastStatistics
        {
            get { return this._serviceForecastStatistics; }
            set { this._serviceForecastStatistics = value; }
        }

        // Check to see if ServiceForecastStatistics property is set
        internal bool IsSetServiceForecastStatistics()
        {
            return this._serviceForecastStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceSummaryStatistics.
        /// </summary>
        public ServiceStatistics ServiceSummaryStatistics
        {
            get { return this._serviceSummaryStatistics; }
            set { this._serviceSummaryStatistics = value; }
        }

        // Check to see if ServiceSummaryStatistics property is set
        internal bool IsSetServiceSummaryStatistics()
        {
            return this._serviceSummaryStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Timestamp of the window for which statistics are aggregated.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}