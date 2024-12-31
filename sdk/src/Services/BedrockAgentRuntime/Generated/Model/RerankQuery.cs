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
    /// Contains information about a query to submit to the reranker model.
    /// </summary>
    public partial class RerankQuery
    {
        private RerankTextDocument _textQuery;
        private RerankQueryContentType _type;

        /// <summary>
        /// Gets and sets the property TextQuery. 
        /// <para>
        /// Contains information about a text query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RerankTextDocument TextQuery
        {
            get { return this._textQuery; }
            set { this._textQuery = value; }
        }

        // Check to see if TextQuery property is set
        internal bool IsSetTextQuery()
        {
            return this._textQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RerankQueryContentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}