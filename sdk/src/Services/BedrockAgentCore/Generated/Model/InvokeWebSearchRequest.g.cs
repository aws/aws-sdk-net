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
    /// Container for the parameters to the InvokeWebSearch operation. Searches the web and
    /// returns a ranked list of results. Each result includes a text extract from the page.
    /// <para> You can filter the results by domain and by publication date. </para> <para>
    /// To use this operation, you must have the <c>bedrock-agentcore:InvokeWebSearch</c>
    /// permission on the resource <c>arn:${Partition}:bedrock-agentcore:${Region}:aws:tool/web-search.v1</c>.
    /// </para>
    /// </summary>
    public partial class InvokeWebSearchRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to the search results.
        /// </para>
        /// </summary>
        public WebSearchFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. Defaults to 25.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property SearchQuery. 
        /// <para>
        /// The text to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Checks to see if the SearchQuery property is set.
        /// </summary>
        internal bool IsSetSearchQuery() => this.SearchQuery != null;

        /// <summary>
        /// Gets and sets the property WebSearchId. 
        /// <para>
        /// The identifier of the web search tool to invoke. The Amazon Web Services-managed web
        /// search tool is <c>web-search.v1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string WebSearchId { get; set; }

        /// <summary>
        /// Checks to see if the WebSearchId property is set.
        /// </summary>
        internal bool IsSetWebSearchId() => this.WebSearchId != null;
    }
}
