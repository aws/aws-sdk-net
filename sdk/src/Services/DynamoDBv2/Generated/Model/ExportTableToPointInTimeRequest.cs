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
    /// Container for the parameters to the ExportTableToPointInTime operation.
    /// Exports table data to an S3 bucket. The table must have point in time recovery enabled,
    /// and you can export data from any time within the point in time recovery window.
    /// </summary>
    public partial class ExportTableToPointInTimeRequest : AmazonDynamoDBRequest
    {
        private string _clientToken;
        private ExportFormat _exportFormat;
        private DateTime? _exportTime;
        private ExportType _exportType;
        private IncrementalExportSpecification _incrementalExportSpecification;
        private string _s3Bucket;
        private string _s3BucketOwner;
        private string _s3Prefix;
        private S3SseAlgorithm _s3SseAlgorithm;
        private string _s3SseKmsKeyId;
        private string _tableArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Providing a <c>ClientToken</c> makes the call to <c>ExportTableToPointInTimeInput</c>
        /// idempotent, meaning that multiple identical calls have the same effect as one single
        /// call.
        /// </para>
        ///  
        /// <para>
        /// A client token is valid for 8 hours after the first request that uses it is completed.
        /// After 8 hours, any request with the same client token is treated as a new request.
        /// Do not resubmit the same request with the same client token for more than 8 hours,
        /// or the result might not be idempotent.
        /// </para>
        ///  
        /// <para>
        /// If you submit a request with the same client token but a change in other parameters
        /// within the 8-hour idempotency window, DynamoDB returns an <c>ImportConflictException</c>.
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
        /// Gets and sets the property ExportFormat. 
        /// <para>
        /// The format for the exported data. Valid values for <c>ExportFormat</c> are <c>DYNAMODB_JSON</c>
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
        /// Gets and sets the property ExportTime. 
        /// <para>
        /// Time in the past from which to export table data, counted in seconds from the start
        /// of the Unix epoch. The table export will be a snapshot of the table's state at this
        /// point in time.
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
        /// Choice of whether to execute as a full export or incremental export. Valid values
        /// are FULL_EXPORT or INCREMENTAL_EXPORT. The default value is FULL_EXPORT. If INCREMENTAL_EXPORT
        /// is provided, the IncrementalExportSpecification must also be used.
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
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket to export the snapshot to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// The ID of the Amazon Web Services account that owns the bucket the export will be
        /// stored in.
        /// </para>
        ///  <note> 
        /// <para>
        /// S3BucketOwner is a required parameter when exporting to a S3 bucket in another account.
        /// </para>
        ///  </note>
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
        /// The Amazon S3 bucket prefix to use as the file name and path of the exported snapshot.
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
        /// Type of encryption used on the bucket where export data will be stored. Valid values
        /// for <c>S3SseAlgorithm</c> are:
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
        /// The ID of the KMS managed key used to encrypt the S3 bucket where export data will
        /// be stored (if applicable).
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
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the table to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

    }
}