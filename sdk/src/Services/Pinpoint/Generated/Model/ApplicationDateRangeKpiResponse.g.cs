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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides the results of a query that retrieved the data for a standard metric that
    /// applies to an application, and provides information about that query.
    /// </summary>
    public partial class ApplicationDateRangeKpiResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the metric applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The last date and time of the date range that was used to filter the query results,
        /// in extended ISO 8601 format. The date range is inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

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
        [AWSProperty(Required = true)]
        public string KpiName { get; set; }

        /// <summary>
        /// Checks to see if the KpiName property is set.
        /// </summary>
        internal bool IsSetKpiName() => this.KpiName != null;

        /// <summary>
        /// Gets and sets the property KpiResult. 
        /// <para>
        /// An array of objects that contains the results of the query. Each object contains the
        /// value for the metric and metadata about that value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BaseKpiResult KpiResult { get; set; }

        /// <summary>
        /// Checks to see if the KpiResult property is set.
        /// </summary>
        internal bool IsSetKpiResult() => this.KpiResult != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string to use in a subsequent request to get the next page of results in a paginated
        /// response. This value is null for the Application Metrics resource because the resource
        /// returns all results in a single page.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The first date and time of the date range that was used to filter the query results,
        /// in extended ISO 8601 format. The date range is inclusive.
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
