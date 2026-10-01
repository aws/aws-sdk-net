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
    /// Container for the parameters to the GetTimeSeriesServiceStatistics operation. Get
    /// an aggregation of service statistics defined by a specific time range.
    /// </summary>
    public partial class GetTimeSeriesServiceStatisticsRequest : AmazonXRayRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time frame for which to aggregate statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EntitySelectorExpression. 
        /// <para>
        /// A filter expression defining entities that will be aggregated for statistics. Supports
        /// ID, service, and edge functions. If no selector expression is specified, edge statistics
        /// are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string EntitySelectorExpression { get; set; }

        /// <summary>
        /// Checks to see if the EntitySelectorExpression property is set.
        /// </summary>
        internal bool IsSetEntitySelectorExpression() => this.EntitySelectorExpression != null;

        /// <summary>
        /// Gets and sets the property ForecastStatistics. 
        /// <para>
        /// The forecasted high and low fault count values. Forecast enabled requests require
        /// the EntitySelectorExpression ID be provided.
        /// </para>
        /// </summary>
        public bool? ForecastStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ForecastStatistics property is set.
        /// </summary>
        internal bool IsSetForecastStatistics() => this.ForecastStatistics.HasValue;

        /// <summary>
        /// Gets and sets the property GroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the group for which to pull statistics from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 400)]
        public string GroupARN { get; set; }

        /// <summary>
        /// Checks to see if the GroupARN property is set.
        /// </summary>
        internal bool IsSetGroupARN() => this.GroupARN != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The case-sensitive name of the group for which to pull statistics from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// Aggregation period in seconds.
        /// </para>
        /// </summary>
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time frame for which to aggregate statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
