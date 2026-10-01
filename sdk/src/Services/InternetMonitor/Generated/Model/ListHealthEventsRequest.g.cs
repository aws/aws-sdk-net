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
    /// Container for the parameters to the ListHealthEvents operation. Lists all health events
    /// for a monitor in Amazon CloudWatch Internet Monitor. Returns information for health
    /// events including the event start and end times, and the status. <note> <para> Health
    /// events that have start times during the time frame that is requested are not included
    /// in the list of health events. </para> </note>
    /// </summary>
    public partial class ListHealthEventsRequest : AmazonInternetMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when a health event ended. If the health event is still ongoing, then the
        /// end time is not set.
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
        /// The status of a health event.
        /// </para>
        /// </summary>
        public HealthEventStatus EventStatus { get; set; }

        /// <summary>
        /// Checks to see if the EventStatus property is set.
        /// </summary>
        internal bool IsSetEventStatus() => this.EventStatus != null;

        /// <summary>
        /// Gets and sets the property LinkedAccountId. 
        /// <para>
        /// The account ID for an account that you've set up cross-account sharing for in Amazon
        /// CloudWatch Internet Monitor. You configure cross-account sharing by using Amazon CloudWatch
        /// Observability Access Manager. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cwim-cross-account.html">Internet
        /// Monitor cross-account observability</a> in the Amazon CloudWatch Internet Monitor
        /// User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string LinkedAccountId { get; set; }

        /// <summary>
        /// Checks to see if the LinkedAccountId property is set.
        /// </summary>
        internal bool IsSetLinkedAccountId() => this.LinkedAccountId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of health event objects that you want to return with this call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MonitorName { get; set; }

        /// <summary>
        /// Checks to see if the MonitorName property is set.
        /// </summary>
        internal bool IsSetMonitorName() => this.MonitorName != null;

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
        /// The time when a health event started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
