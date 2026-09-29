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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains details of a session summary.
    /// </summary>
    public partial class MemorySessionSummary
    {
        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The unique identifier of the memory where the session summary is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property SessionExpiryTime. 
        /// <para>
        /// The time when the memory duration for the session is set to end.
        /// </para>
        /// </summary>
        public DateTime? SessionExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the SessionExpiryTime property is set.
        /// </summary>
        internal bool IsSetSessionExpiryTime() => this.SessionExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier for this session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionStartTime. 
        /// <para>
        /// The start time for this session.
        /// </para>
        /// </summary>
        public DateTime? SessionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the SessionStartTime property is set.
        /// </summary>
        internal bool IsSetSessionStartTime() => this.SessionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SummaryText. 
        /// <para>
        /// The summarized text for this session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25000000)]
        public string SummaryText { get; set; }

        /// <summary>
        /// Checks to see if the SummaryText property is set.
        /// </summary>
        internal bool IsSetSummaryText() => this.SummaryText != null;
    }
}
