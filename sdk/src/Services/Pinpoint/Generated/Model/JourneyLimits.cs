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
    /// Specifies limits on the messages that a journey can send and the number of times participants
    /// can enter a journey.
    /// </summary>
    public partial class JourneyLimits
    {
        private int? _dailyCap;
        private int? _endpointReentryCap;
        private string _endpointReentryInterval;
        private int? _messagesPerSecond;
        private JourneyTimeframeCap _timeframeCap;
        private int? _totalCap;

        /// <summary>
        /// Gets and sets the property DailyCap. 
        /// <para>
        /// The maximum number of messages that the journey can send to a single participant during
        /// a 24-hour period. The maximum value is 100.
        /// </para>
        /// </summary>
        public int? DailyCap
        {
            get { return this._dailyCap; }
            set { this._dailyCap = value; }
        }

        // Check to see if DailyCap property is set
        internal bool IsSetDailyCap()
        {
            return this._dailyCap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointReentryCap. 
        /// <para>
        /// The maximum number of times that a participant can enter the journey. The maximum
        /// value is 100. To allow participants to enter the journey an unlimited number of times,
        /// set this value to 0.
        /// </para>
        /// </summary>
        public int? EndpointReentryCap
        {
            get { return this._endpointReentryCap; }
            set { this._endpointReentryCap = value; }
        }

        // Check to see if EndpointReentryCap property is set
        internal bool IsSetEndpointReentryCap()
        {
            return this._endpointReentryCap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointReentryInterval. 
        /// <para>
        /// Minimum time that must pass before an endpoint can re-enter a given journey. The duration
        /// should use an ISO 8601 format, such as PT1H. 
        /// </para>
        /// </summary>
        public string EndpointReentryInterval
        {
            get { return this._endpointReentryInterval; }
            set { this._endpointReentryInterval = value; }
        }

        // Check to see if EndpointReentryInterval property is set
        internal bool IsSetEndpointReentryInterval()
        {
            return this._endpointReentryInterval != null;
        }

        /// <summary>
        /// Gets and sets the property MessagesPerSecond. 
        /// <para>
        /// The maximum number of messages that the journey can send each second.
        /// </para>
        /// </summary>
        public int? MessagesPerSecond
        {
            get { return this._messagesPerSecond; }
            set { this._messagesPerSecond = value; }
        }

        // Check to see if MessagesPerSecond property is set
        internal bool IsSetMessagesPerSecond()
        {
            return this._messagesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeframeCap. 
        /// <para>
        /// The number of messages that an endpoint can receive during the specified timeframe.
        /// </para>
        /// </summary>
        public JourneyTimeframeCap TimeframeCap
        {
            get { return this._timeframeCap; }
            set { this._timeframeCap = value; }
        }

        // Check to see if TimeframeCap property is set
        internal bool IsSetTimeframeCap()
        {
            return this._timeframeCap != null;
        }

        /// <summary>
        /// Gets and sets the property TotalCap. 
        /// <para>
        /// The maximum number of messages a journey can sent to a single endpoint. The maximum
        /// value is 100. If set to 0, this limit will not apply.
        /// </para>
        /// </summary>
        public int? TotalCap
        {
            get { return this._totalCap; }
            set { this._totalCap = value; }
        }

        // Check to see if TotalCap property is set
        internal bool IsSetTotalCap()
        {
            return this._totalCap.HasValue; 
        }

    }
}