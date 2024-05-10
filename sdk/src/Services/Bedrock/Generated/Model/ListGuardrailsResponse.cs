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
    /// This is the response object from the ListGuardrails operation.
    /// </summary>
    public partial class ListGuardrailsResponse : AmazonWebServiceResponse
    {
        private List<GuardrailSummary> _guardrails = AWSConfigs.InitializeCollections ? new List<GuardrailSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Guardrails. 
        /// <para>
        /// A list of objects, each of which contains details about a guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<GuardrailSummary> Guardrails
        {
            get { return this._guardrails; }
            set { this._guardrails = value; }
        }

        // Check to see if Guardrails property is set
        internal bool IsSetGuardrails()
        {
            return this._guardrails != null && (this._guardrails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more results than were returned in the response, the response returns
        /// a <c>nextToken</c> that you can send in another <c>ListGuardrails</c> request to see
        /// the next batch of results.
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