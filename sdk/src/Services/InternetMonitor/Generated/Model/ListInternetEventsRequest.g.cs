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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the ListInternetEvents operation. Lists internet events
    /// that cause performance or availability issues for client locations. Amazon CloudWatch
    /// Internet Monitor displays information about recent global health events, called internet
    /// events, on a global outages map that is available to all Amazon Web Services customers.
    /// <para> You can constrain the list of internet events returned by providing a start
    /// time and end time to define a total time frame for events you want to list. Both start
    /// time and end time specify the time when an event started. End time is optional. If
    /// you don't include it, the default end time is the current time. </para> <para> You
    /// can also limit the events returned to a specific status (<c>ACTIVE</c> or <c>RESOLVED</c>)
    /// or type (<c>PERFORMANCE</c> or <c>AVAILABILITY</c>). </para>
    /// </summary>
    public partial class ListInternetEventsRequest : AmazonInternetMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the time window that you want to get a list of internet events for.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The status of an internet event.
        /// </para>
        /// </summary>
        public string EventStatus { get; set; }

        /// <summary>
        /// Checks to see if the EventStatus property is set.
        /// </summary>
        internal bool IsSetEventStatus() => this.EventStatus != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of network impairment.
        /// </para>
        /// </summary>
        public string EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of query results that you want to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
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
        /// The start time of the time window that you want to get a list of internet events for.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
