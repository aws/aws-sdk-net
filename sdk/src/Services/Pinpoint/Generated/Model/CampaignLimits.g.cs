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
    /// For a campaign, specifies limits on the messages that the campaign can send. For an
    /// application, specifies the default limits for messages that campaigns in the application
    /// can send.
    /// </summary>
    public partial class CampaignLimits
    {
        /// <summary>
        /// Gets and sets the property Daily. 
        /// <para>
        /// The maximum number of messages that a campaign can send to a single endpoint during
        /// a 24-hour period. For an application, this value specifies the default limit for the
        /// number of messages that campaigns and journeys can send to a single endpoint during
        /// a 24-hour period. The maximum value is 100.
        /// </para>
        /// </summary>
        public int? Daily { get; set; }

        /// <summary>
        /// Checks to see if the Daily property is set.
        /// </summary>
        internal bool IsSetDaily() => this.Daily.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumDuration. 
        /// <para>
        /// The maximum amount of time, in seconds, that a campaign can attempt to deliver a message
        /// after the scheduled start time for the campaign. The minimum value is 60 seconds.
        /// </para>
        /// </summary>
        public int? MaximumDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaximumDuration property is set.
        /// </summary>
        internal bool IsSetMaximumDuration() => this.MaximumDuration.HasValue;

        /// <summary>
        /// Gets and sets the property MessagesPerSecond. 
        /// <para>
        /// The maximum number of messages that a campaign can send each second. For an application,
        /// this value specifies the default limit for the number of messages that campaigns can
        /// send each second. The minimum value is 1. The maximum value is 20,000.
        /// </para>
        /// </summary>
        public int? MessagesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the MessagesPerSecond property is set.
        /// </summary>
        internal bool IsSetMessagesPerSecond() => this.MessagesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The maximum total number of messages that the campaign can send per user session.
        /// </para>
        /// </summary>
        public int? Session { get; set; }

        /// <summary>
        /// Checks to see if the Session property is set.
        /// </summary>
        internal bool IsSetSession() => this.Session.HasValue;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The maximum number of messages that a campaign can send to a single endpoint during
        /// the course of the campaign. If a campaign recurs, this setting applies to all runs
        /// of the campaign. The maximum value is 100.
        /// </para>
        /// </summary>
        public int? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;
    }
}
