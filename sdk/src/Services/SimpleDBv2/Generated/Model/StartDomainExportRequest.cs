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
    /// Container for the parameters to the StartDomainExport operation.
    /// Initiates the export of a SimpleDB domain to an S3 bucket.
    /// </summary>
    public partial class StartDomainExportRequest : AmazonSimpleDBv2Request
    {
        private string _clientToken;
        private string _domainName;
        private string _s3Bucket;
        private string _s3BucketOwner;
        private string _s3KeyPrefix;
        private S3SseAlgorithm _s3SseAlgorithm;
        private string _s3SseKmsKeyId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Providing a ClientToken makes the call to StartDomainExport API idempotent, meaning
        /// that multiple identical calls have the same effect as one single call. A client token
        /// is valid for 8 hours after the first request that uses it is completed. After 8 hours,
        /// any request with the same client token is treated as a new request. Do not resubmit
        /// the same request with the same client token for more than 8 hours, or the result might
        /// not be idempotent. If you submit a request with the same client token but a change
        /// in other parameters within the 8-hour idempotency window, a ConflictException will
        /// be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The name of the domain to export.
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
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the S3 bucket where the domain data will be exported.
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
        /// The ID of the AWS account that owns the bucket the export will be stored in.
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
        /// The prefix string to be used to generate the S3 object keys for export artifacts.
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
        /// The server-side encryption algorithm to use for the exported data in S3. Valid values
        /// are: AES256 (SSE-S3) and KMS (SSE-KMS). If not specified, bucket's default encryption
        /// will apply.
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
        /// The KMS key ID to use for server-side encryption with AWS KMS-managed keys (SSE-KMS).
        /// This parameter is only expected with KMS as the S3 SSE algorithm.
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