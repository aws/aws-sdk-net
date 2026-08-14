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
    /// Container for the parameters to the GetIngestedDocumentAcl operation.
    /// Retrieves the ingested access control list (ACL) for a specific document in a knowledge
    /// base. Use this operation to inspect the allow and deny lists that were ingested for
    /// a document to troubleshoot access control issues. To use this operation, you must
    /// have the <c>bedrock:GetIngestedDocumentAcl</c> permission.
    /// </summary>
    public partial class GetIngestedDocumentAclRequest : AmazonBedrockAgentRuntimeRequest
    {
        private string _dataSourceId;
        private string _documentId;
        private string _knowledgeBaseId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier of the data source that contains the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The unique identifier of the document to retrieve the ingested access control list
        /// (ACL) for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1825)]
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
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base that contains the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=2048)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

    }
}