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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the GetKnowledgeBaseDocuments operation.
    /// Retrieves specific documents from a data source that is connected to a knowledge base.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-direct-ingestion.html">Ingest
    /// changes directly into a knowledge base</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class GetKnowledgeBaseDocumentsRequest : AmazonBedrockAgentRequest
    {
        private string _dataSourceId;
        private List<DocumentIdentifier> _documentIdentifiers = AWSConfigs.InitializeCollections ? new List<DocumentIdentifier>() : null;
        private string _knowledgeBaseId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier of the data source that contains the documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DocumentIdentifiers. 
        /// <para>
        /// A list of objects, each of which contains information to identify a document for which
        /// to retrieve information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<DocumentIdentifier> DocumentIdentifiers
        {
            get { return this._documentIdentifiers; }
            set { this._documentIdentifiers = value; }
        }

        // Check to see if DocumentIdentifiers property is set
        internal bool IsSetDocumentIdentifiers()
        {
            return this._documentIdentifiers != null && (this._documentIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base that is connected to the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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