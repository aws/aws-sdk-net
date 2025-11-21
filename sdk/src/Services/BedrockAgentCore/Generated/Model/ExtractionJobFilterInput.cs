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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Filters for querying memory extraction jobs based on various criteria.
    /// </summary>
    public partial class ExtractionJobFilterInput
    {
        private string _actorId;
        private string _sessionId;
        private ExtractionJobStatus _status;
        private string _strategyId;

        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The identifier of the actor. If specified, only extraction jobs with this actor ID
        /// are returned.
        /// </para>
        /// </summary>
        public string ActorId
        {
            get { return this._actorId; }
            set { this._actorId = value; }
        }

        // Check to see if ActorId property is set
        internal bool IsSetActorId()
        {
            return this._actorId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session. If specified, only extraction jobs with this
        /// session ID are returned.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the extraction job. If specified, only extraction jobs with this status
        /// are returned.
        /// </para>
        /// </summary>
        public ExtractionJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StrategyId. 
        /// <para>
        /// The memory strategy identifier to filter extraction jobs by. If specified, only extraction
        /// jobs with this strategy ID are returned.
        /// </para>
        /// </summary>
        public string StrategyId
        {
            get { return this._strategyId; }
            set { this._strategyId = value; }
        }

        // Check to see if StrategyId property is set
        internal bool IsSetStrategyId()
        {
            return this._strategyId != null;
        }

    }
}