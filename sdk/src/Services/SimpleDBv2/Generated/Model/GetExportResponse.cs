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
 * Do not modify this file. This file is generated from the simpledbv2-2025-09-26.normal.json service model.
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
        private string _clientToken;
        private string _domainName;
        private string _exportArn;
        private DateTime? _exportDataCutoffTime;
        private string _exportManifest;
        private ExportStatus _exportStatus;
        private string _failureCode;
        private string _failureMessage;
        private long? _itemsCount;
        private DateTime? _requestedAt;
        private string _s3Bucket;
        private string _s3BucketOwner;
        private string _s3KeyPrefix;
        private S3SseAlgorithm _s3SseAlgorithm;
        private string _s3SseKmsKeyId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token provided for this export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property ExportArn. 
        /// <para>
        /// Unique ARN identifier of the export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property ExportDataCutoffTime. 
        /// <para>
        /// The timestamp indicating the cutoff point for data inclusion in the export. All data
        /// inserted or modified before this time will be present in the exported data. Data insertions
        /// or modifications after this timestamp may or may not be present in the export.
        /// </para>
        /// </summary>
        public DateTime ExportDataCutoffTime
        {
            get { return this._exportDataCutoffTime.GetValueOrDefault(); }
            set { this._exportDataCutoffTime = value; }
        }

        // Check to see if ExportDataCutoffTime property is set
        internal bool IsSetExportDataCutoffTime()
        {
            return this._exportDataCutoffTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportManifest. 
        /// <para>
        /// The name of the manifest summary file for the export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The current state of the export. Current possible values include : PENDING - export
        /// request received, IN_PROGRESS - export is being processed, SUCCEEDED - export completed
        /// successfully, and FAILED - export encountered an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Failure code for the result of the failed export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ItemsCount. 
        /// <para>
        /// Total number of exported items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ItemsCount
        {
            get { return this._itemsCount.GetValueOrDefault(); }
            set { this._itemsCount = value; }
        }

        // Check to see if ItemsCount property is set
        internal bool IsSetItemsCount()
        {
            return this._itemsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestedAt. 
        /// <para>
        /// Timestamp when the export request was received by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime RequestedAt
        {
            get { return this._requestedAt.GetValueOrDefault(); }
            set { this._requestedAt = value; }
        }

        // Check to see if RequestedAt property is set
        internal bool IsSetRequestedAt()
        {
            return this._requestedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the S3 bucket for this export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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
        /// The S3 bucket owner account ID for this export.
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
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The S3 key prefix provided in the corresponding StartDomainExport request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=850)]
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property S3SseAlgorithm. 
        /// <para>
        /// The S3 SSE encryption algorithm for this export.
        /// </para>
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
        /// The KMS key ID for this export.
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

    }
}