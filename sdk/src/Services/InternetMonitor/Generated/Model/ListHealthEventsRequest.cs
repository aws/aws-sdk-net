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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the ListHealthEvents operation.
    /// Lists all health events for a monitor in Amazon CloudWatch Internet Monitor. Returns
    /// all information for health events including the client location information the network
    /// cause and status, event start and end time, percentage of total traffic impacted,
    /// and status.
    /// 
    ///  <note> 
    /// <para>
    /// Health events that have start times during the time frame that is requested are not
    /// included in the list of health events.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListHealthEventsRequest : AmazonInternetMonitorRequest
    {
        private DateTime? _endTime;
        private HealthEventStatus _eventStatus;
        private int? _maxResults;
        private string _monitorName;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when a health event ended. If the health event is still ongoing, then the
        /// end time is not set.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The status of a health event.
        /// </para>
        /// </summary>
        public HealthEventStatus EventStatus
        {
            get { return this._eventStatus; }
            set { this._eventStatus = value; }
        }

        // Check to see if EventStatus property is set
        internal bool IsSetEventStatus()
        {
            return this._eventStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of health event objects that you want to return with this call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
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
        /// The time when a health event started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}