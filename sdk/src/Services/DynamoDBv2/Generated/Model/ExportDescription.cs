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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
        private long? _billedSizeBytes;
        private string _clientToken;
        private DateTime? _endTime;
        private string _exportArn;
        private ExportFormat _exportFormat;
        private string _exportManifest;
        private ExportStatus _exportStatus;
        private DateTime? _exportTime;
        private ExportType _exportType;
        private string _failureCode;
        private string _failureMessage;
        private IncrementalExportSpecification _incrementalExportSpecification;
        private long? _itemCount;
        private string _s3Bucket;
        private string _s3BucketOwner;
        private string _s3Prefix;
        private S3SseAlgorithm _s3SseAlgorithm;
        private string _s3SseKmsKeyId;
        private DateTime? _startTime;
        private string _tableArn;
        private string _tableId;

        /// <summary>
        /// Gets and sets the property BilledSizeBytes. 
        /// <para>
        /// The billable size of the table export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? BilledSizeBytes
        {
            get { return this._billedSizeBytes; }
            set { this._billedSizeBytes = value; }
        }

        // Check to see if BilledSizeBytes property is set
        internal bool IsSetBilledSizeBytes()
        {
            return this._billedSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token that was provided for the export task. A client token makes calls
        /// to <c>ExportTableToPointInTimeInput</c> idempotent, meaning that multiple identical
        /// calls have the same effect as one single call.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the export task completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=37, Max=1024)]
        public string ExportArn
        {
            get { return this._exportArn; }
            set { this._exportArn = value; }
        }

        // Check to see if ExportArn property is set
        internal bool IsSetExportArn()
        {
            return this._exportArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The format of the exported data. Valid values for <c>ExportFormat</c> are <c>DYNAMODB_JSON</c>
        /// or <c>ION</c>.
        /// </para>
        /// </summary>
        public ExportFormat ExportFormat
        {
            get { return this._exportFormat; }
            set { this._exportFormat = value; }
        }

        // Check to see if ExportFormat property is set
        internal bool IsSetExportFormat()
        {
            return this._exportFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ExportManifest. 
        /// <para>
        /// The name of the manifest file for the export task.
        /// </para>
        /// </summary>
        public string ExportManifest
        {
            get { return this._exportManifest; }
            set { this._exportManifest = value; }
        }

        // Check to see if ExportManifest property is set
        internal bool IsSetExportManifest()
        {
            return this._exportManifest != null;
        }

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// Export can be in one of the following states: IN_PROGRESS, COMPLETED, or FAILED.
        /// </para>
        /// </summary>
        public ExportStatus ExportStatus
        {
            get { return this._exportStatus; }
            set { this._exportStatus = value; }
        }

        // Check to see if ExportStatus property is set
        internal bool IsSetExportStatus()
        {
            return this._exportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ExportTime. 
        /// <para>
        /// Point in time from which table data was exported.
        /// </para>
        /// </summary>
        public DateTime? ExportTime
        {
            get { return this._exportTime; }
            set { this._exportTime = value; }
        }

        // Check to see if ExportTime property is set
        internal bool IsSetExportTime()
        {
            return this._exportTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportType. 
        /// <para>
        /// The type of export that was performed. Valid values are <c>FULL_EXPORT</c> or <c>INCREMENTAL_EXPORT</c>.
        /// </para>
        /// </summary>
        public ExportType ExportType
        {
            get { return this._exportType; }
            set { this._exportType = value; }
        }

        // Check to see if ExportType property is set
        internal bool IsSetExportType()
        {
            return this._exportType != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Status code for the result of the failed export.
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Export failure reason description.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property IncrementalExportSpecification. 
        /// <para>
        /// Optional object containing the parameters specific to an incremental export.
        /// </para>
        /// </summary>
        public IncrementalExportSpecification IncrementalExportSpecification
        {
            get { return this._incrementalExportSpecification; }
            set { this._incrementalExportSpecification = value; }
        }

        // Check to see if IncrementalExportSpecification property is set
        internal bool IsSetIncrementalExportSpecification()
        {
            return this._incrementalExportSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket containing the export.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the bucket containing the export.
        /// </para>
        /// </summary>
        public string S3BucketOwner
        {
            get { return this._s3BucketOwner; }
            set { this._s3BucketOwner = value; }
        }

        // Check to see if S3BucketOwner property is set
        internal bool IsSetS3BucketOwner()
        {
            return this._s3BucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The Amazon S3 bucket prefix used as the file name and path of the exported snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

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
        public S3SseAlgorithm S3SseAlgorithm
        {
            get { return this._s3SseAlgorithm; }
            set { this._s3SseAlgorithm = value; }
        }

        // Check to see if S3SseAlgorithm property is set
        internal bool IsSetS3SseAlgorithm()
        {
            return this._s3SseAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property S3SseKmsKeyId. 
        /// <para>
        /// The ID of the KMS managed key used to encrypt the S3 bucket where export data is stored
        /// (if applicable).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string S3SseKmsKeyId
        {
            get { return this._s3SseKmsKeyId; }
            set { this._s3SseKmsKeyId = value; }
        }

        // Check to see if S3SseKmsKeyId property is set
        internal bool IsSetS3SseKmsKeyId()
        {
            return this._s3SseKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the export task began.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table that was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// Unique ID of the table that was exported.
        /// </para>
        /// </summary>
        public string TableId
        {
            get { return this._tableId; }
            set { this._tableId = value; }
        }

        // Check to see if TableId property is set
        internal bool IsSetTableId()
        {
            return this._tableId != null;
        }

    }
}