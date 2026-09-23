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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EdgeSummaryStatistics.
        /// </summary>
        public EdgeStatistics EdgeSummaryStatistics { get; set; }

        /// <summary>
        /// Checks to see if the EdgeSummaryStatistics property is set.
        /// </summary>
        internal bool IsSetEdgeSummaryStatistics() => this.EdgeSummaryStatistics != null;

        /// <summary>
        /// Gets and sets the property ResponseTimeHistogram. 
        /// <para>
        /// The response time histogram for the selected entities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HistogramEntry> ResponseTimeHistogram { get; set; } = AWSConfigs.InitializeCollections ? new List<HistogramEntry>() : null;

        /// <summary>
        /// Checks to see if the ResponseTimeHistogram property is set.
        /// </summary>
        internal bool IsSetResponseTimeHistogram() => this.ResponseTimeHistogram != null && (this.ResponseTimeHistogram.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceForecastStatistics. 
        /// <para>
        /// The forecasted high and low fault count values.
        /// </para>
        /// </summary>
        public ForecastStatistics ServiceForecastStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ServiceForecastStatistics property is set.
        /// </summary>
        internal bool IsSetServiceForecastStatistics() => this.ServiceForecastStatistics != null;

        /// <summary>
        /// Gets and sets the property ServiceSummaryStatistics.
        /// </summary>
        public ServiceStatistics ServiceSummaryStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSummaryStatistics property is set.
        /// </summary>
        internal bool IsSetServiceSummaryStatistics() => this.ServiceSummaryStatistics != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Timestamp of the window for which statistics are aggregated.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
