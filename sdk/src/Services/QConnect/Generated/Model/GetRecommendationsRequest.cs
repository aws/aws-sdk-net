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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the GetRecommendations operation.
    /// <important> 
    /// <para>
    /// This API will be discontinued starting June 1, 2024. To receive generative responses
    /// after March 1, 2024, you will need to create a new Assistant in the Amazon Connect
    /// console and integrate the Amazon Q in Connect JavaScript library (amazon-q-connectjs)
    /// into your applications.
    /// 
    ///  </important> 
    /// <para>
    /// Retrieves recommendations for the specified session. To avoid retrieving the same
    /// recommendations in subsequent calls, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_NotifyRecommendationsReceived.html">NotifyRecommendationsReceived</a>.
    /// This API supports long-polling behavior with the <c>waitTimeSeconds</c> parameter.
    /// Short poll is the default behavior and only returns recommendations already available.
    /// To perform a manual query against an assistant, use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_QueryAssistant.html">QueryAssistant</a>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class GetRecommendationsRequest : AmazonQConnectRequest
    {
        private string _assistantId;
        private int? _maxResults;
        private string _nextChunkToken;
        private string _sessionId;
        private int? _waitTimeSeconds;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
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
        /// Gets and sets the property NextChunkToken. 
        /// <para>
        /// The token for the next set of chunks. Use the value returned in the previous response
        /// in the next request to retrieve the next set of chunks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextChunkToken
        {
            get { return this._nextChunkToken; }
            set { this._nextChunkToken = value; }
        }

        // Check to see if NextChunkToken property is set
        internal bool IsSetNextChunkToken()
        {
            return this._nextChunkToken != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session. Can be either the ID or the ARN. URLs cannot contain
        /// the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property WaitTimeSeconds. 
        /// <para>
        /// The duration (in seconds) for which the call waits for a recommendation to be made
        /// available before returning. If a recommendation is available, the call returns sooner
        /// than <c>WaitTimeSeconds</c>. If no messages are available and the wait time expires,
        /// the call returns successfully with an empty list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public int? WaitTimeSeconds
        {
            get { return this._waitTimeSeconds; }
            set { this._waitTimeSeconds = value; }
        }

        // Check to see if WaitTimeSeconds property is set
        internal bool IsSetWaitTimeSeconds()
        {
            return this._waitTimeSeconds.HasValue; 
        }

    }
}