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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Information about the knowledge base.
    /// </summary>
    public partial class KnowledgeBaseData
    {
        private string _description;
        private List<string> _ingestionFailureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SyncStatus _ingestionStatus;
        private string _knowledgeBaseArn;
        private string _knowledgeBaseId;
        private KnowledgeBaseType _knowledgeBaseType;
        private DateTime? _lastContentModificationTime;
        private string _name;
        private RenderingConfiguration _renderingConfiguration;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private SourceConfiguration _sourceConfiguration;
        private KnowledgeBaseStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VectorIngestionConfiguration _vectorIngestionConfiguration;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionFailureReasons. 
        /// <para>
        /// List of failure reasons on ingestion per file.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IngestionFailureReasons
        {
            get { return this._ingestionFailureReasons; }
            set { this._ingestionFailureReasons = value; }
        }

        // Check to see if IngestionFailureReasons property is set
        internal bool IsSetIngestionFailureReasons()
        {
            return this._ingestionFailureReasons != null && (this._ingestionFailureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IngestionStatus. 
        /// <para>
        /// Status of ingestion on data source.
        /// </para>
        /// </summary>
        public SyncStatus IngestionStatus
        {
            get { return this._ingestionStatus; }
            set { this._ingestionStatus = value; }
        }

        // Check to see if IngestionStatus property is set
        internal bool IsSetIngestionStatus()
        {
            return this._ingestionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier of the knowledge base.
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

        /// <summary>
        /// Gets and sets the property KnowledgeBaseType. 
        /// <para>
        /// The type of knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseType KnowledgeBaseType
        {
            get { return this._knowledgeBaseType; }
            set { this._knowledgeBaseType = value; }
        }

        // Check to see if KnowledgeBaseType property is set
        internal bool IsSetKnowledgeBaseType()
        {
            return this._knowledgeBaseType != null;
        }

        /// <summary>
        /// Gets and sets the property LastContentModificationTime. 
        /// <para>
        /// An epoch timestamp indicating the most recent content modification inside the knowledge
        /// base. If no content exists in a knowledge base, this value is unset.
        /// </para>
        /// </summary>
        public DateTime? LastContentModificationTime
        {
            get { return this._lastContentModificationTime; }
            set { this._lastContentModificationTime = value; }
        }

        // Check to see if LastContentModificationTime property is set
        internal bool IsSetLastContentModificationTime()
        {
            return this._lastContentModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property RenderingConfiguration. 
        /// <para>
        /// Information about how to render the content.
        /// </para>
        /// </summary>
        public RenderingConfiguration RenderingConfiguration
        {
            get { return this._renderingConfiguration; }
            set { this._renderingConfiguration = value; }
        }

        // Check to see if RenderingConfiguration property is set
        internal bool IsSetRenderingConfiguration()
        {
            return this._renderingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The configuration information for the customer managed key used for encryption. 
        /// </para>
        ///  
        /// <para>
        /// This KMS key must have a policy that allows <c>kms:CreateGrant</c>, <c>kms:DescribeKey</c>,
        /// <c>kms:Decrypt</c>, and <c>kms:GenerateDataKey*</c> permissions to the IAM identity
        /// using the key to invoke Amazon Q in Connect. 
        /// </para>
        ///  
        /// <para>
        /// For more information about setting up a customer managed key for Amazon Q in Connect,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-q.html">Enable
        /// Amazon Q in Connect for your instance</a>.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// Source configuration information about the knowledge base.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VectorIngestionConfiguration. 
        /// <para>
        /// Contains details about how to ingest the documents in a data source.
        /// </para>
        /// </summary>
        public VectorIngestionConfiguration VectorIngestionConfiguration
        {
            get { return this._vectorIngestionConfiguration; }
            set { this._vectorIngestionConfiguration = value; }
        }

        // Check to see if VectorIngestionConfiguration property is set
        internal bool IsSetVectorIngestionConfiguration()
        {
            return this._vectorIngestionConfiguration != null;
        }

    }
}