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
    /// Details of a full document expansion action.
    /// </summary>
    public partial class AgenticRetrieveFullDocExpansionDetails
    {
        private string _documentId;
        private AgenticRetrieveSourceRetriever _sourceRetriever;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier of the document to expand.
        /// </para>
        /// </summary>
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRetriever. 
        /// <para>
        /// The source retriever associated with the document.
        /// </para>
        /// </summary>
        public AgenticRetrieveSourceRetriever SourceRetriever
        {
            get { return this._sourceRetriever; }
            set { this._sourceRetriever = value; }
        }

        // Check to see if SourceRetriever property is set
        internal bool IsSetSourceRetriever()
        {
            return this._sourceRetriever != null;
        }

    }
}