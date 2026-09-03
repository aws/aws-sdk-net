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

namespace Amazon.SimpleDBv2.Model
{
    /// <summary>
    /// This is the response object from the GetExport operation.
    /// </summary>
    public partial class GetExportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientToken. The client token provided for this export.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain that was exported.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ExportArn. Unique ARN identifier of the export.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExportArn { get; set; }

        /// <summary>
        /// Checks to see if the ExportArn property is set.
        /// </summary>
        internal bool IsSetExportArn() => this.ExportArn != null;

        /// <summary>
        /// Gets and sets the property ExportDataCutoffTime. The timestamp indicating the cutoff
        /// point for data inclusion in the export. All data inserted or modified before this
        /// time will be present in the exported data. Data insertions or modifications after
        /// this timestamp may or may not be present in the export.
        /// </summary>
        public DateTime? ExportDataCutoffTime { get; set; }

        /// <summary>
        /// Checks to see if the ExportDataCutoffTime property is set.
        /// </summary>
        internal bool IsSetExportDataCutoffTime() => this.ExportDataCutoffTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExportManifest. The name of the manifest summary file for
        /// the export.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ExportManifest { get; set; }

        /// <summary>
        /// Checks to see if the ExportManifest property is set.
        /// </summary>
        internal bool IsSetExportManifest() => this.ExportManifest != null;

        /// <summary>
        /// Gets and sets the property ExportStatus. The current state of the export. Current
        /// possible values include : PENDING - export request received, IN_PROGRESS - export
        /// is being processed, SUCCEEDED - export completed successfully, and FAILED - export
        /// encountered an error.
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportStatus ExportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExportStatus property is set.
        /// </summary>
        internal bool IsSetExportStatus() => this.ExportStatus != null;

        /// <summary>
        /// Gets and sets the property FailureCode. Failure code for the result of the failed
        /// export.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. Export failure reason description.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property ItemsCount. Total number of exported items.
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemsCount property is set.
        /// </summary>
        internal bool IsSetItemsCount() => this.ItemsCount.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedAt. Timestamp when the export request was received
        /// by the service.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? RequestedAt { get; set; }

        /// <summary>
        /// Checks to see if the RequestedAt property is set.
        /// </summary>
        internal bool IsSetRequestedAt() => this.RequestedAt.HasValue;

        /// <summary>
        /// Gets and sets the property S3Bucket. The name of the S3 bucket for this export.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. The S3 bucket owner account ID for this
        /// export.
        /// </summary>
        public string S3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwner property is set.
        /// </summary>
        internal bool IsSetS3BucketOwner() => this.S3BucketOwner != null;

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. The S3 key prefix provided in the corresponding
        /// StartDomainExport request.
        /// </summary>
        [AWSProperty(Min = 1, Max = 850)]
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property S3SseAlgorithm. The S3 SSE encryption algorithm for this
        /// export.
        /// </summary>
        public S3SseAlgorithm S3SseAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the S3SseAlgorithm property is set.
        /// </summary>
        internal bool IsSetS3SseAlgorithm() => this.S3SseAlgorithm != null;

        /// <summary>
        /// Gets and sets the property S3SseKmsKeyId. The KMS key ID for this export.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string S3SseKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the S3SseKmsKeyId property is set.
        /// </summary>
        internal bool IsSetS3SseKmsKeyId() => this.S3SseKmsKeyId != null;
    }
}
