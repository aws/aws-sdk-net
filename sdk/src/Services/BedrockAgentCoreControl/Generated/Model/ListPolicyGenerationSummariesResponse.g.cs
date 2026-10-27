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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the ListPolicyGenerationSummaries operation.
    /// </summary>
    public partial class ListPolicyGenerationSummariesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that can be used in subsequent <a href="https://docs.aws.amazon.com/bedrock-agentcore-control/latest/APIReference/API_ListPolicyGenerationSummaries.html">ListPolicyGenerationSummaries</a>
        /// calls to retrieve additional results. This token is only present when there are more
        /// results available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PolicyGenerations. 
        /// <para>
        /// An array of policy generation summary objects that match the specified criteria. Each
        /// summary contains resource identifiers, status, timestamps, and findings without customer-encrypted
        /// content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public List<PolicyGenerationSummary> PolicyGenerations { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyGenerationSummary>() : null;

        /// <summary>
        /// Checks to see if the PolicyGenerations property is set.
        /// </summary>
        internal bool IsSetPolicyGenerations() => this.PolicyGenerations != null && (this.PolicyGenerations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
