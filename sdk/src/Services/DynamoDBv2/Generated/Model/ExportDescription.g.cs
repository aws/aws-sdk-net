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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the properties of the exported table.
    /// </summary>
    public partial class ExportDescription
    {
        /// <summary>
        /// Gets and sets the property BilledSizeBytes. 
        /// <para>
        /// The billable size of the table export.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? BilledSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the BilledSizeBytes property is set.
        /// </summary>
        internal bool IsSetBilledSizeBytes() => this.BilledSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token that was provided for the export task. A client token makes calls
        /// to <c>ExportTableToPointInTimeInput</c> idempotent, meaning that multiple identical
        /// calls have the same effect as one single call.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the export task completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExportArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table export.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string ExportArn { get; set; }

        /// <summary>
        /// Checks to see if the ExportArn property is set.
        /// </summary>
        internal bool IsSetExportArn() => this.ExportArn != null;

        /// <summary>
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The format of the exported data. Valid values for <c>ExportFormat</c> are <c>DYNAMODB_JSON</c>
        /// or <c>ION</c>.
        /// </para>
        /// </summary>
        public ExportFormat ExportFormat { get; set; }

        /// <summary>
        /// Checks to see if the ExportFormat property is set.
        /// </summary>
        internal bool IsSetExportFormat() => this.ExportFormat != null;

        /// <summary>
        /// Gets and sets the property ExportManifest. 
        /// <para>
        /// The name of the manifest file for the export task.
        /// </para>
        /// </summary>
        public string ExportManifest { get; set; }

        /// <summary>
        /// Checks to see if the ExportManifest property is set.
        /// </summary>
        internal bool IsSetExportManifest() => this.ExportManifest != null;

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// Export can be in one of the following states: IN_PROGRESS, COMPLETED, or FAILED.
        /// </para>
        /// </summary>
        public ExportStatus ExportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExportStatus property is set.
        /// </summary>
        internal bool IsSetExportStatus() => this.ExportStatus != null;

        /// <summary>
        /// Gets and sets the property ExportTime. 
        /// <para>
        /// Point in time from which table data was exported.
        /// </para>
        /// </summary>
        public DateTime? ExportTime { get; set; }

        /// <summary>
        /// Checks to see if the ExportTime property is set.
        /// </summary>
        internal bool IsSetExportTime() => this.ExportTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExportType. 
        /// <para>
        /// The type of export that was performed. Valid values are <c>FULL_EXPORT</c> or <c>INCREMENTAL_EXPORT</c>.
        /// </para>
        /// </summary>
        public ExportType ExportType { get; set; }

        /// <summary>
        /// Checks to see if the ExportType property is set.
        /// </summary>
        internal bool IsSetExportType() => this.ExportType != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Status code for the result of the failed export.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Export failure reason description.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property FilterSpecification. 
        /// <para>
        /// The filter criteria applied to the export. When present, only items that match the
        /// specified key conditions and filter expressions are included in the export output.
        /// </para>
        /// </summary>
        public FilterSpecification FilterSpecification { get; set; }

        /// <summary>
        /// Checks to see if the FilterSpecification property is set.
        /// </summary>
        internal bool IsSetFilterSpecification() => this.FilterSpecification != null;

        /// <summary>
        /// Gets and sets the property IncrementalExportSpecification. 
        /// <para>
        /// Optional object containing the parameters specific to an incremental export.
        /// </para>
        /// </summary>
        public IncrementalExportSpecification IncrementalExportSpecification { get; set; }

        /// <summary>
        /// Checks to see if the IncrementalExportSpecification property is set.
        /// </summary>
        internal bool IsSetIncrementalExportSpecification() => this.IncrementalExportSpecification != null;

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket containing the export.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the bucket containing the export.
        /// </para>
        /// </summary>
        public string S3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwner property is set.
        /// </summary>
        internal bool IsSetS3BucketOwner() => this.S3BucketOwner != null;

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The Amazon S3 bucket prefix used as the file name and path of the exported snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;

        /// <summary>
        /// Gets and sets the property S3SseAlgorithm. 
        /// <para>
        /// Type of encryption used on the bucket where export data is stored. Valid values for
        /// <c>S3SseAlgorithm</c> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AES256</c> - server-side encryption with Amazon S3 managed keys
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KMS</c> - server-side encryption with KMS managed keys
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public S3SseAlgorithm S3SseAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the S3SseAlgorithm property is set.
        /// </summary>
        internal bool IsSetS3SseAlgorithm() => this.S3SseAlgorithm != null;

        /// <summary>
        /// Gets and sets the property S3SseKmsKeyId. 
        /// <para>
        /// The ID of the KMS managed key used to encrypt the S3 bucket where export data is stored
        /// (if applicable).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string S3SseKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the S3SseKmsKeyId property is set.
        /// </summary>
        internal bool IsSetS3SseKmsKeyId() => this.S3SseKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the export task began.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table that was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// Unique ID of the table that was exported.
        /// </para>
        /// </summary>
        public string TableId { get; set; }

        /// <summary>
        /// Checks to see if the TableId property is set.
        /// </summary>
        internal bool IsSetTableId() => this.TableId != null;
    }
}
