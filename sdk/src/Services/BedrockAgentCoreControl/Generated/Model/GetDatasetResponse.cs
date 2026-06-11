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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the GetDataset operation.
    /// </summary>
    public partial class GetDatasetResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _datasetArn;
        private string _datasetId;
        private string _datasetName;
        private string _datasetVersion;
        private string _description;
        private string _downloadUrl;
        private DateTime? _downloadUrlExpiresAt;
        private DraftStatus _draftStatus;
        private long? _exampleCount;
        private string _failureReason;
        private string _kmsKeyArn;
        private DatasetSchemaType _schemaType;
        private DatasetStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the dataset was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        ///  The name of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        ///  The resolved version: "DRAFT" (default) or the requested version number. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetVersion
        {
            get { return this._datasetVersion; }
            set { this._datasetVersion = value; }
        }

        // Check to see if DatasetVersion property is set
        internal bool IsSetDatasetVersion()
        {
            return this._datasetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the dataset. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        ///  Presigned Amazon S3 URL to download the consolidated dataset file for the resolved
        /// version. Expires after 5 minutes. Omitted if the file does not yet exist. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DownloadUrl
        {
            get { return this._downloadUrl; }
            set { this._downloadUrl = value; }
        }

        // Check to see if DownloadUrl property is set
        internal bool IsSetDownloadUrl()
        {
            return this._downloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property DownloadUrlExpiresAt. 
        /// <para>
        ///  Expiry timestamp for the download URL. 
        /// </para>
        /// </summary>
        public DateTime? DownloadUrlExpiresAt
        {
            get { return this._downloadUrlExpiresAt; }
            set { this._downloadUrlExpiresAt = value; }
        }

        // Check to see if DownloadUrlExpiresAt property is set
        internal bool IsSetDownloadUrlExpiresAt()
        {
            return this._downloadUrlExpiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DraftStatus. 
        /// <para>
        ///  Publish synchronization state. Only authoritative when status is ACTIVE. MODIFIED
        /// indicates DRAFT has unpublished changes. UNMODIFIED indicates DRAFT matches the latest
        /// published version. 
        /// </para>
        /// </summary>
        public DraftStatus DraftStatus
        {
            get { return this._draftStatus; }
            set { this._draftStatus = value; }
        }

        // Check to see if DraftStatus property is set
        internal bool IsSetDraftStatus()
        {
            return this._draftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ExampleCount. 
        /// <para>
        ///  The number of examples in the DRAFT. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ExampleCount
        {
            get { return this._exampleCount; }
            set { this._exampleCount = value; }
        }

        // Check to see if ExampleCount property is set
        internal bool IsSetExampleCount()
        {
            return this._exampleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  Populated when status is CREATE_FAILED, UPDATE_FAILED, or DELETE_FAILED. Describes
        /// the reason for the failure. 
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        ///  KMS key ARN used for server-side encryption on service Amazon S3 writes, if configured.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaType. 
        /// <para>
        ///  The schema type declared at create time. Immutable after creation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetSchemaType SchemaType
        {
            get { return this._schemaType; }
            set { this._schemaType = value; }
        }

        // Check to see if SchemaType property is set
        internal bool IsSetSchemaType()
        {
            return this._schemaType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetStatus Status
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
        ///  The tags associated with the dataset. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the dataset was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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