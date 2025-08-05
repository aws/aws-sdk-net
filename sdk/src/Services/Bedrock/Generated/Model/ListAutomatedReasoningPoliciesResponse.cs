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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
    /// This is the response object from the ListAutomatedReasoningPolicies operation.
    /// </summary>
    public partial class ListAutomatedReasoningPoliciesResponse : AmazonWebServiceResponse
    {
        private List<AutomatedReasoningPolicySummary> _automatedReasoningPolicySummaries = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicySummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutomatedReasoningPolicySummaries. 
        /// <para>
        /// A list of Automated Reasoning policy summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<AutomatedReasoningPolicySummary> AutomatedReasoningPolicySummaries
        {
            get { return this._automatedReasoningPolicySummaries; }
            set { this._automatedReasoningPolicySummaries = value; }
        }

        // Check to see if AutomatedReasoningPolicySummaries property is set
        internal bool IsSetAutomatedReasoningPolicySummaries()
        {
            return this._automatedReasoningPolicySummaries != null && (this._automatedReasoningPolicySummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use in a subsequent request to retrieve the next page of results.
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

    }
}