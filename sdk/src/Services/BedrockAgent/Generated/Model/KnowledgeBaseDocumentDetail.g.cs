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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the details for a document that was ingested or deleted.
    /// </summary>
    public partial class KnowledgeBaseDocumentDetail
    {
        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source connected to the knowledge base that the document
        /// was ingested into or deleted from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Contains information that identifies the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentIdentifier Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base that the document was ingested into or deleted
        /// from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The ingestion status of the document. The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// STARTING – You submitted the ingestion job containing the document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING – The document is waiting to be ingested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IN_PROGRESS – The document is being ingested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INDEXED – The document was successfully indexed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PARTIALLY_INDEXED – The document was partially indexed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// METADATA_PARTIALLY_INDEXED – You submitted metadata for an existing document and it
        /// was partially indexed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// METADATA_UPDATE_FAILED – You submitted a metadata update for an existing document
        /// but it failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED – The document failed to be ingested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NOT_FOUND – The document wasn't found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IGNORED – The document was ignored during ingestion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING – You submitted the delete job containing the document.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_IN_PROGRESS – The document is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the status. Appears alongside the status <c>IGNORED</c>.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time at which the document was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
