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
    /// Container for the parameters to the GetTimeSeriesServiceStatistics operation.
    /// Get an aggregation of service statistics defined by a specific time range.
    /// </summary>
    public partial class GetTimeSeriesServiceStatisticsRequest : AmazonXRayRequest
    {
        private DateTime? _endTime;
        private string _entitySelectorExpression;
        private bool? _forecastStatistics;
        private string _groupARN;
        private string _groupName;
        private string _nextToken;
        private int? _period;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time frame for which to aggregate statistics.
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
        /// Gets and sets the property EntitySelectorExpression. 
        /// <para>
        /// A filter expression defining entities that will be aggregated for statistics. Supports
        /// ID, service, and edge functions. If no selector expression is specified, edge statistics
        /// are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string EntitySelectorExpression
        {
            get { return this._entitySelectorExpression; }
            set { this._entitySelectorExpression = value; }
        }

        // Check to see if EntitySelectorExpression property is set
        internal bool IsSetEntitySelectorExpression()
        {
            return this._entitySelectorExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastStatistics. 
        /// <para>
        /// The forecasted high and low fault count values. Forecast enabled requests require
        /// the EntitySelectorExpression ID be provided.
        /// </para>
        /// </summary>
        public bool? ForecastStatistics
        {
            get { return this._forecastStatistics; }
            set { this._forecastStatistics = value; }
        }

        // Check to see if ForecastStatistics property is set
        internal bool IsSetForecastStatistics()
        {
            return this._forecastStatistics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the group for which to pull statistics from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
        public string GroupARN
        {
            get { return this._groupARN; }
            set { this._groupARN = value; }
        }

        // Check to see if GroupARN property is set
        internal bool IsSetGroupARN()
        {
            return this._groupARN != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The case-sensitive name of the group for which to pull statistics from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
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
        /// Gets and sets the property Period. 
        /// <para>
        /// Aggregation period in seconds.
        /// </para>
        /// </summary>
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
        /// The start of the time frame for which to aggregate statistics.
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

    }
}