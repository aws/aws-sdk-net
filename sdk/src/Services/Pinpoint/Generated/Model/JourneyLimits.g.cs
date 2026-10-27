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
    /// Specifies limits on the messages that a journey can send and the number of times participants
    /// can enter a journey.
    /// </summary>
    public partial class JourneyLimits
    {
        /// <summary>
        /// Gets and sets the property DailyCap. 
        /// <para>
        /// The maximum number of messages that the journey can send to a single participant during
        /// a 24-hour period. The maximum value is 100.
        /// </para>
        /// </summary>
        public int? DailyCap { get; set; }

        /// <summary>
        /// Checks to see if the DailyCap property is set.
        /// </summary>
        internal bool IsSetDailyCap() => this.DailyCap.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointReentryCap. 
        /// <para>
        /// The maximum number of times that a participant can enter the journey. The maximum
        /// value is 100. To allow participants to enter the journey an unlimited number of times,
        /// set this value to 0.
        /// </para>
        /// </summary>
        public int? EndpointReentryCap { get; set; }

        /// <summary>
        /// Checks to see if the EndpointReentryCap property is set.
        /// </summary>
        internal bool IsSetEndpointReentryCap() => this.EndpointReentryCap.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointReentryInterval. 
        /// <para>
        /// Minimum time that must pass before an endpoint can re-enter a given journey. The duration
        /// should use an ISO 8601 format, such as PT1H. 
        /// </para>
        /// </summary>
        public string EndpointReentryInterval { get; set; }

        /// <summary>
        /// Checks to see if the EndpointReentryInterval property is set.
        /// </summary>
        internal bool IsSetEndpointReentryInterval() => this.EndpointReentryInterval != null;

        /// <summary>
        /// Gets and sets the property MessagesPerSecond. 
        /// <para>
        /// The maximum number of messages that the journey can send each second.
        /// </para>
        /// </summary>
        public int? MessagesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the MessagesPerSecond property is set.
        /// </summary>
        internal bool IsSetMessagesPerSecond() => this.MessagesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property TimeframeCap. 
        /// <para>
        /// The number of messages that an endpoint can receive during the specified timeframe.
        /// </para>
        /// </summary>
        public JourneyTimeframeCap TimeframeCap { get; set; }

        /// <summary>
        /// Checks to see if the TimeframeCap property is set.
        /// </summary>
        internal bool IsSetTimeframeCap() => this.TimeframeCap != null;

        /// <summary>
        /// Gets and sets the property TotalCap. 
        /// <para>
        /// The maximum number of messages a journey can sent to a single endpoint. The maximum
        /// value is 100. If set to 0, this limit will not apply.
        /// </para>
        /// </summary>
        public int? TotalCap { get; set; }

        /// <summary>
        /// Checks to see if the TotalCap property is set.
        /// </summary>
        internal bool IsSetTotalCap() => this.TotalCap.HasValue;
    }
}
