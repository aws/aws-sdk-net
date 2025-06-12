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
    /// Summary information about the import job.
    /// </summary>
    public partial class ImportJobData
    {
        private DateTime? _createdTime;
        private ExternalSourceConfiguration _externalSourceConfiguration;
        private string _failedRecordReport;
        private string _importJobId;
        private ImportJobType _importJobType;
        private string _knowledgeBaseArn;
        private string _knowledgeBaseId;
        private DateTime? _lastModifiedTime;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ImportJobStatus _status;
        private string _uploadId;
        private string _url;
        private DateTime? _urlExpiry;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the import job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExternalSourceConfiguration.
        /// </summary>
        public ExternalSourceConfiguration ExternalSourceConfiguration
        {
            get { return this._externalSourceConfiguration; }
            set { this._externalSourceConfiguration = value; }
        }

        // Check to see if ExternalSourceConfiguration property is set
        internal bool IsSetExternalSourceConfiguration()
        {
            return this._externalSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FailedRecordReport. 
        /// <para>
        /// The link to download the information of resource data that failed to be imported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string FailedRecordReport
        {
            get { return this._failedRecordReport; }
            set { this._failedRecordReport = value; }
        }

        // Check to see if FailedRecordReport property is set
        internal bool IsSetFailedRecordReport()
        {
            return this._failedRecordReport != null;
        }

        /// <summary>
        /// Gets and sets the property ImportJobId. 
        /// <para>
        /// The identifier of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImportJobId
        {
            get { return this._importJobId; }
            set { this._importJobId = value; }
        }

        // Check to see if ImportJobId property is set
        internal bool IsSetImportJobId()
        {
            return this._importJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportJobType. 
        /// <para>
        /// The type of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportJobType ImportJobType
        {
            get { return this._importJobType; }
            set { this._importJobType = value; }
        }

        // Check to see if ImportJobType property is set
        internal bool IsSetImportJobType()
        {
            return this._importJobType != null;
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the import job data was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata fields of the imported Amazon Q in Connect resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportJobStatus Status
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
        /// Gets and sets the property UploadId. 
        /// <para>
        /// A pointer to the uploaded asset. This value is returned by <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1200)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The download link to the resource file that is uploaded to the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property UrlExpiry. 
        /// <para>
        /// The expiration time of the URL as an epoch timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UrlExpiry
        {
            get { return this._urlExpiry; }
            set { this._urlExpiry = value; }
        }

        // Check to see if UrlExpiry property is set
        internal bool IsSetUrlExpiry()
        {
            return this._urlExpiry.HasValue; 
        }

    }
}