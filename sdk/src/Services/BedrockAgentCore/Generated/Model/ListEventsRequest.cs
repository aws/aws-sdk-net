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
    /// Container for the parameters to the ListEvents operation.
    /// Lists events in an AgentCore Memory resource based on specified criteria. We recommend
    /// using pagination to ensure that the operation returns quickly and successfully.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>bedrock-agentcore:ListEvents</c> permission.
    /// </para>
    /// </summary>
    public partial class ListEventsRequest : AmazonBedrockAgentCoreRequest
    {
        private string _actorId;
        private FilterInput _filter;
        private bool? _includePayloads;
        private int? _maxResults;
        private string _memoryId;
        private string _nextToken;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The identifier of the actor for which to list events. If specified, only events from
        /// this actor are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filter criteria to apply when listing events.
        /// </para>
        /// </summary>
        public FilterInput Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property IncludePayloads. 
        /// <para>
        /// Specifies whether to include event payloads in the response. Set to true to include
        /// payloads, or false to exclude them.
        /// </para>
        /// </summary>
        public bool? IncludePayloads
        {
            get { return this._includePayloads; }
            set { this._includePayloads = value; }
        }

        // Check to see if IncludePayloads property is set
        internal bool IsSetIncludePayloads()
        {
            return this._includePayloads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Minimum value of 1, maximum
        /// value of 100. Default is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource for which to list events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session for which to list events. If specified, only events
        /// from this session are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

    }
}