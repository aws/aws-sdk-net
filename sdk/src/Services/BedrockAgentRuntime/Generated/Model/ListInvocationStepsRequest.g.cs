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
    /// Container for the parameters to the ListInvocationSteps operation. Lists all invocation
    /// steps associated with a session and optionally, an invocation within the session.
    /// For more information about sessions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessions.html">Store
    /// and retrieve conversation history and context with Amazon Bedrock sessions</a>.
    /// </summary>
    public partial class ListInvocationStepsRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property InvocationIdentifier. 
        /// <para>
        /// The unique identifier (in UUID format) for the invocation to list invocation steps
        /// for.
        /// </para>
        /// </summary>
        public string InvocationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the InvocationIdentifier property is set.
        /// </summary>
        internal bool IsSetInvocationIdentifier() => this.InvocationIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. If the total number of results
        /// is greater than this value, use the token returned in the response in the <c>nextToken</c>
        /// field when making another request to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, enter the token returned in the <c>nextToken</c> field in the response
        /// in this field to return the next batch of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SessionIdentifier. 
        /// <para>
        /// The unique identifier for the session associated with the invocation steps. You can
        /// specify either the session's <c>sessionId</c> or its Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SessionIdentifier property is set.
        /// </summary>
        internal bool IsSetSessionIdentifier() => this.SessionIdentifier != null;
    }
}
