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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides the results of a query that retrieved the data for a standard engagement
    /// metric that applies to a journey, and provides information about that query.
    /// </summary>
    public partial class JourneyDateRangeKpiResponse
    {
        private string _applicationId;
        private DateTime? _endTime;
        private string _journeyId;
        private string _kpiName;
        private BaseKpiResult _kpiResult;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the metric applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The last date and time of the date range that was used to filter the query results,
        /// in extended ISO 8601 format. The date range is inclusive.
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
        /// Gets and sets the property JourneyId. 
        /// <para>
        /// The unique identifier for the journey that the metric applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JourneyId
        {
            get { return this._journeyId; }
            set { this._journeyId = value; }
        }

        // Check to see if JourneyId property is set
        internal bool IsSetJourneyId()
        {
            return this._journeyId != null;
        }

        /// <summary>
        /// Gets and sets the property KpiName. 
        /// <para>
        /// The name of the metric, also referred to as a <i>key performance indicator (KPI)</i>,
        /// that the data was retrieved for. This value describes the associated metric and consists
        /// of two or more terms, which are comprised of lowercase alphanumeric characters, separated
        /// by a hyphen. For a list of possible values, see the <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/analytics-standard-metrics.html">Amazon
        /// Pinpoint Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KpiName
        {
            get { return this._kpiName; }
            set { this._kpiName = value; }
        }

        // Check to see if KpiName property is set
        internal bool IsSetKpiName()
        {
            return this._kpiName != null;
        }

        /// <summary>
        /// Gets and sets the property KpiResult. 
        /// <para>
        /// An array of objects that contains the results of the query. Each object contains the
        /// value for the metric and metadata about that value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BaseKpiResult KpiResult
        {
            get { return this._kpiResult; }
            set { this._kpiResult = value; }
        }

        // Check to see if KpiResult property is set
        internal bool IsSetKpiResult()
        {
            return this._kpiResult != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string to use in a subsequent request to get the next page of results in a paginated
        /// response. This value is null for the Journey Engagement Metrics resource because the
        /// resource returns all results in a single page.
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
        /// The first date and time of the date range that was used to filter the query results,
        /// in extended ISO 8601 format. The date range is inclusive.
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