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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the ListPrompts operation. Returns either information
    /// about the working draft (<c>DRAFT</c> version) of each prompt in an account, or information
    /// about of all versions of a prompt, depending on whether you include the <c>promptIdentifier</c>
    /// field or not. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-manage.html#prompt-management-view.html">View
    /// information about prompts using Prompt management</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class ListPromptsRequest : AmazonBedrockAgentRequest
    {
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
        /// Gets and sets the property PromptIdentifier. 
        /// <para>
        /// The unique identifier of the prompt for whose versions you want to return information.
        /// Omit this field to list information about all prompts in an account.
        /// </para>
        /// </summary>
        public string PromptIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PromptIdentifier property is set.
        /// </summary>
        internal bool IsSetPromptIdentifier() => this.PromptIdentifier != null;
    }
}
