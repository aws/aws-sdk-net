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
    /// Container for the parameters to the ListCodeInterpreterSessions operation.
    /// Retrieves a list of code interpreter sessions in Amazon Bedrock that match the specified
    /// criteria. This operation returns summary information about each session, including
    /// identifiers, status, and timestamps.
    /// 
    ///  
    /// <para>
    /// You can filter the results by code interpreter identifier and session status. The
    /// operation supports pagination to handle large result sets efficiently.
    /// </para>
    ///  
    /// <para>
    /// We recommend using pagination to ensure that the operation returns quickly and successfully
    /// when retrieving large numbers of sessions.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>ListCodeInterpreterSessions</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListCodeInterpreterSessionsRequest : AmazonBedrockAgentCoreRequest
    {
        private string _codeInterpreterIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private CodeInterpreterSessionStatus _status;

        /// <summary>
        /// Gets and sets the property CodeInterpreterIdentifier. 
        /// <para>
        /// The unique identifier of the code interpreter to list sessions for. If specified,
        /// only sessions for this code interpreter are returned. If not specified, sessions for
        /// all code interpreters are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeInterpreterIdentifier
        {
            get { return this._codeInterpreterIdentifier; }
            set { this._codeInterpreterIdentifier = value; }
        }

        // Check to see if CodeInterpreterIdentifier property is set
        internal bool IsSetCodeInterpreterIdentifier()
        {
            return this._codeInterpreterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. The default value is 10.
        /// Valid values range from 1 to 100. To retrieve the remaining results, make another
        /// call with the returned <c>nextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. If not specified, Amazon
        /// Bedrock returns the first page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the code interpreter sessions to list. Valid values include ACTIVE,
        /// STOPPING, and STOPPED. If not specified, sessions with any status are returned.
        /// </para>
        /// </summary>
        public CodeInterpreterSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}