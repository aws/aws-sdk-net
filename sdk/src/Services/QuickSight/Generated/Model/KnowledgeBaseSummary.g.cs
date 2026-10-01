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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A summary of a knowledge base, including its identifier, name, status, and metadata.
    /// </summary>
    public partial class KnowledgeBaseSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the knowledge base was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The ARN of the data source associated with the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1284)]
        public string DataSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceArn property is set.
        /// </summary>
        internal bool IsSetDataSourceArn() => this.DataSourceArn != null;

        /// <summary>
        /// Gets and sets the property DocumentCount. 
        /// <para>
        /// The number of documents in the knowledge base.
        /// </para>
        /// </summary>
        public long? DocumentCount { get; set; }

        /// <summary>
        /// Checks to see if the DocumentCount property is set.
        /// </summary>
        internal bool IsSetDocumentCount() => this.DocumentCount.HasValue;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1284)]
        public string KnowledgeBaseArn { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseArn property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseArn() => this.KnowledgeBaseArn != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseSizeBytes. 
        /// <para>
        /// The size of the knowledge base in bytes.
        /// </para>
        /// </summary>
        public long? KnowledgeBaseSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseSizeBytes property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseSizeBytes() => this.KnowledgeBaseSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrimaryOwnerArn. 
        /// <para>
        /// The ARN of the primary owner of the knowledge base.
        /// </para>
        /// </summary>
        public string PrimaryOwnerArn { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryOwnerArn property is set.
        /// </summary>
        internal bool IsSetPrimaryOwnerArn() => this.PrimaryOwnerArn != null;

        /// <summary>
        /// Gets and sets the property PrimaryOwnerUsername. 
        /// <para>
        /// The username of the primary owner of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PrimaryOwnerUsername { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryOwnerUsername property is set.
        /// </summary>
        internal bool IsSetPrimaryOwnerUsername() => this.PrimaryOwnerUsername != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the knowledge base.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the knowledge base was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
