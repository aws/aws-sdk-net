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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
        private string _memoryId;
        private DateTime? _sessionExpiryTime;
        private string _sessionId;
        private DateTime? _sessionStartTime;
        private string _summaryText;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The unique identifier of the memory where the session summary is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string MemoryId
        {
            get { return this._memoryId; }
            set { this._memoryId = value; }
        }

        // Check to see if MemoryId property is set
        internal bool IsSetMemoryId()
        {
            return this._memoryId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionExpiryTime. 
        /// <para>
        /// The time when the memory duration for the session is set to end.
        /// </para>
        /// </summary>
        public DateTime? SessionExpiryTime
        {
            get { return this._sessionExpiryTime; }
            set { this._sessionExpiryTime = value; }
        }

        // Check to see if SessionExpiryTime property is set
        internal bool IsSetSessionExpiryTime()
        {
            return this._sessionExpiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier for this session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionStartTime. 
        /// <para>
        /// The start time for this session.
        /// </para>
        /// </summary>
        public DateTime? SessionStartTime
        {
            get { return this._sessionStartTime; }
            set { this._sessionStartTime = value; }
        }

        // Check to see if SessionStartTime property is set
        internal bool IsSetSessionStartTime()
        {
            return this._sessionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SummaryText. 
        /// <para>
        /// The summarized text for this session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25000000)]
        public string SummaryText
        {
            get { return this._summaryText; }
            set { this._summaryText = value; }
        }

        // Check to see if SummaryText property is set
        internal bool IsSetSummaryText()
        {
            return this._summaryText != null;
        }

    }
}