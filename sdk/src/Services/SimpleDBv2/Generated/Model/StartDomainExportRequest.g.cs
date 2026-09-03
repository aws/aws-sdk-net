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
    /// Container for the parameters to the StartDomainExport operation. Initiates the export
    /// of a SimpleDB domain to an S3 bucket.
    /// </summary>
    public partial class StartDomainExportRequest : AmazonSimpleDBv2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Providing a ClientToken makes the call to
        /// StartDomainExport API idempotent, meaning that multiple identical calls have the same
        /// effect as one single call. A client token is valid for 8 hours after the first request
        /// that uses it is completed. After 8 hours, any request with the same client token is
        /// treated as a new request. Do not resubmit the same request with the same client token
        /// for more than 8 hours, or the result might not be idempotent. If you submit a request
        /// with the same client token but a change in other parameters within the 8-hour idempotency
        /// window, a ConflictException will be returned.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain to export.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. The name of the S3 bucket where the domain data
        /// will be exported.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. The ID of the AWS account that owns the
        /// bucket the export will be stored in.
        /// </summary>
        public string S3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwner property is set.
        /// </summary>
        internal bool IsSetS3BucketOwner() => this.S3BucketOwner != null;

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. The prefix string to be used to generate the
        /// S3 object keys for export artifacts.
        /// </summary>
        [AWSProperty(Min = 1, Max = 850)]
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property S3SseAlgorithm. The server-side encryption algorithm to
        /// use for the exported data in S3. Valid values are: AES256 (SSE-S3) and KMS (SSE-KMS).
        /// If not specified, bucket's default encryption will apply.
        /// </summary>
        public S3SseAlgorithm S3SseAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the S3SseAlgorithm property is set.
        /// </summary>
        internal bool IsSetS3SseAlgorithm() => this.S3SseAlgorithm != null;

        /// <summary>
        /// Gets and sets the property S3SseKmsKeyId. The KMS key ID to use for server-side encryption
        /// with AWS KMS-managed keys (SSE-KMS). This parameter is only expected with KMS as the
        /// S3 SSE algorithm.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string S3SseKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the S3SseKmsKeyId property is set.
        /// </summary>
        internal bool IsSetS3SseKmsKeyId() => this.S3SseKmsKeyId != null;
    }
}
