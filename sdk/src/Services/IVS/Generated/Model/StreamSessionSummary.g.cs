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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Summary information about a stream session.
    /// </summary>
    public partial class StreamSessionSummary
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time when the channel went offline. This is an ISO 8601 timestamp; <i>note that this
        /// is returned as a string</i>. For live streams, this is <c>NULL</c>.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property HasErrorEvent. 
        /// <para>
        /// If <c>true</c>, this stream encountered a quota breach or failure.
        /// </para>
        /// </summary>
        public bool? HasErrorEvent { get; set; }

        /// <summary>
        /// Checks to see if the HasErrorEvent property is set.
        /// </summary>
        internal bool IsSetHasErrorEvent() => this.HasErrorEvent.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Time when the channel went live. This is an ISO 8601 timestamp; <i>note that this
        /// is returned as a string</i>.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// Unique identifier for a live or previously live stream in the specified channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 26, Max = 26)]
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;
    }
}
