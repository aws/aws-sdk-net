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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
    /// Contains configurations for an Amazon Bedrock reranker model.
    /// </summary>
    public partial class BedrockRerankingConfiguration
    {
        private BedrockRerankingModelConfiguration _modelConfiguration;
        private int? _numberOfResults;

        /// <summary>
        /// Gets and sets the property ModelConfiguration. 
        /// <para>
        /// Contains configurations for a reranker model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BedrockRerankingModelConfiguration ModelConfiguration
        {
            get { return this._modelConfiguration; }
            set { this._modelConfiguration = value; }
        }

        // Check to see if ModelConfiguration property is set
        internal bool IsSetModelConfiguration()
        {
            return this._modelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfResults. 
        /// <para>
        /// The number of results to return after reranking.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? NumberOfResults
        {
            get { return this._numberOfResults; }
            set { this._numberOfResults = value; }
        }

        // Check to see if NumberOfResults property is set
        internal bool IsSetNumberOfResults()
        {
            return this._numberOfResults.HasValue; 
        }

    }
}