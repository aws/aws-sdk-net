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
    /// Container for the parameters to the ListMonitors operation. Lists all of your monitors
    /// for Amazon CloudWatch Internet Monitor and their statuses, along with the Amazon Resource
    /// Name (ARN) and name of each monitor.
    /// </summary>
    public partial class ListMonitorsRequest : AmazonInternetMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// A boolean option that you can set to <c>TRUE</c> to include monitors for linked accounts
        /// in a list of monitors, when you've set up cross-account sharing in Amazon CloudWatch
        /// Internet Monitor. You configure cross-account sharing by using Amazon CloudWatch Observability
        /// Access Manager. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cwim-cross-account.html">Internet
        /// Monitor cross-account observability</a> in the Amazon CloudWatch Internet Monitor
        /// User Guide.
        /// </para>
        /// </summary>
        public bool? IncludeLinkedAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLinkedAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeLinkedAccounts() => this.IncludeLinkedAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of monitor objects that you want to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorStatus. 
        /// <para>
        /// The status of a monitor. This includes the status of the data processing for the monitor
        /// and the status of the monitor itself.
        /// </para>
        ///  
        /// <para>
        /// For information about the statuses for a monitor, see <a href="https://docs.aws.amazon.com/internet-monitor/latest/api/API_Monitor.html">
        /// Monitor</a>.
        /// </para>
        /// </summary>
        public string MonitorStatus { get; set; }

        /// <summary>
        /// Checks to see if the MonitorStatus property is set.
        /// </summary>
        internal bool IsSetMonitorStatus() => this.MonitorStatus != null;

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
    }
}
