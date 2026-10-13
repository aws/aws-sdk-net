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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListMonitoringSchedules operation. Returns list
    /// of all monitoring schedules.
    /// </summary>
    public partial class ListMonitoringSchedulesRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only monitoring schedules created after a specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter that returns only monitoring schedules created before a specified time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// Name of a specific endpoint to fetch schedules for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeAfter. 
        /// <para>
        /// A filter that returns only monitoring schedules modified after a specified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeAfter property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeAfter() => this.LastModifiedTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeBefore. 
        /// <para>
        /// A filter that returns only monitoring schedules modified before a specified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeBefore property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeBefore() => this.LastModifiedTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of jobs to return in the response. The default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MonitoringJobDefinitionName. 
        /// <para>
        /// Gets a list of the monitoring schedules for the specified monitoring job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string MonitoringJobDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringJobDefinitionName property is set.
        /// </summary>
        internal bool IsSetMonitoringJobDefinitionName() => this.MonitoringJobDefinitionName != null;

        /// <summary>
        /// Gets and sets the property MonitoringTypeEquals. 
        /// <para>
        /// A filter that returns only the monitoring schedules for the specified monitoring type.
        /// </para>
        /// </summary>
        public MonitoringType MonitoringTypeEquals { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringTypeEquals property is set.
        /// </summary>
        internal bool IsSetMonitoringTypeEquals() => this.MonitoringTypeEquals != null;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Filter for monitoring schedules whose name contains a specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string NameContains { get; set; }

        /// <summary>
        /// Checks to see if the NameContains property is set.
        /// </summary>
        internal bool IsSetNameContains() => this.NameContains != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned if the response is truncated. To retrieve the next set of job executions,
        /// use it in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Whether to sort the results by the <c>Status</c>, <c>CreationTime</c>, or <c>ScheduledTime</c>
        /// field. The default is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public MonitoringScheduleSortKey SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Whether to sort the results in <c>Ascending</c> or <c>Descending</c> order. The default
        /// is <c>Descending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// A filter that returns only monitoring schedules modified before a specified time.
        /// </para>
        /// </summary>
        public ScheduleStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;
    }
}
