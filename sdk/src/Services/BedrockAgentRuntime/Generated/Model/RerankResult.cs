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
    /// Contains information about a document that was reranked.
    /// </summary>
    public partial class RerankResult
    {
        private RerankDocument _document;
        private int? _index;
        private float? _relevanceScore;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// Contains information about the document.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RerankDocument Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The ranking of the document. The lower a number, the higher the document is ranked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public int? Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelevanceScore. 
        /// <para>
        /// The relevance score of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float? RelevanceScore
        {
            get { return this._relevanceScore; }
            set { this._relevanceScore = value; }
        }

        // Check to see if RelevanceScore property is set
        internal bool IsSetRelevanceScore()
        {
            return this._relevanceScore.HasValue; 
        }

    }
}