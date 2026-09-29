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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GetIngestedDocumentAcl operation. Retrieves the
    /// ingested access control list (ACL) for a specific document in a knowledge base. Use
    /// this operation to inspect the allow and deny lists that were ingested for a document
    /// to troubleshoot access control issues. To use this operation, you must have the <c>bedrock:GetIngestedDocumentAcl</c>
    /// permission.
    /// </summary>
    public partial class GetIngestedDocumentAclRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier of the data source that contains the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The unique identifier of the document to retrieve the ingested access control list
        /// (ACL) for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1825)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Checks to see if the DocumentId property is set.
        /// </summary>
        internal bool IsSetDocumentId() => this.DocumentId != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base that contains the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 2048)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;
    }
}
