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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListGuardrails operation. Lists details about
    /// all the guardrails in an account. To list the <c>DRAFT</c> version of all your guardrails,
    /// don't specify the <c>guardrailIdentifier</c> field. To list all versions of a guardrail,
    /// specify the ARN of the guardrail in the <c>guardrailIdentifier</c> field. <para> You
    /// can set the maximum number of results to return in a response in the <c>maxResults</c>
    /// field. If there are more results than the number you set, the response returns a <c>nextToken</c>
    /// that you can send in another <c>ListGuardrails</c> request to see the next batch of
    /// results. </para>
    /// </summary>
    public partial class ListGuardrailsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property GuardrailIdentifier. 
        /// <para>
        /// The unique identifier of the guardrail. This can be an ID or the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string GuardrailIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailIdentifier property is set.
        /// </summary>
        internal bool IsSetGuardrailIdentifier() => this.GuardrailIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
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
        /// If there are more results than were returned in the response, the response returns
        /// a <c>nextToken</c> that you can send in another <c>ListGuardrails</c> request to see
        /// the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
