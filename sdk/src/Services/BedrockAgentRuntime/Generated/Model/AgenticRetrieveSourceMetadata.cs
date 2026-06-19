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
    /// Metadata about a retrieval source.
    /// </summary>
    public partial class AgenticRetrieveSourceMetadata
    {
        private string _identifier;
        private AgenticRetrieveType _retrievalType;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the retrieval source.
        /// </para>
        /// </summary>
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalType. 
        /// <para>
        /// The type of retrieval source.
        /// </para>
        /// </summary>
        public AgenticRetrieveType RetrievalType
        {
            get { return this._retrievalType; }
            set { this._retrievalType = value; }
        }

        // Check to see if RetrievalType property is set
        internal bool IsSetRetrievalType()
        {
            return this._retrievalType != null;
        }

    }
}