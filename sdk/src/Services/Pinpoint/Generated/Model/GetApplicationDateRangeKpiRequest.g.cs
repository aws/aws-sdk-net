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
    /// Container for the parameters to the GetApplicationDateRangeKpi operation. Retrieves
    /// (queries) pre-aggregated data for a standard metric that applies to an application.
    /// </summary>
    public partial class GetApplicationDateRangeKpiRequest : AmazonPinpointRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application. This identifier is displayed as the <b>Project
        /// ID</b> on the Amazon Pinpoint console.
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
        /// The last date and time to retrieve data for, as part of an inclusive date range that
        /// filters the query results. This value should be in extended ISO 8601 format and use
        /// Coordinated Universal Time (UTC), for example: 2019-07-26T20:00:00Z for 8:00 PM UTC
        /// July 26, 2019.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property KpiName. 
        /// <para>
        /// The name of the metric, also referred to as a <i>key performance indicator (KPI)</i>,
        /// to retrieve data for. This value describes the associated metric and consists of two
        /// or more terms, which are comprised of lowercase alphanumeric characters, separated
        /// by a hyphen. Examples are email-open-rate and successful-delivery-rate. For a list
        /// of valid values, see the <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/analytics-standard-metrics.html">Amazon
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies which page of results to return in a paginated response.
        /// This parameter is not supported for application, campaign, and journey metrics.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to include in each page of a paginated response. This
        /// parameter is not supported for application, campaign, and journey metrics.
        /// </para>
        /// </summary>
        public string PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The first date and time to retrieve data for, as part of an inclusive date range that
        /// filters the query results. This value should be in extended ISO 8601 format and use
        /// Coordinated Universal Time (UTC), for example: 2019-07-19T20:00:00Z for 8:00 PM UTC
        /// July 19, 2019. This value should also be fewer than 90 days from the current day.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
