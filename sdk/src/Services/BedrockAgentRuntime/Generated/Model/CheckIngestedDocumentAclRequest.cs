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
    /// Container for the parameters to the CheckIngestedDocumentAcl operation.
    /// Checks whether a user has access to a specific document by verifying against the ingested
    /// access control list (ACL) in a knowledge base. Use this operation to validate that
    /// document-level access control is working as expected after ingestion. To use this
    /// operation, you must have the <c>bedrock:CheckIngestedDocumentAcl</c> permission.
    /// </summary>
    public partial class CheckIngestedDocumentAclRequest : AmazonBedrockAgentRuntimeRequest
    {
        private string _dataSourceId;
        private string _documentId;
        private string _knowledgeBaseId;
        private UserContext _userContext;

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
        /// The unique identifier of the document to check access for.
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

        /// <summary>
        /// Gets and sets the property UserContext. 
        /// <para>
        /// The context object containing identity information for access control filtering, including
        /// user ID and optional group memberships used to evaluate the document access control
        /// list (ACL).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public UserContext UserContext
        {
            get { return this._userContext; }
            set { this._userContext = value; }
        }

        // Check to see if UserContext property is set
        internal bool IsSetUserContext()
        {
            return this._userContext != null;
        }

    }
}