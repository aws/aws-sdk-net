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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private DateTime? _createdAt;
        private string _dataSourceArn;
        private long? _documentCount;
        private string _knowledgeBaseArn;
        private string _knowledgeBaseId;
        private long? _knowledgeBaseSizeBytes;
        private string _name;
        private string _primaryOwnerArn;
        private string _primaryOwnerUsername;
        private DataSetStatus _status;
        private string _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the knowledge base was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The ARN of the data source associated with the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentCount. 
        /// <para>
        /// The number of documents in the knowledge base.
        /// </para>
        /// </summary>
        public long? DocumentCount
        {
            get { return this._documentCount; }
            set { this._documentCount = value; }
        }

        // Check to see if DocumentCount property is set
        internal bool IsSetDocumentCount()
        {
            return this._documentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string KnowledgeBaseArn
        {
            get { return this._knowledgeBaseArn; }
            set { this._knowledgeBaseArn = value; }
        }

        // Check to see if KnowledgeBaseArn property is set
        internal bool IsSetKnowledgeBaseArn()
        {
            return this._knowledgeBaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property KnowledgeBaseSizeBytes. 
        /// <para>
        /// The size of the knowledge base in bytes.
        /// </para>
        /// </summary>
        public long? KnowledgeBaseSizeBytes
        {
            get { return this._knowledgeBaseSizeBytes; }
            set { this._knowledgeBaseSizeBytes = value; }
        }

        // Check to see if KnowledgeBaseSizeBytes property is set
        internal bool IsSetKnowledgeBaseSizeBytes()
        {
            return this._knowledgeBaseSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryOwnerArn. 
        /// <para>
        /// The ARN of the primary owner of the knowledge base.
        /// </para>
        /// </summary>
        public string PrimaryOwnerArn
        {
            get { return this._primaryOwnerArn; }
            set { this._primaryOwnerArn = value; }
        }

        // Check to see if PrimaryOwnerArn property is set
        internal bool IsSetPrimaryOwnerArn()
        {
            return this._primaryOwnerArn != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryOwnerUsername. 
        /// <para>
        /// The username of the primary owner of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PrimaryOwnerUsername
        {
            get { return this._primaryOwnerUsername; }
            set { this._primaryOwnerUsername = value; }
        }

        // Check to see if PrimaryOwnerUsername property is set
        internal bool IsSetPrimaryOwnerUsername()
        {
            return this._primaryOwnerUsername != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the knowledge base.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the knowledge base was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}