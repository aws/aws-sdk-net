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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the GetDataset operation.
    /// </summary>
    public partial class GetDatasetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when the dataset was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        ///  The name of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        ///  The resolved version: "DRAFT" (default) or the requested version number. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// Checks to see if the DatasetVersion property is set.
        /// </summary>
        internal bool IsSetDatasetVersion() => this.DatasetVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the dataset. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        ///  Presigned Amazon S3 URL to download the consolidated dataset file for the resolved
        /// version. Expires after 5 minutes. Omitted if the file does not yet exist. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the DownloadUrl property is set.
        /// </summary>
        internal bool IsSetDownloadUrl() => this.DownloadUrl != null;

        /// <summary>
        /// Gets and sets the property DownloadUrlExpiresAt. 
        /// <para>
        ///  Expiry timestamp for the download URL. 
        /// </para>
        /// </summary>
        public DateTime? DownloadUrlExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the DownloadUrlExpiresAt property is set.
        /// </summary>
        internal bool IsSetDownloadUrlExpiresAt() => this.DownloadUrlExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property DraftStatus. 
        /// <para>
        ///  Publish synchronization state. Only authoritative when status is ACTIVE. MODIFIED
        /// indicates DRAFT has unpublished changes. UNMODIFIED indicates DRAFT matches the latest
        /// published version. 
        /// </para>
        /// </summary>
        public DraftStatus DraftStatus { get; set; }

        /// <summary>
        /// Checks to see if the DraftStatus property is set.
        /// </summary>
        internal bool IsSetDraftStatus() => this.DraftStatus != null;

        /// <summary>
        /// Gets and sets the property ExampleCount. 
        /// <para>
        ///  The number of examples in the DRAFT. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ExampleCount { get; set; }

        /// <summary>
        /// Checks to see if the ExampleCount property is set.
        /// </summary>
        internal bool IsSetExampleCount() => this.ExampleCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        ///  Populated when status is CREATE_FAILED, UPDATE_FAILED, or DELETE_FAILED. Describes
        /// the reason for the failure. 
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        ///  KMS key ARN used for server-side encryption on service Amazon S3 writes, if configured.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property SchemaType. 
        /// <para>
        ///  The schema type declared at create time. Immutable after creation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetSchemaType SchemaType { get; set; }

        /// <summary>
        /// Checks to see if the SchemaType property is set.
        /// </summary>
        internal bool IsSetSchemaType() => this.SchemaType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags associated with the dataset. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The timestamp when the dataset was last updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
