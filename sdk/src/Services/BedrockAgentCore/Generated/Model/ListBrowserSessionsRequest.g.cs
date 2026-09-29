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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the ListBrowserSessions operation. Retrieves a list
    /// of browser sessions in Amazon Bedrock AgentCore that match the specified criteria.
    /// This operation returns summary information about each session, including identifiers,
    /// status, and timestamps. <para> You can filter the results by browser identifier and
    /// session status. The operation supports pagination to handle large result sets efficiently.
    /// </para> <para> We recommend using pagination to ensure that the operation returns
    /// quickly and successfully when retrieving large numbers of sessions. </para> <para>
    /// The following operations are related to <c>ListBrowserSessions</c>: </para> <ul> <li>
    /// <para> <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_StartBrowserSession.html">StartBrowserSession</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/APIReference/API_GetBrowserSession.html">GetBrowserSession</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class ListBrowserSessionsRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The unique identifier of the browser to list sessions for. If specified, only sessions
        /// for this browser are returned. If not specified, sessions for all browsers are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BrowserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BrowserIdentifier property is set.
        /// </summary>
        internal bool IsSetBrowserIdentifier() => this.BrowserIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. The default value is 10.
        /// Valid values range from 1 to 100. To retrieve the remaining results, make another
        /// call with the returned <c>nextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. If not specified, Amazon
        /// Bedrock AgentCore returns the first page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the browser sessions to list. Valid values include ACTIVE, STOPPING,
        /// and STOPPED. If not specified, sessions with any status are returned.
        /// </para>
        /// </summary>
        public BrowserSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
