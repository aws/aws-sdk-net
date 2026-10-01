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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Summary information about the import job.
    /// </summary>
    public partial class ImportJobData
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the import job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExternalSourceConfiguration.
        /// </summary>
        public ExternalSourceConfiguration ExternalSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExternalSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetExternalSourceConfiguration() => this.ExternalSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property FailedRecordReport. 
        /// <para>
        /// The link to download the information of resource data that failed to be imported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string FailedRecordReport { get; set; }

        /// <summary>
        /// Checks to see if the FailedRecordReport property is set.
        /// </summary>
        internal bool IsSetFailedRecordReport() => this.FailedRecordReport != null;

        /// <summary>
        /// Gets and sets the property ImportJobId. 
        /// <para>
        /// The identifier of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImportJobId { get; set; }

        /// <summary>
        /// Checks to see if the ImportJobId property is set.
        /// </summary>
        internal bool IsSetImportJobId() => this.ImportJobId != null;

        /// <summary>
        /// Gets and sets the property ImportJobType. 
        /// <para>
        /// The type of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportJobType ImportJobType { get; set; }

        /// <summary>
        /// Checks to see if the ImportJobType property is set.
        /// </summary>
        internal bool IsSetImportJobType() => this.ImportJobType != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseArn { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseArn property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseArn() => this.KnowledgeBaseArn != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the import job data was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata fields of the imported Amazon Q in Connect resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// A pointer to the uploaded asset. This value is returned by <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_StartContentUpload.html">StartContentUpload</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1200)]
        public string UploadId { get; set; }

        /// <summary>
        /// Checks to see if the UploadId property is set.
        /// </summary>
        internal bool IsSetUploadId() => this.UploadId != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The download link to the resource file that is uploaded to the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4096)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property UrlExpiry. 
        /// <para>
        /// The expiration time of the URL as an epoch timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UrlExpiry { get; set; }

        /// <summary>
        /// Checks to see if the UrlExpiry property is set.
        /// </summary>
        internal bool IsSetUrlExpiry() => this.UrlExpiry.HasValue;
    }
}
